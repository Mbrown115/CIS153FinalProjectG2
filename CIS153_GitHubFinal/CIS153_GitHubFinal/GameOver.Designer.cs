
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
            this.btn_Quit = new System.Windows.Forms.Button();
            this.lbl_NewGame = new System.Windows.Forms.Label();
            this.picBx_WinLose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBx_WinLose)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_NewGame
            // 
            this.btn_NewGame.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(145)))), ((int)(((byte)(129)))), ((int)(((byte)(206)))));
            this.btn_NewGame.Font = new System.Drawing.Font("Source Code Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NewGame.Location = new System.Drawing.Point(386, 414);
            this.btn_NewGame.Margin = new System.Windows.Forms.Padding(4);
            this.btn_NewGame.Name = "btn_NewGame";
            this.btn_NewGame.Size = new System.Drawing.Size(95, 68);
            this.btn_NewGame.TabIndex = 10;
            this.btn_NewGame.Text = "New Game";
            this.btn_NewGame.UseVisualStyleBackColor = false;
            // 
            // btn_Quit
            // 
            this.btn_Quit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(145)))), ((int)(((byte)(129)))), ((int)(((byte)(206)))));
            this.btn_Quit.Font = new System.Drawing.Font("Source Code Pro", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Quit.Location = new System.Drawing.Point(513, 414);
            this.btn_Quit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Quit.Name = "btn_Quit";
            this.btn_Quit.Size = new System.Drawing.Size(95, 68);
            this.btn_Quit.TabIndex = 12;
            this.btn_Quit.Text = "Main Menu";
            this.btn_Quit.UseVisualStyleBackColor = false;
            // 
            // lbl_NewGame
            // 
            this.lbl_NewGame.BackColor = System.Drawing.Color.Transparent;
            this.lbl_NewGame.Font = new System.Drawing.Font("Source Code Pro Black", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NewGame.ForeColor = System.Drawing.Color.Black;
            this.lbl_NewGame.Location = new System.Drawing.Point(180, 314);
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
            this.picBx_WinLose.Location = new System.Drawing.Point(274, 147);
            this.picBx_WinLose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBx_WinLose.Name = "picBx_WinLose";
            this.picBx_WinLose.Size = new System.Drawing.Size(442, 165);
            this.picBx_WinLose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBx_WinLose.TabIndex = 9;
            this.picBx_WinLose.TabStop = false;
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CIS153_GitHubFinal.Properties.Resources.ArcadeScreen_screenimage_ref;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(984, 960);
            this.Controls.Add(this.btn_NewGame);
            this.Controls.Add(this.btn_Quit);
            this.Controls.Add(this.lbl_NewGame);
            this.Controls.Add(this.picBx_WinLose);
            this.Name = "GameOver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Over";
            ((System.ComponentModel.ISupportInitialize)(this.picBx_WinLose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_NewGame;
        private System.Windows.Forms.Button btn_Quit;
        private System.Windows.Forms.Label lbl_NewGame;
        private System.Windows.Forms.PictureBox picBx_WinLose;
    }
}