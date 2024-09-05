using FM.WebSite.Models.Maintenance;
using System.ComponentModel.DataAnnotations;

namespace FM.WebSite.Models
{
    public class Fridge
    {
        [Key]
        public int FridgeId { get; set; }
        [Required, StringLength(50), Display(Name ="Fridge Name")]
        public string FridgeName { get; set; }
        [Required, StringLength(15), Display(Name ="Fridge Type")]
        public string FridgeType { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public bool Available { get; set; }
        [Required, StringLength(20)]
        public string Status { get; set; }
        public ICollection<Fault> Faults { get; set; }
        public ICollection<Record> Records { get; set; }
        public ICollection<Repair> Repairs {  get; set; }
        public ICollection<Visit> Visits { get; set; }
        public Supplier Supplier { get; set; }
        public FridgeAllocation Allocation { get; set; }
    }
}
