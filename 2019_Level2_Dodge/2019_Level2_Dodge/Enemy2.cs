using System.Drawing;
using System;

namespace _2019_Level2_Dodge
{
    class Enemy2
    {
        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public Image planetImage;//variable for the planet's image

        public Rectangle planetRec;//variable for a rectangle to place our image in
        public int score;
        //Create a constructor (initialises the values of the fields)
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
            g.DrawImage(planetImage, planetRec);
        }



        public void movePlanet()
        {
            y -= 1;

            planetRec.Location = new Point(x, y);

            if (planetRec.Y < -10)
            {
                int[] quoteDoge = new int[] { 3400, 3800, 4200, 4500, 4700, 5000, 5100 };

                // init random generator 
                Random rnd2 = new Random();

                // get random value (0 <= n < 3) 
                int r2 = rnd2.Next(7);

                // pull out string from array 
                int str2 = quoteDoge[r2];

                score += 1;// add 1 to score when planet reaches bottom of panel
                y = str2;
                planetRec.Location = new Point(y, x);
            }

        }
    }
}
