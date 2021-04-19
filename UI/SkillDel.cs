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
    public partial class SkillDel : Form
    {
        public SkillDel()
        {
            InitializeComponent();
        }

        private void btReturn_Click(object sender, EventArgs e)
        {
            Program.Appear(Program.ad);
            Program.ShutDown(Program.skillDel);
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            if (Function.delSkillData(tbSkillName.Text))
            {
                MessageBox.Show("删除成功");
                tbSkillName.Text = "";
            }
            else 
            {
                MessageBox.Show("删除失败");
            }
        }
    }
}
