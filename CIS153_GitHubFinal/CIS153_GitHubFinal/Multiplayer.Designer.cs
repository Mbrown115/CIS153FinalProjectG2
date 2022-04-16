﻿
namespace CIS153_GitHubFinal
{
    partial class Multiplayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Multiplayer));
            this.lbl_PlayTurn = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPreviousGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previousGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerStatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menStp_Options_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.menStp_Options_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gamePlayInstructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rulesOfTheGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.picBx_WinLose = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBx_WinLose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_PlayTurn
            // 
            this.lbl_PlayTurn.AutoSize = true;
            this.lbl_PlayTurn.BackColor = System.Drawing.Color.Transparent;
            this.lbl_PlayTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PlayTurn.ForeColor = System.Drawing.Color.SlateBlue;
            this.lbl_PlayTurn.Location = new System.Drawing.Point(58, 680);
            this.lbl_PlayTurn.Name = "lbl_PlayTurn";
            this.lbl_PlayTurn.Size = new System.Drawing.Size(227, 32);
            this.lbl_PlayTurn.TabIndex = 2;
            this.lbl_PlayTurn.Text = "Player 1\'s Turn!";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(389, 185);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(530, 468);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Font = new System.Drawing.Font("Source Code Pro Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameOptionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1290, 33);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameOptionsToolStripMenuItem
            // 
            this.gameOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewPreviousGameToolStripMenuItem,
            this.menStp_Options_Menu,
            this.menStp_Options_Exit});
            this.gameOptionsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gameOptionsToolStripMenuItem.Name = "gameOptionsToolStripMenuItem";
            this.gameOptionsToolStripMenuItem.Size = new System.Drawing.Size(172, 29);
            this.gameOptionsToolStripMenuItem.Text = "Game Options";
            // 
            // viewPreviousGameToolStripMenuItem
            // 
            this.viewPreviousGameToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.viewPreviousGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.previousGameToolStripMenuItem,
            this.playerStatsToolStripMenuItem});
            this.viewPreviousGameToolStripMenuItem.Name = "viewPreviousGameToolStripMenuItem";
            this.viewPreviousGameToolStripMenuItem.Size = new System.Drawing.Size(282, 34);
            this.viewPreviousGameToolStripMenuItem.Text = "View";
            // 
            // previousGameToolStripMenuItem
            // 
            this.previousGameToolStripMenuItem.Name = "previousGameToolStripMenuItem";
            this.previousGameToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.previousGameToolStripMenuItem.Text = "Previous Game";
            // 
            // playerStatsToolStripMenuItem
            // 
            this.playerStatsToolStripMenuItem.Name = "playerStatsToolStripMenuItem";
            this.playerStatsToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.playerStatsToolStripMenuItem.Text = "Player Stats";
            // 
            // menStp_Options_Menu
            // 
            this.menStp_Options_Menu.BackColor = System.Drawing.Color.Transparent;
            this.menStp_Options_Menu.Name = "menStp_Options_Menu";
            this.menStp_Options_Menu.Size = new System.Drawing.Size(282, 34);
            this.menStp_Options_Menu.Text = "Main Menu";
            this.menStp_Options_Menu.Click += new System.EventHandler(this.menStp_Options_Menu_Click);
            // 
            // menStp_Options_Exit
            // 
            this.menStp_Options_Exit.BackColor = System.Drawing.Color.Transparent;
            this.menStp_Options_Exit.Name = "menStp_Options_Exit";
            this.menStp_Options_Exit.Size = new System.Drawing.Size(282, 34);
            this.menStp_Options_Exit.Text = "Exit Connect 4";
            this.menStp_Options_Exit.Click += new System.EventHandler(this.menStp_Options_Exit_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gamePlayInstructionsToolStripMenuItem,
            this.rulesOfTheGameToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(76, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // gamePlayInstructionsToolStripMenuItem
            // 
            this.gamePlayInstructionsToolStripMenuItem.Name = "gamePlayInstructionsToolStripMenuItem";
            this.gamePlayInstructionsToolStripMenuItem.Size = new System.Drawing.Size(378, 34);
            this.gamePlayInstructionsToolStripMenuItem.Text = "Game Play Instructions";
            // 
            // rulesOfTheGameToolStripMenuItem
            // 
            this.rulesOfTheGameToolStripMenuItem.Name = "rulesOfTheGameToolStripMenuItem";
            this.rulesOfTheGameToolStripMenuItem.Size = new System.Drawing.Size(378, 34);
            this.rulesOfTheGameToolStripMenuItem.Text = "Rules of The Game";
            // 
            // picBx_WinLose
            // 
            this.picBx_WinLose.BackColor = System.Drawing.Color.Transparent;
            this.picBx_WinLose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picBx_WinLose.Location = new System.Drawing.Point(377, 375);
            this.picBx_WinLose.Name = "picBx_WinLose";
            this.picBx_WinLose.Size = new System.Drawing.Size(550, 83);
            this.picBx_WinLose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBx_WinLose.TabIndex = 5;
            this.picBx_WinLose.TabStop = false;
            this.picBx_WinLose.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(389, 653);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 30);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Multiplayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::CIS153_GitHubFinal.Properties.Resources.ArcadeScreen_Crop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1290, 1263);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_PlayTurn);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.picBx_WinLose);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Multiplayer";
            this.Text = "2 Player";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBx_WinLose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_PlayTurn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gamePlayInstructionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rulesOfTheGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPreviousGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menStp_Options_Menu;
        private System.Windows.Forms.ToolStripMenuItem menStp_Options_Exit;
        private System.Windows.Forms.ToolStripMenuItem previousGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerStatsToolStripMenuItem;
        private System.Windows.Forms.PictureBox picBx_WinLose;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}