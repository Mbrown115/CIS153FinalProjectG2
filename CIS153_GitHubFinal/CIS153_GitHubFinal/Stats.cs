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

namespace CIS153_GitHubFinal
{
    public partial class Stats : Form
    {
        Welcome menu;

        public Stats (Welcome w)
        {
            InitializeComponent ();
            menu = w;

            DisplayStats ();
        }

        private void btn_Menu_Click (object sender , EventArgs e)
        {
            menu.Show ();
            Close ();
        }

        private void btn_Exit_Click (object sender , EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirm Exit. Clicking Yes will end the game.", "Exiting Game!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void DisplayStats ()
        {
            //Placed the textfile in the "Debug" folder, from reading the default behavior is to look here
            //this way the filepath below should work, more concise that using the entire fielpath
            string filePath = "WinRecord.txt";
            string line = "";

            FileStream stats = new FileStream (filePath , FileMode.Open , FileAccess.Read);

            //while((line = stats.sp)
        }
    }
}
