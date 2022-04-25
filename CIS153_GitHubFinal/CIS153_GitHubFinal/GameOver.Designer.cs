
namespace CIS153_GitHubFinal
{
    partial class GameOver
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_NewGame = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lbl_NewGame = new System.Windows.Forms.Label();
            this.picBx_WinLose = new System.Windows.Forms.PictureBox();
            this.btn_Review = new System.Windows.Forms.Button();
            this.lbl_pxWins = new System.Windows.Forms.Label();
            this.lbl_poWins = new System.Windows.Forms.Label();
            this.lbl_pxStats = new System.Windows.Forms.Label();
            this.lbl_poStats = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBx_WinLose)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_NewGame
            // 
            this.btn_NewGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(145)))), ((int)(((byte)(129)))), ((int)(((byte)(206)))));
            this.btn_NewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NewGame.Location = new System.Drawing.Point(358, 413);
            this.btn_NewGame.Margin = new System.Windows.Forms.Padding(4);
            this.btn_NewGame.Name = "btn_NewGame";
            this.btn_NewGame.Size = new System.Drawing.Size(85, 60);
            this.btn_NewGame.TabIndex = 10;
            this.btn_NewGame.Text = "New Game";
            this.btn_NewGame.UseVisualStyleBackColor = false;
            this.btn_NewGame.Click += new System.EventHandler(this.btn_NewGame_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(145)))), ((int)(((byte)(129)))), ((int)(((byte)(206)))));
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Location = new System.Drawing.Point(544, 413);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(85, 60);
            this.btn_Exit.TabIndex = 12;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lbl_NewGame
            // 
            this.lbl_NewGame.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NewGame.ForeColor = System.Drawing.Color.Black;
            this.lbl_NewGame.Location = new System.Drawing.Point(180, 343);
            this.lbl_NewGame.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NewGame.Name = "lbl_NewGame";
            this.lbl_NewGame.Size = new System.Drawing.Size(638, 66);
            this.lbl_NewGame.TabIndex = 11;
            this.lbl_NewGame.Text = "Play Again?";
            this.lbl_NewGame.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_NewGame.Visible = false;
            // 
            // picBx_WinLose
            // 
            this.picBx_WinLose.BackColor = System.Drawing.Color.Transparent;
            this.picBx_WinLose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picBx_WinLose.Location = new System.Drawing.Point(283, 162);
            this.picBx_WinLose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBx_WinLose.Name = "picBx_WinLose";
            this.picBx_WinLose.Size = new System.Drawing.Size(418, 119);
            this.picBx_WinLose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBx_WinLose.TabIndex = 9;
            this.picBx_WinLose.TabStop = false;
            // 
            // btn_Review
            // 
            this.btn_Review.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(145)))), ((int)(((byte)(129)))), ((int)(((byte)(206)))));
            this.btn_Review.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Review.Location = new System.Drawing.Point(451, 413);
            this.btn_Review.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Review.Name = "btn_Review";
            this.btn_Review.Size = new System.Drawing.Size(85, 60);
            this.btn_Review.TabIndex = 13;
            this.btn_Review.Text = "Review Game";
            this.btn_Review.UseVisualStyleBackColor = false;
            this.btn_Review.Click += new System.EventHandler(this.btn_Review_Click);
            // 
            // lbl_pxWins
            // 
            this.lbl_pxWins.AutoSize = true;
            this.lbl_pxWins.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pxWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pxWins.Location = new System.Drawing.Point(321, 295);
            this.lbl_pxWins.Name = "lbl_pxWins";
            this.lbl_pxWins.Size = new System.Drawing.Size(400, 48);
            this.lbl_pxWins.TabIndex = 14;
            this.lbl_pxWins.Text = "Player X Total Wins:";
            // 
            // lbl_poWins
            // 
            this.lbl_poWins.AutoSize = true;
            this.lbl_poWins.BackColor = System.Drawing.Color.Transparent;
            this.lbl_poWins.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_poWins.Location = new System.Drawing.Point(321, 343);
            this.lbl_poWins.Name = "lbl_poWins";
            this.lbl_poWins.Size = new System.Drawing.Size(405, 48);
            this.lbl_poWins.TabIndex = 15;
            this.lbl_poWins.Text = "Player O Total Wins:";
            // 
            // lbl_pxStats
            // 
            this.lbl_pxStats.AutoSize = true;
            this.lbl_pxStats.BackColor = System.Drawing.Color.Transparent;
            this.lbl_pxStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pxStats.Location = new System.Drawing.Point(629, 295);
            this.lbl_pxStats.Name = "lbl_pxStats";
            this.lbl_pxStats.Size = new System.Drawing.Size(134, 48);
            this.lbl_pxStats.TabIndex = 16;
            this.lbl_pxStats.Text = "empty";
            // 
            // lbl_poStats
            // 
            this.lbl_poStats.AutoSize = true;
            this.lbl_poStats.BackColor = System.Drawing.Color.Transparent;
            this.lbl_poStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_poStats.Location = new System.Drawing.Point(631, 341);
            this.lbl_poStats.Name = "lbl_poStats";
            this.lbl_poStats.Size = new System.Drawing.Size(134, 48);
            this.lbl_poStats.TabIndex = 17;
            this.lbl_poStats.Text = "empty";
            // 
            // GameOver
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::CIS153_GitHubFinal.Properties.Resources.ArcadeScreen_screenimage_ref;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 960);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_poStats);
            this.Controls.Add(this.lbl_pxStats);
            this.Controls.Add(this.lbl_poWins);
            this.Controls.Add(this.lbl_pxWins);
            this.Controls.Add(this.btn_Review);
            this.Controls.Add(this.btn_NewGame);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.lbl_NewGame);
            this.Controls.Add(this.picBx_WinLose);
            this.Name = "GameOver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Over";
            ((System.ComponentModel.ISupportInitialize)(this.picBx_WinLose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_NewGame;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label lbl_NewGame;
        private System.Windows.Forms.PictureBox picBx_WinLose;
        private System.Windows.Forms.Button btn_Review;
        private System.Windows.Forms.Label lbl_pxWins;
        private System.Windows.Forms.Label lbl_poWins;
        private System.Windows.Forms.Label lbl_pxStats;
        private System.Windows.Forms.Label lbl_poStats;
    }
}