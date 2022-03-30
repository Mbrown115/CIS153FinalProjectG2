
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
            this.SuspendLayout();
            // 
            // btn_menu
            // 
            this.btn_menu.Location = new System.Drawing.Point(33, 220);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(75, 23);
            this.btn_menu.TabIndex = 0;
            this.btn_menu.Text = "Menu";
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // Multiplayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 317);
            this.Controls.Add(this.btn_menu);
            this.Name = "Multiplayer";
            this.Text = "Multiplayer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_menu;
    }
}