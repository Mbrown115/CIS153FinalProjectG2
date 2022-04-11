using CIS153_GitHubFinal.Properties;
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
    public partial class Single : Form
    {
        Welcome menu;

        public Single (Welcome sp)
        {
            InitializeComponent ();            
            menu = sp;
        }

        private void btn_Menu_Click (object sender , EventArgs e)
        {
            menu.Show ();
            Close ();
        }

        private void btn_Exit_Click (object sender , EventArgs e)
        {
            //*********************************************************************************************
            //Working on a dialogbox to confirm "Exit" option
            //Works the first time, but if you run the program multiple times it gives you a weird
            //unhandled exception when trying to terminate. Websearches haven't been helpful so far,
            //working to resolve. 4/5/22 - BT
            //*********************************************************************************************

            //DialogResult result = MessageBox.Show ("Confirm Exit. Clicking Yes will end the game." , "Exiting Game!" , MessageBoxButtons.YesNo , MessageBoxIcon.Exclamation);

            //if (result == DialogResult.Yes)
            //{
            //    Application.Exit();
            //}
        }

        private void displayTurn()
        {
            //Display the player turn status in the label at the bottom of form

           // lbl_PlayerTurn.Text = 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Picture Box clicked!");

            pictureBox1.BackgroundImage = Resources.black_poker_chip;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Confirm Exit. Clicking Yes will end the game.", "Exiting Game!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
