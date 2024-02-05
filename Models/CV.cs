using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CvWebApp.Models
{
    public class CV 
    {
        public int? Id {get; set;}
        public string Name {get; set;}
        public string Email {get; set;}
        public string Address {get; set;}
        public string WorkExperience {get; set;}
        public string Skill1 {get; set;}
        public string Skill2 {get; set;}
        public string Skill3 {get; set;}


    }
}