using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Drawing;

namespace _2019_Level2_Dodge
{
    public partial class frmMenu : Form
    {

        public static string SetValueFortxtNamebox = "No Name Given";
        public static int SetValueFornumHP = 10;

        public frmMenu()
        {
            Cursor.Show();
            InitializeComponent();
            //https://www.c-sharpcorner.com/UploadFile/834980/how-to-pass-data-from-one-form-to-other-form-in-windows-form/
            //https://www.homeandlearn.co.uk/csharp/csharp_s13p1.html
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            lblHelp.Text = "now with 34% more planet";
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            lblHelp.ForeColor = Color.FromArgb(90, 153, 171);
            Cursor.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

            frmHelp helpForm = new frmHelp();
            //Application.Exit();
            this.Close();
            helpForm.Show();

           DialogResult result1 = MessageBox.Show("Use the W, A, S and D keys to move the spaceship and use Mouse1 to shoot. \n \nDon't get hit by the enemy bullets! \nEvery enemy that gets past scores a point, and each ship you shoot scores 5. \nIf a bullet hits a spaceship a life is lost! \n \nIn the main menu, Enter your Name, press tab and enter the number of lives \nPush esc to pause the game, and return to the main menu. \n \nClick start to begin!",
           "How to Play:",
            MessageBoxButtons.OK,
            MessageBoxIcon.Question);
           // MessageBox.Show(", "Game Instructions");
        }

        //frmDodge playForm = new frmDodge();
        //frmMenu homeForm = new frmMenu();
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //playForm.Show();

            SetValueFortxtNamebox = txtNamebox.Text;
            SetValueFornumHP = (int)numHP.Value;


            //frmDodge playForm = new frmDodge();
            frmLevel lvlForm = new frmLevel();
            //Application.Exit();
            this.Close();
            lvlForm.Show();


        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            DialogResult result1 = MessageBox.Show("Are you sure you want to Exit?",
    "Bruh?",
    MessageBoxButtons.YesNo,
    MessageBoxIcon.Warning,
    MessageBoxDefaultButton.Button2);
            if (result1 == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            //this.SuspendLayout();
            //pictureBox6.Location = new Point(pictureBox6.Location.X, pictureBox6.Location.X + 1);

        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            //pictureBox6.Location = new Point(pictureBox6.Location.X, pictureBox6.Location.X - 1);
        }

        private void txtname(object sender, EventArgs e)
        {
            string context = txtNamebox.Text;
            bool isletter = true;
            //for loop checks for numbers as characters are entered
            for (int i = 0; i < context.Length; i++)
            {
                if (!char.IsLetter(context[i]))//if current character not a letter
                {
                    isletter = false;//make isletter false
                    break;//exit the for loop
                }
            }

            //if not a number clear the textbox and focus on it to enter lives again
            if (isletter == false)
            {
                txtNamebox.Clear();
                txtNamebox.Focus();
                DialogResult result1 = MessageBox.Show("Please only enter letters for your name.",
            "Warning",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error);
            }

        }

        private void txtLives_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("You are beyond help.",
            "Help",
            MessageBoxButtons.OK,
            MessageBoxIcon.Question);
            //MessageBox.Show("Use the left and right arrow keys to move the spaceship. \n Don't get hit by the planets! \n Every planet that gets past scores a point. \n If a planet hits a spaceship a life is lost! \n \n Enter your Name press tab and enter the number of lives \n Click Start to begin", "Game Instructions");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/KiwisGithub/Game_Assignment_1/wiki");
        }

        private void numHP_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            lblHelp.Text = "hello patrick";
        }

        private void frmMenu_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
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

            if (e.KeyData == Keys.Enter)
            {
                SetValueFortxtNamebox = txtNamebox.Text;
                SetValueFornumHP = (int)numHP.Value;
   
                frmDodge playForm = new frmDodge();
                //Application.Exit();
                this.Close();
                playForm.Show();

            }

        }

        private void frmMenu_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void lblHelp_Click(object sender, EventArgs e)
        {
            lblHelp.Text = "← click on the button - not this text!";
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            lblHelp.Text = "i pissed on the moon!!!";
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            lblHelp.Text = "it's where Brit*n is D:";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            lblHelp.Text = "my name is luka tomic and i am from s*rbia";
        }
    }
}
