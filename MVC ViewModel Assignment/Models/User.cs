using System.ComponentModel.DataAnnotations;

namespace MVC_ViewModel_Assignment.Models
{
    public class User
    {
        public int Id {  get; set; }


        [Required(ErrorMessage = "Name is Required")]
        public string? Name { get; set; }

        [Required]
        [EmailAddress(ErrorMessage ="Email is Invalid")]
        public string? Email { get; set; }


        [Required]
        [MinLength(8, ErrorMessage ="Password must be greater than 8")]
        public string? Password { get; set; }



        [Required]
        [Compare("Password", ErrorMessage ="Password does not mismatch")]
        public string? ConfirmPassword {  get; set; }
    }
}
