
namespace CIS153_GitHubFinal
{
    partial class GameBoard
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameBoard));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menStp = new System.Windows.Forms.MenuStrip();
            this.gameOptionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boardSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leaderBoardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gameOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPreviousGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previousGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerStatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menStp_Options_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.menStp_Options_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gamePlayInstructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rulesOfTheGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_TurnIndicator = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.howToPlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menStp.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(296, 139);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(415, 356);
            this.tableLayoutPanel1.TabIndex = 3;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // menStp
            // 
            this.menStp.BackColor = System.Drawing.Color.Transparent;
            this.menStp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menStp.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menStp.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menStp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameOptionsToolStripMenuItem1,
            this.statisticsToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.menStp.Location = new System.Drawing.Point(0, 0);
            this.menStp.Name = "menStp";
            this.menStp.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menStp.Size = new System.Drawing.Size(988, 33);
            this.menStp.TabIndex = 4;
            this.menStp.Text = "menuStrip1";
            // 
            // gameOptionsToolStripMenuItem1
            // 
            this.gameOptionsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mainMenuToolStripMenuItem,
            this.boardSetupToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.gameOptionsToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.gameOptionsToolStripMenuItem1.Name = "gameOptionsToolStripMenuItem1";
            this.gameOptionsToolStripMenuItem1.Size = new System.Drawing.Size(166, 29);
            this.gameOptionsToolStripMenuItem1.Text = "Game Options";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // boardSetupToolStripMenuItem
            // 
            this.boardSetupToolStripMenuItem.Name = "boardSetupToolStripMenuItem";
            this.boardSetupToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.boardSetupToolStripMenuItem.Text = "Board Setup";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leaderBoardToolStripMenuItem1});
            this.statisticsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(116, 29);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            // 
            // leaderBoardToolStripMenuItem1
            // 
            this.leaderBoardToolStripMenuItem1.Name = "leaderBoardToolStripMenuItem1";
            this.leaderBoardToolStripMenuItem1.Size = new System.Drawing.Size(270, 34);
            this.leaderBoardToolStripMenuItem1.Text = "Leader Board";
            this.leaderBoardToolStripMenuItem1.Click += new System.EventHandler(this.leaderBoardToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToPlayToolStripMenuItem});
            this.helpToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(72, 29);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // gameOptionsToolStripMenuItem
            // 
            this.gameOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewPreviousGameToolStripMenuItem,
            this.menStp_Options_Menu,
            this.menStp_Options_Exit});
            this.gameOptionsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gameOptionsToolStripMenuItem.Name = "gameOptionsToolStripMenuItem";
            this.gameOptionsToolStripMenuItem.Size = new System.Drawing.Size(172, 32);
            this.gameOptionsToolStripMenuItem.Text = "Game Options";
            // 
            // viewPreviousGameToolStripMenuItem
            // 
            this.viewPreviousGameToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.viewPreviousGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.previousGameToolStripMenuItem,
            this.playerStatsToolStripMenuItem});
            this.viewPreviousGameToolStripMenuItem.Name = "viewPreviousGameToolStripMenuItem";
            this.viewPreviousGameToolStripMenuItem.Size = new System.Drawing.Size(151, 34);
            this.viewPreviousGameToolStripMenuItem.Text = "View";
            // 
            // previousGameToolStripMenuItem
            // 
            this.previousGameToolStripMenuItem.Name = "previousGameToolStripMenuItem";
            this.previousGameToolStripMenuItem.Size = new System.Drawing.Size(232, 34);
            this.previousGameToolStripMenuItem.Text = "Previous Game";
            // 
            // playerStatsToolStripMenuItem
            // 
            this.playerStatsToolStripMenuItem.Name = "playerStatsToolStripMenuItem";
            this.playerStatsToolStripMenuItem.Size = new System.Drawing.Size(232, 34);
            this.playerStatsToolStripMenuItem.Text = "Player Stats";
            // 
            // menStp_Options_Menu
            // 
            this.menStp_Options_Menu.Name = "menStp_Options_Menu";
            this.menStp_Options_Menu.Size = new System.Drawing.Size(151, 34);
            // 
            // menStp_Options_Exit
            // 
            this.menStp_Options_Exit.Name = "menStp_Options_Exit";
            this.menStp_Options_Exit.Size = new System.Drawing.Size(151, 34);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // gamePlayInstructionsToolStripMenuItem
            // 
            this.gamePlayInstructionsToolStripMenuItem.Name = "gamePlayInstructionsToolStripMenuItem";
            this.gamePlayInstructionsToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // rulesOfTheGameToolStripMenuItem
            // 
            this.rulesOfTheGameToolStripMenuItem.Name = "rulesOfTheGameToolStripMenuItem";
            this.rulesOfTheGameToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // lbl_TurnIndicator
            // 
            this.lbl_TurnIndicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_TurnIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TurnIndicator.ForeColor = System.Drawing.Color.White;
            this.lbl_TurnIndicator.Location = new System.Drawing.Point(293, 509);
            this.lbl_TurnIndicator.Name = "lbl_TurnIndicator";
            this.lbl_TurnIndicator.Size = new System.Drawing.Size(418, 24);
            this.lbl_TurnIndicator.TabIndex = 0;
            this.lbl_TurnIndicator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_TurnIndicator.Visible = false;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Visible = true;
            // 
            // howToPlayToolStripMenuItem
            // 
            this.howToPlayToolStripMenuItem.Name = "howToPlayToolStripMenuItem";
            this.howToPlayToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.howToPlayToolStripMenuItem.Text = "How to Play";
            this.howToPlayToolStripMenuItem.Click += new System.EventHandler(this.howToPlayToolStripMenuItem_Click);
            // 
            // GameBoard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::CIS153_GitHubFinal.Properties.Resources.ArcadeScreen_screenimage_ref;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(988, 976);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_TurnIndicator);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menStp);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menStp;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "GameBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect Four";
            this.menStp.ResumeLayout(false);
            this.menStp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menStp;
        private System.Windows.Forms.ToolStripMenuItem gameOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gamePlayInstructionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rulesOfTheGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPreviousGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menStp_Options_Menu;
        private System.Windows.Forms.ToolStripMenuItem menStp_Options_Exit;
        private System.Windows.Forms.ToolStripMenuItem previousGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerStatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameOptionsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lbl_TurnIndicator;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leaderBoardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boardSetupToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem howToPlayToolStripMenuItem;
    }
}