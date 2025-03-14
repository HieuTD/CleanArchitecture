using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.DTOs.ProductVariants
{
    public class ProductVariantCreateRequest
    {
        public int Stock { get; set; }
        public int? ProdId { get; set; }
        public int? ColorId { get; set; }
        public int? SizeId { get; set; }
    }
}
