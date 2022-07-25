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
        Fish fish1 = new Fish (); //create the object, planet1

        public FishyFrm()
        {
            InitializeComponent();
        }

        private void FishyPanel_Paint(object sender, PaintEventArgs e)
        {
            //get the graphics used to paint on the panel control
            g = e.Graphics;
            //call the Planet class's DrawFish method to draw the image fish1 
            fish1.DrawFish(g);

        }
    }
}
