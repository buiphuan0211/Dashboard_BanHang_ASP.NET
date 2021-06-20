using ModelEF.DAO;
using ModelEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TestUngDung.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var categoryDAO = new CategoryDAO();
            var productDAO = new ProductDAO();
            ViewBag.Products = productDAO.ListProduct();
            ViewBag.Categories= categoryDAO.ListCategory();
            return View("Index");
        }
    }
}