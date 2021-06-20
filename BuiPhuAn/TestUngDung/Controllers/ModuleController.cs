using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestUngDung.Controllers
{
    public class ModuleController : Controller
    {
        // GET: Module
        public ActionResult MainMenu()
        {
            return View("MainMenu");
        }
    }
}