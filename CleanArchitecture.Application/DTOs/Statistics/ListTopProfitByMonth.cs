using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.DTOs.Statistics
{
    public class ListTopProfitByMonth
    {
        public string Month { get; set; }
        public decimal Profit { get; set; }
    }
}
