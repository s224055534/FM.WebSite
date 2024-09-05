using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FM.WebSite.Models
{
    public class PurchaseRequest
    {
        [Key]
        public int PurchaseId { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required, ForeignKey("Fridge")]
        public int FridgeId { get; set; }
        public Fridge Fridge { get; set; }

        //Add Supplier as foreignkey
        [Required, ForeignKey("Supplier")]
        public int SupplierId {  get; set; }
        public Supplier Supplier {  get; set; }
    }
}
