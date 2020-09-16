using System;
using System.Drawing;
using System.Drawing.Drawing2D;


namespace _2019_Level2_Dodge
{
    class Stars
    {
        public int x, y, width, height;
        public int missileRotated;
        public double xSpeed, ySpeed;
        public Image missile;//variable for the missile's image
        public Rectangle missileRec;//variable for a rectangle to place our image in
        public Matrix matrixMissile;//matrix to enable us to rotate missile in the same angle as the spaceship
        Point centreMissile;//centre of missile
        // in the following constructor we pass in the values of spaceRec and the rotation angle of the spaceship
        // this gives us the position of the spaceship which we can then use to place the
        // missile where the spaceship is located and at the correct angle
        public Stars(Rectangle spaceRec, int missileRotate)
        {

            int[] quoteDoge = new int[] { 5, 2, 1, 3, 6, 2, 3 };
            Random rnd = new Random();
            int r = rnd.Next(7);
            int str = quoteDoge[r];

            int[] quoteDoge2 = new int[] {1,2,3,3,4};
            Random rnd2 = new Random();
            int r2 = rnd2.Next(5);
            int str2 = quoteDoge2[r2];



            height = str;
            width = str;
            missile = Image.FromFile("star" + str2.ToString() + ".png");
            missileRec = new Rectangle(x, y, width, height);
            //this code works out the speed of the missile to be used in the moveMissile method
            xSpeed = 5 * (Math.Cos((missileRotate - 90) * Math.PI / 180));
            ySpeed = 5 * (Math.Sin((missileRotate + 90) * Math.PI / 180));
            //calculate x,y to move missile to middle of spaceship in drawMissile method
            x = spaceRec.X + spaceRec.Width / 2;
            y = spaceRec.Y + spaceRec.Height / 2;
            //pass missileRotate angle to missileRotated so that it can be used in the drawMissile method
            missileRotated = missileRotate;

        }

        public void drawMissile(Graphics g)
        {
            // if ((missileRec.X > 0) && (missileRec.X < 1400))
            //{
            //centre missile 
            centreMissile = new Point(x, y);
            //instantiate a Matrix object called matrixMissile
            matrixMissile = new Matrix();
            //rotate the matrix (in this case missileRec) about its centre
            matrixMissile.RotateAt(missileRotated, centreMissile);
            //Set the current draw location to the rotated matrix point i.e. where missileRec is now
            g.Transform = matrixMissile;
            //Draw the missile
            g.DrawImage(missile, missileRec);
            //  }


        }
        public void moveMissile(Graphics g)
        {
            x += (int)xSpeed;//cast double to an integer value
            y -= (int)ySpeed;
            missileRec.Location = new Point(x, y);//missiles new location

        }

    }
}
