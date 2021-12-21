using LTQL_1721050441.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace LTQL_1721050441.Controllers
{
    public class AccountsController : Controller
    {
        // GET: Accounts
        private ActionResult RedirecToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        public ViewResult Login(string returnUrl)
        {
            ViewBag.returnUrl = returnUrl;
            return View();
        }
        //Nhận dữ liệu từ client gửi lên
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Account acc, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                if (acc.UserName == "Admin" && acc.PassWord == "123456")
                {
                    FormsAuthentication.SetAuthCookie(acc.UserName, true);
                    return RedirecToLocal(returnUrl);
                }
            }
            return View(acc);
        }
        //Đăng xuất
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Home");
        }

    }
}