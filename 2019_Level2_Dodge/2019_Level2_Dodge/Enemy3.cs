﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace _2019_Level2_Dodge
{
    class Enemy3
    {
        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public Image planetImage;//variable for the planet's image

        public Rectangle planetRec;//variable for a rectangle to place our image in
        public int score;
        //Create a constructor (initialises the values of the fields)
        public Enemy3(int spacing)
        {
            x = spacing;
            y = 4000;
            width = 100;
            height = 100;
            planetImage = Image.FromFile("spaceship3.png");

        }


        // Methods for the Planet class
        public void drawPlanet(Graphics g)
        {
            planetRec = new Rectangle(y, x, width, height);
            g.DrawImage(planetImage, planetRec);
        }



        public void movePlanet()
        {
            y -= 1;

            planetRec.Location = new Point(x, y);

            if (planetRec.Y < -10)
            {
                score += 1;// add 1 to score when planet reaches bottom of panel
                y = 1900;
                planetRec.Location = new Point(y, x);
            }

        }
    }
}
