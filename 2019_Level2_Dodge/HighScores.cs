using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace _2019_Level2_Dodge
{
    class HighScores
    {
        //we create a Constructor with 2 overloads, 1 for the player's name and one for their score
        public HighScores(string name, int score)
        {
            Name = name;
            Score = score;

            //Name = frmDeath.highScore.ToString();
            //int epicScore = frmDodge.score;
            //Score = score;
        }
        //set properties so we can access the name and score
        public string Name { get; set; }

        public int Score { get; set; }


    }
}
