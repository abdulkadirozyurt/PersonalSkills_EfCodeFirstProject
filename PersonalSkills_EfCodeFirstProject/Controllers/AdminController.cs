using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PersonalSkills_EfCodeFirstProject.Models.Contexts;
using PersonalSkills_EfCodeFirstProject.Models.Entities;

namespace PersonalSkills_EfCodeFirstProject.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin

        SkillsContext skillsContext = new SkillsContext();
        public ActionResult Index()
        {
            var skills = skillsContext.Skills.ToList();

            return View(skills);
        }

        [HttpGet]
        public ActionResult AddSkill()
        {

            return View();
        }

        [HttpPost]
        public ActionResult AddSkill(Skill skill)
        {
            skillsContext.Skills.Add(skill);
            skillsContext.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}