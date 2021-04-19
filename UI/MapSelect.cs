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
    public partial class MapSelect : Form
    {
        public MapSelect()
        {
            Program.mapSelectWMP = WindowsMediaPlayer;
            InitializeComponent();
            showMap(plAD,"攻防作战");
            showMap(plAC,"攻击/护送");
            showMap(plO,"占领要点");
            showMap(plCa, "运载目标");
            showMap(plS,"勇夺旗帜");
            showMap(plD,"决斗先锋");
            showMap(plFD, "死斗");
            showMap(plTD, "团队死斗");
            WindowsMediaPlayer.URL = "Resources\\bgm\\map.mp3";
            WindowsMediaPlayer.settings.autoStart = true; //设置自动播放
            WindowsMediaPlayer.settings.setMode("loop", true);//设置循环播放
        }
        private void btReturn_Click(object sender, EventArgs e)
        {
            Program.ShutDown(Program.mapSelect);
            Program.Appear(Program.menu);
            Program.Voice(Program.menuWMP);
        }
        public void showMap(Panel p, string mapType)
        {
            DataSet ds = new DataSet();
            ds = Function.getMapNumbers(mapType);
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                int x = 0, y = 0;
                y = y + i * 66;
                Button button = new Button();
                button.Location = new Point(x, y);
                button.Size = new Size(120, 60);
                button.Name="_"+ ds.Tables[0].Rows[i][0];
                string path = string.Format("Resources\\MapPic\\{0}.jpg", Convert.ToString(ds.Tables[0].Rows[i][0]));
                button.BackgroundImage = Image.FromFile(path);
                button.BackgroundImageLayout = ImageLayout.Stretch;
                button.Click += delegate { showStrategy(button.Name.Remove(0, 1)); };
                p.Controls.Add(button);
            }
        }
        public void showStrategy(string mapNumber) 
        {
            Program.strategyShow = new StrategyShow();
            Program.Disappear(Program.mapSelect);
            Program.Appear(Program.strategyShow);
            Program.lbMapName.Text = Function.getMapName(mapNumber);
            Program.dgvStrategy.DataSource=Function.getStrategy(mapNumber).Tables[0];
        }
    }
}
