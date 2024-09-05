using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FM.WebSite.Models.Maintenance
{
    public class Fault
    {
        [Key]
        public int FaultId { get; set; }
        [Required, Display(Name = "Current Date"), DataType(DataType.Date)]
        public DateOnly Date { get; set; }
        [Required, StringLength(255)]
        public string Description { get; set; }
        [Required, StringLength(25)]
        public string Status { get; set; }
        [Required, ForeignKey("Fridge")]
        public int FridgeId { get; set; }
        public Fridge Fridges { get; set; }
    }
}
