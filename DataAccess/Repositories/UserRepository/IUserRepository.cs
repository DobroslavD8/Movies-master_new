using ProjectDB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories.UserRepository
{
    interface IUserRepository : IDisposable
    {
        User LogIn(string username, string password);
        void Registration(User user);
        void Save();
    }
}
