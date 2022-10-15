using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
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
        public string displaytype = null;
        public Rectangle displayfishRec;
        public Image displayfish;
        private Rectangle rodRec;//variable for a rectangle to place our image in
        private Rectangle titleRec;
        public Rectangle seasonRec;
        private Rectangle RecE1; //encyclopaedia box 1
        private Rectangle RecE2; //encyclopaedia box 2
        private Rectangle RecE3; //encyclopaedia box 3
        private Rectangle RecE4; //encyclopaedia box 4
        public Image Title;
        public Image Seasontitle;
        bool success, Catch, spring, summer, autumn, winter, redcod, bluecod, snapper, gurnard, rockfish, bluetang, squid, yellowtang, clownfish, catfish, pinksalmon, ringtailunicornfish, kingfish, pufferfish, eel, jellyfish;


        private void GeneralClick(object sender, EventArgs e)
        {
            if (FishyPopUp.Visible == true)
            {
                FishyPopUp.Visible = false;
                TmrFish.Enabled = true;
                displaytype = null;
                LblNew.Visible = false;
                TmrWait.Enabled = false;
                TmrWait.Enabled = true;
                LblText.Visible = true;
                LblInfo.Visible = false;
                checkSeason();
            }
        }


        public void checkSeason()
        {
            if (redcod && bluecod && gurnard && snapper && spring)
            {
                displaytype = "Summer";
                FishyPopUp.Visible = true;
                spring = false;
                summer = true;
                Seasontitle = Properties.Resources.Summer;
                TmrCatch.Interval = 2500;
            }
            if (rockfish && bluetang && squid && yellowtang && summer)
            {
                displaytype = "Autumn";
                FishyPopUp.Visible = true;
                summer = false;
                autumn = true;
                Seasontitle = Properties.Resources.Autumn;
                TmrCatch.Interval = 2000;
            }
            if (clownfish && catfish && pinksalmon && ringtailunicornfish && autumn)
            {
                displaytype = "Winter";
                FishyPopUp.Visible = true;
                autumn = false;
                winter = true;
                Seasontitle = Properties.Resources.Winter;
                TmrCatch.Interval = 1000;

            }
            if (kingfish && pufferfish && eel && jellyfish && winter)
            {
                displaytype = "Success";
                FishyPopUp.Visible = true;
                winter = false;
                success = true;
                spring = true;
            }
        }

        public void FishyPopUp_Paint(object sender, PaintEventArgs e)
        {
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, FishyPopUp, new object[] { true });

            Graphics g2 = e.Graphics;

            displayfishRec = new Rectangle(60, 60, 100, 100);

            
            if (displaytype == "Snapper")
            {
                if (snapper == false) { LblNew.Visible = true; }
                LblText.Text = "You caught a snapper!";
                displayfish = Properties.Resources.Snapper; 
                g2.DrawImage(displayfish, displayfishRec);
                snapper = true;
            }
            if (displaytype == "Redcod")
            {
                if (redcod == false) { LblNew.Visible = true; }
                LblText.Text = "You caught a red cod!";
                displayfish = Properties.Resources.Red_cod;
                g2.DrawImage(displayfish, displayfishRec);
                redcod = true;
            }
            if (displaytype == "Bluecod")
            {
                if (bluecod == false) { LblNew.Visible = true; }
                LblText.Text = "You caught a blue cod!";
                displayfish = Properties.Resources.Blue_cod;
                g2.DrawImage(displayfish, displayfishRec);
                bluecod = true;
            }
            if (displaytype == "Gurnard")
            {
                if (gurnard == false) { LblNew.Visible = true; }
                LblText.Text = "You caught a gurnard!";
                displayfish = Properties.Resources.Gurnard;
                g2.DrawImage(displayfish, displayfishRec);
                gurnard = true;
            }
            if (displaytype == "Summer")
            {
                LblText.Text = "It is now summer!";
            }
            if (displaytype == "Rockfish")
            {
                if (rockfish == false) { LblNew.Visible = true; }
                LblText.Text = "You caught a rockfish!";
                displayfish = Properties.Resources.Rockfish;
                g2.DrawImage(displayfish, displayfishRec);
                rockfish = true;
            }
            if (displaytype == "Bluetang")
            {
                if (bluetang == false) { LblNew.Visible = true; }
                LblText.Text = "You caught a blue tang!";
                displayfish = Properties.Resources.Blue_tang;
                g2.DrawImage(displayfish, displayfishRec);
                bluetang = true;
            }
            if (displaytype == "Squid")
            {
                if (squid == false) { LblNew.Visible = true; }
                LblText.Text = "You caught a squid!";
                displayfish = Properties.Resources.Squid;
                g2.DrawImage(displayfish, displayfishRec);
                squid = true;
            }
            if (displaytype == "Yellowtang")
            {
                if (yellowtang == false) { LblNew.Visible = true; }
                LblText.Text = "You caught a yellow tang!";
                displayfish = Properties.Resources.Yellow_Tang;
                g2.DrawImage(displayfish, displayfishRec);
                yellowtang = true;
            }
            if (displaytype == "Autumn")
            {
                LblText.Text = "It is now Autumn!";
            }
            if (displaytype == "Clownfish")
            {
                if (clownfish == false) { LblNew.Visible = true; }
                LblText.Text = "You caught a clownfish!";
                displayfish = Properties.Resources.Clownfish;
                g2.DrawImage(displayfish, displayfishRec);
                clownfish = true;
            }
            if (displaytype == "Catfish")
            {
                if (catfish == false) { LblNew.Visible = true; }
                LblText.Text = "You caught a catfish!";
                displayfish = Properties.Resources.Catfish;
                g2.DrawImage(displayfish, displayfishRec);
                catfish = true;
            }
            if (displaytype == "Pinksalmon")
            {
                if (pinksalmon == false) { LblNew.Visible = true; }
                LblText.Text = "You caught a pink salmon!";
                displayfish = Properties.Resources.Pink_Salmon;
                g2.DrawImage(displayfish, displayfishRec);
                pinksalmon = true;
            }
            if (displaytype == "Ringtailunicornfish")
            {
                if (ringtailunicornfish == false) { LblNew.Visible = true; }
                LblText.Text = "You caught a ringtail unicornfish!";
                displayfish = Properties.Resources.Ringtail_Unicornfish;
                g2.DrawImage(displayfish, displayfishRec);
                ringtailunicornfish = true;
            }
            if (displaytype == "Winter")
            {
                LblText.Text = "It is now Winter!";
            }
            if (displaytype == "Kingfish")
            {
                if (kingfish == false) { LblNew.Visible = true; }
                LblText.Text = "You caught a kingfish!";
                displayfish = Properties.Resources.Kingfish;
                g2.DrawImage(displayfish, displayfishRec);
                kingfish = true;
            }
            if (displaytype == "Pufferfish")
            {
                if (pufferfish == false) { LblNew.Visible = true; }
                LblText.Text = "You caught a pufferfish!";
                displayfish = Properties.Resources.Pufferfish;
                g2.DrawImage(displayfish, displayfishRec);
                pufferfish = true;
            }
            if (displaytype == "Eel")
            {
                if (eel == false) { LblNew.Visible = true; }
                LblText.Text = "You caught an eel!";
                displayfish = Properties.Resources.Eel;
                g2.DrawImage(displayfish, displayfishRec);
                eel = true;
            }
            if (displaytype == "Jellyfish")
            {
                if (jellyfish == false) { LblNew.Visible = true; }
                LblText.Text = "You caught a jellyfish!";
                displayfish = Properties.Resources.jellyfish;
                g2.DrawImage(displayfish, displayfishRec);
                jellyfish = true;
            }
            if (displaytype == "Success")
            {
                LblText.Text = "You have caught all fish!";
            }
            if (displaytype == "Information")
            {
                LblInfo.Text = "Your aim is to become a master fisher and catch every single fish. Each" + Environment.NewLine + 
                    "season has four different fish to catch, the season will change after you have" + Environment.NewLine + "caught all available fish. " +
                    "Make sure to not run out of bait though! Duplicate fish" + Environment.NewLine + "can be used to create more bait."
                    + Environment.NewLine + "" + Environment.NewLine + "You can view all fish you have caught in your encyclopedia by pressing E"
                    + Environment.NewLine + "or clicking on the encyclopaedia button." + Environment.NewLine + "" + Environment.NewLine +
                    "As you continue through the seasons, the fish will become more aware of your" + Environment.NewLine + "presence, and you'll have" +
                    " less time to catch them. When you see a ( ! ), press the" + Environment.NewLine + "space bar to catch the fish." + Environment.NewLine +
                    "" + Environment.NewLine + "You can view all this information again by pressing ( i ).";
                ;
            }
            if (displaytype == "Encyclopedia")
            {
                RecE1 = new Rectangle (20, 20, 190, 90);
                g2.FillRectangle(Brushes.Pink, RecE1);
                
                RecE2 = new Rectangle(240, 20, 190, 90);
                g2.FillRectangle(Brushes.LightGreen, RecE2);

                RecE3 = new Rectangle(20, 140, 190, 90);
                g2.FillRectangle(Brushes.DarkOrange, RecE3);

                RecE4 = new Rectangle(240, 140, 190, 90);
                g2.FillRectangle(Brushes.LightBlue, RecE4);

                
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
                LblContinue.Visible = true;
                Catch = false;
                TmrCatch.Enabled = false;
            }
            Graphics g3 = e.Graphics; //graphics object

            //title and season title images
            titleRec = new Rectangle(300, 50, 350, 100);
            Title = Properties.Resources.Title;
            g3.DrawImage(Title, titleRec);
            seasonRec = new Rectangle(450, 150, 200, 50);
            g3.DrawImage(Seasontitle, seasonRec);

            Random random = new Random();
            //get the graphics used to paint on the panel control
            g = e.Graphics;
            //call the Fish class's DrawFish method to draw the image fish1 

            double spacing = 0;

            foreach (Fish f in fish)
            {
                //creating the circle for the fish
                int centre_x = 200, centre_y = 300;
                phi += 0.01;
                f.DrawFish(g, x = radius * Math.Cos(phi + spacing) + centre_x, y = radius * Math.Sin(phi + spacing) + centre_y);
                spacing = spacing + 2;
            }

            rodRec = new Rectangle(200, 240, 5, 5);
            e.Graphics.FillRectangle(Brushes.Black, rodRec);

            foreach (Fish f_this in fish) // this stops the fish and ensures that the fish can be caught. 
            {
                if (TmrWait.Enabled == false)
                {
                    if (rodRec.IntersectsWith(f_this.fishRec))
                    {

                        if (random.Next(0, 100) < 100) // random chance for the fish to be "caught" currently set at 100% for testing
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
            success = false;
            Seasontitle = Properties.Resources.Spring;
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
            if (FishyPopUp.Visible == false)
            {
                TmrWait.Enabled = false;
            }
        }

        public void FishyFrm_KeyDown(object sender, KeyEventArgs e)
        {
             Random random = new Random();
            if (e.KeyData == Keys.I)
            {
                displaytype = "Information";
                FishyPopUp.Visible = true;
            }
            if (e.KeyData == Keys.E)
            {
                displaytype = "Encyclopedia"; 
                FishyPopUp.Visible = true;
            }
            if (Catch)
                {
                   
                    
                        if (e.KeyData == Keys.Space)
                        {

                        if (spring)
                        {  
                            int rand = random.Next(1, 5);
                            if (rand == 1)
                            {
                                FishyPopUp.Visible = true;
                                displaytype = "Redcod";

                        }
                        if (rand == 2)
                            {
                                FishyPopUp.Visible = true;
                                displaytype = "Bluecod";;

                        }
                            if (rand == 3)
                            {
                                FishyPopUp.Visible = true;
                                displaytype = "Snapper";

                        }
                        if (rand == 4)
                            {
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
                                eel = true; 
                                FishyPopUp.Visible = true;
                                displaytype = "Eel";
                        }
                            if (rand == 4)
                            {
                                jellyfish = true;
                                FishyPopUp.Visible = true;
                                displaytype = "Jellyfish";
                            }
                        }
                    
                }
            }
            
        }

        public void TmrFish_Tick(object sender, EventArgs e)
        {
            FishyPanel.Invalidate();//makes the paint event fire to redraw the panel
        }
        private void FishyFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
        }
    }
}

