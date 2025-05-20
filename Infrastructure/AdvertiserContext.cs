using Core.Models.Customers;
using Core.Models.Orders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure
{
    public class AdvertiserContext : DbContext
    {
        public AdvertiserContext(DbContextOptions<AdvertiserContext> options)
        : base(options)
        {
        }
        // Orders
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Item> Items { get; set; }

        // Customers
        public DbSet<Customer> Customers { get; set; }
        public DbSet<ContactCustomer> ContactCustomers { get; set; }
        public DbSet<OrderCustomer> OrderCustomers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Customer>()
                .HasDiscriminator<string>("CustomerType")
                .HasValue<ContactCustomer>("ContactCustomer")
                .HasValue<OrderCustomer>("OrderCustomer");

            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Item)
                .WithMany()
                .HasForeignKey(oi => oi.ItemId);

            modelBuilder.Entity<OrderItem>()
                .HasOne<Order>(oi => oi.Order)
                .WithMany(o => o.OrderItems)
                .HasForeignKey(oi => oi.OrderId)
                .OnDelete(DeleteBehavior.Cascade); 
        }
    }
}


