
namespace CIS153_GitHubFinal
{
    partial class Single
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Single));
            this.lbl_PlayerTurn = new System.Windows.Forms.Label();
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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_PlayerTurn
            // 
            this.lbl_PlayerTurn.AutoSize = true;
            this.lbl_PlayerTurn.BackColor = System.Drawing.Color.Transparent;
            this.lbl_PlayerTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PlayerTurn.Location = new System.Drawing.Point(396, 662);
            this.lbl_PlayerTurn.Name = "lbl_PlayerTurn";
            this.lbl_PlayerTurn.Size = new System.Drawing.Size(159, 29);
            this.lbl_PlayerTurn.TabIndex = 2;
            this.lbl_PlayerTurn.Text = "Player\'s Turn!";
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
            this.menuStrip1.Size = new System.Drawing.Size(1278, 33);
            this.menuStrip1.TabIndex = 5;
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
            // 
            // menStp_Options_Exit
            // 
            this.menStp_Options_Exit.BackColor = System.Drawing.Color.Transparent;
            this.menStp_Options_Exit.Name = "menStp_Options_Exit";
            this.menStp_Options_Exit.Size = new System.Drawing.Size(282, 34);
            this.menStp_Options_Exit.Text = "Exit Connect 4";
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
            // Single
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = global::CIS153_GitHubFinal.Properties.Resources.ArcadeScreen_Crop_Purple;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1278, 1264);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lbl_PlayerTurn);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Single";
            this.Text = "Single";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_PlayerTurn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPreviousGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previousGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerStatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menStp_Options_Menu;
        private System.Windows.Forms.ToolStripMenuItem menStp_Options_Exit;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gamePlayInstructionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rulesOfTheGameToolStripMenuItem;
    }
}