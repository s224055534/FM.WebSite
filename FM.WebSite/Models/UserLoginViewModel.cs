using System.ComponentModel.DataAnnotations;

namespace FM.WebSite.Models
{
    public class UserLoginViewModel
    {
        [Required(ErrorMessage = "Username is required")]
        [EmailAddress(ErrorMessage = "Invalid Username or P"), Display(Name ="Username")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
