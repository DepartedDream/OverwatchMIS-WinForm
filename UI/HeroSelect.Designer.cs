namespace UI
{
    partial class HeroSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeroSelect));
            this.重装 = new System.Windows.Forms.Label();
            this.输出 = new System.Windows.Forms.Label();
            this.Support = new System.Windows.Forms.Label();
            this.btReturn = new System.Windows.Forms.Button();
            this.WindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // 重装
            // 
            this.重装.AutoSize = true;
            this.重装.BackColor = System.Drawing.Color.Transparent;
            this.重装.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.重装.Location = new System.Drawing.Point(588, 51);
            this.重装.Name = "重装";
            this.重装.Size = new System.Drawing.Size(82, 41);
            this.重装.TabIndex = 1;
            this.重装.Text = "重装";
            // 
            // 输出
            // 
            this.输出.AutoSize = true;
            this.输出.BackColor = System.Drawing.Color.Transparent;
            this.输出.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.输出.Location = new System.Drawing.Point(588, 295);
            this.输出.Name = "输出";
            this.输出.Size = new System.Drawing.Size(82, 41);
            this.输出.TabIndex = 2;
            this.输出.Text = "输出";
            // 
            // Support
            // 
            this.Support.AutoSize = true;
            this.Support.BackColor = System.Drawing.Color.Transparent;
            this.Support.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Support.Location = new System.Drawing.Point(588, 506);
            this.Support.Name = "Support";
            this.Support.Size = new System.Drawing.Size(82, 41);
            this.Support.TabIndex = 3;
            this.Support.Text = "支援";
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
            this.btReturn.TabIndex = 32;
            this.btReturn.UseVisualStyleBackColor = false;
            this.btReturn.Click += new System.EventHandler(this.btReturn_Click);
            // 
            // WindowsMediaPlayer
            // 
            this.WindowsMediaPlayer.Enabled = true;
            this.WindowsMediaPlayer.Location = new System.Drawing.Point(1183, 12);
            this.WindowsMediaPlayer.Name = "WindowsMediaPlayer";
            this.WindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WindowsMediaPlayer.OcxState")));
            this.WindowsMediaPlayer.Size = new System.Drawing.Size(55, 49);
            this.WindowsMediaPlayer.TabIndex = 33;
            this.WindowsMediaPlayer.Visible = false;
            // 
            // HeroSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UI.Properties.Resources.SelectHero;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 762);
            this.ControlBox = false;
            this.Controls.Add(this.WindowsMediaPlayer);
            this.Controls.Add(this.btReturn);
            this.Controls.Add(this.Support);
            this.Controls.Add(this.输出);
            this.Controls.Add(this.重装);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HeroSelect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选择英雄";
            this.Load += new System.EventHandler(this.HeroSelect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WindowsMediaPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label 重装;
        private System.Windows.Forms.Label 输出;
        private System.Windows.Forms.Label Support;
        private System.Windows.Forms.Button btReturn;
        private AxWMPLib.AxWindowsMediaPlayer WindowsMediaPlayer;
    }
}