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
    public class OrderDetail : BaseEntityWithDateModified
    {
        [Key]
        public int Id { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }

        public int? OrderId { get; set; }
        [ForeignKey("OrderId")]
        public virtual Order Order { get; set; }

        public int? ProdId { get; set; }
        [ForeignKey("ProdId")]
        public virtual Product Product { get; set; }

        public int? ProdVariantId { get; set; }
        [ForeignKey("ProdVariantId")]
        public virtual ProductVariant ProductVariant { get; set; }
    }
}
