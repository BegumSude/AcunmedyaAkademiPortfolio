using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunmedyaAkademiPortfolio.Models;

namespace AcunmedyaAkademiPortfolio.Controllers
{
    public class SocialMediaController : Controller
    {
        DbAcunMedyaAkademiPortfolioEntities2 db = new DbAcunMedyaAkademiPortfolioEntities2();
        public ActionResult Index()
        {
            var values = db.TblSocialMedias.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddSocialMedia()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddSocialMedia(TblSocialMedia model)
        {
            db.TblSocialMedias.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteSocialMedia(int id)
        {
            var value = db.TblSocialMedias.Find(id);
            db.TblSocialMedias.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateSocialMedia(int id)
        {
            var value = db.TblSocialMedias.Find(id);
            return View(value);

        }

        [HttpPost]
        public ActionResult UpdateSocialMedia(TblSocialMedia model)
        {
            var value = db.TblSocialMedias.Find(model.SocialMediaId);
            value.Name = model.Name;
            value.Url = model.Url;
            value.Icon = model.Icon;
            
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}