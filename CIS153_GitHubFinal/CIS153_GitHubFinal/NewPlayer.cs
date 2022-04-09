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
            //NOTE: Questioning this addition, it might over complicate things too much.
            //Might play with it, but not required so i don't want to waste too much time.
            
            //Here is where the game board should be loaded
            //Names should save to STATS file to display individual player Stats vs. computer
            //AND display TOTAL Player Wins vs TOTAL Computer wins.
        }
    }
}
