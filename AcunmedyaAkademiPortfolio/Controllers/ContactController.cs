using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunmedyaAkademiPortfolio.Models;

namespace AcunmedyaAkademiPortfolio.Controllers
{
    public class ContactController : Controller
    {
        DbAcunMedyaAkademiPortfolioEntities2 db = new DbAcunMedyaAkademiPortfolioEntities2();
        public ActionResult Index()
        {
            var values = db.TblContacts.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddContact()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddContact(TblContact model)
        {
            db.TblContacts.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult DeleteContact(int id)
        {
            var value = db.TblContacts.Find(id);
            db.TblContacts.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateContact(int id)
        {
            var value = db.TblContacts.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateContact(TblContact model)
        {
            var value = db.TblContacts.Find(model.ContactId);
            value.Adress = model.Adress;
            value.Phone = model.Phone;
            value.Email = model.Email;
            value.MapUrl = model.MapUrl;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}