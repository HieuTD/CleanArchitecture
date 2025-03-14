using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Application.DTOs.Products;

namespace CleanArchitecture.Application.DTOs.Carts
{
    public class CartViewModel
    {
        public int CartID { get; set; }
        public string UserID { get; set; }
        public string Color { get; set; }
        public int Quantity { get; set; }
        public int? ProdVariantId { get; set; }
        public string Size { get; set; }
        public ProductDetailViewModel ProductDetail { get; set; }
    }
}
