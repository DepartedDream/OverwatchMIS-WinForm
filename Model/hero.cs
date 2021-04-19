using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Hero
    {
        private string heroId;
        private string heroName;
        private string heroType;

        public string HeroId { get => heroId; set => heroId = value; }
        public string HeroName { get => heroName; set => heroName = value; }
        public string HeroType { get => heroType; set => heroType = value; }
    }
}
