using System.ComponentModel.DataAnnotations;

namespace TypicalTypist.Models 
{
    public class PostUserDTO
    {
        [Required(ErrorMessage = "First Name is Required.")]
        [StringLength(35, ErrorMessage = "First Name May Not Exceed 35 Characters.")]
        public string FirstName { get; set; } = null!;

        [Required(ErrorMessage = "Last Name is Required.")]
        [StringLength(35, ErrorMessage = "Last Name May Not Exceed 35 Characters.")]
        public string LastName { get; set; } = null!;

        [Required(ErrorMessage = "Email is Required.")]
        [DataType(DataType.EmailAddress, ErrorMessage = "Email is in Invalid Format.")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "Username is Required.")]
        [StringLength(35, ErrorMessage = "Username May Not Exceed 35 Characters.")]
        public string UserName { get; set; } = null!;

        [Required(ErrorMessage = "Password is Required.")]
        [StringLength(50, ErrorMessage = "Password May Not Exceed 50 Characters.")]
        [RegularExpression(@"^(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*()_+{}\[\]:;<>,.?~\-=/\\|`])[A-Za-z\d!@#$%^&*()_+{}\[\]:;<>,.?~\-=/\\|`]{6,}$",
        ErrorMessage = "Password Must be at Least 6 Characters Long and Contain at Least One Number, One Special Symbol, and One Capitalized Character.")]
        public string Password { get; set; } = null!;

        [Required(ErrorMessage = "Confirmation Password is Required.")]
        [Compare("Password", ErrorMessage = "Passwords must match.")]
        public string ConfirmPassword { get; set; } = null!;

        public DateTime Joined { get; set; }
    }
}