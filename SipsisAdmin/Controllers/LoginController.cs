using SipsisAdmin.Attribute;
using SipsisAdmin.Models;
using SipsisDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SipsisAdmin.Controllers
{
    public class LoginController : BaseController
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginControl(LoginVM gelen)
        {
            if (ModelState.IsValid)
            {
                if (service.UserServices.logincontrol(gelen.UserName, gelen.Password))
                {
                    user use = service.UserServices.FindUserName(gelen.UserName);
                    SessionContext _sessionContext = new SessionContext()
                    {
                        ID = use.Id,
                        UserName = use.UserName,
                        ImageURL = use.ImagineURL
                    };
                    Session["SessionContext"] = _sessionContext;
                    return Json(true, JsonRequestBehavior.AllowGet);
                }
                else
                {
                    return Json(false, JsonRequestBehavior.AllowGet);
                }
            }
                else
                {
                    return Redirect("/Login/Index");
                }
        }

        public ActionResult LogOut()
        {
            Session.Abandon();
            return Redirect("/Login");
        }
    }
}