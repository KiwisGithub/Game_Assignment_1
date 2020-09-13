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
    public partial class frmLevel : Form
    {
        public frmLevel()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmDodge playForm = new frmDodge();

            //Application.Exit();
            this.Close();
            playForm.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            frmDodge playForm = new frmDodge();
            
            //Application.Exit();
            this.Close();
            playForm.Show();
        }
    }
}
