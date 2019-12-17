using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace DeliveryService.Model
{
    public class DSContext:DbContext
    {
        public DSContext( DbContextOptions<DSContext> options):base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    //base.OnModelCreating(modelBuilder);
        //    modelBuilder.Entity<Order>().HasOne("DeliveryService.Model.Customer", null)
        //                .WithMany("CustomerOrder")
        //                .HasForeignKey("CustomerId")
        //                .OnDelete(DeleteBehavior.Cascade)
        //                .IsRequired();
        //}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().ToTable("Order");

        }
    }
}
