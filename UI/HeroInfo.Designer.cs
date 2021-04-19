namespace UI
{
    partial class HeroInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeroInfo));
            this.WindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.lbSkillDescribe = new System.Windows.Forms.Label();
            this.lbSkillName = new System.Windows.Forms.Label();
            this.btReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // WindowsMediaPlayer
            // 
            this.WindowsMediaPlayer.Enabled = true;
            this.WindowsMediaPlayer.Location = new System.Drawing.Point(151, 55);
            this.WindowsMediaPlayer.Name = "WindowsMediaPlayer";
            this.WindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WindowsMediaPlayer.OcxState")));
            this.WindowsMediaPlayer.Size = new System.Drawing.Size(1103, 615);
            this.WindowsMediaPlayer.TabIndex = 0;
            // 
            // lbSkillDescribe
            // 
            this.lbSkillDescribe.AutoSize = true;
            this.lbSkillDescribe.BackColor = System.Drawing.Color.Transparent;
            this.lbSkillDescribe.Font = new System.Drawing.Font("微软雅黑", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbSkillDescribe.ForeColor = System.Drawing.Color.Black;
            this.lbSkillDescribe.Location = new System.Drawing.Point(159, 683);
            this.lbSkillDescribe.MaximumSize = new System.Drawing.Size(1120, 0);
            this.lbSkillDescribe.Name = "lbSkillDescribe";
            this.lbSkillDescribe.Size = new System.Drawing.Size(0, 35);
            this.lbSkillDescribe.TabIndex = 6;
            // 
            // lbSkillName
            // 
            this.lbSkillName.AutoSize = true;
            this.lbSkillName.BackColor = System.Drawing.Color.Transparent;
            this.lbSkillName.Font = new System.Drawing.Font("微软雅黑", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbSkillName.ForeColor = System.Drawing.Color.Black;
            this.lbSkillName.Location = new System.Drawing.Point(657, 9);
            this.lbSkillName.MaximumSize = new System.Drawing.Size(1120, 0);
            this.lbSkillName.Name = "lbSkillName";
            this.lbSkillName.Size = new System.Drawing.Size(0, 35);
            this.lbSkillName.TabIndex = 7;
            // 
            // btReturn
            // 
            this.btReturn.BackColor = System.Drawing.Color.Transparent;
            this.btReturn.BackgroundImage = global::UI.Properties.Resources._return;
            this.btReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btReturn.Location = new System.Drawing.Point(12, 12);
            this.btReturn.Name = "btReturn";
            this.btReturn.Size = new System.Drawing.Size(70, 70);
            this.btReturn.TabIndex = 33;
            this.btReturn.UseVisualStyleBackColor = false;
            this.btReturn.Click += new System.EventHandler(this.btReturn_Click);
            // 
            // HeroInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UI.Properties.Resources.SelectHero;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 762);
            this.ControlBox = false;
            this.Controls.Add(this.btReturn);
            this.Controls.Add(this.lbSkillName);
            this.Controls.Add(this.lbSkillDescribe);
            this.Controls.Add(this.WindowsMediaPlayer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HeroInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "英雄信息";
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer WindowsMediaPlayer;
        private System.Windows.Forms.Label lbSkillDescribe;
        private System.Windows.Forms.Label lbSkillName;
        private System.Windows.Forms.Button btReturn;
    }
}