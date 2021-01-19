using AccesAut1.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccesAut1.Database
{
    public class Acsr3Context : IdentityDbContext<User>
    {
        public Acsr3Context()
        {
        }

        public Acsr3Context(DbContextOptions<Acsr3Context> options)
       : base(options)
        { }


    
        public virtual DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }

        public DbSet<Product> Products { get; set; }
        public DbSet<ProductWishlist> ProductWishlist { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
     
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }



        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {



            {
                base.OnModelCreating(modelbuilder);
            }


            modelbuilder.Entity<Category>(category => {
                category.HasMany(c => c.Children)
                .WithOne(c => c.ParentCategory)
                .HasForeignKey(c => c.ParentCategoryId);
            });

            modelbuilder.Entity<Product>(entity =>
            {
                entity.HasOne(d => d.Category)
                  .WithMany(p => p.Products)
                  .HasForeignKey(d => d.CategoryId)
                  .OnDelete(DeleteBehavior.ClientSetNull)
                  .HasConstraintName("FK_Category_Product");

    

                entity.HasOne(d => d.Supplier)
                   .WithMany(p => p.Products)
                   .HasForeignKey(d => d.SupplierId)
                   .OnDelete(DeleteBehavior.ClientSetNull)
                   .HasConstraintName("FK_Supplier_Product");
            });





        }
    }
}

