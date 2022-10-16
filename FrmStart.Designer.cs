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
            this.components = new System.ComponentModel.Container();
            this.PnlStart = new System.Windows.Forms.Panel();
            this.BtnStart = new System.Windows.Forms.Button();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.Lbl1 = new System.Windows.Forms.Label();
            this.TmrChange = new System.Windows.Forms.Timer(this.components);
            this.PnlStart.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlStart
            // 
            this.PnlStart.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PnlStart.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.PnlStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PnlStart.Controls.Add(this.BtnStart);
            this.PnlStart.Controls.Add(this.TxtName);
            this.PnlStart.Controls.Add(this.Lbl1);
            this.PnlStart.ForeColor = System.Drawing.Color.Transparent;
            this.PnlStart.Location = new System.Drawing.Point(0, 0);
            this.PnlStart.Name = "PnlStart";
            this.PnlStart.Size = new System.Drawing.Size(685, 462);
            this.PnlStart.TabIndex = 0;
            this.PnlStart.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlStart_Paint);
            // 
            // BtnStart
            // 
            this.BtnStart.Location = new System.Drawing.Point(275, 360);
            this.BtnStart.Name = "BtnStart";
            this.BtnStart.Size = new System.Drawing.Size(120, 50);
            this.BtnStart.TabIndex = 4;
            this.BtnStart.Text = "Continue";
            this.BtnStart.UseVisualStyleBackColor = true;
            this.BtnStart.Click += new System.EventHandler(this.BtnStart_Click);
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(264, 334);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(139, 20);
            this.TxtName.TabIndex = 3;
            this.TxtName.Visible = false;
            this.TxtName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtName_KeyPress);
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl1.Location = new System.Drawing.Point(21, 152);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(39, 20);
            this.Lbl1.TabIndex = 0;
            this.Lbl1.Text = "Lbl1";
            // 
            // TmrChange
            // 
            this.TmrChange.Tick += new System.EventHandler(this.TmrChange_Tick);
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
        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.Timer TmrChange;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Button BtnStart;
    }
}