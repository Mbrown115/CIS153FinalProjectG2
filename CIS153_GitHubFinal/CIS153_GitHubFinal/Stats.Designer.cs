
namespace CIS153_GitHubFinal
    {
    partial class Stats
        {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose (bool disposing)
            {
            if (disposing && (components != null))
                {
                components.Dispose ();
                }
            base.Dispose (disposing);
            }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
            {
            this.btn_Menu = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.listBx_Stats = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menStp = new System.Windows.Forms.MenuStrip();
            this.gameOptionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boardSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leaderBoardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.gameRulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menStp.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Menu
            // 
            this.btn_Menu.Location = new System.Drawing.Point(151, 609);
            this.btn_Menu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(111, 41);
            this.btn_Menu.TabIndex = 0;
            this.btn_Menu.Text = "Main Menu";
            this.btn_Menu.UseVisualStyleBackColor = true;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(122, 526);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(111, 41);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "Exit Game";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // listBx_Stats
            // 
            this.listBx_Stats.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(255)))), ((int)(((byte)(254)))));
            this.listBx_Stats.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBx_Stats.FormattingEnabled = true;
            this.listBx_Stats.ItemHeight = 32;
            this.listBx_Stats.Location = new System.Drawing.Point(405, 268);
            this.listBx_Stats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBx_Stats.Name = "listBx_Stats";
            this.listBx_Stats.Size = new System.Drawing.Size(537, 420);
            this.listBx_Stats.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Source Code Pro Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(535, 206);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 45);
            this.label1.TabIndex = 3;
            this.label1.Text = "Leader Board";
            // 
            // menStp
            // 
            this.menStp.BackColor = System.Drawing.Color.Transparent;
            this.menStp.Font = new System.Drawing.Font("Source Code Pro Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menStp.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menStp.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menStp.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameOptionsToolStripMenuItem1,
            this.statisticsToolStripMenuItem,
            this.helpToolStripMenuItem1});
            this.menStp.Location = new System.Drawing.Point(0, 0);
            this.menStp.Name = "menStp";
            this.menStp.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menStp.Size = new System.Drawing.Size(1328, 36);
            this.menStp.TabIndex = 5;
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
            this.gameOptionsToolStripMenuItem1.Size = new System.Drawing.Size(172, 32);
            this.gameOptionsToolStripMenuItem1.Text = "Game Options";
            // 
            // mainMenuToolStripMenuItem
            // 
            this.mainMenuToolStripMenuItem.Name = "mainMenuToolStripMenuItem";
            this.mainMenuToolStripMenuItem.Size = new System.Drawing.Size(246, 34);
            this.mainMenuToolStripMenuItem.Text = "Main Menu";
            this.mainMenuToolStripMenuItem.Click += new System.EventHandler(this.mainMenuToolStripMenuItem_Click);
            // 
            // boardSetupToolStripMenuItem
            // 
            this.boardSetupToolStripMenuItem.Name = "boardSetupToolStripMenuItem";
            this.boardSetupToolStripMenuItem.Size = new System.Drawing.Size(246, 34);
            this.boardSetupToolStripMenuItem.Text = "Board Setup";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(246, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leaderBoardToolStripMenuItem1});
            this.statisticsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(148, 32);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            // 
            // leaderBoardToolStripMenuItem1
            // 
            this.leaderBoardToolStripMenuItem1.Name = "leaderBoardToolStripMenuItem1";
            this.leaderBoardToolStripMenuItem1.Size = new System.Drawing.Size(258, 34);
            this.leaderBoardToolStripMenuItem1.Text = "Leader Board";
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameRulesToolStripMenuItem,
            this.instructionsToolStripMenuItem});
            this.helpToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(76, 32);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // gameRulesToolStripMenuItem
            // 
            this.gameRulesToolStripMenuItem.Name = "gameRulesToolStripMenuItem";
            this.gameRulesToolStripMenuItem.Size = new System.Drawing.Size(258, 34);
            this.gameRulesToolStripMenuItem.Text = "Game Rules";
            // 
            // instructionsToolStripMenuItem
            // 
            this.instructionsToolStripMenuItem.Name = "instructionsToolStripMenuItem";
            this.instructionsToolStripMenuItem.Size = new System.Drawing.Size(258, 34);
            this.instructionsToolStripMenuItem.Text = "Instructions";
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImage = global::CIS153_GitHubFinal.Properties.Resources.ArcadeScreen_Crop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1328, 1262);
            this.ControlBox = false;
            this.Controls.Add(this.menStp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBx_Stats);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Menu);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Stats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stats";
            this.menStp.ResumeLayout(false);
            this.menStp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.Button btn_Menu;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.ListBox listBx_Stats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menStp;
        private System.Windows.Forms.ToolStripMenuItem gameOptionsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem boardSetupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leaderBoardToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem gameRulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructionsToolStripMenuItem;
    }
    }