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

namespace UI
{
    public partial class HeroInfo : Form
    {
        public HeroInfo()
        {
            InitializeComponent();
            Program.heroInfoWMp = WindowsMediaPlayer;
            Program.lbSkillDescribe = lbSkillDescribe;
            Program.lbSkillName = lbSkillName;
            WindowsMediaPlayer.settings.autoStart = true; //设置自动播放
            WindowsMediaPlayer.settings.setMode("loop", true);//设置循环播放
        }

        private void btReturn_Click(object sender, EventArgs e)
        {
            Program.ShutDown(Program.heroInfo);
            Program.Appear(Program.heroSelect);
            Program.Voice(Program.heroSelectWMP);
        }
    }
}
