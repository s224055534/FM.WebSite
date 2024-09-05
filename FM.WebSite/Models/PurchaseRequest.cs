using System.ComponentModel.DataAnnotations;

namespace FM.WebSite.Models
{
    public class PurchaseRequest
    {
        [Key]
        public int PurchaseId { get; set; }
        [Required]
        public int Quantity { get; set; }

        public int FridgeId { get; set; }
        public Fridge Fridge { get; set; }

        //Add Supplier as foreignkey
        public int SupplierId {  get; set; }
        public Supplier Supplier {  get; set; }
    }
}
