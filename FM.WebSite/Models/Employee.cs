using FM.WebSite.Models.Maintenance;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace FM.WebSite.Models
{
    public class Employee
    {
        [Key, ForeignKey("User")]
        public string EmployeeId { get; set; }
        //public string Id { get; set; }
        [Required, StringLength(10)]
        public string Role {  get; set; }
        //public IdentityUser User { get; set; }
        public User User { get; set; }
        public Visit Visit { get; set; }
        
    }
}
