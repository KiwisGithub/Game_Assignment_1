using System.Drawing;
using System;

namespace _2019_Level2_Dodge
{
    class PowerupSpawner
    {
        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public Image planetImage;//variable for the planet's image

        public Rectangle planetRec;//variable for a rectangle to place our image in
       // public int score;
        //Create a constructor (initialises the values of the fields)
        public PowerupSpawner(int spacing)
        {
            
            x = 749;//749
            y = 1500; //1000
            width = 10;
            height = 10;
            planetImage = Image.FromFile("star1.png");

        }


        // Methods for the Planet class
        public void drawPlanet(Graphics g)
        {
            planetRec = new Rectangle(y, x, width, height);
            g.DrawImage(planetImage, planetRec);
        }
    }
}
