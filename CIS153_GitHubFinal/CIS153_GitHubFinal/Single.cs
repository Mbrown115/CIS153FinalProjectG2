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

            DialogResult result = MessageBox.Show ("Confirm Exit. Clicking Yes will end the game." , "Exiting Game!" , MessageBoxButtons.YesNo , MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }
    }
}
