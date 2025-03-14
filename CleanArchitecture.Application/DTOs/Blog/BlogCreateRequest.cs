using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;


namespace CleanArchitecture.Application.DTOs.Blog
{
    public class BlogCreateRequest
    {
        public int Id { get; set; }
        public int MyProperty { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string UserId { get; set; }
        public IFormFile files { get; set; }
    }
}
