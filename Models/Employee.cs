using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DataAnnotationExample.Models
{
    public class Employee
    {
        [Required(ErrorMessage ="First Name is required")]
        [StringLength(10, MinimumLength = 2)]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(10,MinimumLength =2)]
        [DisplayName("Last Name")]

        public string LastName { get; set; }
        [Required]
        [Range(18,60)]
        [DisplayName("Age")]

        public int Age { get; set; }
        [StringLength(50,MinimumLength =10)]
        [DisplayName("Address")]

        public string Address { get; set; }
        [RegularExpression("\\d{6}")]
        [DisplayName("Pin Code")]

        public string PinCode { get; set; }
        [EmailAddress]
        [DisplayName("Email Address")]

        public string Email { get; set; }
        [Required(ErrorMessage ="Password required")]
        public string Password { get; set; }
        [Compare("Password")]
        [DisplayName("Confirm Password")]

        public string ConfirmPassword { get; set; }
    }
}
