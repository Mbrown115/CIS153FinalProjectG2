//-=----------------------=-
//Authors: Michael Brown, 
//Date:    3/28/2022
//Desc:    Connect 4
//-=----------------------=-

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
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Exits the program
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        // Brings up the multiplayer form
        private void btn_multiplayer_Click(object sender, EventArgs e)
        {
            Multiplayer Dual = new Multiplayer(this);

            Dual.Show();
            this.Hide();

        }
    }
}
