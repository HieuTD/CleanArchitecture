using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.DTOs.Receipt
{
    public class ReceiptCreateRequest
    {
        public string UserId { get; set; }
        public string Description { get; set; }
        public decimal TotalPrice { get; set; }
        public string SupplierId { get; set; }
        public ICollection<ReceiptDetailCreateRequest> ReceiptDetails { get; set; }
    }
}
