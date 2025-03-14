using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Domain.BaseEntity;

namespace CleanArchitecture.Domain.Entities
{
    public class ProductVariant : BaseEntityWithDateModified
    {
        [Key]
        public int Id { get; set; }
        public int Stock { get; set; }

        public int? ProdId { get; set; }
        [ForeignKey("ProdId")]
        public virtual Product Product { get; set; }

        public int? ColorId { get; set; }
        [ForeignKey("ColorId")]
        public virtual Color Color { get; set; }

        public int? SizeId { get; set; }
        [ForeignKey("SizeId")]
        public virtual Size Size { get; set; }

        public ICollection<Cart> Carts { get; set; }
        public ICollection<ReceiptDetail> ReceiptDetails { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
    }
}
