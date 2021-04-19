using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace UI
{
    public partial class HeroDel : Form
    {
        public HeroDel()
        {
            InitializeComponent();
        }

        private void btReturn_Click(object sender, EventArgs e)
        {
            Program.ShutDown(Program.heroDel);
            Program.Appear(Program.ad);
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            if (Function.delHeroData(tbHeroName.Text))
            {
                MessageBox.Show("删除成功");
                tbHeroName.Text = "";
            }
            else
            {
                MessageBox.Show("删除失败");
            }
        }
    }
}
