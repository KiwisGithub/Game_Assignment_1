using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace _2019_Level2_Dodge
{
    public partial class frmHelp : Form
    {
        Graphics g; //declare a graphics object called g
                    // declare space for an array of 7 objects called planet 
        Enemy[] planet = new Enemy[7];
        Random yspeed = new Random();

        //float timer = 0f;
        //declare a list  missiles from the Missile class
        List<Missile> missiles = new List<Missile>();
        List<Missile2> missiles2 = new List<Missile2>();

        Spaceship spaceship = new Spaceship();
        SpaceshipMouse spaceshipMouse = new SpaceshipMouse(); //create an instance of the Spaceship Class called spaceship

        bool left, right, up, down;
       // int score, lives;
        string move;

       // double x, y;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            spaceshipMouse.moveSpaceshipMouse(e.X, e.Y);
            var mouseCurrentX = e.X;
            var mouseCurrentY = e.Y;
        }

        private void tmrPlanet_Tick(object sender, EventArgs e)
        {
            panel1.Invalidate();//makes the paint event fire to redraw the panel
        }

        private void tmrMissile2_Tick(object sender, EventArgs e)
        {

        }

        private void tmrMissile_Tick(object sender, EventArgs e)
        {
            foreach (Enemy p in planet)
            {

                // missiles.Add(new Missile(spaceship.spaceRec, 270));
                missiles2.Add(new Missile2(p.planetRec, 270));
                //System.Threading.Thread.Sleep(5000);
            }

            foreach (Missile2 m2 in missiles2)
            {
                if ((m2.x < 0))
                {
                    missiles2.Remove(m2);
                    break;
                }

            }
        }

        private void tmrMouse_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void tmrShip_Tick(object sender, EventArgs e)
        {
            if (right) // if right arrow key pressed
            {
                move = "right";
                spaceship.moveSpaceship(move);
            }
            if (left) // if left arrow key pressed
            {
                move = "left";
                spaceship.moveSpaceship(move);
            }
            if (up) // if left arrow key pressed
            {
                move = "up";
                spaceship.moveSpaceship(move);
            }
            if (down) // if left arrow key pressed
            {
                move = "down";
                spaceship.moveSpaceship(move);
            }

            foreach (Missile2 m2 in missiles2)
            {


            }

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                missiles.Add(new Missile(spaceship.spaceRec, spaceship.rotationAngle));
                //System.Threading.Thread.Sleep(50);
            }
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            Cursor.Hide();
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            //Cursor.Hide();
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Show();
        }

        private void frmHelp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.A) { left = true; }
            if (e.KeyData == Keys.D) { right = true; }
            if (e.KeyData == Keys.W) { up = true; }
            if (e.KeyData == Keys.S) { down = true; }
            if (e.KeyData == Keys.Escape)
            {

                tmrShip.Enabled = false;
                tmrPlanet.Enabled = false;
                tmrMissile.Enabled = false;
                tmrMissile2.Enabled = false;


                DialogResult result1 = MessageBox.Show("Are you sure you want to Exit to the main menu?",
                 "Bruh?",
                  MessageBoxButtons.YesNo,
                 MessageBoxIcon.Warning,
                 MessageBoxDefaultButton.Button2);
                if (result1 == DialogResult.Yes)
                {
                    frmMenu mnuForm = new frmMenu();
                    //Application.Exit();
                    this.Close();
                    mnuForm.Show();
                }

                else
                {
                    tmrShip.Enabled = true;
                    tmrPlanet.Enabled = true;
                    tmrMissile.Enabled = true;
                    tmrMissile2.Enabled = true;
                }
            }
        }

        private void frmHelp_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.A) { left = false; }
            if (e.KeyData == Keys.D) { right = false; }
            if (e.KeyData == Keys.W) { up = false; }
            if (e.KeyData == Keys.S) { down = false; }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //get the graphics used to paint on the panel control
            g = e.Graphics;
            //call the Planet class's DrawPlanet method to draw the image planet1 
            for (int i = 0; i < 7; i++)
            {

                // generate a random number from 5 to 20 and put it in rndmspeed
                int rndmspeed = yspeed.Next(0, 0);
                planet[i].y += rndmspeed;

                //call the Planet class's drawPlanet method to draw the images
                planet[i].drawPlanet(g);
            }
            spaceship.drawSpaceship(g);
            spaceshipMouse.drawSpaceshipMouse(g);
            foreach (Missile m in missiles)
            {

                m.drawMissile(g);
                m.moveMissile(g);
            }

            foreach (Missile2 m in missiles2)
            {
                //m.drawMissile(g);
                //m.moveMissile(g);
            }
        }

       // double phi = 0;
        //int radius = 200;


        public frmHelp()

        {
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, panel1, new object[] { true });

            for (int i = 0; i < 7; i++)
            {
                int x = 10 + (i * 140);
                planet[i] = new Enemy(x);
            }
        }

        private void frmHelp_Load(object sender, EventArgs e)
        {

        }
    }
}
