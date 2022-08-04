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
        // declare space for an array of 3 objects called fish 
        Fish[] fish = new Fish[3];
        double x, y;
        double phi = 0;
        int radius = 100;

        public FishyFrm()
        {
            InitializeComponent();
               for (int i = 0; i < 3; i++)
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
            for (int i = 0; i < 3; i++)
            {
                
                //fish[0].DrawFish(g, x, y);
                //fish[1].DrawFish(g, x - 20, y - 20);
                //fish[2].DrawFish(g, x + 20, y+ 20);
            }


        }

        private void TmrFish_Tick(object sender, EventArgs e)
        {
        

           
                
            for (int i = 0; i < 3; i++)
            {
                int centre_x = 300, centre_y = 300;
                phi += 0.01;
                fish[0].DrawFish(g, x = radius * Math.Cos(phi) + centre_x, y = radius * Math.Sin(phi) + centre_y);
                fish[1].DrawFish(g, x = radius * Math.Cos(phi) + centre_x + 20, y = radius * Math.Sin(phi) + centre_y + 20);
                fish[2].DrawFish(g, x = radius * Math.Cos(phi) + centre_x -20, y = radius * Math.Sin(phi) + centre_y - 20);
            }
                FishyPanel.Invalidate();//makes the paint event fire to redraw the panel


        }
    }
}
