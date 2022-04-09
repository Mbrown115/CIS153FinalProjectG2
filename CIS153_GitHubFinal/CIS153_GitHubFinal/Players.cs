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

        //Constructor
        public Players()
        {

        }

        //--------------------SETTERS--------------------------

        public void setPlayerName(string n)
        {
            name = n;
        }

        public void setPlayerWins(int w)
        {
            wins = w;
        }

        public void setPlayerLoss(int l)
        {
            loss = l;
        }
        //-----------------------------------------------------



        //--------------------GETTERS--------------------------
        public string getPlayerName()
        {
            return name;
        }

        public int getPlayerWins()
        {
            return wins;
        }

        public int getPlayerLoss()
        {
            return loss;
        }
        //-----------------------------------------------------

    }
}
