
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace CIS153_GitHubFinal
{
    public partial class Multiplayer : Form
    {
        board game;
        Welcome menu;
        int[,] b = new int[6, 7];


        public Multiplayer()
        {
            InitializeComponent();

            //Board theBoard = new Board();
            //theBoard.setcolumns(new Rectangle[7]);
            //theBoard.setBoard(b);
        }

        public Multiplayer(Welcome fml)
        {
            InitializeComponent();
            GameTest();
            menu = fml;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Confirm Exit. Clicking Yes will end the game.", "Exiting Game!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void displayTurn()
        {
            //this will display the current players turn status in the label at the bottom
            //of the game screen.

            // lbl_PlayTurn.Text = 
        }

        public void GameTest()
        {
            int columns = 7;
            int rows = 6;
            int streak = 4;
            game = new board(columns, rows, streak, "o");
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

                        button.BackColor = Color.White;
                    }
                    else if (token == "x")
                    {
                        button.BackColor = Color.Red;
                    }
                    else if (token == "o")
                    {
                        button.BackColor = Color.Black;
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
                button.BackColor = Color.White;
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
        }

        bool check_game_over()
        {
            bool status = false;
            if (game.streak_of(4) == true)
            {
                // set the winner to the previous player as we have already changed to next player
                if (game.get_player() == "x")
                {
                    game.set_winner("o");
                }
                else if (game.get_player() == "o")
                {
                    game.set_winner("x");
                }
                Console.WriteLine("Winner is " + game.get_winner());
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
                lbl_PlayTurn.Text = "Player 2's turn!";
            }
            else
            {
                game.set_player("x");
                lbl_PlayTurn.Text = "Player 1's turn!";
            }
        }
        private void menStp_Options_Menu_Click(object sender, EventArgs e)
        {
            menu.Show();
            Close();
        }

        private void menStp_Options_Exit_Click(object sender, EventArgs e)
        {
            SoundPlayer mainMenuSound = new SoundPlayer(Properties.Resources.alert1);
            mainMenuSound.Play();

            DialogResult result = MessageBox.Show("Confirm Exit. Clicking Yes will end the game.", "Exiting Game!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        //=======================END MENU STRIP BUTTONS===================================
    }
    
}
