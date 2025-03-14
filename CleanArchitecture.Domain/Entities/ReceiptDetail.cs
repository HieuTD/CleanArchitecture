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
    public class ReceiptDetail : BaseEntityWithDateModified
    {
        [Key]
        public int Id { get; set; }
        public int Amonut { get; set; }
        public decimal TotalPrice { get; set; }

        public int? ReceiptId { get; set; }
        [ForeignKey("ReceiptId")]
        public virtual Receipt Receipt { get; set; }

        public int? ProdVariantId { get; set; }
        [ForeignKey("ProdVariantId")]
        public virtual ProductVariant ProductVariant { get; set; }
    }
}
