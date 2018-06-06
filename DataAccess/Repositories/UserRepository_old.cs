using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectDB;
using ProjectDB.Entities;

//namespace DataAccess.Repositories
//{
 //   public class UserRepositoryy shti napravq nov che toq prai problemi neshto
//}
//        class UserRepository<T> : RepositoryBase<T>
//        where T : class
//    {
//        protected CourseProjectDbContext ctx;

//        public UserRepository() =>
//        ctx = new CourseProjectDbContext();

//        public UserRepository(CourseProjectDbContext ctx)
//        {
//            this.ctx = ctx;
//        }

//        public User GetById(int? id)
//        {
//            return ctx.User.Find(id);
//        }

//        public User GetByUsername(string username)
//        {
//            return ctx.User.Find(username);
//        }

//        public User GetAll(int id, string firstName, string LastName, string username, int PhoneNumber)
//        {
//            return ctx.User.Find(id, firstName, LastName, username, PhoneNumber);
//        }

//        public string Login(string UserName, string Password)
//        {
//            if (ctx.User.Any(x => x.UserName == UserName && x.Password == Password))
//            {
//                return "Hello, " + UserName + "." + "You are logged successfully";
//            }
//            throw new UnauthorizedAccessException();
//        }

//        public void Register(User user)
//        {
//            ctx.User.Add(user);
//        }

//        public void Saved()
//        {
//            ctx.SaveChanges();
//        }

//        // Inserted class
//        public class User
//        {
//            public int ID { get; set; }
//            public string Username { get; set; }
//            public bool IsAdministrator { get; set; }
//        }
//        public class RepositoryUser
//        {
//            public User GetUserByNameAndPassword(string username, string password)
//            {
//                return new User()
//                {
//                    ID = 1,
//                    Username = username,
//                    IsAdministrator = true
//                };
//            }
//        }

//    }}

