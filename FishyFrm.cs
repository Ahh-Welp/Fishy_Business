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
            rodRec = new Rectangle(200, 220, 40, 40);
            e.Graphics.FillRectangle(Brushes.Black, rodRec);

            if(rodRec.IntersectsWith(fish[3].fishRec))
            {

            }
        }

        private void FishyFrm_Load(object sender, EventArgs e)
        {

        }

        private void TmrFish_Tick(object sender, EventArgs e)
        {
            FishyPanel.Invalidate();//makes the paint event fire to redraw the panel
        }
    }
}
