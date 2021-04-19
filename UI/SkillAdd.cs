using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using BLL;

namespace UI
{
    public partial class SkillAdd : Form
    {
        public SkillAdd()
        {
            InitializeComponent();
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            Skill s = new Skill();
            s.SkillNumber = tbSkillNumber.Text;
            s.SkillName = tbSkillName.Text;
            s.SkillDescribe = tbSkillDescribe.Text;
            s.HeroNumber = tbHeroNumber.Text;
            if (Function.addSkillData(s))
            {
                MessageBox.Show("添加成功");
                tbSkillNumber.Text = "";
                tbSkillName.Text = "";
                tbSkillDescribe.Text = "";
                tbHeroNumber.Text = "";
            }
            else
            {
                MessageBox.Show("添加失败");
            }
        }

        private void btReturn_Click(object sender, EventArgs e)
        {
            Program.Appear(Program.ad);
            Program.ShutDown(Program.skillAdd);
        }
    }
}
