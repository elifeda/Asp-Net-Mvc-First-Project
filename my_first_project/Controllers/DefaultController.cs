using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace my_first_project.Controllers
{
    public class DefaultController : Controller
    {
      [Route("")]
      public ActionResult Index()
        {
            return View();  
        }
        [Route("test")]
        public ActionResult Test()
        {
            return View();
        }
        [Route("ekle/{isim}")]
        public ActionResult Ekle(string isim)
        {
            ViewBag.Elif = isim;
            return View();
        }
    }
}