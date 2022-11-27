using SipsisAdmin.Attribute;
using SipsisAdmin.Models;
using SipsisDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace SipsisAdmin.Controllers
{
    [Auth]
    public class MarketController : BaseController
    {
        public ActionResult Index()
        {
            var liste = service.MarketServices.GetAll();
            return View(liste);
        }
        [HttpGet]
        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(MarketVM gelen)
        {
            Market market = new Market()
            {
                MarketName = gelen.MarketName,
                Commission = gelen.Commission,
                UserId = ((SessionContext)Session["SessionContext"]).ID
            };
            service.MarketServices.Insert(market);  
            return Redirect("/Market/Index");
        }

        public ActionResult Update(int? ID)
        {
            if(ID != null)
            {
                var bulunan = service.MarketServices.Find((int)ID);
                if (bulunan != null)
                {
                    return View(bulunan);
                }
                else
                {
                    return Redirect("/Market/Index");
                }

            }
            else
            {
                return Redirect("/Market/Index");
            }
        }

        [HttpPost]
        public ActionResult Update(MarketVM gelen)
        {
            if(ModelState.IsValid) 
            {
                Market market = new Market()
                { 
                    MarketName = gelen.MarketName,
                    Commission = gelen.Commission,
                    Id = gelen.Id,
                    UserId = ((SessionContext)Session["SessionContext"]).ID,
                };

                service.MarketServices.update(market);
                return Redirect("/Market/Index");
            }
            else
            {
                return Redirect("/Market/Index");
            }
        }
    }
}