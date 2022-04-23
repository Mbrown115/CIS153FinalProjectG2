﻿using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace CIS153_GitHubFinal
{
    public partial class GameBoard : Form
    {
        board game;
        Welcome menu;
        int[,] b = new int[6, 7];


        public GameBoard()
        {
            InitializeComponent();
            btn_NewGame.Visible = false;
            btn_Quit.Visible = false;
        }

        public GameBoard(Welcome fml)
        {
            InitializeComponent();
            GameTest();
            menu = fml;

            btn_NewGame.Visible = false;
            btn_Quit.Visible = false;
        }

        public void GameTest()
        {
            int columns = 7;
            int rows = 6;
            int streak = 4;
            string bot = Welcome.bot_select;
            rows = Welcome.rows_select;
            columns = Welcome.columns_select;
            streak = Welcome.streak_select;
            Console.WriteLine("in multiplayer col: {0} row: {1} streak: {2} bot: {3} ", columns, rows, streak, bot);
            game = new board(columns, rows, streak, bot);
            var rowCount = game.get_rows();
            var columnCount = game.get_columns();

            this.tableLayoutPanel1.ColumnCount = columnCount;
            this.tableLayoutPanel1.RowCount = rowCount;

            this.tableLayoutPanel1.ColumnStyles.Clear();
            this.tableLayoutPanel1.RowStyles.Clear();

            for (int i = 0; i < columnCount; i++)
            {
                this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100 / columnCount));
            }
            for (int i = 0; i < rowCount; i++)
            {
                this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100 / rowCount));
            }

            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    var button = new Button();
                    button.Name = string.Format("{0}:{1}", i, j);
                    button.Click += MyButtonClick;
                    button.MouseEnter += MyButtonHover;
                    button.MouseLeave += MyButtonHoverExit;
                    button.Dock = DockStyle.Fill;
                    this.tableLayoutPanel1.Controls.Add(button, j, i);
                    game.set_button(i, j, button);
                }
            }
            DrawBoard();
            // this makes the bot play first if it is player x
            if (game.get_bot() == "x")
            {
                play_bot_round();
            }
        }
        void DrawBoard()
        {
            Button button;
            string token;

            for (int r = 0; r < game.get_rows(); r++)
            {
                for (int c = 0; c < game.get_columns(); c++)
                {
                    button = game.get_button(r, c);
                    token = game.get_token(r, c);

                    if (token == "-")
                    {
                        button.BackColor = Color.FromArgb(25, 192, 0, 192);
                    }
                    else if (token == "x")
                    {
                        button.BackColor = Color.FromArgb(230, 21, 205);
                    }
                    else if (token == "o")
                    {
                        button.BackColor = Color.FromArgb(127, 4, 194);
                    }
                }
            }
        }
        void MyButtonHover(object sender, EventArgs e)
        {
            Button button = sender as Button;
            String[] indexes = button.Name.Split(':');
            int row = Int16.Parse(indexes[0]);
            int column = Int16.Parse(indexes[1]);

            if (game.is_full(column) == false)
            {
                game.hover_token(column);
            }
        }
        void MyButtonHoverExit(object sender, EventArgs e)
        {
            cell lasttoken = game.get_last_token();
            if (game.get_token(lasttoken.get_row(), lasttoken.get_column()) == "-")
            {
                Button button = game.get_button(lasttoken.get_row(), lasttoken.get_column());
                button.BackColor = Color.FromArgb(25, 192, 0, 192);
            }
        }
        void MyButtonClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            //bool dropped = false;
            String[] indexes = button.Name.Split(':');
            int row = Int16.Parse(indexes[0]);
            int column = Int16.Parse(indexes[1]);
            string token = game.get_token(row, column);

            if (check_game_over() == false) // stops the game from continuing
            {
                play_player_round(column);
            }
            if ((game.get_bot() != "-") && (check_game_over() == false))
            {
                play_bot_round();
            }
            check_game_over();
        }
        //here you can check which button was clicked by the sender

        bool check_game_over()
        {
            bool status = false;
            Console.WriteLine("streak_size: {0}", game.get_streak());
            if (game.streak_of(game.get_streak()) == true)
            {
                // set the winner to the previous player as we have already changed to next player
                if (game.get_player() == "x")
                {
                    game.set_winner("o");
                    picBx_WinLose.Image = Properties.Resources.FinalPlayer_Opng;
                    lbl_NewGame.Visible = true;
                    btn_NewGame.Visible = true;
                    btn_Quit.Visible = true;                    
                }
                else if (game.get_player() == "o")
                {
                    game.set_winner("x");
                    picBx_WinLose.Image = Properties.Resources.FinalPlayer_Xpng;
                    lbl_NewGame.Visible = true;
                    btn_NewGame.Visible = true;
                    btn_Quit.Visible = true;             
                }
                Console.WriteLine("Winner is " + game.get_winner());
                tableLayoutPanel1.Hide();
                picBx_WinLose.Visible = true;
                game.set_game_over(true);
                status = true;
            }
            else if (game.is_board_full() == true)
            {
                Console.WriteLine("Draw");
                status = true;
            }
            else
            {
                Console.WriteLine("Play On!!!");
            }
            return (status);
        }

        void play_player_round(int column)
        {
            bool dropped = false;
            if (game.is_full(column) == false)
            {
                dropped = game.drop_token(column);
            }
            if (dropped == true)
            {
                DrawBoard();
                change_player();
            }
        }
        void play_bot_round()
        {
            Thread.Sleep(100);
            game.bot_AI();
            Thread.Sleep(100);
            DrawBoard();
            Thread.Sleep(100);
            change_player();
        }
        void change_player()
        {
            if (game.get_player() == "x")
            {
                game.set_player("o");
                lbl_TurnIndicator.Visible = true;
                lbl_TurnIndicator.Text = "Player O, make a move!";

            }
            else
            {
                game.set_player("x");
                lbl_TurnIndicator.Visible = true;
                lbl_TurnIndicator.Text = "Player X, make a move!";
            }
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

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SoundPlayer mainMenuSound = new SoundPlayer(Properties.Resources.alert1);
            mainMenuSound.Play();

            DialogResult result = MessageBox.Show("Quit current game? Clicking yes wil exit the game.", "Quit game?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                Close();
                menu.Show();
            }

        }

        private void leaderBoardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Stats viewStats = new Stats();
            viewStats.Show();
            Hide();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_NewGame_Click(object sender, EventArgs e)
        {

        }

        private void btn_Quit_Click(object sender, EventArgs e)
        {

        }
    }
}

