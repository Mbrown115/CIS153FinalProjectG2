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
    public partial class Stats : Form
        {
        Welcome menu;

        public Stats (Welcome w)
            {
            InitializeComponent ();
            menu = w;
            }

        private void btn_Menu_Click (object sender , EventArgs e)
            {
            menu.Show ();
            Close ();
            }

        private void btn_Exit_Click (object sender , EventArgs e)
        {
            Environment.Exit (0);
        }
    }
    }
