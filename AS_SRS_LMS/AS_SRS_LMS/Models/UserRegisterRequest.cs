using System.ComponentModel.DataAnnotations;

namespace AS_SRS_LMS.Models
{
    public class UserRegisterRequest
    {
        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string PhoneNumber { get; set; }

        [Required, MinLength(6, ErrorMessage = "Please enter at least 6 characters!!!")]
        public string Password { get; set; } = string.Empty;
        [Required, Compare("Password")]
        public string ConfirmPassword { get; set; } = string.Empty;
       
        public int RoleId { get; set; }

    }
}
