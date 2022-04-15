
using System;

namespace CIS153_GitHubFinal
{
    public class cell
    {
        private float x;
        private float y;
        private int row;
        private int column;

        public cell(int r, int c)
        {
            setup((float)r, (float)c, r, c);
        }

        public cell(float Y, float X)
        {
            setup(Y, X, (int)Y, (int)X);
        }

        public void setup(float Y, float X, int r, int c)
        {
            this.x = X;
            if (Y > 0)
            {
                this.y = Y * -1;
            }
            else
            {
                this.y = Y;
            }
            this.row = r;
            this.column = c;
        }

        public int get_column()
        {
            return (this.column);
        }

        public int get_row()
        {
            return (this.row);
        }

        public float get_x()
        {
            return (this.x);
        }

        public float get_y()
        {
            return (this.y);
        }

        public bool same(cell a)
        {
            bool status = false;
            if ((this.x == a.x) && (this.y == a.y))
            {
                status = true;
            }
            return (status);
        }

        public void set_y(float y)
        {
            this.y = y;
        }

        public void display()
        {
            Console.WriteLine("x: {0} y: {1} column: {2} row: {3}", this.x, this.y, this.column, this.row);
        }
    }
    
}
