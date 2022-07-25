﻿using System;
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
        public int x, y, width, height;//variables for the rectangle
        public Image fishImage;//variable for the fish's image

        public Rectangle fishRec;//variable for a rectangle to place our image in
        public int score;
        //Create a constructor (initialises the values of the fields)
        public Fish()
        {
            x = 10;
            y = 10;
            width = 40;
            height = 40;
            //fishImage contains the mysteryfish.png image
            fishImage = Properties.Resources.mysteryfish;
            fishRec = new Rectangle(x, y, width, height);
        }

        // Methods for the Planet class
        public void DrawFish(Graphics g)
        {
            g.DrawImage(fishImage, fishRec);
        }



    }
}
