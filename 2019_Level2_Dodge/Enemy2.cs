using System.Drawing;
using System.Drawing.Drawing2D;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2019_Level2_Dodge
{
    class Enemy2
    {
        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public Image planetImage;//variable for the planet's image
        public Rectangle planetRec;//variable for a rectangle to place our image in
                                   //Create a constructor (initialises the values of the fields)

        public int rotationAngle = 0;
        public Matrix matrix;
        //public bool ShieldHas;
        Point centre;
        public Enemy2(int spacing)
        {
            int[] quoteDoge = new int[] { 3400, 3800, 4200, 4500, 4700, 5000, 5100 };

            // init random generator 
            Random rnd2 = new Random();

            // get random value (0 <= n < 3) 
            int r2 = rnd2.Next(7);

            // pull out string from array 
            int str2 = quoteDoge[r2];


            x = spacing;
            y = str2;
            width = 80;
            height = 80;
            planetImage = Image.FromFile("spaceship2.png");

        }


        // Methods for the Planet class
        public void drawPlanet(Graphics g)
        {
            planetRec = new Rectangle(y, x, width, height);

            //find the centre point of spaceRec
            centre = new Point(planetRec.X + width / 2, planetRec.Y + width / 2);
            //instantiate a Matrix object called matrix
            matrix = new Matrix();
            //rotate the matrix (spaceRec) about its centre
            matrix.RotateAt(rotationAngle, centre);
            //Set the current draw location to the rotated matrix point
            g.Transform = matrix;
            //draw the spaceship

            g.DrawImage(planetImage, planetRec);
        }
    }
}
