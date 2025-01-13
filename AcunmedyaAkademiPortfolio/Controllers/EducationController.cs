using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunmedyaAkademiPortfolio.Models;
using Microsoft.Ajax.Utilities;

namespace AcunmedyaAkademiPortfolio.Controllers
{
    public class EducationController : Controller
    {
        DbAcunMedyaAkademiPortfolioEntities2 db = new DbAcunMedyaAkademiPortfolioEntities2();
        public ActionResult Index()
        {
            var values = db.TblEducations.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult AddEducation()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddEducation(TblEducation model)
        {
            db.TblEducations.Add(model);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteEducation(int id)
        {
            var value = db.TblEducations.Find(id);
            db.TblEducations.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateEducation(int id)
        {
            var value = db.TblEducations.Find(id);
            return View(value);

        }

        [HttpPost]
        public ActionResult UpdateEducation(TblEducation model)
        {
            var value = db.TblEducations.Find(model.EducationId);
            value.Department = model.Department;
            value.StartYear = model.StartYear;
            value.EndYear = model.EndYear;
            value.SchoolName = model.SchoolName;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}