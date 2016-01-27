using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using WebAppMvcControllerModelViewForm.Models;

namespace WebAppMvcControllerModelViewForm.Controllers
{
    public class LogController : Controller
    {
        //
        // GET: /Log/

        public ActionResult Index()
        {
            Log log = new Log();
            log.Id = 1;
            log.Name = "mock only test 1";
            log.Date = DateTime.Now;

            List<Log> list = new List<Log>();
            list.Add(log);

            return View(list);
        }

        //public ActionResult Edit(int id = 0)
        //{
        //    Log movie = db.Movies.Find(id);
        //    if (movie == null)
        //    {
        //        return HttpNotFound();
        //    }
        //    return View(movie);
        //}

        //
        // POST: /Movies/Edit/5

        //[HttpPost]
        //public ActionResult Edit(Movie movie)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(movie).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(movie);
        //}

    }
}
