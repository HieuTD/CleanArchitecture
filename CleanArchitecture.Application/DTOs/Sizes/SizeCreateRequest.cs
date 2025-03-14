using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.DTOs.Sizes
{
    public class SizeCreateRequest
    {
        public string SizeName { get; set; }
        public int CategoryId { get; set; }
    }
}
