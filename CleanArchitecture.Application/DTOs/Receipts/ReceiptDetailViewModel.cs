using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Application.DTOs.ProductVariants;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.DTOs.Receipts
{
    public class ReceiptDetailViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? CreatedAt { get; set; }
        public decimal TotalPrice { get; set; }
        public string Description { get; set; }
        public string UserName { get; set; }
        public Supplier Supplier { get; set; }
        public List<GetListProdVariantByReceiptIdVM> ListProdVariants { get; set; }
    }
}
