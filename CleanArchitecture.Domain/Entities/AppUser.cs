using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace CleanArchitecture.Domain.Entities
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Role { get; set; }
        public string Address { get; set; }
        public string? ResetPasswordToken { get; set; }
        public DateTime ResetPasswordExpiry { get; set; }
        public ICollection<AuthHistory> AuthHistories { get; set; }
        public ICollection<Blog> Blogs { get; set; }
        public ICollection<Cart> Carts { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<Receipt> Receipts { get; set; }
        public ICollection<ProductLike> ProductLikes { get; set; }
    }
}
