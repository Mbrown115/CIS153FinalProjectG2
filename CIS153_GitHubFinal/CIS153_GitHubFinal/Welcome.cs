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
        public static string bot_select = "-";
        public static int rows_select = 6;
        public static int columns_select = 7;
        public static int streak_select = 4;
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
            bot_select = comboBox1.Text;
            rows_select = Int32.Parse(comboBox2.Text);
            columns_select = Int32.Parse(comboBox3.Text);
            streak_select = Int32.Parse(comboBox4.Text);
            //Console.WriteLine("In Welcome " + bot_select);
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

        private void Welcome_Load(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }

}
