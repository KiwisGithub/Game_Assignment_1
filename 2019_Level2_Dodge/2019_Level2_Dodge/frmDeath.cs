﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2019_Level2_Dodge
{
    public partial class frmDeath : Form
    {

        public static int highScore = 0;
        public static int yourScore = 0;
        public static string playerName = frmMenu.SetValueFortxtNamebox;
        public static string sparkname = "Sparkles";



        public frmDeath()
        {
            InitializeComponent();
            lblHighscore.ForeColor = Color.FromArgb(90, 153, 171);
            lblScore.ForeColor = Color.FromArgb(90, 153, 171);
            lblScore.Text = frmDodge.finalScore.ToString();
            yourScore = frmDodge.finalScore;
            if (yourScore > highScore)
            {
                highScore = yourScore;
            }
            lblHighscore.Text = highScore.ToString();
            lblDoge.ForeColor = Color.FromArgb(90, 153, 171);


            if (playerName == sparkname)
            {
                string[] quote = new string[] { "What is this? A crossover episode?", "Bruh... that's kinda cringe...", "Wow this game is bad go play Mice in the Hice amiright?", "Gamer Word", "lol u died" };
                

                // init random generator 
                Random rnd = new Random();

                // get random value (0 <= n < 3) 
                int r = rnd.Next(5);

                // pull out string from array 
                string str = quote[r];






                lblSpark.Text = str;

                picSpark.Show();
                lblSpark.Show();

                picDoge.Hide();
                lblDoge.Hide();
            }
            else
            {
                picSpark.Hide();
                lblSpark.Hide();

                string[] quoteDoge = new string[] { "Such Die", "much F", "wow", "bro... you just posted cringe 😳😳😳", "ngl, kinda cringe", "u died", "F", "pay respecc", "I'm not Logan Paul, but I see a body 👀", playerName + " fell from a high place" };

                // init random generator 
                Random rnd2 = new Random();

                // get random value (0 <= n < 3) 
                int r2 = rnd2.Next(10);

                // pull out string from array 
                string str2 = quoteDoge[r2];

                lblDoge.Text = str2;
                picDoge.Show();
                lblDoge.Show();


            }


        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
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
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

            frmHelp helpForm = new frmHelp();
            //Application.Exit();
            this.Close();
            helpForm.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            frmDodge playForm = new frmDodge();
            //Application.Exit();
            this.Close();
            playForm.Show();
        }

        private void lblScore_Click(object sender, EventArgs e)
        {

        }

        private void frmDeath_Load(object sender, EventArgs e)
        {

        }

        private void frmDeath_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {

                Cursor.Show();

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
            }
        }

        private void picSpark_Click(object sender, EventArgs e)
        {

        }

        private void lblSpark_Click(object sender, EventArgs e)
        {

        }

        private void lblDoge_Click(object sender, EventArgs e)
        {

        }
    }
}
