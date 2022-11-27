using SipsisAdmin.Attribute;
using SipsisAdmin.Models;
using SipsisDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace SipsisAdmin.Controllers
{
    [Auth]
    public class CustomerController : BaseController
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View(service.CustomerServices.GetAll());
        }

        public ActionResult Insert()
        {
            return View(service.MarketServices.GetAll());
        }

        [HttpPost]
        public ActionResult Insert(CustomerVM gelen)
        {
            Customer customer = new Customer()
            {
                CustomerName = gelen.CustomerName,
                CustomerPhone = gelen.CustomerPhone,
                CustomerAddress = gelen.CustomerAddress,
                MarketId = gelen.MarketId,
                UserId = ((SessionContext)Session["SessionContext"]).ID
            };
            service.CustomerServices.Insert(customer);
            return Redirect("/Customer/Index");
        }

        public ActionResult CustomerSearch(string Phone) 
        {
            var result = service.CustomerServices.PhoneSearch(Phone);

            if(result.Id != 0) 
            { 
                return Json(result, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(false, JsonRequestBehavior.AllowGet);   
            }
        }

        public ActionResult Update(int?  Id)
        {
            if(Id != null)
            {
                var bulunan = service.CustomerServices.Find((int) Id);
                if(bulunan != null)
                {
                    ViewBag.market = service.MarketServices.GetAll();
                    return View(bulunan);
                }
                else
                {
                    return Redirect("/Customer/Index");
                }
            }
            else
            {
                return Redirect("/Customer/Index");
            }

        }

        [HttpPost]
        public ActionResult Update(CustomerVM vm)
        {
            if(ModelState.IsValid)
            {
                Customer cust = new Customer()
                {
                    Id = vm.Id,
                    MarketId = vm.MarketId,
                    CustomerName = vm.CustomerName,
                    CustomerAddress = vm.CustomerAddress,
                    CustomerPhone = vm.CustomerPhone,
                    UserId = ((SessionContext)Session["SessionContext"]).ID,    
                };
                service.CustomerServices.Update(cust);
                return Redirect("/Customer/Index");
            }
            else
            {
                return Redirect("/Customer/Index");
            }
        } 
    }
}