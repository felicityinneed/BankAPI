using Application.Interfaces;
using System;

namespace Application.Interfaces
{
    public interface ITotalROICalculator : IInvestmentService
    {
        
        double calculateTotalROI(double totalAmount, double percentageAmount);
    }
}
