
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
            this.btn_menu = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lbl_Turn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_menu
            // 
            this.btn_menu.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_menu.Location = new System.Drawing.Point(50, 338);
            this.btn_menu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(112, 35);
            this.btn_menu.TabIndex = 0;
            this.btn_menu.Text = "Menu";
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_Exit.Location = new System.Drawing.Point(235, 338);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(112, 35);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "Exit Game";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lbl_Turn
            // 
            this.lbl_Turn.AutoSize = true;
            this.lbl_Turn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Turn.Location = new System.Drawing.Point(12, 450);
            this.lbl_Turn.Name = "lbl_Turn";
            this.lbl_Turn.Size = new System.Drawing.Size(178, 29);
            this.lbl_Turn.TabIndex = 2;
            this.lbl_Turn.Text = "Player 1\'s Turn!";
            // 
            // Multiplayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1244, 488);
            this.Controls.Add(this.lbl_Turn);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_menu);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Multiplayer";
            this.Text = "Multiplayer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label lbl_Turn;
    }
}