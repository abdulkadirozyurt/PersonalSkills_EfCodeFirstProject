using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonalSkills_EfCodeFirstProject.Models.Contexts;

namespace PersonalSkills_EfCodeFirstProject.Controllers
{
    public class SkillsController : Controller
    {
        // GET: Default
        private SkillsContext skillsContext = new SkillsContext();
        public ActionResult Index()
        {
            var values = skillsContext.Skills.ToList();
            return View(values);
        }
    }
}