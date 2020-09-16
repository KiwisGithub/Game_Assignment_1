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
    class Enemy
    {
        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public Image planetImage;//variable for the planet's image
        public Rectangle planetRec2;//variable for a rectangle to place our image in
        //Create a constructor (initialises the values of the fields)

        public int rotationAngle;
        public Matrix matrix;
        //public bool ShieldHas;
        Point centre;
        public Enemy(int spacing)
        {
            int[] quoteDoge = new int[] { 1500, 1700, 2000, 2200, 2500, 3000, 3500 };

            // init random generator 
            Random rnd2 = new Random();

            // get random value (0 <= n < 3) 
            int r2 = rnd2.Next(7);

            // pull out string from array 
            int str2 = quoteDoge[r2];


            x = spacing;
            y = str2;
            width = 70;
            height = 70;


            rotationAngle = 30;


            planetImage = Image.FromFile("spaceship4.png");

        }


        // Methods for the Planet class
        public void drawPlanet(Graphics g)
        {
            planetRec2 = new Rectangle(y, x, width, height);

            //find the centre point of spaceRec
            centre = new Point(planetRec2.X + width / 2, planetRec2.Y + width / 2);
            //instantiate a Matrix object called matrix
            matrix = new Matrix();
            //rotate the matrix (spaceRec) about its centre
            matrix.RotateAt(0, centre); //frmDodge.angleToChange
            //Set the current draw location to the rotated matrix point
            g.Transform = matrix;
            //draw the spaceship


            g.DrawImage(planetImage, planetRec2);
        }
    }
}
