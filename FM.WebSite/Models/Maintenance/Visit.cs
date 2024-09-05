using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FM.WebSite.Models.Maintenance
{
    public class Visit
    {
        [Key]
        public int VisitID { get; set; }
        [Required,DataType(DataType.Date), Display(Name ="Date")] 
        public DateOnly VisitDate { get; set; }
        [Required, DataType(DataType.Time), Display(Name ="Time")]
        public TimeOnly VisitTime { get; set; }
        [Required, ForeignKey("Employee")]
        public int EmployeeId {  get; set; }
        [Required, ForeignKey("Customer")]
        public int CustomerId { get; set; }
        [Required, ForeignKey("Fridge")]
        public int FrideId {  get; set; }
        public Employee Employee { get; set; }
        public ICollection<Fridge> Fridge { get; set; }

    }
}
