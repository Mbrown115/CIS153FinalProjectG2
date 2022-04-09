using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS153_GitHubFinal
{
    public partial class NewPlayer : Form
    {
        public NewPlayer()
        {
            InitializeComponent();
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            //Here is where the game board should be loaded
            //Names should save to STATS file to display individual player Stats vs. computer
            //AND display TOTAL Player Wins vs TOTAL Computer wins. 
                //If the player has chosen to play against the computer, Player 2 TextBox Should 
                //NOT be active and text should read "Computer"
        }
    }
}
