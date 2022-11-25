using SipsisAdmin.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SipsisAdmin.Controllers
{
    public class HomeController : BaseController
    {
        [Auth]
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult t()
        {
            return View();
        }
    }
}