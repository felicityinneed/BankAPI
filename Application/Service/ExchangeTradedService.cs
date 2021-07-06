using Application.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Service
{
    public class ExchangeTradedService : IMainCalculatorService
    {
        public int _ServiceType => (int)InvestmentType.ETF;

        public double calculateTotalROI(double total, double percentage)
        {

            return total * 12.8 / 100;
        }
        public double calculateTotalFee(double roiTotal)
        {
            return roiTotal * 2 / 100;
        }
    }
}
