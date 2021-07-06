using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Models
{
    public enum InvestmentType
    {
        CashService = 1,
        FixedInterest = 2,
        Shares = 3,
        ManagedFund = 4,
        ETF = 5,
        InvestmentBond = 6,
        Annuities = 7,
        ListedInvestment = 8,
        RealEstate = 9
    }
}
