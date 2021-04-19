namespace UI
{
    partial class HeroAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HeroAdd));
            this.btReturn = new System.Windows.Forms.Button();
            this.tbHeroNumber = new System.Windows.Forms.TextBox();
            this.tbHeroName = new System.Windows.Forms.TextBox();
            this.tbHeroType = new System.Windows.Forms.TextBox();
            this.lbHeroNumber = new System.Windows.Forms.Label();
            this.lbHeroName = new System.Windows.Forms.Label();
            this.lbHeroType = new System.Windows.Forms.Label();
            this.btConfirm = new System.Windows.Forms.Button();
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
            // tbHeroNumber
            // 
            this.tbHeroNumber.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbHeroNumber.Location = new System.Drawing.Point(512, 265);
            this.tbHeroNumber.Name = "tbHeroNumber";
            this.tbHeroNumber.Size = new System.Drawing.Size(404, 46);
            this.tbHeroNumber.TabIndex = 36;
            // 
            // tbHeroName
            // 
            this.tbHeroName.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbHeroName.Location = new System.Drawing.Point(512, 326);
            this.tbHeroName.Name = "tbHeroName";
            this.tbHeroName.Size = new System.Drawing.Size(404, 46);
            this.tbHeroName.TabIndex = 37;
            // 
            // tbHeroType
            // 
            this.tbHeroType.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbHeroType.Location = new System.Drawing.Point(512, 397);
            this.tbHeroType.Name = "tbHeroType";
            this.tbHeroType.Size = new System.Drawing.Size(404, 46);
            this.tbHeroType.TabIndex = 39;
            // 
            // lbHeroNumber
            // 
            this.lbHeroNumber.AutoSize = true;
            this.lbHeroNumber.BackColor = System.Drawing.Color.Transparent;
            this.lbHeroNumber.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbHeroNumber.Location = new System.Drawing.Point(356, 265);
            this.lbHeroNumber.Name = "lbHeroNumber";
            this.lbHeroNumber.Size = new System.Drawing.Size(133, 38);
            this.lbHeroNumber.TabIndex = 40;
            this.lbHeroNumber.Text = "英雄编号";
            // 
            // lbHeroName
            // 
            this.lbHeroName.AutoSize = true;
            this.lbHeroName.BackColor = System.Drawing.Color.Transparent;
            this.lbHeroName.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbHeroName.Location = new System.Drawing.Point(356, 334);
            this.lbHeroName.Name = "lbHeroName";
            this.lbHeroName.Size = new System.Drawing.Size(133, 38);
            this.lbHeroName.TabIndex = 41;
            this.lbHeroName.Text = "英雄名称";
            // 
            // lbHeroType
            // 
            this.lbHeroType.AutoSize = true;
            this.lbHeroType.BackColor = System.Drawing.Color.Transparent;
            this.lbHeroType.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbHeroType.Location = new System.Drawing.Point(356, 397);
            this.lbHeroType.Name = "lbHeroType";
            this.lbHeroType.Size = new System.Drawing.Size(133, 38);
            this.lbHeroType.TabIndex = 43;
            this.lbHeroType.Text = "英雄类型";
            // 
            // btConfirm
            // 
            this.btConfirm.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btConfirm.Location = new System.Drawing.Point(552, 496);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(98, 43);
            this.btConfirm.TabIndex = 44;
            this.btConfirm.Text = "添加";
            this.btConfirm.UseVisualStyleBackColor = true;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // HeroAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UI.Properties.Resources.SelectHero;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 762);
            this.ControlBox = false;
            this.Controls.Add(this.btConfirm);
            this.Controls.Add(this.lbHeroType);
            this.Controls.Add(this.lbHeroName);
            this.Controls.Add(this.lbHeroNumber);
            this.Controls.Add(this.tbHeroType);
            this.Controls.Add(this.tbHeroName);
            this.Controls.Add(this.tbHeroNumber);
            this.Controls.Add(this.btReturn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HeroAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加英雄";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btReturn;
        private System.Windows.Forms.TextBox tbHeroNumber;
        private System.Windows.Forms.TextBox tbHeroName;
        private System.Windows.Forms.TextBox tbHeroType;
        private System.Windows.Forms.Label lbHeroNumber;
        private System.Windows.Forms.Label lbHeroName;
        private System.Windows.Forms.Label lbHeroType;
        private System.Windows.Forms.Button btConfirm;
    }
}