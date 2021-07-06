using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Interfaces
{
    public interface ITotalFeeCalculator : IInvestmentService
    {
        double calculateTotalFee(double roiTotal);
    }
}
