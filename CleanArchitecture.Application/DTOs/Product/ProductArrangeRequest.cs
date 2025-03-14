using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.DTOs.Product
{
    public class ProductArrangeRequest
    {
        public decimal High { get; set; }
        public decimal Low { get; set; }
    }
}
