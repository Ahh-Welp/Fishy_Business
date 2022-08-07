
namespace Fishy_Business
{
    partial class FishyFrm
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
            this.FishyPanel = new System.Windows.Forms.Panel();
            this.TmrFish = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // FishyPanel
            // 
            this.FishyPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FishyPanel.Location = new System.Drawing.Point(0, 0);
            this.FishyPanel.Name = "FishyPanel";
            this.FishyPanel.Size = new System.Drawing.Size(684, 464);
            this.FishyPanel.TabIndex = 0;
            this.FishyPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.FishyPanel_Paint);
            // 
            // TmrFish
            // 
            this.TmrFish.Enabled = true;
            this.TmrFish.Interval = 50;
            this.TmrFish.Tick += new System.EventHandler(this.TmrFish_Tick);
            // 
            // FishyFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.FishyPanel);
            this.Name = "FishyFrm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FishyFrm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FishyPanel;
        private System.Windows.Forms.Timer TmrFish;
    }
}

