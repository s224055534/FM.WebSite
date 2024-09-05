using System.ComponentModel.DataAnnotations;

namespace FM.WebSite.Models.Maintenance
{
    public class Fault
    {
        [Key]
        public int FaultId { get; set; }
        [Required, Display(Name ="Current Date"), DataType(DataType.Date)]
        public DateOnly Date {  get; set; }
        [Required,StringLength(255)]
        public string Description { get; set; }
        public Fridge Fridges { get; set; }
    }
}
