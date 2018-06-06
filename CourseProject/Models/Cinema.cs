using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProject.Models
{
    public class Cinema
    {
        [Required]
        public int CinemaID { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Field {1} must be between 3 and 30 characters!")]
        public string Name { get; set; }

        [Required]
        [Range(300, 5000, ErrorMessage = "Enter capacity between 300 to 5000.")]
        public int Capacity { get; set; }
    }
}
