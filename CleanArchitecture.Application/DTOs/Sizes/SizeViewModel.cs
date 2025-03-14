using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.DTOs.Sizes
{
    public class SizeViewModel
    {
        public int Id { get; set; }
        public string SizeName { get; set; }
        public int? CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
