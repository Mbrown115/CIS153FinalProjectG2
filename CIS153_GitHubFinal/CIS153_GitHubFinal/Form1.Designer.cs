
namespace CIS153_GitHubFinal
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Location = new System.Drawing.Point(192, 50);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(49, 13);
            this.lbl_welcome.TabIndex = 0;
            this.lbl_welcome.Text = "welcome";
            // 
            // btn_single
            // 
            this.btn_single.Location = new System.Drawing.Point(195, 132);
            this.btn_single.Name = "btn_single";
            this.btn_single.Size = new System.Drawing.Size(75, 23);
            this.btn_single.TabIndex = 1;
            this.btn_single.Text = "Alone Play";
            this.btn_single.UseVisualStyleBackColor = true;
            // 
            // btn_stats
            // 
            this.btn_stats.Location = new System.Drawing.Point(195, 223);
            this.btn_stats.Name = "btn_stats";
            this.btn_stats.Size = new System.Drawing.Size(75, 23);
            this.btn_stats.TabIndex = 2;
            this.btn_stats.Text = "Stats";
            this.btn_stats.UseVisualStyleBackColor = true;
            // 
            // btn_multiplayer
            // 
            this.btn_multiplayer.Location = new System.Drawing.Point(195, 176);
            this.btn_multiplayer.Name = "btn_multiplayer";
            this.btn_multiplayer.Size = new System.Drawing.Size(75, 23);
            this.btn_multiplayer.TabIndex = 3;
            this.btn_multiplayer.Text = "Dual Play";
            this.btn_multiplayer.UseVisualStyleBackColor = true;
            this.btn_multiplayer.Click += new System.EventHandler(this.btn_multiplayer_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(195, 269);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 455);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_multiplayer);
            this.Controls.Add(this.btn_stats);
            this.Controls.Add(this.btn_single);
            this.Controls.Add(this.lbl_welcome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Button btn_single;
        private System.Windows.Forms.Button btn_stats;
        private System.Windows.Forms.Button btn_multiplayer;
        private System.Windows.Forms.Button btn_exit;
    }
}

