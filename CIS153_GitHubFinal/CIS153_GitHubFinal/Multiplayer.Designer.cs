
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
            this.lbl_PlayTurn = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewPreviousGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewStatsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tStrip_Options_Menu = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gamePlayInstructionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rulesOfTheGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_PlayTurn
            // 
            this.lbl_PlayTurn.AutoSize = true;
            this.lbl_PlayTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PlayTurn.Location = new System.Drawing.Point(61, 761);
            this.lbl_PlayTurn.Name = "lbl_PlayTurn";
            this.lbl_PlayTurn.Size = new System.Drawing.Size(159, 29);
            this.lbl_PlayTurn.TabIndex = 2;
            this.lbl_PlayTurn.Text = "Player\'s Turn!";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(928, 33);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewPreviousGameToolStripMenuItem,
            this.viewStatsToolStripMenuItem,
            this.tStrip_Options_Menu,
            this.exitToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(92, 29);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // viewPreviousGameToolStripMenuItem
            // 
            this.viewPreviousGameToolStripMenuItem.Name = "viewPreviousGameToolStripMenuItem";
            this.viewPreviousGameToolStripMenuItem.Size = new System.Drawing.Size(274, 34);
            this.viewPreviousGameToolStripMenuItem.Text = "View Previous Game";
            // 
            // viewStatsToolStripMenuItem
            // 
            this.viewStatsToolStripMenuItem.Name = "viewStatsToolStripMenuItem";
            this.viewStatsToolStripMenuItem.Size = new System.Drawing.Size(274, 34);
            this.viewStatsToolStripMenuItem.Text = "View Stats";
            // 
            // tStrip_Options_Menu
            // 
            this.tStrip_Options_Menu.Name = "tStrip_Options_Menu";
            this.tStrip_Options_Menu.Size = new System.Drawing.Size(274, 34);
            this.tStrip_Options_Menu.Text = "Main Menu";
            this.tStrip_Options_Menu.Click += new System.EventHandler(this.tStrip_Options_Menu_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(274, 34);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gamePlayInstructionsToolStripMenuItem,
            this.rulesOfTheGameToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(65, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // gamePlayInstructionsToolStripMenuItem
            // 
            this.gamePlayInstructionsToolStripMenuItem.Name = "gamePlayInstructionsToolStripMenuItem";
            this.gamePlayInstructionsToolStripMenuItem.Size = new System.Drawing.Size(294, 34);
            this.gamePlayInstructionsToolStripMenuItem.Text = "Game Play Instructions";
            // 
            // rulesOfTheGameToolStripMenuItem
            // 
            this.rulesOfTheGameToolStripMenuItem.Name = "rulesOfTheGameToolStripMenuItem";
            this.rulesOfTheGameToolStripMenuItem.Size = new System.Drawing.Size(294, 34);
            this.rulesOfTheGameToolStripMenuItem.Text = "Rules of the Game";
            // 
            // Multiplayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 893);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lbl_PlayTurn);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Multiplayer";
            this.Text = "Multiplayer";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_PlayTurn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewPreviousGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewStatsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tStrip_Options_Menu;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gamePlayInstructionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rulesOfTheGameToolStripMenuItem;
    }
}