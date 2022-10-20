using System;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
        public Rectangle AlertRec; //rectangle for (!)
        public Rectangle InfoRec;//rectangle for (i)
        public Image Title; //title image
        public Image Seasontitle; //season image
        public Image Info; //info button image
        public Image Alert;//(!) image
        bool success, Catch, time, spring, summer, autumn, winter, redcod, bluecod, snapper, gurnard, rockfish, bluetang, squid, yellowtang, clownfish, catfish, pinksalmon, ringtailunicornfish, kingfish, pufferfish, eel, jellyfish;

        private void InfoBtn_Click(object sender, EventArgs e)
        {
            DisplayType = "Information"; //shows instructions
            FishyPopUp.Visible = true;
        }
        private void EButton1_Click(object sender, EventArgs e)
        {
            if (DisplayType == "Encyclopedia") //if button is clicked then change to spring display
            {
                DisplayType = "ESpring";
                BtnTmr.Enabled = true;
            }
            if (time) //time from BtnTmr to stop clicking twice
            {
                if (DisplayType == "ESpring")
                {
                    if (redcod)
                    {
                        EButton1.Visible = false;
                        EButton2.Visible = false; //removes buttons
                        EButton3.Visible = false;
                        EButton4.Visible = false;
                        LblText.Visible = true;
                        LblContinue.Visible = true;
                        DisplayType = "Redcod"; //shows red cod display
                        FishyPopUp.Invalidate(); //invalidates panel to redraw
                    }                            //same below
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
            DisplayType = "Encyclopedia"; //Changes display
            FishyPopUp.Visible = true;
        }
        public void Ebutton4_Click(object sender, EventArgs e)
        {
            if (DisplayType == "Encyclopedia") //changes display
            {
                DisplayType = "EWinter";
                BtnTmr.Enabled = true;
            }
            if (time) //timer to stop double clicking
            {
                if (DisplayType == "ESpring") //changes displaytype
                {
                    if (gurnard)
                    {
                        EButton1.Visible = false;
                        EButton2.Visible = false;
                        EButton3.Visible = false; //removes buttons
                        EButton4.Visible = false; //and redraws panel with fish
                        LblText.Visible = true;
                        LblContinue.Visible = true;
                        DisplayType = "Gurnard";
                        FishyPopUp.Invalidate(); //same below
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
            if (DisplayType == "Encyclopedia") //same as other buttons
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
            time = true; //time bool to stop double clicking
            BtnTmr.Enabled = false;
        }
        public void Ebutton2_Click(object sender, EventArgs e)
        {
            if (DisplayType == "Encyclopedia") //same as other buttons
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
            if (FishyPopUp.Visible == true) //if panel is visible and clicked on
            {
                FishyPopUp.Visible = false; //remove panel
                TmrFish.Enabled = true; //start game again
                DisplayType = null; //string type = null
                LblNew.Visible = false;
                TmrWait.Enabled = false; //reset timer
                TmrWait.Enabled = true;
                LblText.Visible = true;
                LblInfo.Visible = false;
                EButton1.Visible = false;
                EButton2.Visible = false; //clearing labels and buttons
                EButton3.Visible = false;
                EButton4.Visible = false;
                LblText.Text = "";
                LblContinue.Visible = true;
                EncyclopediaBtn.TabStop = false;
                InfoBtn.TabStop = false;
                time = false;
                CheckSeason(); //check season
            }

        }
        public void CheckBait()
        {
            if (Bait == 0)
            {
                DisplayType = "Failure";
                FishyPopUp.Visible = true; //checking bait to "lose" the game
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
                success = true; //success allows fish to still be seen in encyclopedia
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
            //all fish are the same
            if (DisplayType == "Snapper") //if snapper is shown
            {
                if (snapper == false) { LblNew.Visible = true; } //if it has not been caught then display the correct label
                LblText.Text = "You caught a snapper!"; //change text
                DisplayFish = Properties.Resources.Snapper; //set image to snapper
                g2.DrawImage(DisplayFish, DisplayFishRec); //draw image
                snapper = true; //snapper has been caught
            } //same as rest
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
                //summer text
                LblText.Text = "It is now summer!" + Environment.NewLine + " You are now a novice baiter!" + Environment.NewLine + "" + Environment.NewLine + "New fish are now available, but they are more aware" + Environment.NewLine + "of your presence. They will be faster and you will have" + Environment.NewLine + "less time to catch them.";
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
                //autumn text
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
                //shown when game finishes
                LblText.Text = "You have caught all fish!" + Environment.NewLine + " You are now a master baiter!";

            }
            if (DisplayType == "Information")
            {
                //display instructions again
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
                EButton1.Visible = true; //show buttons
                EButton2.Visible = true;
                EButton3.Visible = true;
                EButton4.Visible = true;
                LblText.Visible = false;
                LblContinue.Visible = false;
                EButton1.Text = "Spring";
                EButton2.Text = "Summer"; //change text
                EButton3.Text = "Autumn";
                EButton4.Text = "Winter";
            }
            if (DisplayType == "ESpring")
            {
                //this is all just if the fish is caught then it is shown, if not then text is ???
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
                LblText.Text = "You have run out of bait..." + Environment.NewLine + "Better luck next time!" + Environment.NewLine + "";
                FishyPanel.Enabled = false;
                FishyPopUp.Enabled = false; //disable panels so that the player cannot continue
                LblContinue.Visible = false;
            }
        }
        public FishyFrm()
        {
            InitializeComponent();

            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, FishyPanel, new object[] { true });

            NumberOfFish = fish.Count(); //when form is loaded set starting positions of fish
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
                    phi += 0.012; //changes speed of the fish
                }
                if (autumn)
                {
                    phi += 0.02; //changes speed of the fish
                }
                if (winter)
                {
                    phi += 0.03; //changes speed of the fish
                }
                f.DrawFish(g, x = radius * Math.Cos(phi + spacing) + centre_x, y = radius * Math.Sin(phi + spacing) + centre_y); //call the Fish class's DrawFish method to draw the image
                spacing = spacing + 2;
            }
            RodRec = new Rectangle(100, 240, 5, 5); //new rectangle for fish to be caught on
            foreach (Fish f_this in fish) // for each fish in the array
            {
                if (TmrWait.Enabled == false) // if the timer is up
                {
                    if (RodRec.IntersectsWith(f_this.FishRec)) //if the fish is on the rod
                    {
                        if (random.Next(0, 100) < 70) // random chance for the fish to be "caught"g
                        {
                            AlertRec = new Rectangle(120, 200, 50, 50); //draw (!) in new rectangle
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
            autumn = false; //set correct season
            winter = false;
            success = false;
            Seasontitle = Properties.Resources.Spring; //show season title
            Bait = 10; // set bait to 10 when starting
            LblBait.Text = Bait.ToString(); //display the amount of bait
        }
        public void TmrCatch_Tick(object sender, EventArgs e)
        {
            TmrFish.Enabled = true; //fish moves again
            Catch = false; //can no longer trigger catch event
            TmrCatch.Enabled = false;
            TmrWait.Enabled = true; //stops player from catching 2 in a row
            Bait -= 1; //remove one bait
            LblBait.Text = Bait.ToString(); //display new bait number
            CheckBait(); //check if bait = 0
        }
        public void TmrWait_Tick(object sender, EventArgs e)
        {
            if (FishyPopUp.Visible == false)
            {
                TmrWait.Enabled = false; //player can catch fish again
            }
        }
        public void FishyFrm_KeyDown(object sender, KeyEventArgs e)
        {
            Random random = new Random(); //new random
            if (e.KeyData == Keys.I) //if I is pressed then show instructions
            {
                DisplayType = "Information";
                FishyPopUp.Visible = true;
            }
            if (e.KeyData == Keys.E) //if e is pressed show encyclopedia
            {
                FishyPopUp.Visible = true;
                DisplayType = "Encyclopedia";

            }
            if (FishyPopUp.Visible == false)
            {
                if (e.KeyData == Keys.Space) //if space is pressed
                { //and catch is not true
                    Bait -= 1; //take away one bait
                    LblBait.Text = Bait.ToString(); //show bait number
                    CheckBait(); //check if bait is 0

                    if (Catch) //if fish is able to be caught
                    {
                        Catch = false; //no longer able to be caught
                        TmrWait.Enabled = true;
                        Bait += 2; //add bait
                        LblBait.Text = Bait.ToString(); //display bait number
                        int rand = random.Next(1, 5); //set random interger
                        if (spring) //same for other seasons
                        {

                            if (rand == 1) //if random = 1
                            {
                                FishyPopUp.Visible = true; //fish caught is red cod
                                DisplayType = "Redcod";

                            }
                            if (rand == 2) //if random = 2
                            {
                                FishyPopUp.Visible = true; //bluecod is caught
                                DisplayType = "Bluecod"; ;

                            }
                            if (rand == 3) //if random = 3
                            {
                                FishyPopUp.Visible = true;
                                DisplayType = "Snapper"; //snapper is caught

                            }
                            if (rand == 4)// if random = 4
                            {
                                FishyPopUp.Visible = true; //gurnard is caught
                                DisplayType = "Gurnard";
                            }
                        }
                        if (summer)
                        {
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

