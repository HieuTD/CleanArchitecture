using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.DTOs.Receipts
{
    public class ReceiptViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? CreatedAt { get; set; }
        public decimal TotalPrice { get; set; }
        public string Description { get; set; }
        public string UserName { get; set; }
        public string SupplierName { get; set; }
    }
}
