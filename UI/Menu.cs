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
using System.IO;
using Model;

namespace UI
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            Program.menuWMP = WindowsMediaPlayer;
            WindowsMediaPlayer.URL = "Resources\\MainVideo.mp4";
            WindowsMediaPlayer.settings.autoStart = true; //设置自动播放
            WindowsMediaPlayer.settings.setMode("loop", true);//设置循环播放
        }
        private void HeroButton_Click(object sender, EventArgs e)
        {
            Program.heroSelect = new HeroSelect();
            Program.Mute(Program.menuWMP);
            Program.Disappear(Program.menu);
            Program.Appear(Program.heroSelect);
        }
        private void MapButton_Click(object sender, EventArgs e)
        {
            Program.mapSelect = new MapSelect();
            Program.Mute(Program.menuWMP);
            Program.Disappear(Program.menu);
            Program.Appear(Program.mapSelect);
        }
        private void buAdLogin_Click(object sender, EventArgs e)
        {
            Program.adLogin = new AdLogin();
            Program.Mute(Program.menuWMP);
            Program.Disappear(Program.menu);
            Program.Appear(Program.adLogin);
        }
    }
}
