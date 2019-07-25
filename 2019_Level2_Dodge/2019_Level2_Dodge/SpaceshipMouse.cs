using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace _2019_Level2_Dodge
{
    class SpaceshipMouse
    {
        // declare fields to use in the class

        public int x, y, width, height;//variables for the rectangle
        public Image spaceshipMouse;//variable for the planet's image
        public int rotationAngle;
        public Matrix matrix;
        Point centre;
        public Rectangle spaceMouseRec;//variable for a rectangle to place our image in

        //Create a constructor (initialises the values of the fields)
        public SpaceshipMouse()
        {
            x = 10;
            y = 360;
            width = 20;
            height = 20;
            rotationAngle = 0;
            spaceshipMouse = Image.FromFile("crosshair1.png");
            spaceMouseRec = new Rectangle(x, y, width, height);
        }



        //methods
        public void drawSpaceshipMouse(Graphics g)
        {
            //find the centre point of spaceRec
            centre = new Point(spaceMouseRec.X + width / 2, spaceMouseRec.Y + width / 2);
            //instantiate a Matrix object called matrix
            matrix = new Matrix();
            //rotate the matrix (spaceRec) about its centre
            matrix.RotateAt(rotationAngle, centre);
            //Set the current draw location to the rotated matrix point
            g.Transform = matrix;
            //draw the spaceship

            g.DrawImage(spaceshipMouse, spaceMouseRec);
        }

        public void moveSpaceshipMouse(int mouseX, int mouseY)
        {
            spaceMouseRec.X = mouseX;
            spaceMouseRec.Y = mouseY;

        }

    }
}
