using Application.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Service 
{
    public class AnnuitiesService : IMainCalculatorService
    {
        public int _ServiceType => (int)InvestmentType.Annuities;
        public double calculateTotalROI(double total, double percentage)
        {
            return total * 4 / 100;
        }
        public double calculateTotalFee(double roiTotal)
        {
            return roiTotal * 1.4 / 100;
        }
    }
}
