using CourseProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectDB;
using System.Net;
using System.Data;
using DataAccess.Repositories;


namespace CourseProject.Controllers
{
    public class MoviesController : Controller
    {

        private readonly UnitOfWork UnitOW;


        private CourseProjectDbContext db = new CourseProjectDbContext();

        public MoviesController(CourseProjectDbContext context)
        {
            UnitOW = new UnitOfWork(context);
        }

        //public ActionResult Index()
        //{
        //    // Fix cannot convert ------ ↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓↓ & create Index view
        //    IEnumerable<Movies> movies = UnitOW.Repository.GetAll();

        //    List<MovieViewModel> model = new List<MovieViewModel>();
        //    foreach (Movies movie in movies)
        //    {
        //        MovieViewModel movieModel = new MovieViewModel(movie);
        //        model.Add(movieModel);
        //    }

        //    return View(model);
        //}
        //-------------------------------------------------------------------
        //[HttpGet]
        //public ActionResult Index()
        //{

        //    IEnumerable<Movies> movies = UnitOW.MoviesRepository.GetAll();

        //    List<Movies> model = new List<Movies>();
        //    foreach (Movies movie in Movies)
        //    {
        //        Movies movie = new Movies(movie);
        //        model.Add(movie);
        //    }
        //}
        //-------------------------------------------------------------------

        //public ActionResult Details()
        //{
        //    return View();
        //}

        //public ActionResult Details(int? id)
        //{
        //    if (id == null)
        //           {
        //                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //           }
        //        Movies movie = UnitOW.MoviesRepository.GetByID(id);
        //    MovieViewModel model = new MovieViewModel(movie);

        //    return View(model);
        //}

        //[HttpGet]
        // public ActionResult Create()
        // {
        //     return View();
        // }

        // public ActionResult Create([Bind(Include = "ID,GenreID,Genre,Name,PremiereDate,Duration,Price")] MovieViewModel movieViewModel)
        // {
        //         try
        //         {
        //             Movies movie = new Movies();

        //             UnitOW.MovieRepository.Add(movie);
        //             UnitOW.MovieRepository.Saved();
        //         }
        //         catch
        //         {
        //             ModelState.AddModelError("", "Database error! Unable to save changes. Try again later!");
        //         }
        //         return View(movieViewModel);
        //     }
        // }

        //[HttpPost]
        //public ActionResult Edit(int? id)
        //{
        //    
        //}

        // GET: Movies/Delete/5
        //[HttpGet]
        //public ActionResult Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }

        //    Movies movie = db.MoviesView.Find(id);

        //    if (movie == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(movie);
        //}

        //[HttpPost]
        //public ActionResult Delete(int id)
        //{
        //    Movies movie = RepositoryBase.GetByID(id);

        //    if (movie == null)
        //        return View("NotFound");
        //    else
        //        return View(movie); 
        //}
        //}
} 
