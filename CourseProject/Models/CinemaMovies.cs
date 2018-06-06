using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CourseProject.Models
{
    public class CinemaMovies
    {
        [Required]
        public int MovieID { get; set; }

        [Required]
        public int CinemaID { get; set; }

        [Required, ForeignKey("MovieID")]
        public virtual Movies Movie { get; set; }
    }
}