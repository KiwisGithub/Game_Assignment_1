using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace _2019_Level2_Dodge
{
    public partial class frmDodge : Form
    {
        Graphics g; //declare a graphics object called g
                    // declare space for an array of 7 objects called planet 
        Enemy[] planet = new Enemy[7];
        Enemy2[] planet2 = new Enemy2[7];
        Enemy3[] planet3 = new Enemy3[7];
        Random yspeed = new Random();

        //float timer = 0f;
        //declare a list  missiles from the Missile class
        List<Missile> missiles = new List<Missile>();
        List<Missile2> missiles2 = new List<Missile2>();
        List<Missile3> missiles3 = new List<Missile3>();
        List<Missile4> missiles4 = new List<Missile4>();




        Spaceship spaceship = new Spaceship();
        SpaceshipMouse spaceshipMouse = new SpaceshipMouse(); //create an instance of the Spaceship Class called spaceship

        bool left, right, up, down;
        int score, lives;
        string move;

        double x, y;
        double phi = 0;
        int radius = 200;

        public static int finalScore = 420;

        public frmDodge()
        {
            InitializeComponent();

            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, pnlGame, new object[] { true });

            for (int i = 0; i < 7; i++)
            {
                int x = 10 + (i * 140);
                planet[i] = new Enemy(x);
                planet2[i] = new Enemy2(x);
                planet3[i] = new Enemy3(x);
            }


        }

        private void checkLives()
        {
            if (lives == 0)
            {
                finalScore = (int)score;
                tmrPlanet.Enabled = false;
                tmrShip.Enabled = false;
                //MessageBox.Show("Game Over");
                frmDeath deathForm = new frmDeath();
                //Application.Exit();
                this.Close();
                deathForm.Show();

            }
        }

        //frmMenu mnuForm = new frmMenu();
        private void frmDodge_Load(object sender, EventArgs e)
        {
            // lives = int.Parse(txtLives.Text);// pass lives entered from textbox to lives variable
            //MessageBox.Show("Use the left and right arrow keys to move the spaceship. \n Don't get hit by the planets! \n Every planet that gets past scores a point. \n If a planet hits a spaceship a life is lost! \n \n Enter your Name press tab and enter the number of lives \n Click Start to begin", "Game Instructions");
            //txtName.Focus();
            // mnuForm.Show();
            lblNametag.Text = frmMenu.SetValueFortxtNamebox;
            lives = frmMenu.SetValueFornumHP;
            txtLives.Text = frmMenu.SetValueFornumHP.ToString();

        }

        private void pnlGame_Paint(object sender, PaintEventArgs e)
        {
            //get the graphics used to paint on the panel control
            g = e.Graphics;
            //call the Planet class's DrawPlanet method to draw the image planet1 
            for (int i = 0; i < 7; i++)
            {

                // generate a random number from 5 to 20 and put it in rndmspeed
                int rndmspeed = yspeed.Next(-20, -5);
                planet[i].y += rndmspeed;
                planet2[i].y += rndmspeed;
                planet3[i].y += rndmspeed;

                //call the Planet class's drawPlanet method to draw the images
                planet[i].drawPlanet(g);
                planet2[i].drawPlanet(g);
                planet3[i].drawPlanet(g);



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
                m.drawMissile(g);
                m.moveMissile(g);
            }

            foreach (Missile3 m in missiles3)
            {
                m.drawMissile(g);
                m.moveMissile(g);
            }

            foreach (Missile4 m in missiles4)
            {
                m.drawMissile(g);
                m.moveMissile(g);
            }


        }


        private void pnlGame_MouseMove(object sender, MouseEventArgs e)
        {
            spaceshipMouse.moveSpaceshipMouse(e.X, e.Y);
        }



        private void tmrPlanet_Tick(object sender, EventArgs e)
        {
            score = 0;
            for (int i = 0; i < 7; i++)
            {
                planet[i].movePlanet();
                // planet2[i].movePlanet();
                //if (spaceship.spaceRec.IntersectsWith(planet[i].planetRec))
                //{
                //reset planet[i] back to top of panel
                //planet[i].y = 1495; // set  y value of planetRec
                // lives -= 1;// lose a life
                //  txtLives.Text = lives.ToString();// display number of lives
                //   checkLives();
                //  }


                score += planet[i].score;// get score from Planet class (in movePlanet method)
                lblScore.Text = score.ToString();// display score

            }
            pnlGame.Invalidate();//makes the paint event fire to redraw the panel
        }



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void startToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            score = 0;
            lblScore.Text = score.ToString();
            lives = int.Parse(txtLives.Text);// pass lives entered from textbox to lives variable
            tmrPlanet.Enabled = true;
            tmrShip.Enabled = true;

        }

        private void stopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tmrShip.Enabled = false;
            tmrPlanet.Enabled = false;
            //test2
        }

        private void tmrSpaceshipMouse_Tick(object sender, EventArgs e)
        {
            //Cursor.Hide();
            Invalidate();


        }

        private void pnlGame_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                missiles.Add(new Missile(spaceship.spaceRec, spaceship.rotationAngle));
                //System.Threading.Thread.Sleep(50);
            }

        }

        private void pnlGame_MouseHover(object sender, EventArgs e)
        {
            Cursor.Hide();
        }
        private void pnlGame_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Show();
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



        private void tmrMissile2_Tick(object sender, EventArgs e)
        {
            foreach (Enemy2 p in planet2)
            {

                //  missiles.Add(new Missile(spaceship.spaceRec, 270));
                missiles3.Add(new Missile3(p.planetRec, 270));
                //System.Threading.Thread.Sleep(5000);
            }

            foreach (Missile3 m3 in missiles3)
            {
                if ((m3.x < 0))
                {
                    missiles3.Remove(m3);
                    break;
                }
            }

        }

        private void tmrMissile3_Tick(object sender, EventArgs e)
        {
            foreach (Enemy3 p in planet3)
            {

                // missiles.Add(new Missile(spaceship.spaceRec, 270));
                missiles4.Add(new Missile4(p.planetRec, 270));
                //System.Threading.Thread.Sleep(5000);
            }
            foreach (Missile4 m4 in missiles4)
            {
                if ((m4.x < 0))
                {
                    missiles4.Remove(m4);
                    break;
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Are you sure you want to Exit the game?",
     "Bruh?",
     MessageBoxButtons.YesNo,
     MessageBoxIcon.Warning,
     MessageBoxDefaultButton.Button2);
            if (result1 == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void frmDodge_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void pnlGame_MouseMove_1(object sender, MouseEventArgs e)
        {
            spaceshipMouse.moveSpaceshipMouse(e.X, e.Y);
            var mouseCurrentX = e.X;
            var mouseCurrentY = e.Y;


        }

        private void lblNametag_Click(object sender, EventArgs e)
        {

        }

        private void tmrMouse_Tick(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void PnlGame_MouseClick(object sender, MouseEventArgs e)
        {
            Cursor.Hide();
        }

        private void lblScore_Click(object sender, EventArgs e)
        {

        }

        private void pnlGame_MouseEnter(object sender, EventArgs e)
        {
            //Cursor.Hide();
        }

        private void frmDodge_MouseLeave(object sender, EventArgs e)
        {
                           
        }

        private void tmrCircle_Tick(object sender, EventArgs e)
        {
            int centre_x = 200, centre_y = 200;
            phi += 0.01;

            x = radius * Math.Cos(phi) + centre_x;
            y = radius * Math.Sin(phi) + centre_y;
            Invalidate();
        }

        private void frmDodge_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                missiles.Add(new Missile(spaceship.spaceRec, spaceship.rotationAngle));
            }

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

            foreach (Missile2 m2 in missiles2) {


               if (spaceship.spaceRec.IntersectsWith(m2.missileRec))                      
                {
                    missiles2.Remove(m2);

                    lives -= 1;// lose a life
                    txtLives.Text = lives.ToString();// display number of lives
                    checkLives();
                    break;

                }

            }
            foreach (Missile3 m3 in missiles3)
            {


                if (spaceship.spaceRec.IntersectsWith(m3.missileRec))
                {
                    missiles3.Remove(m3);

                    lives -= 1;// lose a life
                    txtLives.Text = lives.ToString();// display number of lives
                    checkLives();
                    break;

                }

            }
            foreach (Missile4 m4 in missiles4)
            {


                if (spaceship.spaceRec.IntersectsWith(m4.missileRec))
                {
                    missiles4.Remove(m4);

                    lives -= 1;// lose a life
                    txtLives.Text = lives.ToString();// display number of lives
                    checkLives();
                    break;

                }

            }

        }

        private void frmDodge_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.A) { left = true; }
            if (e.KeyData == Keys.D) { right = true; }
            if (e.KeyData == Keys.W) { up = true; }
            if (e.KeyData == Keys.S) { down = true; }
            if (e.KeyData == Keys.Escape)
            {
                Cursor.Show();
                tmrShip.Enabled = false;
                tmrPlanet.Enabled = false;
                tmrMissile.Enabled = false;
                tmrMissile2.Enabled = false;
                tmrMissile3.Enabled = false;


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
                    tmrMissile3.Enabled = true;
                }
            }


        }

        private void frmDodge_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.A) { left = false; }
            if (e.KeyData == Keys.D) { right = false; }
            if (e.KeyData == Keys.W) { up = false; }
            if (e.KeyData == Keys.S) { down = false; }
            // if (e.KeyData == Keys.Escape) { escape = false; }

        }
    }
}
