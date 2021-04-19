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
    public partial class MapDel : Form
    {
        public MapDel()
        {
            InitializeComponent();
        }

        private void btReturn_Click(object sender, EventArgs e)
        {
            Program.ShutDown(Program.mapDel);
            Program.Appear(Program.ad);
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            if (Function.delMapData(tbMapName.Text,tbMapType.Text))
            {
                MessageBox.Show("删除成功");
                tbMapName.Text = "";
                tbMapType.Text = "";
            }
            else 
            {
                MessageBox.Show("删除失败");
            }
        }
    }
}
