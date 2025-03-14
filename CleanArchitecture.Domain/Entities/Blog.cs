using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Domain.BaseEntity;

namespace CleanArchitecture.Domain.Entities
{
    public class Blog : BaseEntityWithDateModified
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public string? UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual AppUser AppUser { get; set; }

        public ICollection<BlogImage> BlogImages { get; set; }
    }
}
