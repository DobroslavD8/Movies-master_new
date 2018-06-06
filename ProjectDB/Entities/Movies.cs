using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDB.Entities
{
    public class Movies
    {
        [ForeignKey("GenreID")] 

        public int GenreID { get; set; } 
        public virtual Genre Genre { get; set;  }

        public string Name { get; set; }
        public DateTime PremiereDate {get; set;}
        public DateTime Duration { get; set; }
        public double Price { get; set; }
    }
}
