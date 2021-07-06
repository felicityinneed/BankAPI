using Application.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Service
{
    public class InvestmentBondService : IMainCalculatorService
    {
        public int _ServiceType => (int)InvestmentType.InvestmentBond;
        public double calculateTotalROI(double total, double percentage)
        {
            return total * 8 / 100;
        }
        public double calculateTotalFee(double roiTotal)
        {
            return roiTotal * 0.9 / 100;
        }
    }
}
