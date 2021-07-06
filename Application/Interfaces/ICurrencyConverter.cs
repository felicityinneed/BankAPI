using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ICurrencyConverter
    {
        Task<double> ConvertToUSD(double Amount);
    }
}
