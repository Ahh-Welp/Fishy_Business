
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
            this.FishyPopUp = new System.Windows.Forms.Panel();
            this.LblText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TmrFish = new System.Windows.Forms.Timer(this.components);
            this.TmrCatch = new System.Windows.Forms.Timer(this.components);
            this.TmrWait = new System.Windows.Forms.Timer(this.components);
            this.FishyPanel.SuspendLayout();
            this.FishyPopUp.SuspendLayout();
            this.SuspendLayout();
            // 
            // FishyPanel
            // 
            this.FishyPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FishyPanel.Controls.Add(this.FishyPopUp);
            this.FishyPanel.Location = new System.Drawing.Point(0, 0);
            this.FishyPanel.Name = "FishyPanel";
            this.FishyPanel.Size = new System.Drawing.Size(684, 464);
            this.FishyPanel.TabIndex = 0;
            this.FishyPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.FishyPanel_Paint);
            // 
            // FishyPopUp
            // 
            this.FishyPopUp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FishyPopUp.Controls.Add(this.LblText);
            this.FishyPopUp.Controls.Add(this.label1);
            this.FishyPopUp.Location = new System.Drawing.Point(100, 100);
            this.FishyPopUp.Name = "FishyPopUp";
            this.FishyPopUp.Size = new System.Drawing.Size(450, 250);
            this.FishyPopUp.TabIndex = 0;
            this.FishyPopUp.Visible = false;
            this.FishyPopUp.Paint += new System.Windows.Forms.PaintEventHandler(this.FishyPopUp_Paint);
            this.FishyPopUp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FishyPopUp_MouseClick);
            // 
            // LblText
            // 
            this.LblText.AutoSize = true;
            this.LblText.Location = new System.Drawing.Point(189, 77);
            this.LblText.Name = "LblText";
            this.LblText.Size = new System.Drawing.Size(35, 13);
            this.LblText.TabIndex = 1;
            this.LblText.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(189, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Click anywhere to continue.";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TmrFish
            // 
            this.TmrFish.Enabled = true;
            this.TmrFish.Interval = 50;
            this.TmrFish.Tick += new System.EventHandler(this.TmrFish_Tick);
            // 
            // TmrCatch
            // 
            this.TmrCatch.Interval = 1000;
            this.TmrCatch.Tick += new System.EventHandler(this.TmrCatch_Tick);
            // 
            // TmrWait
            // 
            this.TmrWait.Enabled = true;
            this.TmrWait.Interval = 5000;
            this.TmrWait.Tick += new System.EventHandler(this.TmrWait_Tick);
            // 
            // FishyFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.FishyPanel);
            this.Name = "FishyFrm";
            this.Text = "Going Fishin\'";
            this.Load += new System.EventHandler(this.FishyFrm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FishyFrm_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FishyFrm_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FishyFrm_KeyUp);
            this.FishyPanel.ResumeLayout(false);
            this.FishyPopUp.ResumeLayout(false);
            this.FishyPopUp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FishyPanel;
        private System.Windows.Forms.Timer TmrFish;
        private System.Windows.Forms.Timer TmrCatch;
        private System.Windows.Forms.Timer TmrWait;
        private System.Windows.Forms.Panel FishyPopUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblText;
    }
}

