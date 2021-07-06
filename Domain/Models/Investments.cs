using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class Investments
    {
        public string totalAmount { get; set; }
        public List<InvestmentOption> options { get; set; }
    }

}
