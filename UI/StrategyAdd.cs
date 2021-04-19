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
    public partial class StrategyAdd : Form
    {
        public StrategyAdd()
        {
            InitializeComponent();
        }

        private void btReturn_Click(object sender, EventArgs e)
        {
            Program.ShutDown(Program.strategyAdd);
            Program.Appear(Program.ad);
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            Strategy s = new Strategy();
            s.StrategyNumber = tbStrategyNumber.Text;
            s.MapNumber = tbMapNumber.Text;
            s.StrategyName = tbStrategyName.Text;
            s.StrategyDescribe = tbStrategyDescribe.Text;
            if (Function.addStrategyData(s))
            {
                MessageBox.Show("添加成功");
                tbStrategyNumber.Text = "";
                tbMapNumber.Text = "";
                tbStrategyName.Text = "";
                tbStrategyDescribe.Text = "";
            }
            else 
            {
                MessageBox.Show("添加失败");
            }
        }
    }
}
