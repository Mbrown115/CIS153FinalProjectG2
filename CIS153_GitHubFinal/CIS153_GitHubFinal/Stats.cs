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
        Players newScores = new Players();
        private List<Players> listOfScores = new List<Players>();
        public Stats()
        {
            InitializeComponent();
        }

        public Stats(Welcome w)
        {
            InitializeComponent();
            menu = w;

            updateList();
            displayStats();
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            menu.Show();
            Close();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {

        }

        public void displayStats()
        {
            for (int i = 0; i < listOfScores.Count; i++)
            {
                newScores.setXWins(listOfScores[i].getXWins() + 1);
                newScores.setOWins(listOfScores[i].getOWins());
                newScores.setTies(listOfScores[i].getTies());
                newScores.setTimesPlayed(listOfScores[i].getTimesPlayed());
            }

            for (int i = 0; i < listOfScores.Count; i++)
            {
                listBx_Stats.Items.Add("Player X Wins: " + listOfScores[i].getXWins());
                if (listOfScores[i].getTimesPlayed() != 0)
                {
                    listBx_Stats.Items.Add("Win Percentage: " + listOfScores[i].getXWins() / listOfScores[i].getTimesPlayed() + " %");
                }
                else
                {
                    listBx_Stats.Items.Add("Win Percentage: 0 %");
                }
                listBx_Stats.Items.Add("Player O Wins: " + listOfScores[i].getOWins());
                if (listOfScores[i].getTimesPlayed() != 0)
                {
                    listBx_Stats.Items.Add("Win Percentage: " + listOfScores[i].getOWins() / listOfScores[i].getTimesPlayed() + " %");
                }
                else
                {
                    listBx_Stats.Items.Add("Win Percentage: 0 %");
                }
                listBx_Stats.Items.Add("Ties: " + listOfScores[i].getTies());
                listBx_Stats.Items.Add("Total Games Played: " + listOfScores[i].getTimesPlayed());
            }
        }

        public void updateList()
        {
            string filePath = "Records.txt";
            Players newScores = new Players();
            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (var line in lines)
            {
                String[] words = line.Split(',');

                newScores.setXWins(Int32.Parse(words[0]));
                newScores.setOWins(Int32.Parse(words[1]));
                newScores.setTies(Int32.Parse(words[2]));
                newScores.setTimesPlayed(Int32.Parse(words[3]));
                listOfScores.Add(newScores);
            }
        }

        public void updateXWins()
        {
            string filePath = "Records.txt";
            StreamWriter statsWrite = new StreamWriter(filePath);

            for (int i = 0; i < listOfScores.Count; i++)
            {
                newScores.setXWins(listOfScores[i].getXWins() + 1);
                newScores.setOWins(listOfScores[i].getOWins());
                newScores.setTies(listOfScores[i].getTies());
                newScores.setTimesPlayed(listOfScores[i].getTimesPlayed());
            }

            statsWrite.WriteLine(newScores.getXWins() + "," + newScores.getOWins() + "," + newScores.getTies() + "," + newScores.getTimesPlayed());
            statsWrite.Flush();
            statsWrite.Close();
        }

        public void updateOWins()
        {
            string filePath = "Records.txt";
            StreamWriter statsWrite = new StreamWriter(filePath);

            for (int i = 0; i < listOfScores.Count; i++)
            {
                newScores.setXWins(listOfScores[i].getXWins());
                newScores.setOWins(listOfScores[i].getOWins() + 1);
                newScores.setTies(listOfScores[i].getTies());
                newScores.setTimesPlayed(listOfScores[i].getTimesPlayed());
            }

            statsWrite.WriteLine(newScores.getXWins() + "," + newScores.getOWins() + "," + newScores.getTies() + "," + newScores.getTimesPlayed());
            statsWrite.Flush();
            statsWrite.Close();
        }

        public void updateTies()
        {
            string filePath = "Records.txt";
            StreamWriter statsWrite = new StreamWriter(filePath);

            for (int i = 0; i < listOfScores.Count; i++)
            {
                newScores.setXWins(listOfScores[i].getXWins());
                newScores.setOWins(listOfScores[i].getOWins());
                newScores.setTies(listOfScores[i].getTies() + 1);
                newScores.setTimesPlayed(listOfScores[i].getTimesPlayed());
            }

            statsWrite.WriteLine(newScores.getXWins() + "," + newScores.getOWins() + "," + newScores.getTies() + "," + newScores.getTimesPlayed());
            statsWrite.Flush();
            statsWrite.Close();
        }

        public void updateGames()
        {
            string filePath = "Records.txt";
            StreamWriter statsWrite = new StreamWriter(filePath);

            for (int i = 0; i < listOfScores.Count; i++)
            {
                newScores.setXWins(listOfScores[i].getXWins());
                newScores.setOWins(listOfScores[i].getOWins());
                newScores.setTies(listOfScores[i].getTies());
                newScores.setTimesPlayed(listOfScores[i].getTimesPlayed() + 1);
            }

            statsWrite.WriteLine(newScores.getXWins() + "," + newScores.getOWins() + "," + newScores.getTies() + "," + newScores.getTimesPlayed());
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

        private void howToPlayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HowToPlay rules = new HowToPlay();
            rules.Show();
        }

        private void readMeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}