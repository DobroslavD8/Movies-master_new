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

        // GET: User
        public ActionResult Registration()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Registration([Bind(Include = "UserId, FirstName, LastName, UserName, Password, Mail, PhoneNumber")] ProjectDB.Entities.User userModel)
        {
            if(ModelState.IsValid)
            {
               ProjectDB.Entities.User user = new ProjectDB.Entities.User()
                {
                    UserId = userModel.UserId,
                    FirstName = userModel.FirstName,
                    LastName = userModel.LastName,
                    UserName = userModel.UserName,
                    Password = userModel.Password,
                    Mail = userModel.Mail,
                    PhoneNumber = userModel.PhoneNumber
                };

                uow.GetUserRepository.Registration(userModel);
                uow.GetUserRepository.Save();
            }
            return View(userModel);
        }

        [HttpPost]
        public ActionResult LogIn(string username, string password)
        {
            using (CourseProjectDbContext db = new CourseProjectDbContext())
            {
                //User user = db.User.Where(d => d.UserName == userModel.UserName && d.Password == userModel.Password).Single();
                try
                {
                    var userDetails = db.User.Where(d => d.UserName.Equals(username) && d.Password.Equals(password)).Single();
                    Session["ID"] = userDetails.UserId;
                }
                catch
                {
                    ModelState.AddModelError("", "Wrong credentials!");
                    return View("Index");
                }
            }
            return RedirectToAction("Index", "Home");
        }

    }
}