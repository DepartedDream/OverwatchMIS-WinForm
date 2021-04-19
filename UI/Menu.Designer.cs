namespace UI
{
    partial class Menu
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.WindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.buAdLogin = new System.Windows.Forms.Button();
            this.MapButton = new System.Windows.Forms.Button();
            this.HeroButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // WindowsMediaPlayer
            // 
            this.WindowsMediaPlayer.Enabled = true;
            this.WindowsMediaPlayer.Location = new System.Drawing.Point(-1, 1);
            this.WindowsMediaPlayer.Name = "WindowsMediaPlayer";
            this.WindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WindowsMediaPlayer.OcxState")));
            this.WindowsMediaPlayer.Size = new System.Drawing.Size(1264, 758);
            this.WindowsMediaPlayer.TabIndex = 0;
            // 
            // buAdLogin
            // 
            this.buAdLogin.BackColor = System.Drawing.Color.Black;
            this.buAdLogin.FlatAppearance.BorderSize = 0;
            this.buAdLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buAdLogin.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buAdLogin.ForeColor = System.Drawing.Color.Black;
            this.buAdLogin.Location = new System.Drawing.Point(1189, 12);
            this.buAdLogin.Name = "buAdLogin";
            this.buAdLogin.Size = new System.Drawing.Size(63, 63);
            this.buAdLogin.TabIndex = 8;
            this.buAdLogin.Text = "管理员登录";
            this.buAdLogin.UseVisualStyleBackColor = false;
            this.buAdLogin.Click += new System.EventHandler(this.buAdLogin_Click);
            // 
            // MapButton
            // 
            this.MapButton.BackColor = System.Drawing.Color.Black;
            this.MapButton.BackgroundImage = global::UI.Properties.Resources.Map;
            this.MapButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MapButton.FlatAppearance.BorderSize = 0;
            this.MapButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MapButton.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MapButton.ForeColor = System.Drawing.Color.Gold;
            this.MapButton.Location = new System.Drawing.Point(738, 687);
            this.MapButton.Name = "MapButton";
            this.MapButton.Size = new System.Drawing.Size(150, 50);
            this.MapButton.TabIndex = 5;
            this.MapButton.UseVisualStyleBackColor = false;
            this.MapButton.Click += new System.EventHandler(this.MapButton_Click);
            // 
            // HeroButton
            // 
            this.HeroButton.BackColor = System.Drawing.Color.Black;
            this.HeroButton.BackgroundImage = global::UI.Properties.Resources.Hero;
            this.HeroButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.HeroButton.FlatAppearance.BorderSize = 0;
            this.HeroButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HeroButton.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.HeroButton.ForeColor = System.Drawing.Color.Gold;
            this.HeroButton.Location = new System.Drawing.Point(342, 687);
            this.HeroButton.Name = "HeroButton";
            this.HeroButton.Size = new System.Drawing.Size(150, 50);
            this.HeroButton.TabIndex = 7;
            this.HeroButton.UseVisualStyleBackColor = false;
            this.HeroButton.Click += new System.EventHandler(this.HeroButton_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1264, 762);
            this.Controls.Add(this.buAdLogin);
            this.Controls.Add(this.MapButton);
            this.Controls.Add(this.HeroButton);
            this.Controls.Add(this.WindowsMediaPlayer);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "守望先锋游戏数据管理系统";
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer WindowsMediaPlayer;
        private System.Windows.Forms.Button MapButton;
        private System.Windows.Forms.Button HeroButton;
        private System.Windows.Forms.Button buAdLogin;
    }
}

