using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _2019_Level2_Dodge
{
    public partial class frmHighScores : Form
    {
        string binPath = Application.StartupPath + @"\highscores.txt";
        List<HighScores> highScores = new List<HighScores>();

        public frmHighScores()
        {
            InitializeComponent();
            lblPlayerScore.Text = (frmDodge.score).ToString();
            lblPlayerName.Text = frmMenu.SetValueFortxtNamebox;

            var reader = new StreamReader(binPath);
            // While the reader still has something to read, this code will execute.
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                // Split into the name and the score.
                var values = line.Split(',');
                highScores.Add(new HighScores(values[0], Int32.Parse(values[1])));

            }
            reader.Close();
        }

        private void frmHighScores_Load(object sender, EventArgs e)
        {
            int lowest_score = highScores[(highScores.Count - 1)].Score;
            if (int.Parse(lblPlayerScore.Text) > lowest_score)
            {
                lblMessage.Text = "You have made the Top Ten!\r\nCongratulations, " + lblPlayerName.Text;
                highScores.Add(new HighScores(lblPlayerName.Text, int.Parse(lblPlayerScore.Text)));

            }
            else
            {
                lblMessage.Text = "You didn't make the top 10:(\r\nBetter luck text time!";
            }

            SortHighScores();
            DisplayHighScores();
            SaveHighScores();

        }

        public void DisplayHighScores()
        {
            foreach (HighScores s in highScores)
            {
                listBoxName.Items.Add(s.Name);
                listBoxScore.Items.Add(s.Score);

            }
        }

        public void SortHighScores()
        {
            highScores = highScores.OrderByDescending(hs => hs.Score).Take(10).ToList();
        }

        public void SaveHighScores()
        {
            StringBuilder builder = new StringBuilder();
            foreach (HighScores score in highScores)
            {
                //{0} is for the Name, {1} is for the Score and {2} is for a new line
                builder.Append(string.Format("{0},{1}{2}", score.Name, score.Score, Environment.NewLine));
            }
            File.WriteAllText(binPath, builder.ToString());
        }



        private void listBoxScore_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblPlayerScore_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblPlayerName_Click(object sender, EventArgs e)
        {

        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }
    }
}
