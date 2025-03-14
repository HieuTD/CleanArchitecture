using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.DTOs.Products
{
    public class ProductLikeCreateRequest
    {
        public string UserId { get; set; }
        public int ProdId { get; set; }
    }
}
