using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _2019_Level2_Dodge
{
    class Animation
    {
        //declare an array of images
        Image[] images;
        int count = 1;
        //Pass the array of images from the form into the constructor 
        public Animation(Image[] frames)
        {

            images = frames;
        }
        //method to take each image in turn
        public Image GetNextImage()
        {
            Image show_image = null;
            if (count < images.Length)
            {
                show_image = images[count++];
            }
            else //start at the first image again
            {
                count = 1;
                show_image = images[count];

            }
            //return the current image back to the from
            return show_image;
        }
    }
}
