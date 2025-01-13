using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AcunmedyaAkademiPortfolio.Models
{
    public class ResumeViewModel
    {
        public List<TblEducation> Educations { get; set; }
        public List<TblExperience> Experiences { get; set; }
    }
}