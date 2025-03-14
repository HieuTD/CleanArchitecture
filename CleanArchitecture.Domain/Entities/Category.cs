using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Domain.BaseEntity;

namespace CleanArchitecture.Domain.Entities
{
    public class Category : BaseEntityWithDateModified
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Product> Products { get; set; }
        public ICollection<Color> Colors { get; set; }
        public ICollection<Size> Sizes { get; set; }
    }
}
