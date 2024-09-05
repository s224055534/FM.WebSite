using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FM.WebSite.Models
{
    public class Repair
    {
        [Key]
        public int RepairId { get; set; }
        [Required, StringLength(50), Display(Name = "Repair Date")]
        public DateTime RepairDate { get; set; }

        [Required, StringLength(50), Display(Name = "Repair Description")]
        public string RepairDescription { get; set; }
        [Required, StringLength(50), Display(Name = "Repair Status")]
        public string RepairStatus { get; set; }
        [Required, ForeignKey("Fridge")]
        public int FridgeId { get; set; }
        public Fridge Fridge { get; set; }
        [Required, ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

    }
}
