using Application.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Service
{
    public class FixedInterestService : IMainCalculatorService
    {
        public int _ServiceType => (int)InvestmentType.FixedInterest;

        public double calculateTotalROI(double total, double percentage)
        {
            return total * 10 / 100;
        }
        public double calculateTotalFee(double roiTotal)
        {
            return roiTotal * 1/ 100;
        }
    }
}
