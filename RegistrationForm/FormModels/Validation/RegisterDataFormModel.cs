using System.ComponentModel.DataAnnotations;

namespace RegistrationForm.FormModels.Validation
{
    public class RegisterDataFormModel
    {
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Age is required")]
        [Range(1, 120, ErrorMessage = "Invalid age")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Mobile number is required")]
        [RegularExpression(@"^[0-9]{10}$", ErrorMessage = "Invalid mobile number")]
        public string MobileNumber { get; set; }

        [Required(ErrorMessage = "Address is required")]
        public string Address { get; set; }
    }
}