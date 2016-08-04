namespace EveMapBrowser
{
    partial class PvpReport
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
            this.lstViolentRegions = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstRattingSystems = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstViolentRegions
            // 
            this.lstViolentRegions.FormattingEnabled = true;
            this.lstViolentRegions.HorizontalScrollbar = true;
            this.lstViolentRegions.Location = new System.Drawing.Point(12, 29);
            this.lstViolentRegions.Name = "lstViolentRegions";
            this.lstViolentRegions.Size = new System.Drawing.Size(244, 238);
            this.lstViolentRegions.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Most Violent Regions";
            // 
            // lstRattingSystems
            // 
            this.lstRattingSystems.FormattingEnabled = true;
            this.lstRattingSystems.HorizontalScrollbar = true;
            this.lstRattingSystems.Location = new System.Drawing.Point(282, 29);
            this.lstRattingSystems.Name = "lstRattingSystems";
            this.lstRattingSystems.Size = new System.Drawing.Size(248, 238);
            this.lstRattingSystems.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Top Ratting Systems";
            // 
            // PvpReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 380);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lstRattingSystems);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstViolentRegions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PvpReport";
            this.Text = "PvP Report";
            this.Load += new System.EventHandler(this.PvpReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstViolentRegions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstRattingSystems;
        private System.Windows.Forms.Label label2;
    }
}