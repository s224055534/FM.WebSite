using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FM.WebSite.Models
{
    public class Record
    {
        [Key]
        public int RecordId { get; set; }
        [Required, StringLength(50), Display(Name ="Record Type")]
        public string RecordType { get; set; }
        [Required, DataType(DataType.Date), Display(Name = "Record Date")]
        public DateTime RecordDate { get; set; }
        [Required, StringLength(500)]
        public string Description { get; set; }
        [Required, ForeignKey("Fridge")]
        public int FridgeId {  get; set; }
        public Fridge Fridge { get; set; }
    }
}
