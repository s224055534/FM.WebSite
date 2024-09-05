using FM.WebSite.Models.Maintenance;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace FM.WebSite.Models
{
    public class Employee
    {
        [Key, ForeignKey("User")]
        public int EmployeeId { get; set; }
        [Required, StringLength(10)]
        public string Role {  get; set; }
        public User User { get; set; }
        public Visit Visit { get; set; }
        
    }
}
