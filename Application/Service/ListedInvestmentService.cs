using Application.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace Application.Service
{
    public class ListedInvestmentService : IMainCalculatorService
    {
        public int _ServiceType => (int)InvestmentType.ListedInvestment;
        public double calculateTotalROI(double total, double percentage)
        {
            return total * 6 / 100;
        }
        public double calculateTotalFee(double roiTotal)
        {
            return roiTotal * 1.3/ 100;
        }
    }
}
