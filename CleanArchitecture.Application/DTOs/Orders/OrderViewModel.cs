using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.DTOs.Orders
{
    public class OrderViewModel
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int? Status { get; set; }
        public string FullName { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int TypePayment { get; set; }
    }
}
