using ProjectDB;
using ProjectDB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    class MovieRepository
    {
        protected CourseProjectDbContext ctx;

        public MovieRepository() =>
        ctx = new CourseProjectDbContext();

        public MovieRepository(CourseProjectDbContext ctx)
        {
            this.ctx = ctx;
        }

        // public Movies GetById(int? id)
        //{
        //    return ctx.MoviesViewModel.Find(id);
        //}

        public User GetByName(string Name)
        {
            return ctx.User.Find(Name);
        }

        public User GetAll(string Name, int GenreID, DateTime PremiereDate, int Duration, double Price)
        {
            return ctx.User.Find(Name, GenreID, PremiereDate, Duration, Price);
        }

        public void Saved()
        {
            ctx.SaveChanges();
        }

        // Error:
        //public void DeleteByID(int id)
        //{
        //    Movies movie = ctx.MoviesViewModel.Find(id);
        //    if (movie != null)
        //    {
        //        ctx.MoviesViewModel.Remove(movie);
        //        ctx.SaveChanges();
        //    }
        //}
    }
}
