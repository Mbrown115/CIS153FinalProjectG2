using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS153_GitHubFinal
{
    public class Board
    {
        // Setting Variables
        private Rectangle[] columns;
        private int[,] board;

        // Constructor
        public Board()
        {

        }

        //-=-----setter-------=-
        public void setcolumns(Rectangle[] r)
        {
            columns = r;
        }

        public void setBoard(int[,] b)
        {
            board = b;
        }
        //-=-----end setter-------=-

        //-=-----getter-------=-
        public Rectangle[] getcolumns()
        {
            return columns;
        }

        public int[,] getboard()
        {
            return board;
        }
        //-=-----end getter-------=-
    }
}
