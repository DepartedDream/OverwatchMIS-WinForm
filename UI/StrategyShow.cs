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
    public partial class StrategyShow : Form
    {
        public StrategyShow()
        {
            InitializeComponent();
            Program.dgvStrategy = dgvStrategy;
            Program.lbMapName = lbMapName;
        }

        private void btReturn_Click(object sender, EventArgs e)
        {
            Program.ShutDown(Program.strategyShow);
            Program.Appear(Program.mapSelect);
        }
    }
}
