using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Windows.Forms;

namespace _2019_Level2_Dodge
{
    public partial class frmMenu : Form
    {

        public static string SetValueFortxtNamebox = "No Name Given";
        public static string SetValueFornumHP = "No HP Given";

        public frmMenu()
        {
            InitializeComponent();
            //https://www.c-sharpcorner.com/UploadFile/834980/how-to-pass-data-from-one-form-to-other-form-in-windows-form/
            //https://www.homeandlearn.co.uk/csharp/csharp_s13p1.html
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("You are beyond help.",
            "Help",
            MessageBoxButtons.OK,
            MessageBoxIcon.Question);
            //MessageBox.Show("Use the left and right arrow keys to move the spaceship. \n Don't get hit by the planets! \n Every planet that gets past scores a point. \n If a planet hits a spaceship a life is lost! \n \n Enter your Name press tab and enter the number of lives \n Click Start to begin", "Game Instructions");
        }

        //frmDodge playForm = new frmDodge();
         //frmMenu homeForm = new frmMenu();
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            //playForm.Show();

            SetValueFortxtNamebox = txtNamebox.Text;
            SetValueFornumHP = numHP.Text;


            frmDodge playForm = new frmDodge();
            //Application.Exit();
            this.Close();
            playForm.Show();


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
    }
}
