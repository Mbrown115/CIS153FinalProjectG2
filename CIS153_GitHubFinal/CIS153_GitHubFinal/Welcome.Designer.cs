
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_bot = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
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
            this.btn_multiplayer.Text = "Start Game";
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
            // comboBox1
            // 
            this.comboBox1.AccessibleName = "bot";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "-",
            "x",
            "o"});
            this.comboBox1.Location = new System.Drawing.Point(666, 354);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(66, 28);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Text = "-";
            // 
            // lbl_bot
            // 
            this.lbl_bot.AutoSize = true;
            this.lbl_bot.Location = new System.Drawing.Point(691, 331);
            this.lbl_bot.Name = "lbl_bot";
            this.lbl_bot.Size = new System.Drawing.Size(41, 20);
            this.lbl_bot.TabIndex = 6;
            this.lbl_bot.Text = "BOT";
            // 
            // comboBox2
            // 
            this.comboBox2.AccessibleName = "rows";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "5",
            "6",
            "7"});
            this.comboBox2.Location = new System.Drawing.Point(310, 354);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(65, 28);
            this.comboBox2.TabIndex = 7;
            this.comboBox2.Text = "6";
            // 
            // comboBox3
            // 
            this.comboBox3.AccessibleName = "columns";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "6",
            "7",
            "8"});
            this.comboBox3.Location = new System.Drawing.Point(395, 354);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(59, 28);
            this.comboBox3.TabIndex = 8;
            this.comboBox3.Text = "7";
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(310, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Rows";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(391, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Columns";
            // 
            // comboBox4
            // 
            this.comboBox4.AccessibleName = "streak";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "3",
            "4",
            "5"});
            this.comboBox4.Location = new System.Drawing.Point(513, 354);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(67, 28);
            this.comboBox4.TabIndex = 11;
            this.comboBox4.Text = "4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(513, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Streak";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::CIS153_GitHubFinal.Properties.Resources.ArcadeScreen_Crop_Purple;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1040, 1044);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.lbl_bot);
            this.Controls.Add(this.comboBox1);
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
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_single;
        private System.Windows.Forms.Button btn_stats;
        private System.Windows.Forms.Button btn_multiplayer;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_bot;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label3;
    }
}

