using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.DTOs.Receipts
{
    public class ReceiptDetailCreateRequest
    {
        public decimal ProdVariantPrice { get; set; }
        public string ProdVariantName { get; set; }
        public int Quantity { get; set; }
    }
}
