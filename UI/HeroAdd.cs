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
    public partial class HeroAdd : Form
    {
        public HeroAdd()
        {
            InitializeComponent();
        }

        private void btReturn_Click(object sender, EventArgs e)
        {
            Program.ShutDown(Program.heroAdd);
            Program.Appear(Program.ad);
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            Hero h = new Hero();
            h.HeroNumber = tbHeroNumber.Text;
            h.HeroName = tbHeroName.Text;
            h.HeroType=tbHeroType.Text;
            if (Function.addHeroData(h))
            {
                MessageBox.Show("添加成功");
                tbHeroNumber.Text = "";
                tbHeroName.Text = "";
                tbHeroType.Text = "";
            }
            else 
            {
                MessageBox.Show("添加失败");
            }
        }
    }
}
