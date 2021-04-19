using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Ad : Form
    {
        public Ad()
        {
            InitializeComponent();
        }
        private void btReturn_Click(object sender, EventArgs e)
        {
            Program.ShutDown(Program.ad);
            Program.Appear(Program.menu);
            Program.Voice(Program.menuWMP);
        }

        private void btAddHero_Click(object sender, EventArgs e)
        {
            Program.heroAdd = new HeroAdd();
            Program.Disappear(Program.ad);
            Program.Appear(Program.heroAdd);
        }

        private void btDelHero_Click(object sender, EventArgs e)
        {
            Program.heroDel = new HeroDel();
            Program.Disappear(Program.ad);
            Program.Appear(Program.heroDel);
        }

        private void btAddMap_Click(object sender, EventArgs e)
        {
            Program.mapAdd = new MapAdd();
            Program.Disappear(Program.ad);
            Program.Appear(Program.mapAdd);
        }

        private void btDelMap_Click(object sender, EventArgs e)
        {
            Program.mapDel = new MapDel();
            Program.Disappear(Program.ad);
            Program.Appear(Program.mapDel);
        }

        private void btAddStrategy_Click(object sender, EventArgs e)
        {
            Program.strategyAdd = new StrategyAdd();
            Program.Disappear(Program.ad);
            Program.Appear(Program.strategyAdd);
        }

        private void btDelStrategy_Click(object sender, EventArgs e)
        {
            Program.strategyDel = new StrategyDel();
            Program.Disappear(Program.ad);
            Program.Appear(Program.strategyDel);
        }

        private void btAddSkill_Click(object sender, EventArgs e)
        {
            Program.skillAdd = new SkillAdd();
            Program.Disappear(Program.ad);
            Program.Appear(Program.skillAdd);
        }

        private void btDelSkill_Click(object sender, EventArgs e)
        {
            Program.skillDel = new SkillDel();
            Program.Disappear(Program.ad);
            Program.Appear(Program.skillDel);
        }
    }
}
