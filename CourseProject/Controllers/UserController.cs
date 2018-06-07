using CourseProject.Models;
using DataAccess.Repositories;
using ProjectDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CourseProject.Controllers
{
    public class UserController : Controller
    {
        private readonly UnitOfWork uow;

        public UserController()
        {
            this.uow = new UnitOfWork(new CourseProjectDbContext());
        }

        public UserController(CourseProjectDbContext context)
        {
            uow = new UnitOfWork(context);
        }


        // --------------------------------------------- #2 --------------------------------------------- //
        //// GET: User
        //public ActionResult Registration()
        //{
        //    return View();
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Registration([Bind(Include = "UserId, FirstName, LastName, UserName, Password, Mail, PhoneNumber")] ProjectDB.Entities.User userModel)
        //{
        //    if(ModelState.IsValid)
        //    {
        //       ProjectDB.Entities.User user = new ProjectDB.Entities.User()
        //        {
        //            UserId = userModel.UserId,
        //            FirstName = userModel.FirstName,
        //            LastName = userModel.LastName,
        //            UserName = userModel.UserName,
        //            Password = userModel.Password,
        //            Mail = userModel.Mail,
        //            PhoneNumber = userModel.PhoneNumber
        //        };

        //        uow.GetUserRepository.Registration(userModel);
        //        uow.GetUserRepository.Save();
        //    }
        //    return View(userModel);
        //}

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(RegisterViewModel viewModel)
        {

            if (ModelState.IsValid)
            {
                User user = new User
                {
                    UserId = viewModel.UserId,
                    FirstName = viewModel.FirstName,
                    LastName = viewModel.LastName,
                    UserName = viewModel.UserName,
                    Address = viewModel.Address,
                    Mail = viewModel.Mail,
                    PhoneNumber = viewModel.PhoneNumber
                };
                //uow.GetUserRepository.Registration(user);
                uow.GetUserRepository.Save();
                return RedirectToAction("Index", "User");

            }
            else
            {
                return View();
            }
        }

        //private static UserViewModel UserViewModel = new UserViewModel(); //Without this: An object reference is required for the non-static
        //With: Cannot implicitly convert type "ProjectDB.Entities.User"
        //-------------------------------- to  "CourseProject.Models.User"
        //[HttpPost]
        //public ActionResult Login(string username, string password)
        //{
        //    using (CourseProjectDbContext db = new CourseProjectDbContext())
        //    {
        //        User user = db.User.Where(d => d.UserName == UserViewModel.UserName && d.Password == UserViewModel.Password).Single();
        //        if (ModelState.IsValid)
        //        {
        //            try
        //            {
        //                var userDetails = db.User.Where(d => d.UserName.Equals(username) && d.Password.Equals(password)).Single();
        //                Session["UserName"] = userDetails.UserName.ToString();
        //                Session["Password"] = userDetails.Password.ToString();
        //            }
        //            catch
        //            {
        //                ModelState.AddModelError("", "Wrong credentials!");
        //                return View("Index");
        //            }
        //        }
        //    }
        //    return RedirectToAction("Index", "Home");
        //}

        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            using (CourseProjectDbContext db = new CourseProjectDbContext())
            {
                var usr = db.Users.Single(u => u.UserName == user.UserName && u.Password == user.Password);
                if (usr != null)
                    {
                        Session["UserId"] = usr.UserId.ToString();
                        Session["UserName"] = usr.UserName.ToString();
                        return RedirectToAction("LoggedIn");
                    }
                else
                    {
                        ModelState.AddModelError("", "Username or password is incorrect.");
                    }
                }
            return View();
            }
           
        public ActionResult LoggedIn()
        {
            if (Session["UserId"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }
        }

        // Generated code "public System.Data.Entity.DbSet<CourseProject.Models.RegisterViewModel> RegisterViewModels { get; set; }" in CourseProjectDbContext
        // ===================================================================================================================
        // ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

}