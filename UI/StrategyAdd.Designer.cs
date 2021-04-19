namespace UI
{
    partial class StrategyAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StrategyAdd));
            this.btReturn = new System.Windows.Forms.Button();
            this.help = new System.Windows.Forms.Label();
            this.lbStrategyDescribe = new System.Windows.Forms.Label();
            this.tbStrategyDescribe = new System.Windows.Forms.TextBox();
            this.btConfirm = new System.Windows.Forms.Button();
            this.lbStrategyName = new System.Windows.Forms.Label();
            this.lbMapNumber = new System.Windows.Forms.Label();
            this.lbStrategyNumber = new System.Windows.Forms.Label();
            this.tbStrategyName = new System.Windows.Forms.TextBox();
            this.tbMapNumber = new System.Windows.Forms.TextBox();
            this.tbStrategyNumber = new System.Windows.Forms.TextBox();
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
            this.help.Size = new System.Drawing.Size(459, 38);
            this.help.TabIndex = 37;
            this.help.Text = "请在添加对应的地图后,执行此功能";
            // 
            // lbStrategyDescribe
            // 
            this.lbStrategyDescribe.AutoSize = true;
            this.lbStrategyDescribe.BackColor = System.Drawing.Color.Transparent;
            this.lbStrategyDescribe.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbStrategyDescribe.Location = new System.Drawing.Point(352, 423);
            this.lbStrategyDescribe.Name = "lbStrategyDescribe";
            this.lbStrategyDescribe.Size = new System.Drawing.Size(133, 38);
            this.lbStrategyDescribe.TabIndex = 69;
            this.lbStrategyDescribe.Text = "策略描述";
            // 
            // tbStrategyDescribe
            // 
            this.tbStrategyDescribe.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbStrategyDescribe.Location = new System.Drawing.Point(508, 423);
            this.tbStrategyDescribe.Name = "tbStrategyDescribe";
            this.tbStrategyDescribe.Size = new System.Drawing.Size(404, 46);
            this.tbStrategyDescribe.TabIndex = 68;
            // 
            // btConfirm
            // 
            this.btConfirm.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btConfirm.Location = new System.Drawing.Point(534, 493);
            this.btConfirm.Name = "btConfirm";
            this.btConfirm.Size = new System.Drawing.Size(98, 43);
            this.btConfirm.TabIndex = 67;
            this.btConfirm.Text = "添加";
            this.btConfirm.UseVisualStyleBackColor = true;
            this.btConfirm.Click += new System.EventHandler(this.btConfirm_Click);
            // 
            // lbStrategyName
            // 
            this.lbStrategyName.AutoSize = true;
            this.lbStrategyName.BackColor = System.Drawing.Color.Transparent;
            this.lbStrategyName.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbStrategyName.Location = new System.Drawing.Point(352, 356);
            this.lbStrategyName.Name = "lbStrategyName";
            this.lbStrategyName.Size = new System.Drawing.Size(133, 38);
            this.lbStrategyName.TabIndex = 66;
            this.lbStrategyName.Text = "策略名称";
            // 
            // lbMapNumber
            // 
            this.lbMapNumber.AutoSize = true;
            this.lbMapNumber.BackColor = System.Drawing.Color.Transparent;
            this.lbMapNumber.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbMapNumber.Location = new System.Drawing.Point(352, 293);
            this.lbMapNumber.Name = "lbMapNumber";
            this.lbMapNumber.Size = new System.Drawing.Size(133, 38);
            this.lbMapNumber.TabIndex = 65;
            this.lbMapNumber.Text = "地图编号";
            // 
            // lbStrategyNumber
            // 
            this.lbStrategyNumber.AutoSize = true;
            this.lbStrategyNumber.BackColor = System.Drawing.Color.Transparent;
            this.lbStrategyNumber.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbStrategyNumber.Location = new System.Drawing.Point(352, 224);
            this.lbStrategyNumber.Name = "lbStrategyNumber";
            this.lbStrategyNumber.Size = new System.Drawing.Size(133, 38);
            this.lbStrategyNumber.TabIndex = 64;
            this.lbStrategyNumber.Text = "策略编号";
            // 
            // tbStrategyName
            // 
            this.tbStrategyName.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbStrategyName.Location = new System.Drawing.Point(508, 356);
            this.tbStrategyName.Name = "tbStrategyName";
            this.tbStrategyName.Size = new System.Drawing.Size(404, 46);
            this.tbStrategyName.TabIndex = 63;
            // 
            // tbMapNumber
            // 
            this.tbMapNumber.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbMapNumber.Location = new System.Drawing.Point(508, 285);
            this.tbMapNumber.Name = "tbMapNumber";
            this.tbMapNumber.Size = new System.Drawing.Size(404, 46);
            this.tbMapNumber.TabIndex = 62;
            // 
            // tbStrategyNumber
            // 
            this.tbStrategyNumber.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbStrategyNumber.Location = new System.Drawing.Point(508, 224);
            this.tbStrategyNumber.Name = "tbStrategyNumber";
            this.tbStrategyNumber.Size = new System.Drawing.Size(404, 46);
            this.tbStrategyNumber.TabIndex = 61;
            // 
            // StrategyAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UI.Properties.Resources.SelectHero;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 762);
            this.ControlBox = false;
            this.Controls.Add(this.lbStrategyDescribe);
            this.Controls.Add(this.tbStrategyDescribe);
            this.Controls.Add(this.btConfirm);
            this.Controls.Add(this.lbStrategyName);
            this.Controls.Add(this.lbMapNumber);
            this.Controls.Add(this.lbStrategyNumber);
            this.Controls.Add(this.tbStrategyName);
            this.Controls.Add(this.tbMapNumber);
            this.Controls.Add(this.tbStrategyNumber);
            this.Controls.Add(this.help);
            this.Controls.Add(this.btReturn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StrategyAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加策略";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btReturn;
        private System.Windows.Forms.Label help;
        private System.Windows.Forms.Label lbStrategyDescribe;
        private System.Windows.Forms.TextBox tbStrategyDescribe;
        private System.Windows.Forms.Button btConfirm;
        private System.Windows.Forms.Label lbStrategyName;
        private System.Windows.Forms.Label lbMapNumber;
        private System.Windows.Forms.Label lbStrategyNumber;
        private System.Windows.Forms.TextBox tbStrategyName;
        private System.Windows.Forms.TextBox tbMapNumber;
        private System.Windows.Forms.TextBox tbStrategyNumber;
    }
}