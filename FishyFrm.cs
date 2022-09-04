﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fishy_Business
{
    public partial class FishyFrm : Form
    {
        Graphics g; //declare a graphics object called g
        // declare space for an array of 3 objects called fish 
        Fish[] fish = new Fish[3];
        double x, y;
        double phi = 0;
        int radius = 80;
        int NumberOfFish;
        public int bait;
        private Rectangle rodRec;//variable for a rectangle to place our image in
        bool  Catch, spring, summer, autumn, winter, redcod, bluecod, snapper, gurnard, rockfish, bluetang, squid, yellowtang, clownfish, catfish, pinksalmon, ringtailunicornfish, kingfish, pufferfish, morayeel, seaanemone;

        private void FishyPopUp_MouseClick(object sender, MouseEventArgs e)
        {
            FishyPopUp.Visible = false;
            TmrFish.Enabled = true;
            displaytype = null;
        }

        public string displaytype = null;
        public Rectangle displayfishRec;
        public Image displayfish;

        public void FishyFrm_KeyUp(object sender, KeyEventArgs e)
        {

        }

        public void FishyFrm_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        public void FishyPopUp_Paint(object sender, PaintEventArgs e)
        {
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, FishyPopUp, new object[] { true });

            Graphics g2 = e.Graphics;

            displayfishRec = new Rectangle(60, 60, 100, 100);

            if (displaytype == "Summer")
            {
                LblText.Visible = true;
                LblText.Text = "It is now summer!";
                FishyPopUp.Invalidate();
            }
            if (displaytype == "Snapper")
            {
                LblText.Visible = true;
                LblText.Text = "You caught a snapper!";
                displayfish = Properties.Resources.Snapper; 
                g2.DrawImage(displayfish, displayfishRec);
                FishyPopUp.Invalidate();
            }
            if (displaytype == "Redcod")
            {
                LblText.Visible = true;
                LblText.Text = "You caught a red cod!";
                displayfish = Properties.Resources.Snapper;
                g2.DrawImage(displayfish, displayfishRec);
                FishyPopUp.Invalidate();
            }
            if (displaytype == "Bluecod")
            {
                LblText.Visible = true;
                LblText.Text = "You caught a blue cod!";
                displayfish = Properties.Resources.Snapper;
                g2.DrawImage(displayfish, displayfishRec);
                FishyPopUp.Invalidate();
            }
            if (displaytype == "Gurnard")
            {
                LblText.Visible = true;
                LblText.Text = "You caught a gurnard!";
                displayfish = Properties.Resources.Snapper;
                g2.DrawImage(displayfish, displayfishRec);
                FishyPopUp.Invalidate();
            }


        }

        public FishyFrm()
        {
            InitializeComponent();

            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, FishyPanel, new object[] { true });

            NumberOfFish = fish.Count();
            for (int i = 0; i < NumberOfFish; i++)
            {
                int x = 10 + (i * 75);
                fish[i] = new Fish(x);
            }
        }

        public void FishyPanel_Paint(object sender, PaintEventArgs e)
        {
            if (FishyPopUp.Visible == true)
            {
                TmrFish.Enabled = false;
                LblText.Visible = true;
                label1.Visible = true;
            }


            if (spring)
            {
                if (redcod == true)
                {
                    if (bluecod == true)
                    {
                        if (snapper == true)
                        {
                            if (gurnard == true)
                            {
                                spring = false;
                                summer = true;
                                displaytype = "Summer";
                                FishyPopUp.Visible = true;
                                MessageBox.Show("Season has changed to summer!" + Environment.NewLine + "New fish are now available!" + Environment.NewLine + Environment.NewLine + "You have obtained the title, 'Novice Baiter'!");
                            }
                        }
                    }
                }
            }
            if (summer)
            {
                if (rockfish == true)
                {
                    if (bluetang == true)
                    {
                        if (squid == true)
                        {
                            if (yellowtang == true)
                            {
                                summer = false;
                                autumn = true;
                                displaytype = "Autumn";
                                MessageBox.Show("Season has changed to autumn!" + Environment.NewLine + "New fish are now available!" + Environment.NewLine + Environment.NewLine + "You have obtained the title, 'Amateur Baiter'!");
                            }
                        }
                    }
                }
            }
            if (autumn)
            {
                if (clownfish == true)
                {
                    if (catfish == true)
                    {
                        if (pinksalmon == true)
                        {
                            if (ringtailunicornfish == true)
                            {
                                autumn = false;
                                winter = true;
                                MessageBox.Show("Season has changed to winter!" + Environment.NewLine + "New fish are now available!" + Environment.NewLine + Environment.NewLine + "You have obtained the title, 'Skilled Baiter'!");
                            }
                        }
                    }
                }
            }
            if (winter)
            {
                if (kingfish == true)
                {
                    if (pufferfish == true)
                    {
                        if (morayeel == true)
                        {
                            if (seaanemone == true)
                            {
                                MessageBox.Show("Congratulations!" + Environment.NewLine + "You have obtained all of the fish available." + Environment.NewLine + Environment.NewLine + "You have obtained the title, 'Master Baiter'!");
                            }
                        }
                    }
                }
            }

            Random random = new Random();
            //get the graphics used to paint on the panel control
            g = e.Graphics;
            //call the Fish class's DrawFish method to draw the image fish1 

            double spacing = 0;

            foreach (Fish f in fish)
            {
                int centre_x = 200, centre_y = 300;
                phi += 0.01;
                f.DrawFish(g, x = radius * Math.Cos(phi + spacing) + centre_x, y = radius * Math.Sin(phi + spacing) + centre_y);
                spacing = spacing + 2;
            }
            rodRec = new Rectangle(200, 240, 5, 5);
            e.Graphics.FillRectangle(Brushes.Black, rodRec);

            foreach (Fish f_this in fish)
            {
                if (TmrWait.Enabled == false)
                {
                    if (rodRec.IntersectsWith(f_this.fishRec))
                    {

                        if (random.Next(0, 100) < 100)
                        {
                            TmrFish.Enabled = false;
                            TmrCatch.Enabled = true;
                            Catch = true;
                        }
                    }
                }
            }
            
            
        }


        public void FishyFrm_Load(object sender, EventArgs e)
        {
            spring = true;
            summer = false;
            autumn = false;
            winter = false;
            bait = 0;
        }

        public void TmrCatch_Tick(object sender, EventArgs e)
        {
            TmrFish.Enabled = true;
            Catch = false;
            TmrCatch.Enabled = false;
            TmrWait.Enabled = true;
        }

        public void TmrWait_Tick(object sender, EventArgs e)
        {
            TmrWait.Enabled = false;
        }

        public void FishyFrm_KeyDown(object sender, KeyEventArgs e)
        {
             Random random = new Random();

                if (Catch)
                {
                   
                    
                        if (e.KeyData == Keys.Space)
                        {

                        if (spring)
                        {  
                            int rand = random.Next(1, 5);
                            if (rand == 1)
                            {
                                redcod = true;
                                FishyPopUp.Visible = true;
                                displaytype = "Redcod";

                        }
                        if (rand == 2)
                            {
                                bluecod = true;
                                FishyPopUp.Visible = true;
                                displaytype = "Bluecod";

                            }
                            if (rand == 3)
                            {
                                snapper = true;
                                FishyPopUp.Visible = true;
                                displaytype = "Snapper";

                        }
                        if (rand == 4)
                            {
                                gurnard = true;
                                FishyPopUp.Visible = true;
                                displaytype = "Gurnard";
                        }
                    }

                        if (summer)
                        {
                            int rand = random.Next(1, 5);
                            if (rand == 1)
                            {
                                rockfish = true;
                                FishyPopUp.Visible = true;
                                displaytype = "Rockfish";
                        }
                            if (rand == 2)
                            {
                                bluetang = true;
                                FishyPopUp.Visible = true;
                                displaytype = "Bluetang";
                        }
                            if (rand == 3)
                            {
                                squid = true;
                                FishyPopUp.Visible = true;
                                displaytype = "Squid";
                        }
                            if (rand == 4)
                            {
                                yellowtang = true;
                                FishyPopUp.Visible = true;
                                displaytype = "Yellowtang";
                        }
                        }

                        if (autumn)
                        {
                            int rand = random.Next(1, 5);
                            if (rand == 1)
                            {
                                clownfish = true;
                                FishyPopUp.Visible = true;
                                displaytype = "Clownfish";
                        }
                            if (rand == 2)
                            {
                                catfish = true;
                                FishyPopUp.Visible = true;
                                displaytype = "Catfish";
                        }
                            if (rand == 3)
                            {
                                pinksalmon = true;
                                FishyPopUp.Visible = true;
                                displaytype = "Pinksalmon";
                        }
                            if (rand == 4)
                            {
                                ringtailunicornfish = true;
                                FishyPopUp.Visible = true;
                                displaytype = "Ringtailunicornfish";
                        }
                        }

                        if (winter)
                        {
                            int rand = random.Next(1, 5);
                            if (rand == 1)
                            {
                                kingfish = true;
                                FishyPopUp.Visible = true;
                                displaytype = "Kingfish";
                        }
                            if (rand == 2)
                            {
                                pufferfish = true;
                                FishyPopUp.Visible = true;
                                displaytype = "Pufferfish";
                        }
                            if (rand == 3)
                            {
                                morayeel = true; 
                                FishyPopUp.Visible = true;
                                displaytype = "Morayeel";
                        }
                            if (rand == 4)
                            {
                                seaanemone = true;
                                FishyPopUp.Visible = true;
                                displaytype = "Seaanemone";
                        }
                        }
                    
                }
            }
            
        }

        public void TmrFish_Tick(object sender, EventArgs e)
        {
            FishyPanel.Invalidate();//makes the paint event fire to redraw the panel
        }
    }
}
