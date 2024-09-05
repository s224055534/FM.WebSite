using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FM.WebSite.Models
{
    public class FridgeAllocation
    {
        [Key]
        public int FridgeAllocationId { get; set; }
        [Required, DataType(DataType.Date)]

        public DateTime AllocationDate { get; set; }

        [Required, DataType(DataType.Date), Display(Name ="Expected Maintenance")]
        public DateTime MaintananceDate { get; set; }

        // Foreign Key
        [Required, ForeignKey("Fridge")]
        public int FridgeId { get; set; }
        [Required, ForeignKey("Customer")]
        public int CustomerId {  get; set; }
        public Fridge Fridge { get; set; }
        public Customer Customer { get; set; }
    }
}
