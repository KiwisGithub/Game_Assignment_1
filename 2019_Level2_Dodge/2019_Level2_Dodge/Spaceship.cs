using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;


namespace _2019_Level2_Dodge
{
    class Spaceship
    {
        // declare fields to use in the class

        public int x, y, width, height;//variables for the rectangle
        public Image spaceship;//variable for the planet's image
        public int rotationAngle;
        public Matrix matrix;
        Point centre;


  
        public Image spaceshipMouse;//variable for the planet's image
        public Rectangle spaceMouseRec;//variable for a rectangle to place our image in

        public Rectangle spaceRec;//variable for a rectangle to place our image in

        //Create a constructor (initialises the values of the fields)
        public Spaceship()
        {
            x = 10;
            y = 360;
            width = 40;
            height = 40;
            spaceship = Image.FromFile("spaceship1.png");
            spaceRec = new Rectangle(x, y, width, height);

            rotationAngle = 0;
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

            g.DrawImage(spaceship, spaceRec);
        }



        /// <summary>
        /// 
        /// </summary>
        /// <param name="move"></param>
        public void moveSpaceship(string move)
        {



            spaceRec.Location = new Point(x, y);

            if (move == "right")
            {
                if (spaceRec.Location.X > 450) // is spaceship within 50 of right side
                {

                    x = 450;
                    spaceRec.Location = new Point(x, y);
                }
                else
                {
                    x += 5;
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
                        x -= 5;
                        spaceRec.Location = new Point(x, y);
                    }



                }

        }
    }
}
    
