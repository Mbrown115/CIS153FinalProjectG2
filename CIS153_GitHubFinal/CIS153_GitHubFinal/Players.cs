using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//This class will be responsible for Creating list of Players
//These players will be used to store Win/Loss STATS for individual players

namespace CIS153_GitHubFinal
{
    public class Players
    {
        private string name;
        private int wins;
        private int loss;

        private int playerWin;
        private int aiWin;
        private int tie;
        private int timesPlayed;

        //Constructor
        public Players()
        {

        }

        //--------------------SETTERS--------------------------

        public void setWins(int w)
        {
            wins = w;
        }

        public void setPlayerWins(int w)
        {
            playerWin = w;
        }

        public void setAIWins(int w)
        {
            aiWin = w;
        }

        public void setTies(int t)
        {
            tie = t;
        }

        public void setTimesPlayed(int tp)
        {
            timesPlayed = tp;
        }

        //-----------------------------------------------------



        //--------------------GETTERS--------------------------
        public string getPlayerName()
        {
            return name;
        }

        public int getWins()
        {
            return wins;
        }

        public int getPlayerLoss()
        {
            return loss;
        }

        public int getPlayerWins()
        {
            return playerWin++;
        }

        public int getAIWins()
        {
            return aiWin;
        }

        public int getTies()
        {
            return tie;
        }

        public int getTimesPlayed()
        {
            return timesPlayed;
        }
        //-----------------------------------------------------

    }
}
