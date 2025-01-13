using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunmedyaAkademiPortfolio.Models;

namespace AcunmedyaAkademiPortfolio.Controllers
{
    public class ServiceController : Controller
    {
        DbAcunMedyaAkademiPortfolioEntities2 db = new DbAcunMedyaAkademiPortfolioEntities2();
        public ActionResult Index()
        {
            var values = db.TblServices.ToList();
            return View(values);
        }


        [HttpGet]
        public ActionResult AddService()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddService(TblService model)
        {
            db.TblServices.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteService(int id)
        {
            var value = db.TblServices.Find(id);
            db.TblServices.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateService(int id)
        {
            var value = db.TblServices.Find(id);
            return View(value);

        }

        [HttpPost]
        public ActionResult UpdateService(TblService model)
        {
            var value = db.TblServices.Find(model.ServiceId);
            value.ServiceName = model.ServiceName;
            value.ServiceDescription = model.ServiceDescription;
           
            db.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}