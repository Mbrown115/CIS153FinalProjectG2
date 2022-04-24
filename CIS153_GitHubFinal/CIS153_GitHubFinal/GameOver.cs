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
    public partial class GameOver : Form
    {
        
        public GameOver()
        {
            InitializeComponent();
        }

        public GameOver(string w)
        {
            InitializeComponent();

            string winner = w;

            if (winner == "x")
            {
                picBx_WinLose.Image = CIS153_GitHubFinal.Properties.Resources.FinalPlayer_Xpng;
            }
            else if (winner == "o")
            {
                picBx_WinLose.Image = CIS153_GitHubFinal.Properties.Resources.FinalPlayer_Opng;
            }
        }
    }
}
