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
using System.Threading;

namespace CIS153_GitHubFinal
{
    public partial class Single : Form
    {
        Welcome menu;

        public Single(Welcome sp)
        {
            InitializeComponent();
            menu = sp;
        }

        private void displayTurn()
        {
            //Display the player turn status in the label at the bottom of form

            // lbl_PlayerTurn.Text = 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
