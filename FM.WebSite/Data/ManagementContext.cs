using FM.WebSite.Models;
using FM.WebSite.Models.Maintenance;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FM.WebSite.Data
{
    public class ManagementContext: IdentityDbContext<User>
    {
        public ManagementContext(DbContextOptions<ManagementContext> options) : base(options) 
        {          
        }
        DbSet<Employee> Employee { get; set; }
        DbSet<User> User { get; set; }
        DbSet<Customer> Customer { get; set; }
        DbSet<Supplier> Supplier { get; set; }
        DbSet<Fridge> Fridge { get; set; }
        DbSet<Visit> Visit { get; set; }
        DbSet<Fault> Fault { get; set; }
        DbSet<Record> Record { get; set; }
        DbSet<FridgeAllocation> FridgeAllocation { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    // Set up foreign key relationship between Employee and IdentityUser
        //    modelBuilder.Entity<Employee>()
        //        .HasOne(e => e.User) // Employee has one IdentityUser
        //        .WithMany() // IdentityUser can have many Employees
        //        .HasForeignKey(e => e.EmployeeId) // Foreign key is UserId in Employee (string)
        //        .IsRequired(false); // Optional: if Employee can exist without a related IdentityUser
        //}

    }
}
