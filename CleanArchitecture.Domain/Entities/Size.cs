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
    public class Size : BaseEntityWithDateModified
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public int? CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; }

        public virtual ICollection<ProductVariant> ProductVariants { get; set; }
    }
}
