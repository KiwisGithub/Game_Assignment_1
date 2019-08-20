using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _2019_Level2_Dodge
{
    class Stars
    {

        public int x, y, width, height;//variables for the rectangle
        Image[] images = new Image[5];
        public Rectangle starRec;//variable for a rectangle to place our image in
        Animation animate; // create an animation object called animate
        //Create a constructor (initialises the values of the fields)
        public Stars()
        {
            //1495, 794
            x = 0;
            y = 0;
            width = 1495;
            height = 794;
            //load the images that will make up the animated character into the images array
            for (int i = 1; i <= 4; i++)
            {
                images[i] = Image.FromFile(@"sprite_rug" + i.ToString() + ".png");
            }
            //pass the images array to the Animation class's constructor
            animate = new Animation(images);
            // Methods for the Rug class
        }
        public void drawStars(Graphics g)
        {
            starRec = new Rectangle(x, y, width, height);
            //draw animated image
            g.DrawImage(animate.GetNextImage(), starRec);
        }
    }

}

