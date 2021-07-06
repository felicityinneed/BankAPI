using Application.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Service
{
    public class SharesServices : IMainCalculatorService
    {
        public int _ServiceType => (int)InvestmentType.Shares;
        public double calculateTotalROI(double total, double percentage)
        {
            if (percentage <= 70)
            {
                return total * 4.3 / 100;
            }
            else
            {
                return total * 6 / 100;
            }
        }
        public double calculateTotalFee(double roiTotal)
        {
            return roiTotal * 2.5 / 100;
        }
    }
}
