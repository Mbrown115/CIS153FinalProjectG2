using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CIS153_GitHubFinal
{
    public class Players
    {
        private int xWin;
        private int oWin;
        private int tie;
        private int timesPlayed;

        //Constructor
        public Players()
        {

        }

        //--------------------SETTERS--------------------------
        public void setXWins(int w)
        {
            xWin = w;
        }

        public void setOWins(int w)
        {
            oWin = w;
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
        public int getXWins()
        {
            return xWin;
        }

        public int getOWins()
        {
            return oWin;
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