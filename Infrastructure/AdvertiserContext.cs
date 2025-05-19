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

            // היררכיה למחלקות Customer (TPT/TPH)
            modelBuilder.Entity<Customer>()
                .HasDiscriminator<string>("CustomerType")
                .HasValue<ContactCustomer>("ContactCustomer")
                .HasValue<OrderCustomer>("OrderCustomer");

            // קשר בין OrderItem ל-Item
            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Item)
                .WithMany()
                .HasForeignKey(oi => oi.ItemId);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-L9S4R74;Database=AdvertiserServer;Trusted_Connection=True;TrustServerCertificate=True");

    }

}