using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebAppMvcControllerModelViewForm.Models;

namespace WebAppMvcControllerModelViewForm.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult DatabaseToModel()
        {
            Log log = new Log();
            log.Id = 1;
            log.Name = "Sam";
            log.Date = DateTime.Now;
            log.Priority = 1;

            return View();
        }

        public ActionResult ControllerPassingModelToView()
        {            
            Log log = new Log();
            log.Id = 1;
            log.Name = "Sam";
            log.Date = DateTime.Now;
            log.Priority = 1;

            List<Log> list = new List<Log>();
            list.Add(log);

            return View(log);
        }

        public ActionResult FormScaffoldAnnotationValidation(){
            Log log = new Log();
            log.Id = 1;
            log.Name = "Sam";
            log.Date = DateTime.Now;
            log.Priority = 1;

            return View(log);
        }

        [HttpPost]
        public ActionResult FormScaffoldAnnotationValidation(Log log)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }

            return View(log);
        }

        public ActionResult EntityFrameworkModel()
        {
            return View();
        }

        public ActionResult ValidationIntegratedRazor()
        {
            Foo foo = new Foo();
            foo.Id = 5;
            return View(foo);
        }
    }
}
