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
    public partial class MapAdd : Form
    {
        public MapAdd()
        {
            InitializeComponent();
        }

        private void btReturn_Click(object sender, EventArgs e)
        {
            Program.ShutDown(Program.mapAdd);
            Program.Appear(Program.ad);
        }

        private void btConfirm_Click(object sender, EventArgs e)
        {
            Map m = new Map();
            m.MapNumber = tbMapNumber.Text;
            m.MapName = tbMapName.Text;
            m.MapType = tbMapType.Text;
            if (Function.addMapData(m))
            {
                MessageBox.Show("添加成功");
                tbMapNumber.Text = "";
                tbMapName.Text = "";
                tbMapType.Text = "";
            }
            else 
            {
                MessageBox.Show("添加失败");
            }
        }
    }
}
