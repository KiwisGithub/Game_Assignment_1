using System;
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
        public frmDeath()
        {
            InitializeComponent();
            lblHighscore.ForeColor = Color.FromArgb(90, 153, 171);
            lblScore.ForeColor = Color.FromArgb(90, 153, 171);
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
    }
}
