
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

namespace CIS153_GitHubFinal
{
    class board
    {
        private string winner;
        private bool game_over;
        private string bot;
        private int columns;
        private int rows;
        private int streak_target;
        private string[,] grid;
        private Button[,] buttons;
        private float height;
        private float width;
        private float diag;
        private cell last_token;
        private string current_player;
        private List<line> lines = new List<line>();
        private List<line> playable = new List<line>();
        private List<cell> streak_points = new List<cell>();
        private List<cell> book_ends = new List<cell>(); //AI
        private line streak_line; //AI
        private List<cell> possible_plays = new List<cell>(); //AI



        public board(int c, int r, int s, string b)
        {
            // enable bot
            if (b == "x")
            {
                this.bot = "x";
            }
            else if (b == "o")
            {
                this.bot = "o";
            }
            else
            {
                this.bot = "-";
            }
            this.streak_target = s;
            this.grid = new string[r, c];
            this.buttons = new Button[r, c];
            // build initial blank grid
            for (int y = 0; y < this.grid.GetLength(0); y += 1)
            {
                for (int x = 0; x < this.grid.GetLength(1); x += 1)
                {
                    this.grid[y, x] = "-";
                }
            }
            this.rows = this.grid.GetLength(0);
            this.columns = this.grid.GetLength(1);
            // figure playing geometry ( lines and points (cells) )
            get_playable_dimensions(s);
            this.find_lines();
            this.find_playable();
            this.points_on_line();
            this.current_player = "x";
            this.winner = "-";
            this.game_over = false;
        }

        public string get_bot()
        {
            return (this.bot);
        }

        public void bot_AI()
        {
            bool dropped = false;
            this.figure_possible_plays();
            this.display_possible_moves();
            //if (this.streak_of(3) == true)
            if (this.streak_of(this.streak_target-1) == true)
            {
                this.find_next_cells_of_streak();
                this.display_book_ends();
                foreach (cell C in this.book_ends)
                {
                    if (this.is_possible_move(C) == true)
                    {
                        Console.WriteLine("\nbot is playing in column: {0}\n", C.get_column());
                        dropped = drop_token(C.get_column());
                        if (dropped == true)
                        {
                            break;
                        }
                    }
                }
            }
            if (dropped == false)
            {
                dropped = drop_token(this.get_random_available_column());
            }
        }
        public int get_streak()
        {
            return (this.streak_target);
        }
        public void set_game_over(bool status)
        {
            this.game_over = status;
        }

        public bool get_game_over()
        {
            return (this.game_over);
        }

        public int get_random_available_column() //AI
        {
            int stack = -1;
            Random rand = new Random();
            List<int> available_stacks = new List<int>();
            for (int c = 0; c < this.get_columns(); c++)
            {
                if (this.get_token(0, c) == "-")
                {
                    available_stacks.Add(c);
                }
            }
            stack = available_stacks[rand.Next(0, available_stacks.Count)];
            return (stack);
        }

        public bool is_possible_move(cell C) //AI
        {
            bool status = false;
            foreach (cell P in this.possible_plays)
            {
                if (C.same(P) == true)
                {
                    status = true;
                    break;
                }
            }
            return (status);
        }

        public cell get_last_token()
        {
            return (this.last_token);
        }

        public void set_last_token(int row, int col)
        {
            this.last_token = new cell(row, col);
        }

        public string get_winner()
        {
            return (this.winner);
        }

        public void set_winner(string win)
        {
            this.winner = win;
        }

        public string get_player()
        {
            return (this.current_player);
        }

        public void set_player(string player)
        {
            this.current_player = player;
        }

        public int get_rows()
        {
            return (this.rows);
        }

        public int get_columns()
        {
            return (this.columns);
        }

        public Button get_button(int row, int col)
        {
            Button button = this.buttons[row, col];
            return (button);
        }

        public void set_button(int row, int col, Button button)
        {
            this.buttons[row, col] = button;
        }

        public string get_token(int row, int col)
        {
            //            Console.WriteLine("rc " + row + " " + col);
            string token = this.grid[row, col];
            return (token);
        }

        public void set_token(int row, int col, string token)
        {
            this.grid[row, col] = token;
        }

        public bool is_board_full()
        {
            bool full = true;
            for (int c = 0; c < this.get_columns(); c++)
            {
                if (this.get_token(0, c) == "-")
                {
                    full = false;
                    break;
                }
            }
            if (full == true)
            {
                this.game_over = true;
            }
            return (full);
        }

        public bool is_full(int col)
        {
            bool full = false;
            if (this.get_token(0, col) != "-")
            {
                full = true;
            }
            return (full);
        }

        public bool hover_token(int col)
        {
            Button button;
            bool status = false;
            string token;
            for (int row = this.get_rows() - 1; row >= 0; row--)
            {
                token = get_token(row, col);
                if (token == "-")
                {
                    button = this.get_button(row, col);
                    if (this.get_player() == "x")
                    {
                        button.BackColor = Color.FromArgb(230, 21, 205);
                    }
                    else if (this.get_player() == "o")
                    {
                        button.BackColor = Color.FromArgb(127,4,194);
                    }
                    this.set_last_token(row, col);
                    status = true;
                    break;
                }
            }
            return (status);
        }

        public void figure_possible_plays() //AI
        {
            this.possible_plays.Clear();
            string token;
            cell invalid_cell = new cell(-1, -1);
            for (int col = 0; col < this.get_columns(); col++)
            {
                if (this.get_token(0, col) == "-")
                {
                    for (int row = this.get_rows() - 1; row >= 0; row--)
                    {
                        token = get_token(row, col);
                        if (token == "-")
                        {
                            cell C = new cell(row, col);
                            this.possible_plays.Add(C);
                            break;
                        }
                    }
                }
                else
                {
                    this.possible_plays.Add(invalid_cell);
                }
            }
        }


        public void display_possible_moves()
        {
            Console.WriteLine("possible moves - start");
            foreach (cell c in this.possible_plays)
            {
                c.display();
            }
            Console.WriteLine("possible moves - end");

        }

        public void display_book_ends()
        {
            Console.WriteLine("book ends - start");
            foreach (cell c in this.book_ends)
            {
                c.display();
            }
            Console.WriteLine("book ends - end");

        }

        public void display_streak_points()
        {
            Console.WriteLine("streak points");
            foreach (cell c in this.streak_points)
            {
                c.display();
            }
        }

        public bool drop_token(int col)
        {
            bool status = false;
            string token;
            for (int row = this.get_rows() - 1; row >= 0; row--)
            {
                token = get_token(row, col);
                if (token == "-")
                {
                    this.set_token(row, col, this.current_player);
                    status = true;
                    break;
                }
            }
            return (status);
        }

        public void find_next_cells_of_streak() //AI
        {
            this.display();
            this.display_streak_points();
            //this.streak_line.display();
            this.book_ends.Clear();
            line S = this.streak_line;
            bool after_streak = false;
            cell fsc = this.streak_points[0];
            cell lsc = this.streak_points[this.streak_points.Count - 1];
            Console.WriteLine("streak");
            Console.WriteLine("fsc");
            fsc.display();
            Console.WriteLine("lsc");
            lsc.display();
            Console.WriteLine("streak");
            cell prev_cell = new cell(-1, -1);
            foreach (cell C in S.get_points_on_line())
            {
                C.display();
                Console.WriteLine("token: {0}", this.get_token(C.get_row(), C.get_column()));
                if ((C.same(fsc)) || (C.same(lsc)))
                {
                    if (this.book_ends.Count == 0)
                    {
                        if (this.get_token(prev_cell.get_row(), prev_cell.get_column()) == "-")
                        {
                            Console.WriteLine("\nadd first be");
                            prev_cell.display();
                            Console.WriteLine("prev_cell token: {0}\n", this.get_token(prev_cell.get_row(), prev_cell.get_column()));
                            book_ends.Add(prev_cell);
                        }
                    }
                    else
                    {
                        after_streak = true;
                    }
                }
                else if (after_streak == true)
                {
                    // only add this point if it is blank
                    if (this.get_token(C.get_row(), C.get_column()) == "-")
                    {
                        this.book_ends.Add(C);
                        break;
                    }
                    else
                    {
                        break;
                    }

                }
                prev_cell = C;
            }
        }

        public bool streak_of(int streak_size)
        {
            bool streak = false;
            string empty = "-";
            string streak_token = "";
            int current_streak = 0;
            string current_element = "";
            List<cell> line_streak_points = new List<cell>();
            foreach (line L in this.playable)
            {
                line_streak_points.Clear();
                streak_token = " ";
                current_streak = 0;
                foreach (cell P in L.get_points_on_line())
                {
                    try
                    {
                        current_element = grid[P.get_row(), P.get_column()];
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
                            line_streak_points.Clear(); // testing if this stops the straggling point
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
                        this.streak_line = L; //AI
                    }
                }
                if (streak == true)
                {
                    this.streak_points = line_streak_points;
                    //this.display_streak_points();
                    break; //this may break the program
                }
                else
                {
                    //his.streak_points.Clear();
                }
            }
            return (streak);
        }

        public void points_on_line()
        {
            for (int row_index = 0; row_index < this.grid.GetLength(0); row_index++)
            {
                for (int col_index = 0; col_index < this.grid.GetLength(1); col_index++)
                {
                    cell test = new cell(row_index, col_index);
                    foreach (line L in this.playable)
                    {
                        if (L.point_on_line(test))
                        {
                            L.add_point(test);
                        }
                    }
                }
            }
        }

        public void get_playable_dimensions(int streak_size)
        {
            this.height = this.grid.GetLength(0) - 1;
            this.width = this.grid.GetLength(1) - 1;
            Console.WriteLine("height: {0} width: {1}", height, width);
            this.diag = (float)Math.Sqrt(Math.Pow((height - 1), 2) + Math.Pow((width - 1), 2));
            //this.diag = (float)Math.Sqrt(Math.Pow((streak_size - 1), 2) + Math.Pow((streak_size - 1), 2));
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
                if ((L.get_no_slope() == true) || (L.get_slope() == 0.0) || (L.get_slope() == 1.0) || (L.get_slope() == -1.0))
                {
                    if (((L.get_no_slope() == true) && (L.get_length() == height)) || ((L.get_slope() == 0.0) && (L.get_length() == width)) || (((L.get_slope() == 1.0) || L.get_slope() == -1.0) && (L.get_length() >= diag)))
                    {
                        this.playable.Add(L);
                    }
                }
            }
        }

        public void find_lines()
        {
            for (int a_row_index = 0; a_row_index < this.grid.GetLength(0); a_row_index++)
            {
                for (int a_col_index = 0; a_col_index < this.grid.GetLength(1); a_col_index++)
                {
                    cell a = new cell(a_row_index, a_col_index);
                    if (is_point_on_perimeter(a))
                    {
                        for (int b_row_index = 0; b_row_index < this.grid.GetLength(0); b_row_index++)
                        {
                            for (int b_col_index = 0; b_col_index < this.grid.GetLength(1); b_col_index++)
                            {
                                cell b = new cell(b_row_index, b_col_index);
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
                if (L.same(l))
                {
                    status = true;
                    break;
                }
            }
            return (status);
        }

        // when building playable lines we only want lines between cells on the perimeter
        public bool is_point_on_perimeter(cell a)
        {
            bool status = false;
            int x = (int)a.get_x();
            int y = (int)a.get_y();
            status = is_point_on_perimeter(y, x);
            return (status);
        }

        public bool is_point_on_perimeter(int y, int x)
        {
            bool status = false;
            int height = this.grid.GetLength(0) - 1;
            int width = this.grid.GetLength(1) - 1;
            int[] h_range = { 0, height };
            int[] w_range = { 0, width };
            if (h_range.Contains(Math.Abs(y)) || w_range.Contains(Math.Abs(x)))
            {
                status = true;
            }
            return (status);
        }
        public void display()
        {
            for (int y = 0; y < this.grid.GetLength(0); y++)
            {
                for (int x = 0; x < this.grid.GetLength(1); x++)
                {
                    Console.Write(this.grid[y, x]);
                }
                Console.WriteLine();
            }
        }
    }

}
