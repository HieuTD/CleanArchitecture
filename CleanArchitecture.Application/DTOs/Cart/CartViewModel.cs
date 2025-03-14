using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.DTOs.Cart
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
