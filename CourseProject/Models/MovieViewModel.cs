using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CourseProject.Models
{
    public class MovieViewModel
    {
        [Required, ForeignKey("GenreID")]

        public int GenreID { get; set; }
        public virtual Genre Genre { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "Field {1} must be between 5 and 30 characters!")]
        public string Name { get; set; }

        [Required]
        [Range(typeof(DateTime), "1/1/1888", "1/5/2018")] // 1888 - заснет първият филм
        public DateTime PremiereDate { get; set; }

        [Required]
        [Range(typeof(int), "10", "400")]
        public int Duration { get; set; }

        [Required]
        [RegularExpression(@"^([0-9]{0,2}((.)[0-9]{0,2}))$", ErrorMessage = "Invalid price.")]
        public double Price { get; set; }

        public virtual ICollection<CinemaMovies> CinemaMovies { get; set; }

    }
}