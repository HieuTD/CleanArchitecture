using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.DTOs.Colors
{
    public class ColorCreateRequest
    {
        public string ColorName { get; set; }
        public int CategoryId { get; set; }
    }
}
