namespace EveMapBrowser
{
    partial class Main
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.dgvResults = new System.Windows.Forms.DataGridView();
            this.btnPvp = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnApplyFilters = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaxSec = new System.Windows.Forms.TextBox();
            this.txtMinSec = new System.Windows.Forms.TextBox();
            this.btnClearFilters = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoad.Location = new System.Drawing.Point(704, 424);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(80, 23);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // dgvResults
            // 
            this.dgvResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResults.Location = new System.Drawing.Point(13, 13);
            this.dgvResults.Name = "dgvResults";
            this.dgvResults.Size = new System.Drawing.Size(771, 328);
            this.dgvResults.TabIndex = 3;
            // 
            // btnPvp
            // 
            this.btnPvp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPvp.Enabled = false;
            this.btnPvp.Location = new System.Drawing.Point(704, 461);
            this.btnPvp.Name = "btnPvp";
            this.btnPvp.Size = new System.Drawing.Size(80, 23);
            this.btnPvp.TabIndex = 4;
            this.btnPvp.Text = "PvP";
            this.btnPvp.UseVisualStyleBackColor = true;
            this.btnPvp.Click += new System.EventHandler(this.btnPvp_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClearFilters);
            this.groupBox1.Controls.Add(this.btnApplyFilters);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMaxSec);
            this.groupBox1.Controls.Add(this.txtMinSec);
            this.groupBox1.Location = new System.Drawing.Point(13, 359);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 125);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filters";
            // 
            // btnApplyFilters
            // 
            this.btnApplyFilters.Location = new System.Drawing.Point(394, 96);
            this.btnApplyFilters.Name = "btnApplyFilters";
            this.btnApplyFilters.Size = new System.Drawing.Size(75, 23);
            this.btnApplyFilters.TabIndex = 3;
            this.btnApplyFilters.Text = "Apply";
            this.btnApplyFilters.UseVisualStyleBackColor = true;
            this.btnApplyFilters.Click += new System.EventHandler(this.btnApplyFilters_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sec";
            // 
            // txtMaxSec
            // 
            this.txtMaxSec.Location = new System.Drawing.Point(158, 23);
            this.txtMaxSec.Name = "txtMaxSec";
            this.txtMaxSec.Size = new System.Drawing.Size(100, 20);
            this.txtMaxSec.TabIndex = 1;
            // 
            // txtMinSec
            // 
            this.txtMinSec.Location = new System.Drawing.Point(38, 23);
            this.txtMinSec.Name = "txtMinSec";
            this.txtMinSec.Size = new System.Drawing.Size(100, 20);
            this.txtMinSec.TabIndex = 0;
            // 
            // btnClearFilters
            // 
            this.btnClearFilters.Location = new System.Drawing.Point(313, 96);
            this.btnClearFilters.Name = "btnClearFilters";
            this.btnClearFilters.Size = new System.Drawing.Size(75, 23);
            this.btnClearFilters.TabIndex = 4;
            this.btnClearFilters.Text = "Clear";
            this.btnClearFilters.UseVisualStyleBackColor = true;
            this.btnClearFilters.Click += new System.EventHandler(this.btnClearFilters_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 496);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnPvp);
            this.Controls.Add(this.dgvResults);
            this.Controls.Add(this.btnLoad);
            this.Name = "Main";
            this.Text = "Eve Map Browser";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResults)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView dgvResults;
        private System.Windows.Forms.Button btnPvp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaxSec;
        private System.Windows.Forms.TextBox txtMinSec;
        private System.Windows.Forms.Button btnApplyFilters;
        private System.Windows.Forms.Button btnClearFilters;
    }
}

