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
using System.Threading;

namespace UI
{
    public partial class HeroSelect : Form
    {
        public HeroSelect()
        {
            InitializeComponent();
            Program.heroSelectWMP = WindowsMediaPlayer;
            WindowsMediaPlayer.URL = "Resources\\bgm\\hero.mp3";
            WindowsMediaPlayer.settings.autoStart = true; //设置自动播放
            WindowsMediaPlayer.settings.setMode("loop", true);//设置循环播放
        }
        private void btReturn_Click(object sender, EventArgs e)
        {
            Program.Disappear(Program.heroSelect);
            Program.Appear(Program.menu);
            Program.Mute(Program.heroSelectWMP);
            Program.Voice(Program.menuWMP);
        }
        private void HeroSelect_Load(object sender, EventArgs e)
        {
            showHero("重装");
            showHero("输出");
            showHero("支援");
        }
        public void showHero(string heroType)
        {
            DataSet ds = new DataSet();
            ds=Function.getHeroNumbers(heroType);
            int y = 0;
            switch (heroType)
            {
                case ("重装"):
                    {
                        y = 118;
                        break;
                    }
                case ("输出"):
                    {
                        y = 347;
                        break;
                    }
                case ("支援"):
                    {
                        y = 571;
                        break;
                    }
            }
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                int x = 580;
                Button button = new Button();
                x = x + ((i + 1) / 2) * 76 * Convert.ToInt32(Math.Pow(-1, i - 1));
                button.Location = new Point(x, y);
                button.Size = new Size(70, 95);
                button.BackColor = Color.Transparent;
                button.FlatStyle = FlatStyle.Flat;
                button.Name = "_"+ds.Tables[0].Rows[i][0];
                string path = string.Format("Resources\\HeroPortraitPic\\{0}.png", button.Name.Remove(0,1));
                button.Image = Image.FromFile(path);
                Program.heroSelect.Controls.Add(button);
                button.Click += delegate { showHeroInfo(button.Name.Remove(0, 1)); };
            }
        }
        public void showHeroInfo(string heroNumber)
        {
            Program.heroInfo = new HeroInfo();
            string path = string.Format("Resources\\HeroVideo\\{0}.mp4", heroNumber);
            Program.heroInfoWMp.URL = path;
            Program.lbSkillName.Text = Function.getHeroName(heroNumber);
            Program.Appear(Program.heroInfo);
            Program.Disappear(Program.heroSelect);
            DataSet ds = new DataSet();
            ds = Function.getSkillNumbers(heroNumber);
            int x = 27, y = 12;
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                Button button = new Button();
                y = y + 80;
                button.Location = new Point(x, y);
                button.Size = new Size(70,70);
                button.BackColor = Color.Transparent;
                button.FlatStyle = FlatStyle.Flat;
                button.Name = "_"+ds.Tables[0].Rows[i][0];
                button.BackgroundImage = Image.FromFile(string.Format("Resources\\SkillPic\\{0}.png", button.Name.Remove(0, 1)));
                button.BackgroundImageLayout= ImageLayout.Stretch;
                Program.heroInfo.Controls.Add(button);
                button.Click += delegate { showHeroSkillBV(button.Name.Remove(0, 1)); };
            }
            Button bt = new Button();
            bt.Location = new Point(27, 672);
            bt.Size = new Size(70, 70);
            bt.BackColor = Color.Transparent;
            bt.FlatStyle = FlatStyle.Flat;
            bt.Name = "_" + heroNumber;
            bt.BackgroundImageLayout = ImageLayout.Stretch;
            bt.BackgroundImage = Image.FromFile(string.Format("Resources\\HeroPic\\{0}.png", bt.Name.Remove(0, 1)));
            bt.Click += delegate { showHeroBV(bt.Name.Remove(0, 1)); };
            Program.heroInfo.Controls.Add(bt);
        }
        public void showHeroSkillBV(string skillNumber) 
        {
            string path = string.Format("Resources\\SkillVideo\\{0}.mp4",skillNumber);
            Program.heroInfoWMp.URL = path;
            Program.lbSkillDescribe.Text= Function.getSkillDescribe(skillNumber);
            Program.lbSkillName.Text = Function.getSkillName(skillNumber);
        }
        public void showHeroBV(string heroNumber) 
        {
            string path = string.Format("Resources\\HeroVideo\\{0}.mp4", heroNumber);
            Program.heroInfoWMp.URL = path;
            Program.lbSkillDescribe.Text = "";
            Program.lbSkillName.Text = Function.getHeroName(heroNumber);
        }
    }
}
