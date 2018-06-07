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

       //private readonly UnitOfWork UnitOW;

       // private CourseProjectDbContext db = new CourseProjectDbContext();

      // // public MoviesController()
      // // {
      // //     this.UnitOW = new UnitOfWork(new CourseProjectDbContext());
      // // }

       // public MoviesController(CourseProjectDbContext context)
       // {
       //     UnitOW = new UnitOfWork(context);
       // }

       // -------------------------------------------------
       // // GET: Movies/Details/5
       // [HttpGet]
       // public ActionResult Details(int? id)
       // {
       //     if (id == null)
       //     {
       //         return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
       //     }
       //     MovieViewModel movies = db.Movies.Find(id);
       //     if (movies == null)
       //     {
       //         return HttpNotFound();
       //     }
       //     return View(movies);
       // }
       // -------------------- или ------------------------
       

       // // GET: Movies
       // [HttpGet]
       // public ActionResult Index()
       // {

       //     var movies = db.Movies;
       //     return View(movies.ToList());

       //     /*
       //     IEnumerable<Movies> movies = UnitOW.RepositoryBase.GetAll();

       //     List<Movies> model = new List<Movies>();
       //     foreach (Movies movie in Movies)
       //     {
       //         Movies movie = new Movies(movie);
       //         model.Add(movie);
       //     }
       //     */
       // }

       // // GET: Cities/Create
       // [HttpGet]
       // public ActionResult Create()
       // {
       //     return View();
       // }

       // // POST: Movies/Create
       // [HttpPost]
       // public ActionResult Create(Movies movie)
       // {
       //     try
       //     {
       //         if (ModelState.IsValid)
       //         {
       //             db.Movies.Add(movie);
       //             db.SaveChanges();
       //             return RedirectToAction("Index");
       //         }
       //     }
       //     catch (DataException)
       //     {
       //         ModelState.AddModelError("", "Unable to save changes...");
       //     }
       //     return View(movie);
       // }

       // // GET: Movies/Edit/5
       // [HttpGet]
       // public ActionResult Edit(int id)
       // {
       //     return View();
       // }

       // // POST: Movies/Edit/5
       // [HttpPost]
       // public ActionResult Edit(int id, FormCollection collection)
       // {
       //     if (id == null)
       //     {
       //         return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
       //     }

       //     var newMovie = db.Movies.Find(id);
       //     if (TryUpdateModel(newMovie, "",
       //        new string[] { "GenreID", "Name", "PremiereDate", "Duration", "Price" }))
       //     {
       //         try
       //         {
       //             db.SaveChanges();
       //             return RedirectToAction("Index");
       //         }
       //         catch (DataException)
       //         {
       //             ModelState.AddModelError("", "Unable to save changes...");
       //         }
       //     }
       //     return View(newMovie);
       // }

       // // GET: Movies/Delete/5
       // [HttpGet]
       // public ActionResult Delete(int? id)
       // {
       //     if (id == null)
       //     {
       //         return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
       //     }

       //     Movies movie = db.Movies.Find(id);

       //     if (movie == null)
       //     {
       //         return HttpNotFound();
       //     }
       //     return View(movie);
       // }

       // // POST: Movies/Delete/5
       // [HttpPost]
       // public ActionResult Delete(int id)
       // {
       //     // #1 
       //     /* Movies movie = RepositoryBase.GetByID(id);

       //     if (movie == null)
       //         return View("NotFound");
       //     else
       //         return View(movie); */

       //     // #2

       //     Movies movie = db.Movies.Find(id);
       //     db.Movies.Remove(movie);
       //     db.SaveChanges();

       //     return RedirectToAction("Index");
       // }

       // protected override void Dispose(bool disposing)
       // {
       //     if (disposing)
       //     {
       //         db.Dispose();
       //     }

       //     base.Dispose(disposing);
       // }
    } 
} 
