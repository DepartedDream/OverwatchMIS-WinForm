namespace UI
{
    partial class StrategyDel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StrategyDel));
            this.btReturn = new System.Windows.Forms.Button();
            this.lbStrategyName = new System.Windows.Forms.Label();
            this.tbStrategyName = new System.Windows.Forms.TextBox();
            this.btConfirm = new System.Windows.Forms.Button();
            this.lbMapName = new System.Windows.Forms.Label();
            this.tbMapName = new System.Windows.Forms.TextBox();
            this.lbMapType = new System.Windows.Forms.Label();
            this.tbMapType = new System.Windows.Forms.TextBox();
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
            // lbStrategyName
            // 
            this.lbStrategyName.AutoSize = true;
            this.lbStrategyName.BackColor = System.Drawing.Color.Transparent;
            this.lbStrategyName.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbStrategyName.Location = new System.Drawing.Point(360, 291);
            this.lbStrategyName.Name = "lbStrategyName";
            this.lbStrategyName.Size = new System.Drawing.Size(133, 38);
            this.lbStrategyName.TabIndex = 68;
            this.lbStrategyName.Text = "策略名称";
            // 
            // tbStrategyName
            // 
            this.tbStrategyName.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbStrategyName.Location = new System.Drawing.Point(516, 291);
            this.tbStrategyName.Name = "tbStrategyName";
            this.tbStrategyName.Size = new System.Drawing.Size(404, 46);
            this.tbStrategyName.TabIndex = 67;
            // 
            // btConfirm
            // 
            this.btConfirm.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btConfirm.Location = new System.Drawing.Point(565, 490);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(98, 43);
            this.btConfirm.TabIndex = 69;
            this.btConfirm.Text = "删除";
            this.btConfirm.UseVisualStyleBackColor = true;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // lbMapName
            // 
            this.lbMapName.AutoSize = true;
            this.lbMapName.BackColor = System.Drawing.Color.Transparent;
            this.lbMapName.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbMapName.Location = new System.Drawing.Point(360, 355);
            this.lbMapName.Name = "lbMapName";
            this.lbMapName.Size = new System.Drawing.Size(133, 38);
            this.lbMapName.TabIndex = 71;
            this.lbMapName.Text = "地图名称";
            // 
            // tbMapName
            // 
            this.tbMapName.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbMapName.Location = new System.Drawing.Point(516, 355);
            this.tbMapName.Name = "tbMapName";
            this.tbMapName.Size = new System.Drawing.Size(404, 46);
            this.tbMapName.TabIndex = 70;
            // 
            // lbMapType
            // 
            this.lbMapType.AutoSize = true;
            this.lbMapType.BackColor = System.Drawing.Color.Transparent;
            this.lbMapType.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbMapType.Location = new System.Drawing.Point(360, 424);
            this.lbMapType.Name = "lbMapType";
            this.lbMapType.Size = new System.Drawing.Size(133, 38);
            this.lbMapType.TabIndex = 73;
            this.lbMapType.Text = "地图类别";
            // 
            // tbMapType
            // 
            this.tbMapType.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbMapType.Location = new System.Drawing.Point(516, 424);
            this.tbMapType.Name = "tbMapType";
            this.tbMapType.Size = new System.Drawing.Size(404, 46);
            this.tbMapType.TabIndex = 72;
            // 
            // StrategyDel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UI.Properties.Resources.SelectHero;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 762);
            this.ControlBox = false;
            this.Controls.Add(this.lbMapType);
            this.Controls.Add(this.tbMapType);
            this.Controls.Add(this.lbMapName);
            this.Controls.Add(this.tbMapName);
            this.Controls.Add(this.btConfirm);
            this.Controls.Add(this.lbStrategyName);
            this.Controls.Add(this.tbStrategyName);
            this.Controls.Add(this.btReturn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StrategyDel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "删除策略";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btReturn;
        private System.Windows.Forms.Label lbStrategyName;
        private System.Windows.Forms.TextBox tbStrategyName;
        private System.Windows.Forms.Button btConfirm;
        private System.Windows.Forms.Label lbMapName;
        private System.Windows.Forms.TextBox tbMapName;
        private System.Windows.Forms.Label lbMapType;
        private System.Windows.Forms.TextBox tbMapType;
    }
}