using Application.Interfaces;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Service
{
    public class RealEstateService : IMainCalculatorService
    {
        public int _ServiceType => (int)InvestmentType.RealEstate;
        public double calculateTotalROI(double total, double percentage)
        {
            return total * 4 / 100;
        }
        public double calculateTotalFee(double roiTotal)
        {
            return roiTotal * 2 / 100;
        }
    }
}
