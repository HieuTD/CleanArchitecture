using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.DTOs.Review
{
    public class ReviewCreateRequest
    {
        public string UserId { get; set; }
        public DateTime? CreatedAt { get; set; }
        public int ProdId { get; set; }
        public string Content { get; set; }
        public int Rating { get; set; }
    }
}
