using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.Infrastructure
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //    modelBuilder.Ignore<IdentityUserLogin<string>>();
        //    modelBuilder.Ignore<IdentityUserRole<string>>();
        //    modelBuilder.Ignore<IdentityUserClaim<string>>();
        //    modelBuilder.Ignore<IdentityUserToken<string>>();
        //    modelBuilder.Ignore<IdentityUser<string>>();
        //    modelBuilder.Ignore<AppUser>();
        //}

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AuthHistory> AuthHistories { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<BlogImage> BlogImages { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Domain.Entities.Color> Colors { get; set; }
        public DbSet<Coupon> Coupons { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductVariant> ProductVariants { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<ProductLike> ProductLikes { get; set; }
        public DbSet<Receipt> Receipts { get; set; }
        public DbSet<ReceiptDetail> ReceiptDetails { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Domain.Entities.Size> Sizes { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
    }
}
