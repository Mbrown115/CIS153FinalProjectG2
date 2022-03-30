using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS153_GitHubFinal
{
    public class Cell
    {
        // Setting variables
        private int neutral;
        private int player1;
        private int player2;

        // Constructor
        public Cell()
        {

        }

        //-=--------setters----------=-
        public void setNeutral(int n)
        {
            neutral = n;
        }
        public void setPlayer1(int p1)
        {
            player1 = p1;
        }
        public void setPlayer2(int p2)
        {
            player2 = p2;
        }
        //-=--------end setters----------=-

        //-=--------getters----------=-
        public int getNeutral()
        {
            return neutral;
        }
        public int getPlayer1()
        {
            return player1;
        }
        public int getPlayer2()
        {
            return player2;
        }
        //-=--------end getters----------=-
    }
}
