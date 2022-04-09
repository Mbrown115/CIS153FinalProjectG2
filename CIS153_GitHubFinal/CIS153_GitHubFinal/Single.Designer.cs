
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
            this.btn_Menu = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.lbl_PlayerTurn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Menu
            // 
            this.btn_Menu.Location = new System.Drawing.Point(313, 309);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(120, 47);
            this.btn_Menu.TabIndex = 0;
            this.btn_Menu.Text = "Main Menu";
            this.btn_Menu.UseVisualStyleBackColor = true;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(464, 309);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(120, 47);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "Exit Game";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lbl_PlayerTurn
            // 
            this.lbl_PlayerTurn.AutoSize = true;
            this.lbl_PlayerTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PlayerTurn.Location = new System.Drawing.Point(12, 412);
            this.lbl_PlayerTurn.Name = "lbl_PlayerTurn";
            this.lbl_PlayerTurn.Size = new System.Drawing.Size(159, 29);
            this.lbl_PlayerTurn.TabIndex = 2;
            this.lbl_PlayerTurn.Text = "Player\'s Turn!";
            // 
            // Single
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_PlayerTurn);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Menu);
            this.Name = "Single";
            this.Text = "Single";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Menu;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label lbl_PlayerTurn;
    }
}