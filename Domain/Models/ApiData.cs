using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class ApiData
    {
        public bool success { get; set; }
        public int timestamp { get; set; }
        public DateTime date { get; set; }
        public Rates rates { get; set; }

    }

    public class Rates
    {
        public double USD { get; set; }
    }
}
