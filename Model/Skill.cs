using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Skill
    {
        private string skillNumber;
        private string skillName;
        private string skillDescribe;
        private string heroNumber;

        public string SkillNumber { get => skillNumber; set => skillNumber = value; }
        public string SkillName { get => skillName; set => skillName = value; }
        public string SkillDescribe { get => skillDescribe; set => skillDescribe = value; }
        public string HeroNumber { get => heroNumber; set => heroNumber = value; }
    }
}
