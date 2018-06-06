using ProjectDB;
using ProjectDB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.UserRepository
{
    public class UsersRepository : IUserRepository, IDisposable
    {
        private readonly CourseProjectDbContext ctx;
        private bool disposed = false;

        public UsersRepository(CourseProjectDbContext context)
        {
            this.ctx = ctx;
        }

        public User LogIn(string username, string password)
        {
            return ctx.User.Where(u => u.UserName.Equals(username) && u.Password.Equals(password)).Single();
        }

        public void Registration(User user)
        {
            ctx.User.Add(user);
        }

        public void Save()
        {
            ctx.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if(!this.disposed)
            {
                if(disposing)
                {
                    ctx.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
