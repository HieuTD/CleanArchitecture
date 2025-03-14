using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.DTOs.Sizes
{
    public class GetListSizeByColorRequest
    {
        public string ColorName { get; set; }
        public int ProdId { get; set; }
    }
}
