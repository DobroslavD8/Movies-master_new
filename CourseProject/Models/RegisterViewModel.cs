using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CourseProject.Models
{
    public class RegisterViewModel
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "First Name is required.")]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "Firstname must be between 5 and 30 characters!")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is required.")]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "Lastname must be between 5 and 30 characters!")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "User Name is required.")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Username must be between 3 and 20 characters!")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "EMail address is required.")]
        [EmailAddress(ErrorMessage = "Invalid Email Address!")]
        public string Mail { get; set; }

        [Required(ErrorMessage = "Phone number is required.")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Wrong phone number!")]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Address is required.")]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "Address must be between 10 and 100 characters!")]
        public string Address { get; set; }


        [Required(ErrorMessage = "Password is required.")]
        [StringLength(50, ErrorMessage = "Password must be between 10 and 50 characters!", MinimumLength = 10)]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}