using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBlog.Areas.Admin.Controllers
{
    public class PostsController : Controller
    {
        // GET: Admin/Posts
        public ActionResult Index()
        {
            return Content("Admin Posts Controller");
        }

        public ActionResult New()
        {
            return Content("A new page");
        }

        public ActionResult Edit(string id)
        {
            return Content(id);
        }

    }
}