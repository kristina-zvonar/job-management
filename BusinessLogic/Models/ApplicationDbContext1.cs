using System;
using System.Collections.Generic;
using System.Text;
using BusinessLogic.Models;

using Microsoft.EntityFrameworkCore;

namespace JobManagement.Data
{
    public class ApplicationDbContext1 : DbContext
    {
        public ApplicationDbContext1(DbContextOptions<ApplicationDbContext1> options)
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Location> Locations { get; set; }
        public DbSet<Job> Jobs { get; set; }

         protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Job>()
                        .HasOne(m => m.Sender)
                        .WithMany(t => t.SenderJobs)
                        .HasForeignKey(m => m.SenderID)
                        .OnDelete(DeleteBehavior.Restrict);


            modelBuilder.Entity<Job>()
                        .HasOne(m => m.Recipient)
                        .WithMany(t => t.ReceipientJobs)
                        .HasForeignKey(m => m.RecipientID)
                        .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
