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
    public class Receipt : BaseEntityWithDateModified
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        //public DateTime CreatedDate { get; set; }
        public decimal TotalPrice { get; set; }
        public string Description { get; set; }

        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual AppUser AppUser { get; set; }

        public int SupplierId { get; set; }
        [ForeignKey("SupplierId")]
        public virtual Supplier Supplier { get; set; }

        public virtual ICollection<ReceiptDetail> ReceiptDetails { get; set; }
    }
}
