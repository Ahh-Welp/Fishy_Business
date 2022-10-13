namespace Fishy_Business
{
    partial class FrmStart
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
            this.PnlStart = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PnlStart.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlStart
            // 
            this.PnlStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PnlStart.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.PnlStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlStart.Controls.Add(this.label3);
            this.PnlStart.Controls.Add(this.label2);
            this.PnlStart.Controls.Add(this.label1);
            this.PnlStart.ForeColor = System.Drawing.Color.Transparent;
            this.PnlStart.Location = new System.Drawing.Point(0, 0);
            this.PnlStart.Name = "PnlStart";
            this.PnlStart.Size = new System.Drawing.Size(685, 462);
            this.PnlStart.TabIndex = 0;
            this.PnlStart.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlStart_Paint);
            this.PnlStart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PnlStart_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // FrmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.PnlStart);
            this.Name = "FrmStart";
            this.Text = "FrmStart";
            this.PnlStart.ResumeLayout(false);
            this.PnlStart.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}