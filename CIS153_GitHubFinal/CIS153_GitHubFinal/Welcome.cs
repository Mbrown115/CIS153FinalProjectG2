//-=----------------------=-
//Authors: Michael Brown, Blake Taylor
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
using System.Threading;
using System.Media;

namespace CIS153_GitHubFinal
{

    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();

            SoundPlayer mainMenuSound = new SoundPlayer(Properties.Resources.connect4_Sound);
            mainMenuSound.Play();
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
            Hide();

        }

        private void btn_stats_Click(object sender, EventArgs e)
        {
            Stats viewStats = new Stats(this);

            viewStats.Show();
            Hide();
        }

        private void btn_single_Click(object sender, EventArgs e)
        {
            Single solo = new Single(this);

            solo.Show();
            Hide();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }
    }

}
