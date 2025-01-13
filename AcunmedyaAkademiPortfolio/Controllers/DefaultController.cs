using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.Mvc;
using AcunmedyaAkademiPortfolio.Models;

namespace AcunmedyaAkademiPortfolio.Controllers
{
    public class DefaultController : Controller
    {
        DbAcunMedyaAkademiPortfolioEntities2 db = new DbAcunMedyaAkademiPortfolioEntities2();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult DefaultBanner()
        {
            var values = db.TblBanners.ToList();
            return PartialView(values);
        }
        public PartialViewResult DefaultAbout()
        {

            var values = db.TblAbouts.ToList();

            return PartialView(values);
        }

        public PartialViewResult DefaultStatistics()
        {
            ViewBag.projectCount = db.TblProjects.Count();
            ViewBag.skillCount = db.TblSkills.Count();
            ViewBag.testimonialCount = db.TblTestimonials.Count();

            return PartialView();
        }

        public PartialViewResult DefaultSkills()
        {
            var values = db.TblSkills.ToList();
            return PartialView(values);
        }


        public PartialViewResult DefaultEducation()
        {
            var values = db.TblEducations.ToList();
            return PartialView(values);

        }
        public PartialViewResult DefaultExperience()
        {
            var values = db.TblExperiences.ToList();
            return PartialView(values);

        }

        public PartialViewResult DefaultPortfolio()
        {
            var values = db.TblProjects.ToList();
            return PartialView(values);
        }
        public PartialViewResult DefaultServices()
        {
            var values = db.TblServices.ToList();
            return PartialView(values);
        }
        public PartialViewResult DefaultTestimonials()
        {
            var values = db.TblTestimonials.ToList();
            return PartialView(values);
        }

        [HttpGet]
        public PartialViewResult SendMessage()
        {
            return PartialView();
        }
        [HttpPost]
        public ActionResult SendMessage(TblMessage model)
        {
            db.TblMessages.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        

      
    }
}