
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FishyFrm));
            this.TmrFish = new System.Windows.Forms.Timer(this.components);
            this.TmrCatch = new System.Windows.Forms.Timer(this.components);
            this.TmrWait = new System.Windows.Forms.Timer(this.components);
            this.BtnTmr = new System.Windows.Forms.Timer(this.components);
            this.FishyPanel = new System.Windows.Forms.Panel();
            this.InfoBtn = new System.Windows.Forms.Button();
            this.FishyPopUp = new System.Windows.Forms.Panel();
            this.LblInfo = new System.Windows.Forms.Label();
            this.LblNew = new System.Windows.Forms.Label();
            this.LblContinue = new System.Windows.Forms.Label();
            this.LblText = new System.Windows.Forms.Label();
            this.EButton1 = new System.Windows.Forms.Button();
            this.EButton2 = new System.Windows.Forms.Button();
            this.EButton3 = new System.Windows.Forms.Button();
            this.EButton4 = new System.Windows.Forms.Button();
            this.EncyclopediaBtn = new System.Windows.Forms.Button();
            this.BaitTxt = new System.Windows.Forms.Label();
            this.LblBait = new System.Windows.Forms.Label();
            this.FishyPanel.SuspendLayout();
            this.FishyPopUp.SuspendLayout();
            this.SuspendLayout();
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
            this.TmrWait.Interval = 1000;
            this.TmrWait.Tick += new System.EventHandler(this.TmrWait_Tick);
            // 
            // BtnTmr
            // 
            this.BtnTmr.Tick += new System.EventHandler(this.BtnTmr_Tick);
            // 
            // FishyPanel
            // 
            this.FishyPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FishyPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FishyPanel.BackgroundImage")));
            this.FishyPanel.Controls.Add(this.InfoBtn);
            this.FishyPanel.Controls.Add(this.FishyPopUp);
            this.FishyPanel.Controls.Add(this.EncyclopediaBtn);
            this.FishyPanel.Controls.Add(this.BaitTxt);
            this.FishyPanel.Controls.Add(this.LblBait);
            this.FishyPanel.Location = new System.Drawing.Point(0, 0);
            this.FishyPanel.Name = "FishyPanel";
            this.FishyPanel.Size = new System.Drawing.Size(684, 464);
            this.FishyPanel.TabIndex = 0;
            this.FishyPanel.Click += new System.EventHandler(this.GeneralClick);
            this.FishyPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.FishyPanel_Paint);
            // 
            // InfoBtn
            // 
            this.InfoBtn.BackColor = System.Drawing.Color.Transparent;
            this.InfoBtn.BackgroundImage = global::Fishy_Business.Properties.Resources.Info;
            this.InfoBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.InfoBtn.ForeColor = System.Drawing.Color.Transparent;
            this.InfoBtn.Location = new System.Drawing.Point(600, 240);
            this.InfoBtn.Margin = new System.Windows.Forms.Padding(0);
            this.InfoBtn.Name = "InfoBtn";
            this.InfoBtn.Size = new System.Drawing.Size(50, 50);
            this.InfoBtn.TabIndex = 0;
            this.InfoBtn.TabStop = false;
            this.InfoBtn.UseVisualStyleBackColor = false;
            this.InfoBtn.Click += new System.EventHandler(this.InfoBtn_Click);
            // 
            // FishyPopUp
            // 
            this.FishyPopUp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FishyPopUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.FishyPopUp.Controls.Add(this.LblInfo);
            this.FishyPopUp.Controls.Add(this.LblNew);
            this.FishyPopUp.Controls.Add(this.LblContinue);
            this.FishyPopUp.Controls.Add(this.LblText);
            this.FishyPopUp.Controls.Add(this.EButton1);
            this.FishyPopUp.Controls.Add(this.EButton2);
            this.FishyPopUp.Controls.Add(this.EButton3);
            this.FishyPopUp.Controls.Add(this.EButton4);
            this.FishyPopUp.Location = new System.Drawing.Point(100, 100);
            this.FishyPopUp.Name = "FishyPopUp";
            this.FishyPopUp.Size = new System.Drawing.Size(450, 250);
            this.FishyPopUp.TabIndex = 0;
            this.FishyPopUp.Visible = false;
            this.FishyPopUp.Click += new System.EventHandler(this.GeneralClick);
            this.FishyPopUp.Paint += new System.Windows.Forms.PaintEventHandler(this.FishyPopUp_Paint);
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
            this.LblInfo.Click += new System.EventHandler(this.GeneralClick);
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
            // EButton1
            // 
            this.EButton1.BackColor = System.Drawing.Color.Transparent;
            this.EButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EButton1.Location = new System.Drawing.Point(20, 20);
            this.EButton1.Name = "EButton1";
            this.EButton1.Size = new System.Drawing.Size(190, 90);
            this.EButton1.TabIndex = 7;
            this.EButton1.TabStop = false;
            this.EButton1.Text = "button1";
            this.EButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.EButton1.UseVisualStyleBackColor = false;
            this.EButton1.Visible = false;
            this.EButton1.Click += new System.EventHandler(this.EButton1_Click);
            // 
            // EButton2
            // 
            this.EButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EButton2.Location = new System.Drawing.Point(240, 20);
            this.EButton2.Name = "EButton2";
            this.EButton2.Size = new System.Drawing.Size(190, 90);
            this.EButton2.TabIndex = 8;
            this.EButton2.TabStop = false;
            this.EButton2.Text = "button2";
            this.EButton2.UseVisualStyleBackColor = true;
            this.EButton2.UseWaitCursor = true;
            this.EButton2.Visible = false;
            this.EButton2.Click += new System.EventHandler(this.Ebutton2_Click);
            // 
            // EButton3
            // 
            this.EButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EButton3.Location = new System.Drawing.Point(20, 140);
            this.EButton3.Name = "EButton3";
            this.EButton3.Size = new System.Drawing.Size(190, 90);
            this.EButton3.TabIndex = 9;
            this.EButton3.TabStop = false;
            this.EButton3.Text = "button3";
            this.EButton3.UseVisualStyleBackColor = true;
            this.EButton3.Visible = false;
            this.EButton3.Click += new System.EventHandler(this.Ebutton3_Click);
            // 
            // EButton4
            // 
            this.EButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EButton4.Location = new System.Drawing.Point(240, 140);
            this.EButton4.Name = "EButton4";
            this.EButton4.Size = new System.Drawing.Size(190, 90);
            this.EButton4.TabIndex = 10;
            this.EButton4.TabStop = false;
            this.EButton4.Text = "button4";
            this.EButton4.UseVisualStyleBackColor = true;
            this.EButton4.Visible = false;
            this.EButton4.Click += new System.EventHandler(this.Ebutton4_Click);
            // 
            // EncyclopediaBtn
            // 
            this.EncyclopediaBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EncyclopediaBtn.Location = new System.Drawing.Point(520, 300);
            this.EncyclopediaBtn.Name = "EncyclopediaBtn";
            this.EncyclopediaBtn.Size = new System.Drawing.Size(150, 50);
            this.EncyclopediaBtn.TabIndex = 0;
            this.EncyclopediaBtn.TabStop = false;
            this.EncyclopediaBtn.Text = "[E]ncyclopedia";
            this.EncyclopediaBtn.UseVisualStyleBackColor = true;
            this.EncyclopediaBtn.Click += new System.EventHandler(this.EncyclopediaBtn_Click);
            // 
            // BaitTxt
            // 
            this.BaitTxt.AutoSize = true;
            this.BaitTxt.BackColor = System.Drawing.Color.Transparent;
            this.BaitTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaitTxt.Location = new System.Drawing.Point(515, 373);
            this.BaitTxt.Name = "BaitTxt";
            this.BaitTxt.Size = new System.Drawing.Size(55, 25);
            this.BaitTxt.TabIndex = 2;
            this.BaitTxt.Text = "Bait:";
            // 
            // LblBait
            // 
            this.LblBait.AutoSize = true;
            this.LblBait.BackColor = System.Drawing.Color.Transparent;
            this.LblBait.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBait.Location = new System.Drawing.Point(614, 372);
            this.LblBait.Name = "LblBait";
            this.LblBait.Size = new System.Drawing.Size(56, 26);
            this.LblBait.TabIndex = 1;
            this.LblBait.Tag = "";
            this.LblBait.Text = "Bait:";
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
            this.FishyPanel.PerformLayout();
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
        private System.Windows.Forms.Button EButton1;
        private System.Windows.Forms.Button EButton2;
        private System.Windows.Forms.Button EButton4;
        private System.Windows.Forms.Button EButton3;
        private System.Windows.Forms.Timer BtnTmr;
        private System.Windows.Forms.Label LblBait;
        private System.Windows.Forms.Label BaitTxt;
        private System.Windows.Forms.Button EncyclopediaBtn;
        private System.Windows.Forms.Button InfoBtn;
    }
}

