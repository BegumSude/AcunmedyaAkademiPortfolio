using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunmedyaAkademiPortfolio.Models;

namespace AcunmedyaAkademiPortfolio.Controllers
{
    public class MessageController : Controller
    {
        DbAcunMedyaAkademiPortfolioEntities2 db = new DbAcunMedyaAkademiPortfolioEntities2();
        public ActionResult Index()
        {
            var values = db.TblMessages.ToList();
            return View(values);
        }

        public ActionResult DeleteMessage(int id)
        {
            var value = db.TblMessages.Find(id);
            db.TblMessages.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}