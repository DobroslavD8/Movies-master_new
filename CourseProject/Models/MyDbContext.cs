using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using CourseProject.Models;

namespace CourseProject.Models
{
    public class MyDbContext : DbContext
    {
        public DbSet<User> User { get; set; }
    }
}