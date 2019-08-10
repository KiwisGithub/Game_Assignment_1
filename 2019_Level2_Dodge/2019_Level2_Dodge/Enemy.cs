using System.Drawing;

namespace _2019_Level2_Dodge
{
    class Enemy
    {
        // declare fields to use in the class
        public int x, y, width, height;//variables for the rectangle
        public Image planetImage;//variable for the planet's image

        public Rectangle planetRec;//variable for a rectangle to place our image in
        public int score;
        //Create a constructor (initialises the values of the fields)
        public Enemy(int spacing)
        {
            x = spacing;
            y = 1600;
            width = 70;
            height = 70;
            planetImage = Image.FromFile("spaceship4.png");

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

            if (planetRec.Y < -40)
            {
                score += 1;// add 1 to score when planet reaches bottom of panel
                y = 1495;
                planetRec.Location = new Point(y, x);
            }

        }



    }
}
