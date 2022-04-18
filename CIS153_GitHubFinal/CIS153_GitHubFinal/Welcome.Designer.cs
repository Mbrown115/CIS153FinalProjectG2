
namespace CIS153_GitHubFinal
{
    partial class Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.btn_single = new System.Windows.Forms.Button();
            this.btn_stats = new System.Windows.Forms.Button();
            this.btn_multiplayer = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_single
            // 
            this.btn_single.BackColor = System.Drawing.Color.Transparent;
            this.btn_single.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_single.BackgroundImage")));
            this.btn_single.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_single.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_single.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_single.Location = new System.Drawing.Point(336, 221);
            this.btn_single.Margin = new System.Windows.Forms.Padding(4, 5, 4, 10);
            this.btn_single.Name = "btn_single";
            this.btn_single.Size = new System.Drawing.Size(170, 78);
            this.btn_single.TabIndex = 1;
            this.btn_single.UseVisualStyleBackColor = false;
            this.btn_single.Click += new System.EventHandler(this.btn_single_Click);
            // 
            // btn_stats
            // 
            this.btn_stats.BackColor = System.Drawing.Color.Transparent;
            this.btn_stats.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stats.Location = new System.Drawing.Point(432, 408);
            this.btn_stats.Margin = new System.Windows.Forms.Padding(4, 5, 4, 10);
            this.btn_stats.Name = "btn_stats";
            this.btn_stats.Size = new System.Drawing.Size(200, 60);
            this.btn_stats.TabIndex = 2;
            this.btn_stats.Text = "Stats";
            this.btn_stats.UseVisualStyleBackColor = false;
            this.btn_stats.Click += new System.EventHandler(this.btn_stats_Click);
            // 
            // btn_multiplayer
            // 
            this.btn_multiplayer.BackColor = System.Drawing.Color.Transparent;
            this.btn_multiplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_multiplayer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_multiplayer.Location = new System.Drawing.Point(532, 221);
            this.btn_multiplayer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 10);
            this.btn_multiplayer.Name = "btn_multiplayer";
            this.btn_multiplayer.Size = new System.Drawing.Size(200, 90);
            this.btn_multiplayer.TabIndex = 3;
            this.btn_multiplayer.Text = "Two\r\nPlayer";
            this.btn_multiplayer.UseVisualStyleBackColor = false;
            this.btn_multiplayer.Click += new System.EventHandler(this.btn_multiplayer_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(432, 509);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 10);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(200, 60);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::CIS153_GitHubFinal.Properties.Resources.ArcadeScreen_Crop_Purple;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1040, 1044);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_stats);
            this.Controls.Add(this.btn_single);
            this.Controls.Add(this.btn_multiplayer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Welcome";
            this.Text = "Connect 4";
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_single;
        private System.Windows.Forms.Button btn_stats;
        private System.Windows.Forms.Button btn_multiplayer;
        private System.Windows.Forms.Button btn_exit;
    }
}

