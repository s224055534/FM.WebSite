using System.ComponentModel.DataAnnotations;
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
        [Required, StringLength(13), Display(Name ="Contact Number")]
        public string ContactNo { get; set; }
        [Required, StringLength(20), EmailAddress]
        public string Email { get; set; }
        [Required]
        public bool IsActive {  get; set; }

    }
}
