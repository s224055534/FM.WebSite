using FM.WebSite.Models.Maintenance;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FM.WebSite.Models
{
    public class Customer
    {
        [Key, ForeignKey("User")]
        public int CustomerId { get; set; }
        [Required, StringLength(50), Display(Name ="Business Name")]
        public string BusinessName { get; set; }
        public ICollection<Visit> Visits { get; set; }
        public FridgeAllocation Allocation { get; set; }
    }
}
