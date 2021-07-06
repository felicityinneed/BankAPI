using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Model
{
    public class InvestmentOption
    {
        public string id { get; set; }
        public string value { get; set; }
        public int selectedItem { get; set; }
    }
}
