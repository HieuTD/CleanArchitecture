using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.DTOs.Colors
{
    public class ColorViewModel
    {
        public int Id { get; set; }
        public string ColorName { get; set; }
        public int? CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
