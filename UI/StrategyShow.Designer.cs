namespace UI
{
    partial class StrategyShow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StrategyShow));
            this.dgvStrategy = new System.Windows.Forms.DataGridView();
            this.StrategyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StrategyDescribe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btReturn = new System.Windows.Forms.Button();
            this.lbMapName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStrategy)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStrategy
            // 
            this.dgvStrategy.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvStrategy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStrategy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StrategyName,
            this.StrategyDescribe});
            this.dgvStrategy.Location = new System.Drawing.Point(126, 96);
            this.dgvStrategy.Name = "dgvStrategy";
            this.dgvStrategy.RowTemplate.Height = 23;
            this.dgvStrategy.Size = new System.Drawing.Size(1126, 653);
            this.dgvStrategy.TabIndex = 0;
            // 
            // StrategyName
            // 
            this.StrategyName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StrategyName.DataPropertyName = "StrategyName";
            this.StrategyName.FillWeight = 20F;
            this.StrategyName.HeaderText = "策略名称";
            this.StrategyName.Name = "StrategyName";
            this.StrategyName.ReadOnly = true;
            this.StrategyName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // StrategyDescribe
            // 
            this.StrategyDescribe.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.StrategyDescribe.DataPropertyName = "StrategyDescribe";
            this.StrategyDescribe.FillWeight = 80F;
            this.StrategyDescribe.HeaderText = "策略描述";
            this.StrategyDescribe.Name = "StrategyDescribe";
            this.StrategyDescribe.ReadOnly = true;
            this.StrategyDescribe.Resizable = System.Windows.Forms.DataGridViewTriState.False;
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
            this.btReturn.TabIndex = 36;
            this.btReturn.UseVisualStyleBackColor = false;
            this.btReturn.Click += new System.EventHandler(this.btReturn_Click);
            // 
            // lbMapName
            // 
            this.lbMapName.AutoSize = true;
            this.lbMapName.BackColor = System.Drawing.Color.Transparent;
            this.lbMapName.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbMapName.Location = new System.Drawing.Point(624, 31);
            this.lbMapName.Name = "lbMapName";
            this.lbMapName.Size = new System.Drawing.Size(178, 41);
            this.lbMapName.TabIndex = 37;
            this.lbMapName.Text = "mapName";
            // 
            // StrategyShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UI.Properties.Resources.SelectHero;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 762);
            this.ControlBox = false;
            this.Controls.Add(this.lbMapName);
            this.Controls.Add(this.btReturn);
            this.Controls.Add(this.dgvStrategy);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StrategyShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "地图策略";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStrategy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStrategy;
        private System.Windows.Forms.Button btReturn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StrategyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn StrategyDescribe;
        private System.Windows.Forms.Label lbMapName;
    }
}