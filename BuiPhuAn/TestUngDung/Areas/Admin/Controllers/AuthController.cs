using ModelEF.DAO;
using ModelEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestUngDung.MoaHoaMD5;

namespace TestUngDung.Areas.Admin.Controllers
{
    public class AuthController : Controller
    {
        UserAccountDAO  userDAO = new UserAccountDAO();
        // GET: Admin/Auth
        public ActionResult Login()
        {
            ViewBag.strError = "";
            return View();
        }

        [HttpPost]
        public ActionResult Login(FormCollection filed)
        {
            String user = filed["username"];
            String pass = MyString.ToMD5(  filed["password"]);      

            String err = "";
            // Xử lý
            UserAccount userAccount_row = userDAO.getRow(user);
            if (userAccount_row != null)
            {
                //login
                if (userAccount_row.Password.Equals(pass))
                {
                    if (userAccount_row.Status.Equals("ACTIVE"))
                    {
                        Session["UserAdmin"] = userAccount_row.UserName;
                        return RedirectToAction("Index", "Dashboard");
                    } else
                    {
                        err = " Tài khoản này không thể đăng nhập";
                    }
                } else
                {
                        err = " Mật khẩu không chính xác";
                 
                }
            } else
            {
                err = "Tên đăng nhập không tồn tại";
            }
            ViewBag.strError = "<div class ='text-danger'>" + err + "</div> ";
       
            return View();
        }
        public ActionResult Logout()
        {
            Session["UserAdmin"] = "";
            return Redirect("~/Admin/login");
        }
    }
}