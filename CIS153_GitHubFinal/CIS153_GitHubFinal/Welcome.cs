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
        Board previewGame;
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

            SoundPlayer mainMenuSound = new SoundPlayer(Properties.Resources.alert1);
            mainMenuSound.Play();

            DialogResult result = MessageBox.Show("Confirm Exit. Clicking Yes will end the game.", "Exiting Game!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        // Brings up the multiplayer form
        private void btn_startGame_Click(object sender, EventArgs e)
        {
            bot_select = comboBox1.Text;
            rows_select = Int32.Parse(comboBox2.Text);
            columns_select = Int32.Parse(comboBox3.Text);
            streak_select = Int32.Parse(comboBox4.Text);
            //Console.WriteLine("In Welcome " + bot_select);
            GameBoard play = new GameBoard(this);
            play.Show();
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

        private void exitConnect4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoundPlayer mainMenuSound = new SoundPlayer(Properties.Resources.alert1);
            mainMenuSound.Play();

            DialogResult result = MessageBox.Show("Confirm Exit. Clicking Yes will end the game.", "Exiting Game!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void previewLastGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameBoard reviewPlay = new GameBoard(this);
            reviewPlay.Show();
            Hide();
            reviewPlay.setPreviewGame(previewGame);
        }

        public void setPreviewGame(Board game)
        {
            previewGame = game;
        }
    }

}
