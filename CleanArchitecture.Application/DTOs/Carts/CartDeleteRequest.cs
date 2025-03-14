using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.DTOs.Carts
{
    public class CartDeleteRequest
    {
        public string UserId { get; set; }
        public int ProdVariantId { get; set; }
    }
}
