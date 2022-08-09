using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace Fishy_Business
{
    class Fish
    {
        // declare fields to use in the class
        private int x, y, width, height;//variables for the rectangle
        private Image fishImage;//variable for the fish's image

        public Rectangle fishRec;//variable for a rectangle to place our image in
        public int score;
        //Create a constructor (initialises the values of the fields)
        //
        public Fish(int spacing)
        {
            x = spacing;
            y = 360;
            width = 40;
            height = 40;
            //fishImage contains the mysteryfish.png image
            fishImage = Properties.Resources.mysteryfish;
            fishRec = new Rectangle(x, y, width, height);
        }

        // Methods for the Planet class
        public void DrawFish(Graphics g, double x1, double y1)
        {

            x = (int) x1; 
            y = (int) y1;
            fishRec.Location = new Point(x, y);
            g.DrawImage(fishImage, fishRec);
        }

        public void MoveFish()
        {
            

        }
    }
}
