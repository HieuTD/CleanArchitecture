using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Domain.BaseEntity;

namespace CleanArchitecture.Domain.Entities
{
    public class Supplier : BaseEntityWithDateModified
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }

        public ICollection<Product> Products { get; set; }
        public ICollection<Receipt> Receipts { get; set; }
    }
}
