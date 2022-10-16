
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
            this.Ebutton4 = new System.Windows.Forms.Button();
            this.Ebutton3 = new System.Windows.Forms.Button();
            this.Ebutton2 = new System.Windows.Forms.Button();
            this.LblInfo = new System.Windows.Forms.Label();
            this.LblNew = new System.Windows.Forms.Label();
            this.LblContinue = new System.Windows.Forms.Label();
            this.LblText = new System.Windows.Forms.Label();
            this.Ebutton1 = new System.Windows.Forms.Button();
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
            this.FishyPanel.Click += new System.EventHandler(this.GeneralClick);
            this.FishyPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.FishyPanel_Paint);
            // 
            // FishyPopUp
            // 
            this.FishyPopUp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FishyPopUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.FishyPopUp.Controls.Add(this.Ebutton4);
            this.FishyPopUp.Controls.Add(this.Ebutton3);
            this.FishyPopUp.Controls.Add(this.Ebutton2);
            this.FishyPopUp.Controls.Add(this.LblInfo);
            this.FishyPopUp.Controls.Add(this.LblNew);
            this.FishyPopUp.Controls.Add(this.LblContinue);
            this.FishyPopUp.Controls.Add(this.LblText);
            this.FishyPopUp.Controls.Add(this.Ebutton1);
            this.FishyPopUp.Location = new System.Drawing.Point(100, 100);
            this.FishyPopUp.Name = "FishyPopUp";
            this.FishyPopUp.Size = new System.Drawing.Size(450, 250);
            this.FishyPopUp.TabIndex = 0;
            this.FishyPopUp.Visible = false;
            this.FishyPopUp.Click += new System.EventHandler(this.GeneralClick);
            this.FishyPopUp.Paint += new System.Windows.Forms.PaintEventHandler(this.FishyPopUp_Paint);
            // 
            // Ebutton4
            // 
            this.Ebutton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ebutton4.Location = new System.Drawing.Point(240, 140);
            this.Ebutton4.Name = "Ebutton4";
            this.Ebutton4.Size = new System.Drawing.Size(190, 90);
            this.Ebutton4.TabIndex = 10;
            this.Ebutton4.Text = "button4";
            this.Ebutton4.UseVisualStyleBackColor = true;
            this.Ebutton4.Visible = false;
            // 
            // Ebutton3
            // 
            this.Ebutton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ebutton3.Location = new System.Drawing.Point(20, 140);
            this.Ebutton3.Name = "Ebutton3";
            this.Ebutton3.Size = new System.Drawing.Size(190, 90);
            this.Ebutton3.TabIndex = 9;
            this.Ebutton3.Text = "button3";
            this.Ebutton3.UseVisualStyleBackColor = true;
            this.Ebutton3.Visible = false;
            // 
            // Ebutton2
            // 
            this.Ebutton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ebutton2.Location = new System.Drawing.Point(240, 20);
            this.Ebutton2.Name = "Ebutton2";
            this.Ebutton2.Size = new System.Drawing.Size(190, 90);
            this.Ebutton2.TabIndex = 8;
            this.Ebutton2.Text = "button2";
            this.Ebutton2.UseVisualStyleBackColor = true;
            this.Ebutton2.UseWaitCursor = true;
            this.Ebutton2.Visible = false;
            this.Ebutton2.Click += new System.EventHandler(this.Ebutton2_Click);
            // 
            // LblInfo
            // 
            this.LblInfo.AutoSize = true;
            this.LblInfo.Location = new System.Drawing.Point(36, 27);
            this.LblInfo.Name = "LblInfo";
            this.LblInfo.Size = new System.Drawing.Size(39, 13);
            this.LblInfo.TabIndex = 3;
            this.LblInfo.Text = "LblInfo";
            this.LblInfo.Visible = false;
            // 
            // LblNew
            // 
            this.LblNew.AutoSize = true;
            this.LblNew.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblNew.Location = new System.Drawing.Point(179, 166);
            this.LblNew.Name = "LblNew";
            this.LblNew.Size = new System.Drawing.Size(242, 13);
            this.LblNew.TabIndex = 2;
            this.LblNew.Text = "This is the first time you\'ve caught this type of fish!";
            this.LblNew.Visible = false;
            this.LblNew.Click += new System.EventHandler(this.GeneralClick);
            // 
            // LblContinue
            // 
            this.LblContinue.AutoSize = true;
            this.LblContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContinue.Location = new System.Drawing.Point(179, 205);
            this.LblContinue.Name = "LblContinue";
            this.LblContinue.Size = new System.Drawing.Size(138, 13);
            this.LblContinue.TabIndex = 0;
            this.LblContinue.Text = "Click anywhere to continue.";
            this.LblContinue.Click += new System.EventHandler(this.GeneralClick);
            // 
            // LblText
            // 
            this.LblText.AutoSize = true;
            this.LblText.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LblText.Location = new System.Drawing.Point(179, 76);
            this.LblText.Name = "LblText";
            this.LblText.Size = new System.Drawing.Size(42, 13);
            this.LblText.TabIndex = 1;
            this.LblText.Text = "LblText";
            this.LblText.Click += new System.EventHandler(this.GeneralClick);
            // 
            // Ebutton1
            // 
            this.Ebutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ebutton1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.Ebutton1.Location = new System.Drawing.Point(20, 20);
            this.Ebutton1.Name = "Ebutton1";
            this.Ebutton1.Size = new System.Drawing.Size(190, 90);
            this.Ebutton1.TabIndex = 7;
            this.Ebutton1.Text = "button1";
            this.Ebutton1.UseVisualStyleBackColor = true;
            this.Ebutton1.Visible = false;
            this.Ebutton1.Click += new System.EventHandler(this.Ebutton1_Click);
            // 
            // TmrFish
            // 
            this.TmrFish.Enabled = true;
            this.TmrFish.Interval = 50;
            this.TmrFish.Tick += new System.EventHandler(this.TmrFish_Tick);
            // 
            // TmrCatch
            // 
            this.TmrCatch.Interval = 3000;
            this.TmrCatch.Tick += new System.EventHandler(this.TmrCatch_Tick);
            // 
            // TmrWait
            // 
            this.TmrWait.Enabled = true;
            this.TmrWait.Interval = 2500;
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
            this.FishyPanel.ResumeLayout(false);
            this.FishyPopUp.ResumeLayout(false);
            this.FishyPopUp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel FishyPanel;
        private System.Windows.Forms.Timer TmrFish;
        private System.Windows.Forms.Timer TmrCatch;
        private System.Windows.Forms.Timer TmrWait;
        public System.Windows.Forms.Panel FishyPopUp;
        public System.Windows.Forms.Label LblContinue;
        public System.Windows.Forms.Label LblText;
        public System.Windows.Forms.Label LblNew;
        private System.Windows.Forms.Label LblInfo;
        private System.Windows.Forms.Button Ebutton1;
        private System.Windows.Forms.Button Ebutton2;
        private System.Windows.Forms.Button Ebutton4;
        private System.Windows.Forms.Button Ebutton3;
    }
}

