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
    public class BlogImage : BaseEntityWithDateModified
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }

        public int? BlogId { get; set; }
        [ForeignKey("BlogId")]
        public virtual Blog Blog { get; set; }
    }
}
