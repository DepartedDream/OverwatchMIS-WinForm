namespace UI
{
    partial class HeroDel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeroDel));
            this.btReturn = new System.Windows.Forms.Button();
            this.help = new System.Windows.Forms.Label();
            this.btConfirm = new System.Windows.Forms.Button();
            this.lbHeroName = new System.Windows.Forms.Label();
            this.tbHeroName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
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
            this.btReturn.TabIndex = 35;
            this.btReturn.UseVisualStyleBackColor = false;
            this.btReturn.Click += new System.EventHandler(this.btReturn_Click);
            // 
            // help
            // 
            this.help.AutoSize = true;
            this.help.BackColor = System.Drawing.Color.Transparent;
            this.help.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.help.Location = new System.Drawing.Point(355, 40);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(611, 38);
            this.help.TabIndex = 36;
            this.help.Text = "注意,删除英雄后,该英雄对应的技能也将被删除";
            // 
            // btConfirm
            // 
            this.btConfirm.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btConfirm.Location = new System.Drawing.Point(548, 474);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(98, 43);
            this.btConfirm.TabIndex = 51;
            this.btConfirm.Text = "删除";
            this.btConfirm.UseVisualStyleBackColor = true;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // lbHeroName
            // 
            this.lbHeroName.AutoSize = true;
            this.lbHeroName.BackColor = System.Drawing.Color.Transparent;
            this.lbHeroName.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbHeroName.Location = new System.Drawing.Point(355, 345);
            this.lbHeroName.Name = "lbHeroName";
            this.lbHeroName.Size = new System.Drawing.Size(133, 38);
            this.lbHeroName.TabIndex = 49;
            this.lbHeroName.Text = "英雄名称";
            // 
            // tbHeroName
            // 
            this.tbHeroName.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbHeroName.Location = new System.Drawing.Point(511, 337);
            this.tbHeroName.Name = "tbHeroName";
            this.tbHeroName.Size = new System.Drawing.Size(404, 46);
            this.tbHeroName.TabIndex = 46;
            // 
            // HeroDel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UI.Properties.Resources.SelectHero;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 762);
            this.ControlBox = false;
            this.Controls.Add(this.btConfirm);
            this.Controls.Add(this.lbHeroName);
            this.Controls.Add(this.tbHeroName);
            this.Controls.Add(this.help);
            this.Controls.Add(this.btReturn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HeroDel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "删除英雄";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btReturn;
        private System.Windows.Forms.Label help;
        private System.Windows.Forms.Button btConfirm;
        private System.Windows.Forms.Label lbHeroName;
        private System.Windows.Forms.TextBox tbHeroName;
    }
}