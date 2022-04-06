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
            //Works if you only make a selection once, but if the user selects "No" after clicking exit
            //and then  proceeds to click "Exit" again and "No" 2+ times before clicking "Yes"
            // there is a weird unhandled exception. Tryin to reslove.
            //*********************************************************************************************
            
            //DialogResult result = MessageBox.Show ("Confirm Exit. Clicking Yes will end the game." , "Exiting Game!" , MessageBoxButtons.YesNo , MessageBoxIcon.Exclamation);

            //if (result == DialogResult.Yes)
            //{
            //    Environment.Exit (0);
            //}
        }
    }
}
