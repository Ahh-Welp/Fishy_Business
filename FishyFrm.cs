using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fishy_Business
{
    public partial class FishyFrm : Form
    {
        Graphics g; //declare a graphics object called g
        // declare space for an array of 7 objects called planet 
        Fish[] fish = new Fish[3];


        public FishyFrm()
        {
            InitializeComponent();
            for (int i = 0; i < 3; i++)
            {
                int x = 50 + (i * 75);
                fish[i] = new Fish(x);
                int y = 100 + (i * 75);
                fish[i] = new Fish(y);
            }

        }

        private void FishyPanel_Paint(object sender, PaintEventArgs e)
        {
            //get the graphics used to paint on the panel control
            g = e.Graphics;
            //call the Fish class's DrawFish method to draw the image fish1 
            for (int i = 0; i < 3; i++)
            {
                //call the Planet class's drawPlanet method to draw the images
                fish[i].DrawFish(g);
            }


        }

        private void TmrFish_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                fish[i].MoveFish();
            }
            FishyPanel.Invalidate();//makes the paint event fire to redraw the panel


        }
    }
}
