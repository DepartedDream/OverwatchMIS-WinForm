namespace UI
{
    partial class MapDel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapDel));
            this.btReturn = new System.Windows.Forms.Button();
            this.help = new System.Windows.Forms.Label();
            this.lbMapName = new System.Windows.Forms.Label();
            this.tbMapName = new System.Windows.Forms.TextBox();
            this.btConfirm = new System.Windows.Forms.Button();
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
            // help
            // 
            this.help.AutoSize = true;
            this.help.BackColor = System.Drawing.Color.Transparent;
            this.help.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.help.Location = new System.Drawing.Point(355, 40);
            this.help.Name = "help";
            this.help.Size = new System.Drawing.Size(611, 38);
            this.help.TabIndex = 36;
            this.help.Text = "注意,删除地图后,该地图对应的策略也将被删除";
            // 
            // lbMapName
            // 
            this.lbMapName.AutoSize = true;
            this.lbMapName.BackColor = System.Drawing.Color.Transparent;
            this.lbMapName.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbMapName.Location = new System.Drawing.Point(324, 353);
            this.lbMapName.Name = "lbMapName";
            this.lbMapName.Size = new System.Drawing.Size(133, 38);
            this.lbMapName.TabIndex = 51;
            this.lbMapName.Text = "地图名称";
            // 
            // tbMapName
            // 
            this.tbMapName.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbMapName.Location = new System.Drawing.Point(480, 345);
            this.tbMapName.Name = "tbMapName";
            this.tbMapName.Size = new System.Drawing.Size(404, 46);
            this.tbMapName.TabIndex = 50;
            // 
            // btConfirm
            // 
            this.btConfirm.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btConfirm.Location = new System.Drawing.Point(568, 486);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(98, 43);
            this.btConfirm.TabIndex = 52;
            this.btConfirm.Text = "删除";
            this.btConfirm.UseVisualStyleBackColor = true;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // lbMapType
            // 
            this.lbMapType.AutoSize = true;
            this.lbMapType.BackColor = System.Drawing.Color.Transparent;
            this.lbMapType.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbMapType.Location = new System.Drawing.Point(324, 411);
            this.lbMapType.Name = "lbMapType";
            this.lbMapType.Size = new System.Drawing.Size(133, 38);
            this.lbMapType.TabIndex = 54;
            this.lbMapType.Text = "地图类型";
            // 
            // tbMapType
            // 
            this.tbMapType.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbMapType.Location = new System.Drawing.Point(480, 411);
            this.tbMapType.Name = "tbMapType";
            this.tbMapType.Size = new System.Drawing.Size(404, 46);
            this.tbMapType.TabIndex = 53;
            // 
            // MapDel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UI.Properties.Resources.SelectHero;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 762);
            this.ControlBox = false;
            this.Controls.Add(this.lbMapType);
            this.Controls.Add(this.tbMapType);
            this.Controls.Add(this.btConfirm);
            this.Controls.Add(this.lbMapName);
            this.Controls.Add(this.tbMapName);
            this.Controls.Add(this.help);
            this.Controls.Add(this.btReturn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MapDel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "删除地图";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btReturn;
        private System.Windows.Forms.Label help;
        private System.Windows.Forms.Label lbMapName;
        private System.Windows.Forms.TextBox tbMapName;
        private System.Windows.Forms.Button btConfirm;
        private System.Windows.Forms.Label lbMapType;
        private System.Windows.Forms.TextBox tbMapType;
    }
}