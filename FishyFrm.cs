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
        bool caught, Catch;

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

                        if (random.Next(0, 100) <100)
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
                    int rand = random.Next(1, 5);
                    if (rand == 1)
                    {
                        MessageBox.Show("Caught1!");
                    }
                    if (rand == 2)
                    {
                        MessageBox.Show("Caught2!");
                    }
                    if (rand == 3)
                    {
                        MessageBox.Show("Caught3!");
                    }
                    if (rand == 4)
                    {
                        MessageBox.Show("Caught4!");
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
