using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace FM.WebSite.Models
{
    public class Supplier
    {
        [Key]
        public int SupplierId { get; set; }
        [Required, StringLength(50), Display(Name ="Supplier Business Name")]
        public string SupplierName { get; set; }
        [Required, StringLength(100)]
        public string Address {  get; set; }
        [Required, StringLength(13), Display(Name ="Contact Number"),Phone]
        public string ContactNo { get; set; }
        [Required, StringLength(50), EmailAddress]
        public string Email { get; set; }
        [Required]
        public bool IsActive {  get; set; }
        [Required, ForeignKey("Fridge")]
        public int FridgeId {  get; set; }
        public ICollection<Fridge> Fridges { get; set; }
        public ICollection<PurchaseRequest> Purchases { get; set; }

    }
}
