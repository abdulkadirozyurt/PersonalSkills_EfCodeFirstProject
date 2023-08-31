using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PersonalSkills_EfCodeFirstProject.Models.Entities
{
    public class Skill
    {
        [Key]
        public int  Id { get; set; }
        public string Description { get; set; }
        public int Value { get; set; }
    }
}