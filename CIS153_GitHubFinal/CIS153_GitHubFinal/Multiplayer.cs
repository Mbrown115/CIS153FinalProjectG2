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
    public partial class Multiplayer : Form
    {
        Welcome menu;
        int[,] b = new int[6,7];

        public Multiplayer()
        {
            InitializeComponent();

            Board theBoard = new Board();
            theBoard.setcolumns(new Rectangle[7]);
            theBoard.setBoard(b);
        }
        
        public Multiplayer(Welcome fml)
        {
            InitializeComponent();
            menu = fml;
        }

        // Brings up menu form
        private void btn_menu_Click(object sender, EventArgs e)
        {
            menu.Show();
            Close(); 
        }

        private void btn_Exit_Click (object sender , EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirm Exit. Clicking Yes will end the game.", "Exiting Game!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void displayTurn()
        {
            //this will display the current players turn status in the label at the bottom
            //of the game screen.

           // lbl_PlayTurn.Text = 
        }
    }
}
