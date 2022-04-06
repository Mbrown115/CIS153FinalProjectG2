
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
            this.SuspendLayout();
            // 
            // btn_Menu
            // 
            this.btn_Menu.Location = new System.Drawing.Point(151, 608);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(112, 41);
            this.btn_Menu.TabIndex = 0;
            this.btn_Menu.Text = "Main Menu";
            this.btn_Menu.UseVisualStyleBackColor = true;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(369, 608);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(112, 41);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "Exit Game";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // listBx_Stats
            // 
            this.listBx_Stats.FormattingEnabled = true;
            this.listBx_Stats.ItemHeight = 20;
            this.listBx_Stats.Location = new System.Drawing.Point(151, 92);
            this.listBx_Stats.Name = "listBx_Stats";
            this.listBx_Stats.ScrollAlwaysVisible = true;
            this.listBx_Stats.Size = new System.Drawing.Size(374, 464);
            this.listBx_Stats.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(202, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 37);
            this.label1.TabIndex = 3;
            this.label1.Text = "Leader Board";
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 674);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBx_Stats);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Menu);
            this.Name = "Stats";
            this.Text = "Stats";
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.Button btn_Menu;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.ListBox listBx_Stats;
        private System.Windows.Forms.Label label1;
    }
    }