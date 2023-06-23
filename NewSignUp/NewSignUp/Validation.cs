using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinical_System
{
    public class SignUpValidation
    {
        [Required(ErrorMessage = "National ID is required")]
        [RegularExpression("^([1-9]{1}[0-9]{2}(0[1-9]|1[0-2])(0[1-9]|1[0-9]|2[0-9]|3[0-1])[0-9]{2}[0-9]{5})$", ErrorMessage = "Please enter Valid National ID")]
        public string PatientNationalID { get; set; }
        [Required, RegularExpression(@"^.*[a-zA-Z]", ErrorMessage = "Please enter a valid First Name")]
        public string PatientFirstName { get; set; }
        [Required, RegularExpression(@"^.*[a-zA-Z]", ErrorMessage = "Please enter a valid Last Name")]
        public string PatientLastName { get; set; }
        [RegularExpression("(201)[0-9]{9}", ErrorMessage = "Please enter Valid phoone number")]
        public string PatientPhone { get; set; }
        [Required, EmailAddress]
        public string PatientEmail { get; set; }
        [Required]
        public string PatientPassword { get; set; }
        [Required]
        public string PatientConfirmPassword { get; set; }
        [Range(18, 120, ErrorMessage = "Age must be between 18 and 120")]
        public string PatientAge { get; set; }
    }
}
