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
        Form1 menu;
        public Multiplayer()
        {
            InitializeComponent();
        }

        public Multiplayer(Form1 fml)
        {
            InitializeComponent();
            menu = fml;
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Hide();
        }
    }
}
