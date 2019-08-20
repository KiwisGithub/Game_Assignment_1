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
    class Spaceship
    {
        // declare fields to use in the class

        public int x, y, width, height;//variables for the rectangle
        //public Image spaceship;//variable for the planet's image
        Image[] images = new Image[7];//set space for an array called images of 7 images
        public int rotationAngle;
        public Matrix matrix;
        Point centre;

        Animation animate;//create an object called animate

        public Image spaceshipMouse;//variable for the planet's image
        public Rectangle spaceMouseRec;//variable for a rectangle to place our image in

        public Rectangle spaceRec;//variable for a rectangle to place our image in

        //Create a constructor (initialises the values of the fields)
        public Spaceship()
        {
            x = 20;
            y = 360;
            width = 60;
            height = 80;
            //spaceship = Image.FromFile("spaceship1.png");

            for (int i = 1; i <= 6; i++)
            {
                images[i] = Image.FromFile(Application.StartupPath + @"\Ship" + i.ToString() + ".gif");
            }
            //pass the images array to the Animation class's constructor
            animate = new Animation(images);
            // planetImage = Image.FromFile("planet1.png");

            spaceRec = new Rectangle(x, y, width, height);

            rotationAngle = 90;
            spaceshipMouse = Image.FromFile("alien1.png");
            spaceMouseRec = new Rectangle(x, y, width, height);

        }

        //methods
        public void drawSpaceship(Graphics g)
        {
            //find the centre point of spaceRec
            centre = new Point(spaceRec.X + width / 2, spaceRec.Y + width / 2);
            //instantiate a Matrix object called matrix
            matrix = new Matrix();
            //rotate the matrix (spaceRec) about its centre
            matrix.RotateAt(rotationAngle, centre);
            //Set the current draw location to the rotated matrix point
            g.Transform = matrix;
            //draw the spaceship

            g.DrawImage(animate.GetNextImage(), spaceRec);

        }


        public void moveSpaceship(string move)
        {



            spaceRec.Location = new Point(x, y);

            if (move == "right")
            {
                if (spaceRec.Location.X > 1435) // is spaceship within 50 of right side
                {

                    x = 1435;
                    spaceRec.Location = new Point(x, y);
                }
                else
                {
                    x += 8;
                    spaceRec.Location = new Point(x, y);
                }
            }

            if (move == "left")
            {
                if (spaceRec.Location.X < 10) // is spaceship within 50 of right side
                {

                    x = 10;
                    spaceRec.Location = new Point(x, y);
                }
                else
                {
                    x -= 8;
                    spaceRec.Location = new Point(x, y);
                }
            }

            if (move == "up")
            {
                if (spaceRec.Location.Y < 10) // is spaceship within 50 of right side
                {
                    y = 10;
                    spaceRec.Location = new Point(x, y);
                }
                else
                {
                    y -= 8;
                    spaceRec.Location = new Point(x, y);
                }
            }

            if (move == "down")
            {
                if (spaceRec.Location.Y > 704) // is spaceship within 50 of right side
                {

                    y = 734;
                    spaceRec.Location = new Point(x, y);
                }
                else
                {
                    y += 8;
                    spaceRec.Location = new Point(x, y);
                }
            }


        }
    }
}

