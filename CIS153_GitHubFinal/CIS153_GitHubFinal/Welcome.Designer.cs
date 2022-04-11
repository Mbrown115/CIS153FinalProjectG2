
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
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.btn_single = new System.Windows.Forms.Button();
            this.btn_stats = new System.Windows.Forms.Button();
            this.btn_multiplayer = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.Location = new System.Drawing.Point(370, 157);
            this.lbl_welcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(182, 37);
            this.lbl_welcome.TabIndex = 0;
            this.lbl_welcome.Text = "Connect 4!";
            // 
            // btn_single
            // 
            this.btn_single.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_single.Location = new System.Drawing.Point(25, 28);
            this.btn_single.Margin = new System.Windows.Forms.Padding(4, 5, 4, 10);
            this.btn_single.Name = "btn_single";
            this.btn_single.Size = new System.Drawing.Size(188, 58);
            this.btn_single.TabIndex = 1;
            this.btn_single.Text = "Alone Play";
            this.btn_single.UseVisualStyleBackColor = true;
            this.btn_single.Click += new System.EventHandler(this.btn_single_Click);
            // 
            // btn_stats
            // 
            this.btn_stats.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stats.Location = new System.Drawing.Point(25, 174);
            this.btn_stats.Margin = new System.Windows.Forms.Padding(4, 5, 4, 10);
            this.btn_stats.Name = "btn_stats";
            this.btn_stats.Size = new System.Drawing.Size(188, 58);
            this.btn_stats.TabIndex = 2;
            this.btn_stats.Text = "Stats";
            this.btn_stats.UseVisualStyleBackColor = true;
            this.btn_stats.Click += new System.EventHandler(this.btn_stats_Click);
            // 
            // btn_multiplayer
            // 
            this.btn_multiplayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_multiplayer.Location = new System.Drawing.Point(25, 101);
            this.btn_multiplayer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 10);
            this.btn_multiplayer.Name = "btn_multiplayer";
            this.btn_multiplayer.Size = new System.Drawing.Size(188, 58);
            this.btn_multiplayer.TabIndex = 3;
            this.btn_multiplayer.Text = "Dual Play";
            this.btn_multiplayer.UseVisualStyleBackColor = true;
            this.btn_multiplayer.Click += new System.EventHandler(this.btn_multiplayer_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(25, 247);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 10);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(188, 58);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_single);
            this.panel1.Controls.Add(this.btn_exit);
            this.panel1.Controls.Add(this.btn_stats);
            this.panel1.Controls.Add(this.btn_multiplayer);
            this.panel1.Location = new System.Drawing.Point(346, 315);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 332);
            this.panel1.TabIndex = 5;
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 893);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_welcome);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Welcome";
            this.Text = "Connect 4";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Button btn_single;
        private System.Windows.Forms.Button btn_stats;
        private System.Windows.Forms.Button btn_multiplayer;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Panel panel1;
    }
}

