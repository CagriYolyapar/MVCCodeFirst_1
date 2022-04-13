using MVCCodeFirst_1.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCCodeFirst_1.Models.Context
{
    public class MyContext:DbContext
    {
        public MyContext():base("MyConnection")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppUser>().HasOptional(x => x.Profile).WithRequired(x => x.AppUser);

            modelBuilder.Entity<OrderDetail>().Ignore(x => x.ID);

            modelBuilder.Entity<OrderDetail>().HasKey(x => new
            {
                x.ProductID,
                x.OrderID
            });
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppUserProfile> AppUserProfiles { get; set; }
    }
}