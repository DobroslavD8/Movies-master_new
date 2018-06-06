using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ProjectDB.Entities;

namespace ProjectDB
{
   public class CourseProjectDbContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Cinema> Cinema { get; set; }
        public DbSet<Genre> Genre { get; set; }
        public DbSet<Movies> Movies { get; set; }
    }
}
