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
        Players players;

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

        public void DisplayStats()
        {
            string filePath = "";
            int count = 0;
            string playerWins = "";
            string aiWins = "";
            string ties = "";
            string timesPlayed = "";

            try
            {
                filePath = "CIS153_GitHubFinal/Properties/Resources.Records";
                Console.WriteLine("Opened");
            }
            catch (Exception e)
            {
                Console.WriteLine("file cannot open" + e.Message);
            }
            String[] words = filePath.Split(',');

            foreach (String word in words)
            {
                if (count == 0)
                {
                    playerWins = word;
                    count++;
                }
                else if (count == 1)
                {
                    aiWins = word;
                    count++;
                }
                else if (count == 2)
                {
                    ties = word;
                    count++;
                }
                else if (count == 3)
                {
                    timesPlayed = word;
                    count = 0;
                }
            }

            //just testing the display
            listBx_Stats.Items.Add("Number of Player Wins: " + playerWins);
            listBx_Stats.Items.Add("Number of AI Wins: " + aiWins);
            listBx_Stats.Items.Add("Number of Ties: " + ties);
            listBx_Stats.Items.Add("Number of times game has been played: " + timesPlayed);
        }

        public void updateFile()
        {
            string filePath = "CIS153_GitHubFinal/Properties/Resources/Records";
            StreamWriter write = File.AppendText(filePath);

            //write.WriteLine("test" + " " + "test");
            //write.WriteLine("testing");
            //write.Flush();
            write.Close();
        }
    }
}
