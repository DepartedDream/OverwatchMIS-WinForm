namespace UI
{
    partial class Ad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ad));
            this.btReturn = new System.Windows.Forms.Button();
            this.btAddHero = new System.Windows.Forms.Button();
            this.btDelHero = new System.Windows.Forms.Button();
            this.btAddMap = new System.Windows.Forms.Button();
            this.btDelMap = new System.Windows.Forms.Button();
            this.btAddStrategy = new System.Windows.Forms.Button();
            this.btDelStrategy = new System.Windows.Forms.Button();
            this.btAddSkill = new System.Windows.Forms.Button();
            this.btDelSkill = new System.Windows.Forms.Button();
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
            this.btReturn.TabIndex = 7;
            this.btReturn.UseVisualStyleBackColor = false;
            this.btReturn.Click += new System.EventHandler(this.btReturn_Click);
            // 
            // btAddHero
            // 
            this.btAddHero.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAddHero.Location = new System.Drawing.Point(310, 147);
            this.btAddHero.Name = "btAddHero";
            this.btAddHero.Size = new System.Drawing.Size(264, 94);
            this.btAddHero.TabIndex = 8;
            this.btAddHero.Text = "添加英雄";
            this.btAddHero.UseVisualStyleBackColor = true;
            this.btAddHero.Click += new System.EventHandler(this.btAddHero_Click);
            // 
            // btDelHero
            // 
            this.btDelHero.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btDelHero.Location = new System.Drawing.Point(665, 147);
            this.btDelHero.Name = "btDelHero";
            this.btDelHero.Size = new System.Drawing.Size(264, 94);
            this.btDelHero.TabIndex = 9;
            this.btDelHero.Text = "删除英雄";
            this.btDelHero.UseVisualStyleBackColor = true;
            this.btDelHero.Click += new System.EventHandler(this.btDelHero_Click);
            // 
            // btAddMap
            // 
            this.btAddMap.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAddMap.Location = new System.Drawing.Point(310, 423);
            this.btAddMap.Name = "btAddMap";
            this.btAddMap.Size = new System.Drawing.Size(264, 94);
            this.btAddMap.TabIndex = 10;
            this.btAddMap.Text = "添加地图";
            this.btAddMap.UseVisualStyleBackColor = true;
            this.btAddMap.Click += new System.EventHandler(this.btAddMap_Click);
            // 
            // btDelMap
            // 
            this.btDelMap.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btDelMap.Location = new System.Drawing.Point(665, 423);
            this.btDelMap.Name = "btDelMap";
            this.btDelMap.Size = new System.Drawing.Size(264, 94);
            this.btDelMap.TabIndex = 11;
            this.btDelMap.Text = "删除地图";
            this.btDelMap.UseVisualStyleBackColor = true;
            this.btDelMap.Click += new System.EventHandler(this.btDelMap_Click);
            // 
            // btAddStrategy
            // 
            this.btAddStrategy.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAddStrategy.Location = new System.Drawing.Point(310, 558);
            this.btAddStrategy.Name = "btAddStrategy";
            this.btAddStrategy.Size = new System.Drawing.Size(264, 94);
            this.btAddStrategy.TabIndex = 12;
            this.btAddStrategy.Text = "添加策略";
            this.btAddStrategy.UseVisualStyleBackColor = true;
            this.btAddStrategy.Click += new System.EventHandler(this.btAddStrategy_Click);
            // 
            // btDelStrategy
            // 
            this.btDelStrategy.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btDelStrategy.Location = new System.Drawing.Point(665, 558);
            this.btDelStrategy.Name = "btDelStrategy";
            this.btDelStrategy.Size = new System.Drawing.Size(264, 94);
            this.btDelStrategy.TabIndex = 13;
            this.btDelStrategy.Text = "删除策略";
            this.btDelStrategy.UseVisualStyleBackColor = true;
            this.btDelStrategy.Click += new System.EventHandler(this.btDelStrategy_Click);
            // 
            // btAddSkill
            // 
            this.btAddSkill.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btAddSkill.Location = new System.Drawing.Point(310, 285);
            this.btAddSkill.Name = "btAddSkill";
            this.btAddSkill.Size = new System.Drawing.Size(264, 94);
            this.btAddSkill.TabIndex = 14;
            this.btAddSkill.Text = "添加技能";
            this.btAddSkill.UseVisualStyleBackColor = true;
            this.btAddSkill.Click += new System.EventHandler(this.btAddSkill_Click);
            // 
            // btDelSkill
            // 
            this.btDelSkill.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btDelSkill.Location = new System.Drawing.Point(665, 285);
            this.btDelSkill.Name = "btDelSkill";
            this.btDelSkill.Size = new System.Drawing.Size(264, 94);
            this.btDelSkill.TabIndex = 15;
            this.btDelSkill.Text = "删除技能";
            this.btDelSkill.UseVisualStyleBackColor = true;
            this.btDelSkill.Click += new System.EventHandler(this.btDelSkill_Click);
            // 
            // Ad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UI.Properties.Resources.SelectHero;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 762);
            this.ControlBox = false;
            this.Controls.Add(this.btAddSkill);
            this.Controls.Add(this.btDelSkill);
            this.Controls.Add(this.btDelStrategy);
            this.Controls.Add(this.btAddStrategy);
            this.Controls.Add(this.btDelMap);
            this.Controls.Add(this.btAddMap);
            this.Controls.Add(this.btDelHero);
            this.Controls.Add(this.btAddHero);
            this.Controls.Add(this.btReturn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "管理员界面";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btReturn;
        private System.Windows.Forms.Button btAddHero;
        private System.Windows.Forms.Button btDelHero;
        private System.Windows.Forms.Button btAddMap;
        private System.Windows.Forms.Button btDelMap;
        private System.Windows.Forms.Button btAddStrategy;
        private System.Windows.Forms.Button btDelStrategy;
        private System.Windows.Forms.Button btAddSkill;
        private System.Windows.Forms.Button btDelSkill;
    }
}