using Application.Interfaces;
using Domain.Models;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;


namespace Infrastructure
{
    public class CurrencyConverter : ICurrencyConverter
    {
        private readonly ILogger<CurrencyConverter> Logger;
        public CurrencyConverter(ILogger<CurrencyConverter> logger)
        {
            Logger = logger;
        }
        public async Task<double> ConvertToUSD(double Amount)
        {
            double convertedUSD = 0;
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://data.fixer.io/api/latest?access_key=ffd00de243dfb7bf3ec5c21c40cdfcd1&symbols=USD");
            var response = await client.GetAsync(client.BaseAddress);

            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync().Result;
                var apiData = JsonConvert.DeserializeObject<ApiData>(result);
                convertedUSD = Amount / apiData.rates.USD;
            }
            return convertedUSD;
        }
    }
}
