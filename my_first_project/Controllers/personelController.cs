using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace my_first_project.Controllers
{
    public class personelController : Controller
    {
        // GET: personel
        public ActionResult Index()
        {
            return Content("Anasayfa");
        }
    }
}