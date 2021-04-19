namespace UI
{
    partial class SkillAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SkillAdd));
            this.btReturn = new System.Windows.Forms.Button();
            this.help = new System.Windows.Forms.Label();
            this.btConfirm = new System.Windows.Forms.Button();
            this.lbSkillDescribe = new System.Windows.Forms.Label();
            this.lbSkillName = new System.Windows.Forms.Label();
            this.lbSkillNumber = new System.Windows.Forms.Label();
            this.tbSkillDescribe = new System.Windows.Forms.TextBox();
            this.tbSkillName = new System.Windows.Forms.TextBox();
            this.tbSkillNumber = new System.Windows.Forms.TextBox();
            this.lbHeroNumber = new System.Windows.Forms.Label();
            this.tbHeroNumber = new System.Windows.Forms.TextBox();
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
            this.btReturn.TabIndex = 34;
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
            this.help.Size = new System.Drawing.Size(468, 38);
            this.help.TabIndex = 35;
            this.help.Text = " 请在添加对应的英雄后,执行此功能";
            // 
            // btConfirm
            // 
            this.btConfirm.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btConfirm.Location = new System.Drawing.Point(505, 518);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(98, 43);
            this.btConfirm.TabIndex = 58;
            this.btConfirm.Text = "添加";
            this.btConfirm.UseVisualStyleBackColor = true;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // lbSkillDescribe
            // 
            this.lbSkillDescribe.AutoSize = true;
            this.lbSkillDescribe.BackColor = System.Drawing.Color.Transparent;
            this.lbSkillDescribe.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbSkillDescribe.Location = new System.Drawing.Point(323, 381);
            this.lbSkillDescribe.Name = "lbSkillDescribe";
            this.lbSkillDescribe.Size = new System.Drawing.Size(133, 38);
            this.lbSkillDescribe.TabIndex = 57;
            this.lbSkillDescribe.Text = "技能描述";
            // 
            // lbSkillName
            // 
            this.lbSkillName.AutoSize = true;
            this.lbSkillName.BackColor = System.Drawing.Color.Transparent;
            this.lbSkillName.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbSkillName.Location = new System.Drawing.Point(323, 318);
            this.lbSkillName.Name = "lbSkillName";
            this.lbSkillName.Size = new System.Drawing.Size(133, 38);
            this.lbSkillName.TabIndex = 56;
            this.lbSkillName.Text = "技能名称";
            // 
            // lbSkillNumber
            // 
            this.lbSkillNumber.AutoSize = true;
            this.lbSkillNumber.BackColor = System.Drawing.Color.Transparent;
            this.lbSkillNumber.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbSkillNumber.Location = new System.Drawing.Point(323, 249);
            this.lbSkillNumber.Name = "lbSkillNumber";
            this.lbSkillNumber.Size = new System.Drawing.Size(133, 38);
            this.lbSkillNumber.TabIndex = 55;
            this.lbSkillNumber.Text = "技能编号";
            // 
            // tbSkillDescribe
            // 
            this.tbSkillDescribe.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbSkillDescribe.Location = new System.Drawing.Point(479, 381);
            this.tbSkillDescribe.Name = "tbSkillDescribe";
            this.tbSkillDescribe.Size = new System.Drawing.Size(404, 46);
            this.tbSkillDescribe.TabIndex = 54;
            // 
            // tbSkillName
            // 
            this.tbSkillName.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbSkillName.Location = new System.Drawing.Point(479, 310);
            this.tbSkillName.Name = "tbSkillName";
            this.tbSkillName.Size = new System.Drawing.Size(404, 46);
            this.tbSkillName.TabIndex = 53;
            // 
            // tbSkillNumber
            // 
            this.tbSkillNumber.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbSkillNumber.Location = new System.Drawing.Point(479, 249);
            this.tbSkillNumber.Name = "tbSkillNumber";
            this.tbSkillNumber.Size = new System.Drawing.Size(404, 46);
            this.tbSkillNumber.TabIndex = 52;
            // 
            // lbHeroNumber
            // 
            this.lbHeroNumber.AutoSize = true;
            this.lbHeroNumber.BackColor = System.Drawing.Color.Transparent;
            this.lbHeroNumber.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbHeroNumber.Location = new System.Drawing.Point(323, 448);
            this.lbHeroNumber.Name = "lbHeroNumber";
            this.lbHeroNumber.Size = new System.Drawing.Size(133, 38);
            this.lbHeroNumber.TabIndex = 60;
            this.lbHeroNumber.Text = "英雄编号";
            // 
            // tbHeroNumber
            // 
            this.tbHeroNumber.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbHeroNumber.Location = new System.Drawing.Point(479, 448);
            this.tbHeroNumber.Name = "tbHeroNumber";
            this.tbHeroNumber.Size = new System.Drawing.Size(404, 46);
            this.tbHeroNumber.TabIndex = 59;
            // 
            // SkillAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UI.Properties.Resources.SelectHero;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 762);
            this.ControlBox = false;
            this.Controls.Add(this.lbHeroNumber);
            this.Controls.Add(this.tbHeroNumber);
            this.Controls.Add(this.btConfirm);
            this.Controls.Add(this.lbSkillDescribe);
            this.Controls.Add(this.lbSkillName);
            this.Controls.Add(this.lbSkillNumber);
            this.Controls.Add(this.tbSkillDescribe);
            this.Controls.Add(this.tbSkillName);
            this.Controls.Add(this.tbSkillNumber);
            this.Controls.Add(this.help);
            this.Controls.Add(this.btReturn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SkillAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加技能";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btReturn;
        private System.Windows.Forms.Label help;
        private System.Windows.Forms.Button btConfirm;
        private System.Windows.Forms.Label lbSkillDescribe;
        private System.Windows.Forms.Label lbSkillName;
        private System.Windows.Forms.Label lbSkillNumber;
        private System.Windows.Forms.TextBox tbSkillDescribe;
        private System.Windows.Forms.TextBox tbSkillName;
        private System.Windows.Forms.TextBox tbSkillNumber;
        private System.Windows.Forms.Label lbHeroNumber;
        private System.Windows.Forms.TextBox tbHeroNumber;
    }
}