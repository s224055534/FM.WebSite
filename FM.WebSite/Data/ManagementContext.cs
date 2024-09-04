using FM.WebSite.Models;
using Microsoft.EntityFrameworkCore;

namespace FM.WebSite.Data
{
    public class ManagementContext:DbContext
    {
        public ManagementContext(DbContextOptions<ManagementContext> options) : base(options) 
        {          
        }
        DbSet<Employee> Employees { get; set; }
        DbSet<User> User { get; set; }
    }
}
