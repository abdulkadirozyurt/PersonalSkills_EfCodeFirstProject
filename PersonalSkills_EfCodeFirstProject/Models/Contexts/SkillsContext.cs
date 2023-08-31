using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using PersonalSkills_EfCodeFirstProject.Models.Entities;

namespace PersonalSkills_EfCodeFirstProject.Models.Contexts
{
    public class SkillsContext : DbContext
    {

        public DbSet<Skill> Skills { get; set; }
    }
}