using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CourseProject.Models
{
    public class Genre
    {
        public int GenreID { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "Field {1} must be between 5 and 30 characters!")]
        public string GenreName { get; set; }

        public virtual ICollection<Movies> Movies { get; set; }
    }
}
