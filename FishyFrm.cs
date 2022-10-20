using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Reflection.Emit;
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
        double x, y; //fish movement
        double phi = 0; //fish speed
        int radius = 80; //fish radius
        int NumberOfFish; // interger to set number of fish
        public int Bait;  //interger for bait/lives
        public string DisplayType = null; //string for the PopUpPanel display
        public Rectangle DisplayFishRec; //rectangle for pop up panel fish display
        public Image DisplayFish;
        private Rectangle RodRec; //variable for a rectangle to place our image in
        private Rectangle TitleRec; //rectangle for title image
        public Rectangle SeasonRec; //rectangle for season title image
        public Rectangle AlertRec;
        public Rectangle InfoRec;
        public Image Title;
        public Image Seasontitle;
        public Image Info;
        public Image Alert;
        public bool stop, success, Catch, time, spring, summer, autumn, winter, redcod, bluecod, snapper, gurnard, rockfish, bluetang, squid, yellowtang, clownfish, catfish, pinksalmon, ringtailunicornfish, kingfish, pufferfish, eel, jellyfish;

        private void InfoBtn_Click(object sender, EventArgs e)
        {
            DisplayType = "Information";
            FishyPopUp.Visible = true;
            this.Focus();
        }
        private void EButton1_Click(object sender, EventArgs e)
        {
                if (DisplayType == "Encyclopedia")
                {
                    DisplayType = "ESpring";
                    BtnTmr.Enabled = true;
                }
                if (time)
                {
                    if (DisplayType == "ESpring")
                    {
                        if (redcod)
                        {
                            EButton1.Visible = false;
                            EButton2.Visible = false;
                            EButton3.Visible = false;
                            EButton4.Visible = false;
                            LblText.Visible = true;
                            LblContinue.Visible = true;                           
                            DisplayType = "Redcod";
                            FishyPopUp.Invalidate();
                        }
                    }
                    if (DisplayType == "ESummer")
                    {
                        if (rockfish)
                        {
                            DisplayType = "Rockfish";
                            EButton1.Visible = false;
                            EButton2.Visible = false;
                            EButton3.Visible = false;
                            EButton4.Visible = false;
                            LblText.Visible = true;
                            LblContinue.Visible = true;
                            FishyPopUp.Invalidate();
                    }
                }
                    if (DisplayType == "EAutumn")
                    {
                        if (clownfish)
                        {
                            DisplayType = "Clownfish";
                            EButton1.Visible = false;
                            EButton2.Visible = false;
                            EButton3.Visible = false;
                            EButton4.Visible = false;
                            LblText.Visible = true;
                            LblContinue.Visible = true;
                            FishyPopUp.Invalidate();
                    }
                }
                    if (DisplayType == "EWinter")
                    {
                        if (kingfish)
                        {
                            DisplayType = "Kingfish";
                            EButton1.Visible = false;
                            EButton2.Visible = false;
                            EButton3.Visible = false;
                            EButton4.Visible = false;
                            LblText.Visible = true;
                            LblContinue.Visible = true;
                            FishyPopUp.Invalidate();

                        }
                    }
                }
        }
        private void EncyclopediaBtn_Click(object sender, EventArgs e)
        {
            DisplayType = "Encyclopedia";
            FishyPopUp.Visible = true;
            this.Focus();
        }
        public void Ebutton4_Click(object sender, EventArgs e)
        {
            if (DisplayType == "Encyclopedia")
            {
                DisplayType = "EWinter";
                BtnTmr.Enabled = true;
            }
            if (time)
            {
                if (DisplayType == "ESpring")
                {
                    if (gurnard)
                    {
                        EButton1.Visible = false;
                        EButton2.Visible = false;
                        EButton3.Visible = false;
                        EButton4.Visible = false;
                        LblText.Visible = true;
                        LblContinue.Visible = true;
                        DisplayType = "Gurnard";
                        FishyPopUp.Invalidate();
                    }
                }
                if (DisplayType == "ESummer")
                {
                    if (yellowtang)
                    {
                        DisplayType = "Yellowtang";
                        EButton1.Visible = false;
                        EButton2.Visible = false;
                        EButton3.Visible = false;
                        EButton4.Visible = false;
                        LblText.Visible = true;
                        LblContinue.Visible = true;
                        FishyPopUp.Invalidate();
                    }
                }
                if (DisplayType == "EAutumn")
                {
                    if (ringtailunicornfish)
                    {
                        DisplayType = "Ringtailunicornfish";
                        EButton1.Visible = false;
                        EButton2.Visible = false;
                        EButton3.Visible = false;
                        EButton4.Visible = false;
                        LblText.Visible = true;
                        LblContinue.Visible = true;
                        FishyPopUp.Invalidate();
                    }
                }
                if (DisplayType == "EWinter")
                {
                    if (jellyfish)
                    {
                        DisplayType = "Jellyfish";
                        EButton1.Visible = false;
                        EButton2.Visible = false;
                        EButton3.Visible = false;
                        EButton4.Visible = false;
                        LblText.Visible = true;
                        LblContinue.Visible = true;
                        FishyPopUp.Invalidate();
                    }
                }
            }
        }
        public void Ebutton3_Click(object sender, EventArgs e)
        {
            if (DisplayType == "Encyclopedia")
            {
                DisplayType = "EAutumn";
                BtnTmr.Enabled = true;
            }
            if (time)
            {
                if (DisplayType == "ESpring")
                {
                    if (snapper)
                    {
                        DisplayType = "Snapper";
                        EButton1.Visible = false;
                        EButton2.Visible = false;
                        EButton3.Visible = false;
                        EButton4.Visible = false;
                        LblText.Visible = true;
                        LblContinue.Visible = true;
                        FishyPopUp.Invalidate();
                    }
                }
                if (DisplayType == "ESummer")
                {
                    if (squid)
                    {
                        DisplayType = "Squid";
                        EButton1.Visible = false;
                        EButton2.Visible = false;
                        EButton3.Visible = false;
                        EButton4.Visible = false;
                        LblText.Visible = true;
                        LblContinue.Visible = true;
                        FishyPopUp.Invalidate();
                    }
                }
                if (DisplayType == "EAutumn")
                {
                    if (pinksalmon)
                    {
                        DisplayType = "Pinksalmon";
                        EButton1.Visible = false;
                        EButton2.Visible = false;
                        EButton3.Visible = false;
                        EButton4.Visible = false;
                        LblText.Visible = true;
                        LblContinue.Visible = true;
                        FishyPopUp.Invalidate();
                    }
                }
                if (DisplayType == "EWinter")
                {
                    if (eel)
                    {
                        DisplayType = "Eel";
                        EButton1.Visible = false;
                        EButton2.Visible = false;
                        EButton3.Visible = false;
                        EButton4.Visible = false;
                        LblText.Visible = true;
                        LblContinue.Visible = true;
                        FishyPopUp.Invalidate();
                    }
                }
            }
        }
        public void BtnTmr_Tick(object sender, EventArgs e)
        {
            time = true;
            BtnTmr.Enabled = false;
        }
        public void Ebutton2_Click(object sender, EventArgs e)
        {
            if (DisplayType == "Encyclopedia")
            {
                DisplayType = "ESummer";
                BtnTmr.Enabled = true;
            }
            if (time)
            {
                if (DisplayType == "ESpring")
                {
                    if (bluecod || success)
                    {
                        DisplayType = "Bluecod";
                        EButton1.Visible = false;
                        EButton2.Visible = false;
                        EButton3.Visible = false;
                        EButton4.Visible = false;
                        LblText.Visible = true;
                        LblContinue.Visible = true;
                        FishyPopUp.Invalidate();
                    }
                }
                if (DisplayType == "ESummer")
                {
                    if (bluetang || success)
                    {
                        DisplayType = "Bluetang";
                        EButton1.Visible = false;
                        EButton2.Visible = false;
                        EButton3.Visible = false;
                        EButton4.Visible = false;
                        LblText.Visible = true;
                        LblContinue.Visible = true;
                        FishyPopUp.Invalidate();
                    }
                }
                if (DisplayType == "EAutumn")
                {
                    if (catfish || success)
                    {
                        DisplayType = "Catfish";
                        EButton1.Visible = false;
                        EButton2.Visible = false;
                        EButton3.Visible = false;
                        EButton4.Visible = false;
                        LblText.Visible = true;
                        LblContinue.Visible = true;
                        FishyPopUp.Invalidate();
                    }
                }
                if (DisplayType == "EWinter")
                {
                    if (pufferfish || success)
                    {
                        DisplayType = "Pufferfish";
                        EButton1.Visible = false;
                        EButton2.Visible = false;
                        EButton3.Visible = false;
                        EButton4.Visible = false;
                        LblText.Visible = true;
                        LblContinue.Visible = true;
                        FishyPopUp.Invalidate();
                    }
                }
            }
        }
        private void GeneralClick(object sender, EventArgs e)
        {
            if (FishyPopUp.Visible == true)
            {
                FishyPopUp.Visible = false;
                TmrFish.Enabled = true;
                DisplayType = null;
                LblNew.Visible = false;
                TmrWait.Enabled = false;
                TmrWait.Enabled = true;
                LblText.Visible = true;
                LblInfo.Visible = false;
                EButton1.Visible = false;
                EButton2.Visible = false;
                EButton3.Visible = false;
                EButton4.Visible = false;
                LblText.Text = "";
                LblContinue.Visible = true;
                EncyclopediaBtn.TabStop = false;
                InfoBtn.TabStop = false;
                time = false;
                CheckSeason();
            }
            
        }
        public void CheckBait()
        {
            if (Bait == 0)
            {
                DisplayType = "Failure";
                FishyPopUp.Visible = true;
            }
        }
        public void CheckSeason() //does the same thing for each season
        {
            if (redcod && bluecod && gurnard && snapper && spring) //if it is currently spring and all fish have been caught
            {
                DisplayType = "Summer"; //show the player that it is summer
                FishyPopUp.Visible = true;
                spring = false; //change season
                summer = true;  //change season
                Seasontitle = Properties.Resources.Summer; //display summer image
                TmrCatch.Interval = 2500; //make fish harder to catch
            }
            if (rockfish && bluetang && squid && yellowtang && summer)
            {
                DisplayType = "Autumn";
                FishyPopUp.Visible = true;
                summer = false;
                autumn = true;
                Seasontitle = Properties.Resources.Autumn;
                TmrCatch.Interval = 2000;
            }
            if (clownfish && catfish && pinksalmon && ringtailunicornfish && autumn)
            {
                DisplayType = "Winter";
                FishyPopUp.Visible = true;
                autumn = false;
                winter = true;
                Seasontitle = Properties.Resources.Winter;
                TmrCatch.Interval = 1000;

            }
            if (kingfish && pufferfish && eel && jellyfish && winter)
            {
                DisplayType = "Success";
                FishyPopUp.Visible = true;
                Seasontitle = Properties.Resources.Spring;
                winter = false;
                success = true;
                spring = true; //set all fish types back to false to be able to progress through the seasons again
                redcod = false;
                bluecod = false;
                snapper = false;
                gurnard = false;
                rockfish = false;
                bluetang = false;
                squid = false;
                yellowtang = false;
                clownfish = false;
                catfish = false;
                pinksalmon = false;
                ringtailunicornfish = false;
                kingfish = false;
                pufferfish = false;
                eel = false;
                jellyfish = false;
            }
        }
        public void FishyPopUp_Paint(object sender, PaintEventArgs e)
        {
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, FishyPopUp, new object[] { true });

            Graphics g2 = e.Graphics; //declare new graphics object
            DisplayFishRec = new Rectangle(60, 60, 100, 100);
            if (DisplayType == "Snapper")
            {
                if (snapper == false) { LblNew.Visible = true; }
                LblText.Text = "You caught a snapper!";
                DisplayFish = Properties.Resources.Snapper; 
                g2.DrawImage(DisplayFish, DisplayFishRec);
                snapper = true;
            }
            if (DisplayType == "Redcod")
            {
                if (redcod == false) { LblNew.Visible = true; }
                LblText.Text = "You caught a red cod!";
                DisplayFish = Properties.Resources.Red_cod;
                g2.DrawImage(DisplayFish, DisplayFishRec);
                redcod = true;
            }
            if (DisplayType == "Bluecod")
            {
                if (bluecod == false) { LblNew.Visible = true; }
                LblText.Text = "You caught a blue cod!";
                DisplayFish = Properties.Resources.Blue_cod;
                g2.DrawImage(DisplayFish, DisplayFishRec);
                bluecod = true;
            }
            if (DisplayType == "Gurnard")
            {
                if (gurnard == false) { LblNew.Visible = true; }
                LblText.Text = "You caught a gurnard!";
                DisplayFish = Properties.Resources.Gurnard;
                g2.DrawImage(DisplayFish, DisplayFishRec);
                gurnard = true;
            }
            if (DisplayType == "Summer")
            {
                LblText.Text = "It is now summer!" + Environment.NewLine + " You are now a novice baiter!" + Environment.NewLine+ "" + Environment.NewLine + "New fish are now available, but they are more aware" + Environment.NewLine + "of your presence. They will be faster and you will have" + Environment.NewLine + "less time to catch them.";
            }
            if (DisplayType == "Rockfish")
            {
                if (rockfish == false) { LblNew.Visible = true; }
                LblText.Text = "You caught a rockfish!";
                DisplayFish = Properties.Resources.Rockfish;
                g2.DrawImage(DisplayFish, DisplayFishRec);
                rockfish = true;
            }
            if (DisplayType == "Bluetang")
            {
                if (bluetang == false) { LblNew.Visible = true; }
                LblText.Text = "You caught a blue tang!";
                DisplayFish = Properties.Resources.Blue_tang;
                g2.DrawImage(DisplayFish, DisplayFishRec);
                bluetang = true;
            }
            if (DisplayType == "Squid")
            {
                if (squid == false) { LblNew.Visible = true; }
                LblText.Text = "You caught a squid!";
                DisplayFish = Properties.Resources.Squid;
                g2.DrawImage(DisplayFish, DisplayFishRec);
                squid = true;
            }
            if (DisplayType == "Yellowtang")
            {
                if (yellowtang == false) { LblNew.Visible = true; }
                LblText.Text = "You caught a yellow tang!";
                DisplayFish = Properties.Resources.Yellow_Tang;
                g2.DrawImage(DisplayFish, DisplayFishRec);
                yellowtang = true;
            }
            if (DisplayType == "Autumn")
            {
                LblText.Text = "It is now Autumn!" + Environment.NewLine + " You are now a amateur baiter!" + Environment.NewLine + "" + Environment.NewLine + "New fish are now available, but they are more aware" + Environment.NewLine + "of your presence. They will be faster and you will have" + Environment.NewLine + "less time to catch them.";

            }
            if (DisplayType == "Clownfish")
            {
                if (clownfish == false) { LblNew.Visible = true; }
                LblText.Text = "You caught a clownfish!";
                DisplayFish = Properties.Resources.Clownfish;
                g2.DrawImage(DisplayFish, DisplayFishRec);
                clownfish = true;
            }
            if (DisplayType == "Catfish")
            {
                if (catfish == false) { LblNew.Visible = true; }
                LblText.Text = "You caught a catfish!";
                DisplayFish = Properties.Resources.Catfish;
                g2.DrawImage(DisplayFish, DisplayFishRec);
                catfish = true;
            }
            if (DisplayType == "Pinksalmon")
            {
                if (pinksalmon == false) { LblNew.Visible = true; }
                LblText.Text = "You caught a pink salmon!";
                DisplayFish = Properties.Resources.Pink_Salmon;
                g2.DrawImage(DisplayFish, DisplayFishRec);
                pinksalmon = true;
            }
            if (DisplayType == "Ringtailunicornfish")
            {
                if (ringtailunicornfish == false) { LblNew.Visible = true; }
                LblText.Text = "You caught a ringtail unicornfish!";
                DisplayFish = Properties.Resources.Ringtail_Unicornfish;
                g2.DrawImage(DisplayFish, DisplayFishRec);
                ringtailunicornfish = true;
            }
            if (DisplayType == "Winter")
            {
                LblText.Text = "It is now Winter!" + Environment.NewLine + " You are now a professional baiter!" + Environment.NewLine + "" + Environment.NewLine + "New fish are now available, but they are more aware" + Environment.NewLine + "of your presence. They will be faster and you will have" + Environment.NewLine + "less time to catch them.";
            }
            if (DisplayType == "Kingfish")
            {
                if (kingfish == false) { LblNew.Visible = true; }
                LblText.Text = "You caught a kingfish!";
                DisplayFish = Properties.Resources.Kingfish;
                g2.DrawImage(DisplayFish, DisplayFishRec);
                kingfish = true;
            }
            if (DisplayType == "Pufferfish")
            {
                if (pufferfish == false) { LblNew.Visible = true; }
                LblText.Text = "You caught a pufferfish!";
                DisplayFish = Properties.Resources.Pufferfish;
                g2.DrawImage(DisplayFish, DisplayFishRec);
                pufferfish = true;
            }
            if (DisplayType == "Eel")
            {
                if (eel == false) { LblNew.Visible = true; }
                LblText.Text = "You caught an eel!";
                DisplayFish = Properties.Resources.Eel;
                g2.DrawImage(DisplayFish, DisplayFishRec);
                eel = true;
            }
            if (DisplayType == "Jellyfish")
            {
                if (jellyfish == false) { LblNew.Visible = true; }
                LblText.Text = "You caught a jellyfish!";
                DisplayFish = Properties.Resources.jellyfish;
                g2.DrawImage(DisplayFish, DisplayFishRec);
                jellyfish = true;
            }
            if (DisplayType == "Success")
            {
                LblText.Text = "You have caught all fish!" + Environment.NewLine + " You are now a master baiter!";

            }
            if (DisplayType == "Information")
            {
                LblInfo.Visible = true;
                LblInfo.Text = "Your aim is to become a master fisher and catch every single fish. Each" + Environment.NewLine + 
                    "season has four different fish to catch, the season will change after you have" + Environment.NewLine + "caught all available fish. " +
                    "Make sure to not run out of bait though! Duplicate fish" + Environment.NewLine + "can be used to create more bait."
                    + Environment.NewLine + "" + Environment.NewLine + "You can view all fish you have caught in your encyclopedia by pressing E"
                    + Environment.NewLine + "or clicking on the encyclopaedia button." + Environment.NewLine + "" + Environment.NewLine +
                    "As you continue through the seasons, the fish will become more aware of your" + Environment.NewLine + "presence, and you'll have" +
                    " less time to catch them. When you see a ( ! ), press the" + Environment.NewLine + "space bar to catch the fish." + Environment.NewLine +
                    "" + Environment.NewLine + "You can view all this information again by pressing ( i ).";
            }
            if (DisplayType == "Encyclopedia")
            {
                EButton1.Visible = true;
                EButton2.Visible = true;
                EButton3.Visible = true;
                EButton4.Visible = true;
                LblText.Visible = false;
                LblContinue.Visible = false;
                EButton1.Text = "Spring";
                EButton2.Text = "Summer";
                EButton3.Text = "Autumn";
                EButton4.Text = "Winter";
            }
            if (DisplayType == "ESpring")
            {
                if (redcod)
                {
                    EButton1.Text = "Red Cod";
                }
                else
                {
                    EButton1.Text = "???";
                }
                if (bluecod)
                {
                    EButton2.Text = "Blue Cod";
                }
                else
                {
                    EButton2.Text = "???";
                }
                if (snapper)
                {
                    EButton3.Text = "Snapper";
                }
                else
                {
                    EButton3.Text = "???";
                }
                if (gurnard)
                {
                    EButton4.Text = " Gurnard";
                }
                else
                {
                    EButton4.Text = "???";
                }
            }
            if (DisplayType == "ESummer")
            {
                if (rockfish)
                {
                    EButton1.Text = "Rockfish";
                }
                else
                {
                    EButton1.Text = "???";
                }
                if (bluetang)
                {
                    EButton2.Text = "Blue Tang";
                }
                else
                {
                    EButton2.Text = "???";
                }
                if (squid)
                {
                    EButton3.Text = "Squid";
                }
                else
                {
                    EButton3.Text = "???";
                }
                if (yellowtang)
                {
                    EButton4.Text = "Yellow Tang";
                }
                else
                {
                    EButton4.Text = "???";
                }
            }
            if (DisplayType == "EAutumn")
            {
                if (clownfish)
                {
                    EButton1.Text = "Clownfish";
                }
                else
                {
                    EButton1.Text = "???";
                }
                if (catfish)
                {
                    EButton2.Text = "Catfish";
                }
                else
                {
                    EButton2.Text = "???";
                }
                if (pinksalmon)
                {
                    EButton3.Text = "Pink Salmon";
                }
                else
                {
                    EButton3.Text = "???";
                }
                if (ringtailunicornfish)
                {
                    EButton4.Text = "Ringtail unicornfish";
                }
                else
                {
                    EButton4.Text = "???";
                }
            }
            if (DisplayType == "EWinter")
            {
                if (rockfish)
                {
                    EButton1.Text = "Kingfish";
                }
                else
                {
                    EButton1.Text = "???";
                }
                if (bluetang)
                {
                    EButton2.Text = "Pufferfish";
                }
                else
                {
                    EButton2.Text = "???";
                }
                if (squid)
                {
                    EButton3.Text = "Eel";
                }
                else
                {
                    EButton3.Text = "???";
                }
                if (yellowtang)
                {
                    EButton4.Text = "Jellyfish";
                }
                else
                {
                    EButton4.Text = "???";
                }
            }
            if (DisplayType == "Failure")
            {
                //get your label text
                //string PlayerName = LblText.Text;
                //Your new text here
                //string NewText = "You have run out of bait ";
                //Concatenate your new sting with label text
                //LblText.Text = string.Format("{0} {1}", NewText, PlayerName);
                LblText.Text = "You have run out of bait..." + Environment.NewLine + "Better luck next time!" + Environment.NewLine + "";
                FishyPanel.Enabled = false;
                FishyPopUp.Enabled = false;
                LblContinue.Visible = false;
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
            //stopping everything on FishyPanel when PopUp is visible
            if (FishyPopUp.Visible == true) 
            {
                TmrFish.Enabled = false;
                Catch = false;
                TmrCatch.Enabled = false;
                FishyPopUp.Enabled = true;
            }
            else
            {
                TmrFish.Enabled = true;
                FishyPopUp.Enabled = false;
            }
            Graphics g3 = e.Graphics; //graphics object
            //title and season title images
            TitleRec = new Rectangle(300, 50, 350, 100);
            Title = Properties.Resources.Title;
            g3.DrawImage(Title, TitleRec);
            SeasonRec = new Rectangle(450, 150, 200, 50);
            g3.DrawImage(Seasontitle, SeasonRec);

            Random random = new Random();
            //get the graphics used to paint on the panel control
            g = e.Graphics;
            //call the Fish class's DrawFish method to draw the image fish1 

            double spacing = 0;

            foreach (Fish f in fish)
            {
                //creating the circle for the fish
                int centre_x = 160, centre_y = 265;
                if (spring)
                {
                    phi += 0.01; //changes speed of the fish
                }
                if (summer)
                {
                    phi += 0.015; //changes speed of the fish
                }
                if (autumn)
                {
                    phi += 0.03; //changes speed of the fish
                }
                if (winter)
                {
                    phi += 0.05; //changes speed of the fish
                }
                f.DrawFish(g, x = radius * Math.Cos(phi + spacing) + centre_x, y = radius * Math.Sin(phi + spacing) + centre_y);
                spacing = spacing + 2;
            }

            RodRec = new Rectangle(100, 240, 5, 5);

            foreach (Fish f_this in fish) // for each fish in the array
            {
                if (TmrWait.Enabled == false) // if the timer is up
                { 
                    if (RodRec.IntersectsWith(f_this.FishRec)) //if the fish is on the rod
                    {
                        if (random.Next(0, 100) < 100) // random chance for the fish to be "caught" currently set at 100% for testing
                        {
                            AlertRec = new Rectangle(120, 200, 50, 50);
                            Alert = Properties.Resources.Alert;
                            g3.DrawImage(Alert, AlertRec);
                            TmrCatch.Enabled = true;
                            TmrFish.Enabled = false;
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
            Bait = 10;
            LblBait.Text = Bait.ToString();
        }
        public void TmrCatch_Tick(object sender, EventArgs e)
        {
            TmrFish.Enabled = true;
            Catch = false;
            TmrCatch.Enabled = false;
            TmrWait.Enabled = true;
            Bait -= 1;
            LblBait.Text = Bait.ToString();
            CheckBait();
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
                DisplayType = "Information";
                FishyPopUp.Visible = true;
            }
            if (e.KeyData == Keys.E)
            {
                FishyPopUp.Visible = true;
                DisplayType = "Encyclopedia"; 
                
            }
            if (FishyPopUp.Visible == false)
            { 
                    if (e.KeyData == Keys.Space)
                    {
                    Bait -= 1; //take away one bait
                    LblBait.Text = Bait.ToString();
                    CheckBait();

                    if (Catch)
                    {
                        Catch = false;
                        TmrWait.Enabled = true;
                        Bait += 2;
                        LblBait.Text = Bait.ToString();
                        if (spring)
                        {
                            int rand = random.Next(1, 5);
                            if (rand == 1)
                            {
                                FishyPopUp.Visible = true;
                                DisplayType = "Redcod";

                            }
                            if (rand == 2)
                            {
                                FishyPopUp.Visible = true;
                                DisplayType = "Bluecod"; ;

                            }
                            if (rand == 3)
                            {
                                FishyPopUp.Visible = true;
                                DisplayType = "Snapper";

                            }
                            if (rand == 4)
                            {
                                FishyPopUp.Visible = true;
                                DisplayType = "Gurnard";
                            }
                        }

                        if (summer)
                        {
                            int rand = random.Next(1, 5);
                            if (rand == 1)
                            {
                                rockfish = true;
                                FishyPopUp.Visible = true;
                                DisplayType = "Rockfish";
                            }
                            if (rand == 2)
                            {
                                bluetang = true;
                                FishyPopUp.Visible = true;
                                DisplayType = "Bluetang";
                            }
                            if (rand == 3)
                            {
                                squid = true;
                                FishyPopUp.Visible = true;
                                DisplayType = "Squid";
                            }
                            if (rand == 4)
                            {
                                yellowtang = true;
                                FishyPopUp.Visible = true;
                                DisplayType = "Yellowtang";
                            }
                        }

                        if (autumn)
                        {
                            int rand = random.Next(1, 5);
                            if (rand == 1)
                            {
                                clownfish = true;
                                FishyPopUp.Visible = true;
                                DisplayType = "Clownfish";
                            }
                            if (rand == 2)
                            {
                                catfish = true;
                                FishyPopUp.Visible = true;
                                DisplayType = "Catfish";
                            }
                            if (rand == 3)
                            {
                                pinksalmon = true;
                                FishyPopUp.Visible = true;
                                DisplayType = "Pinksalmon";
                            }
                            if (rand == 4)
                            {
                                ringtailunicornfish = true;
                                FishyPopUp.Visible = true;
                                DisplayType = "Ringtailunicornfish";
                            }
                        }

                        if (winter)
                        {
                            int rand = random.Next(1, 5);
                            if (rand == 1)
                            {
                                kingfish = true;
                                FishyPopUp.Visible = true;
                                DisplayType = "Kingfish";
                            }
                            if (rand == 2)
                            {
                                pufferfish = true;
                                FishyPopUp.Visible = true;
                                DisplayType = "Pufferfish";
                            }
                            if (rand == 3)
                            {
                                eel = true;
                                FishyPopUp.Visible = true;
                                DisplayType = "Eel";
                            }
                            if (rand == 4)
                            {
                                jellyfish = true;
                                FishyPopUp.Visible = true;
                                DisplayType = "Jellyfish";
                            }
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

