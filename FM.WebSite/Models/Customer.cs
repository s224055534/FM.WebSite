using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FM.WebSite.Models
{
    public class Customer
    {
        [Key, ForeignKey("User")]
        public int CustomerId { get; set; }
        [Required, StringLength(50)]
        public string BusinessName { get; set; }
    }
}
