using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.DTOs.Order
{
    public class OrderCreateRequest
    {
        public string Description { get; set; }
        public decimal TotalPrice { get; set; }
        public string Address { get; set; }
        public string? UserId { get; set; }
        public int? TypePayment { get; set; }
    }
}
