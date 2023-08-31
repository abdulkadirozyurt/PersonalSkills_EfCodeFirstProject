using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        public ActionResult DeleteSkill(int id)
        {
            var skill = skillsContext.Skills.Find(id);
            skillsContext.Skills.Remove(skill);
            skillsContext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateSkill(int id)
        {
            var skill = skillsContext.Skills.Find(id);

            return View(skill);
        }

        [HttpPost]
        public ActionResult UpdateSkill(Skill s)
        {
            var skill = skillsContext.Skills.Find(s.Id);
            skill.Description = s.Description;
            skill.Value = s.Value;
            skillsContext.SaveChanges();

            return RedirectToAction("Index");
        }



    }
}