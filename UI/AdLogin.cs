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
using Model;

namespace UI
{
    public partial class AdLogin : Form
    {
        public AdLogin()
        {
            InitializeComponent();
        }
        private void buLogin_Click(object sender, EventArgs e)
        {
            Admin ad = new Admin();
            ad.UserName = txPassword.Text;
            ad.Password = txUserName.Text;
            if (Function.login(ad))
            {
                this.Hide();
                Program.ad = new Ad();
                Program.Appear(Program.ad);
            }
            else
            {
                MessageBox.Show("登录失败");
            }
        }

        private void btReturn_Click(object sender, EventArgs e)
        {
            Program.ShutDown(Program.adLogin);
            Program.Appear(Program.menu);
            Program.Voice(Program.menuWMP);
        }
    }
}
