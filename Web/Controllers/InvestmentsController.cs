using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Model;
using Infrastructure;
using Application.Interfaces;
using Domain.Models;

namespace Web.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InvestmentsController : ControllerBase
    {
        private IEnumerable<IMainCalculatorService> InvestmentServices;
        private readonly ILogger<InvestmentsController> Logger;
        private ICurrencyConverter CurrencyConverter;
        private IMainCalculatorService MainCalculatorService;
        public InvestmentsController(IEnumerable<IMainCalculatorService> services, ICurrencyConverter currencyConverter , ILogger<InvestmentsController> logger)
        {
            InvestmentServices = services;
            CurrencyConverter = currencyConverter;
            Logger = logger;
        }   

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> CalculateInvestmentDetails(Investments investments)
        {
            if (investments == null)
            {
                return BadRequest();
            }
            bool isKnownInvestmentType = investments.options.Any(item => Enum.IsDefined(typeof(InvestmentType), item.selectedItem));

            if (!isKnownInvestmentType)
            {
                return NotFound("Type of Investment not supported");
            }
            try
            {
                double result = 0;
                double totalFee = 250;
                double total = Double.Parse(investments.totalAmount);

                foreach (InvestmentOption option in investments.options)
                {
                    double value = Double.Parse(option.value);
                    MainCalculatorService = InvestmentServices.First(o => o._ServiceType == option.selectedItem);
                    result += MainCalculatorService.calculateTotalROI(total, value);
                    totalFee += MainCalculatorService.calculateTotalFee(result);
                }

                double usdFee = await CurrencyConverter.ConvertToUSD(totalFee);
                Logger.LogInformation("Currency converter called, result : {0}", totalFee);

                return Ok(new
                {
                    calculatedInvestments = result,
                    totalFee = usdFee
                });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.StackTrace);
            }
        }
        
    }
}
