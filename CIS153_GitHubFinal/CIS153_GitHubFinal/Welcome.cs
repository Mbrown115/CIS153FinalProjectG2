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

namespace CIS153_GitHubFinal
{

    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
            GameTest();
        }

        // Exits the program
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        // Brings up the multiplayer form
        private void btn_multiplayer_Click(object sender, EventArgs e)
        {
            Multiplayer Dual = new Multiplayer(this);

            Dual.Show();
            Hide();

        }

        private void btn_stats_Click(object sender, EventArgs e)
        {
            Stats viewStats = new Stats(this);

            viewStats.Show();
            Hide();
        }

        private void btn_single_Click(object sender, EventArgs e)
        {
            Single solo = new Single(this);

            solo.Show();
            Hide();
        }
        public void GameTest()
        {
            int columns = 7;
            int rows = 6;
            int streak = 4;
            C4 game = new C4(columns, rows, streak);
            //game.find_lines();
            //game.find_playable();
            //game.points_on_line();


            game.board = new string[6, 7] {
            { "x", "x", "-", "-", "-", "-", "-"},
            { "-", "-", "x", "-", "-", "-", "-"},
            { "-", "-", "-", "x", "-", "-", "-"},
            { "-", "-", "-", "-", "x", "-", "-"},
            { "-", "-", "-", "-", "-", "-", "-"},
            { "-", "-", "-", "-", "-", "-", "-"},
        };


            if (game.streak_of(4) == true)
            {
                Console.WriteLine("Winner");
            }
            else
            {
                Console.WriteLine("Play On!!!");
            }
        }

    }

    class C4
    {
        int columns;
        int rows;
        public string[,] board;
        public float height;
        public float width;
        public float diag;
        List<line> lines = new List<line>();
        List<line> playable = new List<line>();
        List<point> streak_points = new List<point>();

        public C4(int c, int r, int s)
        {
            this.board = new string[r, c];
            for (int y = 0; y < this.board.GetLength(0); y += 1)
            {
                for (int x = 0; x < this.board.GetLength(1); x += 1)
                {
                    this.board[y, x] = "-";
                }
            }
            get_playable_dimensions(s);
            this.find_lines();
            this.find_playable();
            this.points_on_line();
        }

        public bool streak_of(int streak_size)
        {
            bool streak = false;
            string empty = "-";
            string streak_token = "";
            int current_streak = 0;
            string current_element = "";
            List<point> line_streak_points = new List<point>();
            foreach (line L in this.playable)
            {
                line_streak_points.Clear();
                streak_token = " ";
                current_streak = 0;
                foreach (point P in L.points_on_line)
                {
                    try
                    {
                        current_element = board[P.row, P.column];
                    }
#pragma warning disable 0168
                    catch (Exception e)
#pragma warning restore 0168
                    {
                        current_element = "-";
                        Console.WriteLine("");
                        Console.WriteLine("HuH!?!");
                        P.display();
                        Console.WriteLine("");
                        Thread.Sleep(20);
                    }
                    //                current_element = board[P.row, P.column];
                    if (current_element == empty)
                    {
                        streak_token = empty;
                        current_streak = 0;
                        if (streak == true)
                        {
                            break;
                        }
                        else
                        {
                            line_streak_points.Clear();
                        }
                    }
                    else if (current_element != streak_token)
                    {
                        streak_token = current_element;
                        current_streak = 1;
                        if (streak == true)
                        {
                            break;
                        }
                        else
                        {
                            line_streak_points.Add(P);
                        }
                    }
                    else if (current_element == streak_token)
                    {
                        current_streak++;
                        line_streak_points.Add(P);
                    }
                    if (current_streak == streak_size)
                    {
                        streak = true;
                    }
                }
                if (streak == true)
                {
                    this.streak_points = line_streak_points;
                }
                else
                {
                    this.streak_points.Clear();
                }
            }
            return (streak);
        }

        public void points_on_line()
        {
            for (int row_index = 0; row_index < this.board.GetLength(0); row_index++)
            {
                for (int col_index = 0; col_index < this.board.GetLength(1); col_index++)
                {
                    point test = new point(row_index, col_index);
                    foreach (line L in this.playable)
                    {
                        if (L.point_on_line(test))
                        {
                            L.points_on_line.Add(test);
                        }
                    }
                }
            }
        }

        public void get_playable_dimensions(int streak_size)
        {
            this.height = this.board.GetLength(0) - 1;
            this.width = this.board.GetLength(1) - 1;
            this.diag = (float)Math.Sqrt(Math.Pow((streak_size - 1), 2) + Math.Pow((streak_size - 1), 2));
            Console.WriteLine("height: {0}, width: {1}, diag: {2}", this.height, this.width, this.diag);
            if ((this.height < streak_size) || (this.width < streak_size) || (this.diag < streak_size))
            {
                Console.WriteLine("board too small for streak of {0}", streak_size);
                while (true == true)
                {
                    // infinite loop to hold program
                }
            }
        }

        public void find_playable()
        {
            foreach (line L in this.lines)
            {
                if ((L.no_slope == true) || (L.slope == 0.0) || (L.slope == 1.0) || (L.slope == -1.0))
                {
                    if (((L.no_slope == true) && (L.length == height)) || ((L.slope == 0.0) && (L.length == width)) || (((L.slope == 1.0) || L.slope == -1.0) && (L.length >= diag)))
                    {
                        this.playable.Add(L);
                    }
                }
            }
        }

        public void find_lines()
        {
            for (int a_row_index = 0; a_row_index < this.board.GetLength(0); a_row_index++)
            {
                for (int a_col_index = 0; a_col_index < this.board.GetLength(1); a_col_index++)
                {
                    point a = new point(a_row_index, a_col_index);
                    if (is_point_on_perimeter(a))
                    {
                        for (int b_row_index = 0; b_row_index < this.board.GetLength(0); b_row_index++)
                        {
                            for (int b_col_index = 0; b_col_index < this.board.GetLength(1); b_col_index++)
                            {
                                point b = new point(b_row_index, b_col_index);
                                if (is_point_on_perimeter(b))
                                {
                                    if (a.same(b))
                                    {
                                        continue;
                                    }
                                    line current = new line(a, b);
                                    line reverse = new line(b, a);
                                    if (line_exists(reverse))
                                    {
                                        // skip
                                    }
                                    else
                                    {
                                        this.lines.Add(current);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        public bool line_exists(line l)
        {
            bool status = false;
            foreach (line L in this.lines)
            {
                if ((L.a.same(l.a)) && (L.b.same(l.b)))
                {
                    status = true;
                    break;
                }
            }
            return (status);
        }

        public bool is_point_on_perimeter(point a)
        {
            bool status = false;
            int x = (int)a.x;
            int y = (int)a.y;
            status = is_point_on_perimeter(y, x);
            return (status);
        }

        public bool is_point_on_perimeter(int y, int x)
        {
            bool status = false;
            int height = this.board.GetLength(0) - 1;
            int width = this.board.GetLength(1) - 1;
            int[] h_range = { 0, height };
            int[] w_range = { 0, width };
            /*
            if ((y == -5) && (x == 5))
            {
                Console.WriteLine("!!!!!!!!!!!!!!checking point!!!!!!!!!!!!!!!!!!!!!!");
                Console.WriteLine("h: {0} w: {1}", height, width);
                Thread.Sleep(100);
            }
            */
            //        if (h_range.Contains(y)||w_range.Contains(x))
            if (h_range.Contains(Math.Abs(y)) || w_range.Contains(Math.Abs(x)))
            {
                status = true;
            }
            return (status);
        }

        public void display()
        {
            for (int y = 0; y < this.board.GetLength(0); y++)
            {
                for (int x = 0; x < this.board.GetLength(1); x++)
                {
                    Console.Write(this.board[y, x]);
                }
                Console.WriteLine();
            }
        }

        static void junk(string[] args)
        {
            int columns = 6;
            int rows = 7;
            C4 game = new C4(6, 7, 4);
            game.find_lines();
            game.find_playable();
            game.points_on_line();

            game.board = new string[6, 7] {
                            {"x","-","-","-","-","-","-"},
                            {"-","x","-","-","-","-","-"},
                            {"-","-","x","-","-","-","-"},
                            {"-","-","-","x","-","-","-"},
                            {"-","-","-","-","-","-","-"},
                            {"-","-","-","-","-","-","-"},
                        };

            if (game.streak_of(4) == true)
            {
                Console.WriteLine("Winner");
            }
            else
            {
                Console.WriteLine("Play on!!!");
            }

        }
    }

    public class line
    {
        public point a;
        public point b;
        public bool no_slope = false;
        public float slope;
        public float length;
        public float y_intercept;
        public List<point> points_on_line = new List<point>();

        public line(float y1, float x1, float y2, float x2)
        {
            this.a = new point(x1, y1);
            this.b = new point(x2, y2);
            setup();
        }

        public line(point a, point b)
        {
            this.a = a;
            this.b = b;
            setup();
        }

        public void setup()
        {
            get_slope();
            get_length();
            get_y_intercept();
        }

        public bool point_on_line(point p)
        {
            bool on_line = false;
            if (this.is_vertical())
            {
                if (p.x == a.x)
                {
                    on_line = true;
                }
            }
            else
            {
                if (p.y == this.slope * p.x + this.y_intercept)
                {
                    on_line = true;
                }
            }
            return (on_line);
        }

        public bool is_vertical()
        {
            bool vertical = false;
            if (a.x == b.x)
            {
                vertical = true;
            }
            return (vertical);
        }

        public void get_y_intercept()
        {
            float m = this.slope;
            this.y_intercept = (float)this.a.y - m * this.a.x;
        }

        public void get_length()
        {
            this.length = (float)Math.Sqrt(Math.Pow((b.x - a.x), 2) + Math.Pow((b.y - a.y), 2));
        }

        public void get_slope()
        {
            float slope;
            try
            {
                this.slope = (this.b.y - this.a.y) / (this.b.x - this.a.x);
                this.no_slope = false;
            }
#pragma warning disable 0168
            catch (DivideByZeroException e)
#pragma warning restore 0168
            {
                this.no_slope = true;
            }
            if (Double.IsNaN(this.slope) || Double.IsInfinity(this.slope))
            {
                this.no_slope = true;
            }
        }

        public void display()
        {
            string slope = this.slope.ToString();
            if (this.no_slope == true)
            {
                slope = "no_slope";
            }
            Console.WriteLine("ax: {0}, ay: {1}, bx: {2}, by: {3}, slope: {4}, length: {5}", this.a.x, this.a.y, this.b.x, this.b.y, slope.PadLeft(8, ' '), this.length);
        }

    }

    public class point
    {
        public float x;
        public float y;
        public int row;
        public int column;

        public point(int r, int c)
        {
            setup((float)r, (float)c, r, c);
        }

        public point(float Y, float X)
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

        public bool same(point a)
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
