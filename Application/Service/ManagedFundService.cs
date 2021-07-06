using Application.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Service
{
    public class ManagedFundService : IMainCalculatorService
    {
        public int _ServiceType => (int)InvestmentType.ManagedFund;
        public double calculateTotalROI(double total, double percentage)
        {
            return total * 12/ 100;
        }
        public double calculateTotalFee(double roiTotal)
        {
            return roiTotal * 0.3 / 100;
        }
    }
}
