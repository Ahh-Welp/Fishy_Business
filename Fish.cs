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
        private Image FishImage;//variable for the fish's image

        public Rectangle FishRec;//variable for a rectangle to place our image in

        //Create a constructor (initialises the values of the fields)
        //
        public Fish(int spacing)
        {
            x = spacing;
            y = 340;
            width = 40;
            height = 40;
            //fishImage contains the mysteryfish.png image
            FishImage = Properties.Resources.mysteryfish;
            FishRec = new Rectangle(x, y, width, height);
        }

        // Methods for the Fish class
        public void DrawFish(Graphics g, double x1, double y1)
        {
                // creating new locations for the fish to be drawn
                x = (int)x1;
                y = (int)y1;
                FishRec.Location = new Point(x, y);
                g.DrawImage(FishImage, FishRec);
        }
    }
}