using SipsisAdmin.Attribute;
using SipsisAdmin.Models;
using SipsisDAL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SipsisAdmin.Controllers
{
    [Auth]
    public class CargoController : BaseController
    {
        // GET: Cargo
        public ActionResult Index()
        {
            return View(service.CargoServices.GetAll());
        }
        public ActionResult Insert() 
        {
            return View();
        }
        [HttpPost]
        public ActionResult Insert(CargoVM vm, HttpPostedFileBase resim)
        {
            if(resim != null)
            {
                string uzanti = Path.GetExtension(resim.FileName);
                string resimAdi = vm.CargoName + uzanti; 
                string dosyaYolu = Server.MapPath("/Assets/Img/" + resimAdi);
                resim.SaveAs(dosyaYolu);

                Cargo crg = new Cargo()
                {
                    CargoName = vm.CargoName,
                    UserId = ((SessionContext)Session["SessionContext"]).ID,
                    CargoImageURL = "/Assets/Img/" + resimAdi,
                };
                service.CargoServices.Insert(crg);
                return Redirect("/Cargo/Index");
            }
            else
            {
                Cargo crg = new Cargo()
                {
                    CargoName = vm.CargoName,
                    UserId = ((SessionContext)Session["SessionContext"]).ID,
                    CargoImageURL = "/Assets/Img/nullImage.png",
                };
                service.CargoServices.Insert(crg);
                return Redirect("/Cargo/Index");
            }
        }
        public ActionResult Update(int? ID)
        {
            if(ID != null)
            {
                var bul = service.CargoServices.Find((int)ID);
                return View(bul);
            }
            else
            {
                return Redirect("/Cargo/Index");
            }
        }
        [HttpPost]
        public ActionResult Update(CargoVM vm, HttpPostedFileBase resim)
        {
             if (resim == null)
            {
                Cargo crg = new Cargo()
                {
                    CargoImageURL = "/Assets/Img/ImageNull.png", 
                    CargoName = vm.CargoName,
                    Id = vm.Id,
                    UserId = ((SessionContext)Session["SessionContext"]).ID
                };
                service.CargoServices.Update(crg);
                return Redirect("/Cargo/Index");
            }
             else
            {
                string uzanti = Path.GetExtension(resim.FileName);
                string resimAdi =vm.CargoName+ uzanti;
                string dosyaYolu = Server.MapPath("/Assets/Img" + resimAdi);
                resim.SaveAs(dosyaYolu);

                Cargo crg= new Cargo()
                {
                    CargoName= vm.CargoName,    
                    Id = vm.Id,
                    UserId = ((SessionContext)Session["SessionContext"]).ID,
                    CargoImageURL = "/Assets/Img/" + resimAdi,
                };
                service.CargoServices.Update(crg);
                return Redirect("/Cargo/Index");
            }
        }
    }
}