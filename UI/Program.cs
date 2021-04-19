using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxWMPLib;

namespace UI
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        ///
        public static Ad ad;
        public static AdLogin adLogin;
        public static HeroSelect heroSelect;
        public static Menu menu;
        public static MapSelect mapSelect;
        public static HeroInfo heroInfo;
        public static StrategyShow strategyShow;
        public static AxWindowsMediaPlayer menuWMP;
        public static AxWindowsMediaPlayer mapSelectWMP;
        public static AxWindowsMediaPlayer heroSelectWMP;
        public static AxWindowsMediaPlayer heroInfoWMp;
        public static Label lbSkillName;
        public static Label lbSkillDescribe;
        public static Label lbMapName;
        public static HeroAdd heroAdd;
        public static HeroDel heroDel;
        public static MapAdd mapAdd;
        public static MapDel mapDel;
        public static StrategyAdd strategyAdd;
        public static StrategyDel strategyDel;
        public static SkillAdd skillAdd;
        public static SkillDel skillDel;
        public static DataGridView dgvStrategy;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Program.menu = new Menu();
            Application.Run(Program.menu);
        }
        public static  void ShutDown(Form f) 
        {
            f.Close();
        }
        public static void Appear(Form f) 
        {
            f.Show();
        }
        public static void Disappear(Form f)
        {
            f.Hide();
        }
        public static void Mute(AxWindowsMediaPlayer wmp) 
        {
            wmp.settings.mute = true;//播放器静音
        }
        public static void Voice(AxWindowsMediaPlayer wmp)
        {
            wmp.settings.mute = false;//播放器静音
        }
    }
}
