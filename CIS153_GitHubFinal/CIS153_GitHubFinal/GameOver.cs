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
                picBx_WinLose.Image = Properties.Resources.FinalPlayer_Xpng;
            }
            else if (winner == "o")
            {
                picBx_WinLose.Image = Properties.Resources.FinalPlayer_Opng;
            }
            else if (winner == "D")
            {
                picBx_WinLose.Image = Properties.Resources.Draw_png;
            }
        }

        private void btn_NewGame_Click(object sender, EventArgs e)
        {
            Welcome newGame = new Welcome();
            newGame.Show();
            Close();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
