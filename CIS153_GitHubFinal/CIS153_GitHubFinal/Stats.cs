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
using System.Media;

namespace CIS153_GitHubFinal
{
    public partial class Stats : Form
    {
        Welcome menu;
        public Stats()
        {
            InitializeComponent();
        }

        public Stats (Welcome w)
        {
            InitializeComponent();
            menu = w;

            DisplayStats();
            updateFile();
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

        public void DisplayStats()
        {
            string filePath = "Records.txt";

            StreamReader statsRead = new StreamReader(filePath);
            string line = statsRead.ReadLine();

            while (line != null)
            {
                String[] words = line.Split(',');
                Players newScores = new Players();

                newScores.setPlayerWins(Int32.Parse(words[0]));
                newScores.setAIWins(Int32.Parse(words[1]));
                newScores.setTies(Int32.Parse(words[2]));
                newScores.setTimesPlayed(Int32.Parse(words[3]));

                line = statsRead.ReadLine();
                //Console.WriteLine(newScores.getPlayerWins());
            }

            statsRead.Close();
        }

        public void updateFile()
        {
            string filePath = "Records.txt";

            StreamWriter statsWrite = new StreamWriter(filePath);
            Players newScores = new Players();
            statsWrite.WriteLine(newScores.getPlayerWins() + "," + newScores.getAIWins() + "," + newScores.getTies() + "," + newScores.getTimesPlayed());

            //Console.WriteLine(newScores.getPlayerWins());

            statsWrite.Flush();
            statsWrite.Close();
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            menu.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoundPlayer mainMenuSound = new SoundPlayer(Properties.Resources.alert1);
            mainMenuSound.Play();

            DialogResult result = MessageBox.Show("Would you like to end the game? \n\n    'Yes' to close the program \n\n    'No' to return to the game.", "Quit game?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
