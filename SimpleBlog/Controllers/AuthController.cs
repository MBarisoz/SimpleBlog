using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using SimpleBlog.ViewModels;

namespace SimpleBlog.Controllers
{
    public class AuthController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Login(AuthLogin form, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View(form);
            }

            if (form.UserName != "Trakya")
            {
                ModelState.AddModelError("UserName", "Username is not valid");
                return View();
            }


            FormsAuthentication.SetAuthCookie(form.UserName, true);

            if (!String.IsNullOrWhiteSpace(returnUrl))
            {
                return Redirect(returnUrl);
            }
            return Content("Hi! " + form.UserName);
        }

        public ActionResult logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToRoute("Home");

        }
    }

}