
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
            this.lbl_gameOverStats = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBx_WinLose)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_NewGame
            // 
            this.btn_NewGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(145)))), ((int)(((byte)(129)))), ((int)(((byte)(206)))));
            this.btn_NewGame.Font = new System.Drawing.Font("Source Code Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btn_Exit.Font = new System.Drawing.Font("Source Code Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.lbl_NewGame.Font = new System.Drawing.Font("Source Code Pro Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btn_Review.Font = new System.Drawing.Font("Source Code Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Review.Location = new System.Drawing.Point(451, 413);
            this.btn_Review.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Review.Name = "btn_Review";
            this.btn_Review.Size = new System.Drawing.Size(85, 60);
            this.btn_Review.TabIndex = 13;
            this.btn_Review.Text = "Review Game";
            this.btn_Review.UseVisualStyleBackColor = false;
            // 
            // lbl_gameOverStats
            // 
            this.lbl_gameOverStats.AutoSize = true;
            this.lbl_gameOverStats.BackColor = System.Drawing.Color.Transparent;
            this.lbl_gameOverStats.Location = new System.Drawing.Point(458, 297);
            this.lbl_gameOverStats.Name = "lbl_gameOverStats";
            this.lbl_gameOverStats.Size = new System.Drawing.Size(51, 20);
            this.lbl_gameOverStats.TabIndex = 14;
            this.lbl_gameOverStats.Text = "label1";
            // 
            // GameOver
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::CIS153_GitHubFinal.Properties.Resources.ArcadeScreen_screenimage_ref;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 960);
            this.Controls.Add(this.lbl_gameOverStats);
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
        private System.Windows.Forms.Label lbl_gameOverStats;
    }
}