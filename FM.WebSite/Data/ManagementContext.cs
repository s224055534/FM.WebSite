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

    }
}
