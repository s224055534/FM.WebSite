using System.ComponentModel.DataAnnotations;

namespace FM.WebSite.Models.Account
{
    public class RegisterViewModel
    {
      
        [Required]
        [StringLength(50), Display(Name ="First Name")]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50), Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [StringLength(10)]
        public string Gender { get; set; }
        [Required, DataType(DataType.Date), Display(Name = "Date Of Birth")]
        public DateTime DOB { get; set; }
        [Required]
        [StringLength(75), DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [StringLength(40), DataType(DataType.Password)]
        public string Password { get; set; }
        [Required, Display(Name = "Phone Number")]
        [StringLength(12)]
        [Phone]
        public string PhoneNumber { get; set; }
        [Required]
        [StringLength(100)]
        public string Address { get; set; }
        [Required]
        [StringLength(50)]
        public string City { get; set; }
        [Required, Display(Name = "Zip Code")]
        [StringLength(10)]
        public string ZipCode { get; set; }
       
    }
}
