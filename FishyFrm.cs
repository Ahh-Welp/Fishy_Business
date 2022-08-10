using System;
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
        private Rectangle rodRec;//variable for a rectangle to place our image in
        bool caught, Catch, spring, summer, autumn, winter, redcod, bluecod, snapper, gurnard, rockfish, bluetang, squid, yellowtang, clownfish, catfish, pinksalmon, ringtailunicornfish, kingfish, pufferfish, morayeel, seaanemone;

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

        private void FishyPanel_Paint(object sender, PaintEventArgs e)
        {
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


        private void FishyFrm_Load(object sender, EventArgs e)
        {
            spring = true;
            summer = false;
            autumn = false;
            winter = false;
        }

        private void TmrCatch_Tick(object sender, EventArgs e)
        {
            TmrFish.Enabled = true;
            Catch = false;
            TmrCatch.Enabled = false;
            TmrWait.Enabled = true;
        }

        private void TmrWait_Tick(object sender, EventArgs e)
        {
            TmrWait.Enabled = false;
        }

        private void FishyFrm_KeyDown(object sender, KeyEventArgs e)
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
                            MessageBox.Show("Caught a red cod!");
                            redcod = true;
                        }
                        if (rand == 2)
                        {
                            MessageBox.Show("Caught a blue cod!");
                            bluecod = true;
                        }
                        if (rand == 3)
                        {
                            MessageBox.Show("Caught a snapper!");
                            snapper = true;
                        }
                        if (rand == 4)
                        {
                            MessageBox.Show("Caught a gurnard!");
                            gurnard = true;
                        }
                    }

                    if (summer)
                    {
                        int rand = random.Next(1, 5);
                        if (rand == 1)
                        {
                            MessageBox.Show("Caught a rockfish!");
                            rockfish = true;
                        }
                        if (rand == 2)
                        {
                            MessageBox.Show("Caught a blue tang!");
                            bluetang = true;
                        }
                        if (rand == 3)
                        {
                            MessageBox.Show("Caught a squid!");
                            squid = true;
                        }
                        if (rand == 4)
                        {
                            MessageBox.Show("Caught a yellow tang!");
                            yellowtang = true;
                        }
                    }

                    if (autumn)
                    {
                        int rand = random.Next(1, 5);
                        if (rand == 1)
                        {
                            MessageBox.Show("Caught a clownfish!");
                            clownfish = true;
                        }
                        if (rand == 2)
                        {
                            MessageBox.Show("Caught a catfish!");
                            catfish = true;
                        }
                        if (rand == 3)
                        {
                            MessageBox.Show("Caught a pink salmon!");
                            pinksalmon = true;
                        }
                        if (rand == 4)
                        {
                            MessageBox.Show("Caught a ringtail unicornfish!");
                            ringtailunicornfish = true;
                        }
                    }

                    if (winter)
                    {
                        int rand = random.Next(1, 5);
                        if (rand == 1)
                        {
                            MessageBox.Show("Caught a kingfish!");
                            kingfish = true;
                        }
                        if (rand == 2)
                        {
                            MessageBox.Show("Caught a pufferfish!");
                            pufferfish = true;
                        }
                        if (rand == 3)
                        {
                            MessageBox.Show("Caught a morayeel!");
                            morayeel = true;
                        }
                        if (rand == 4)
                        {
                            MessageBox.Show("Caught a sea anenome!");
                            seaanemone = true;
                        }
                    }



                }
            }
        }

        private void TmrFish_Tick(object sender, EventArgs e)
        {
            FishyPanel.Invalidate();//makes the paint event fire to redraw the panel
        }
    }
}
