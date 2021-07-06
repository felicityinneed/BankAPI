using Application.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Service
{
    public class CashServices : IMainCalculatorService
    {
        public int _ServiceType => (int)InvestmentType.CashService;
        
        public double calculateTotalROI(double total, double percentage)
        {
            if (percentage <= 50)
            {
                return (total * 8.5 / 100);
            }
            else
            {
                return (total * 10 / 100);
            }
        }
        public double calculateTotalFee (double roiTotal)
        {
            return roiTotal*0.5/100;
        }
    }
}
