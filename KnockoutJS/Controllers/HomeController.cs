using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KnockoutJS.Models;

namespace KnockoutJS.Controllers
{
    public class HomeController : Controller
    {
        IC_MotersEntities db = new IC_MotersEntities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult RazerList()
        {

            var personList = db.People.Select(x => new PersonViewModel
            {
                Id = x.PersonId,
                FirstName = x.FirstName
            }).ToList();
            return View(personList);
        }

        public ActionResult GetAjax()
        {
            var personList = db.People.Select(x => new PersonViewModel
            {
                Id = x.PersonId,
                FirstName = x.FirstName
            }).ToList();
            return Json(personList, JsonRequestBehavior.AllowGet);
        }
    }
}