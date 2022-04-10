
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Menu
            // 
            this.btn_Menu.Location = new System.Drawing.Point(1199, 1460);
            this.btn_Menu.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(187, 68);
            this.btn_Menu.TabIndex = 0;
            this.btn_Menu.Text = "Main Menu";
            this.btn_Menu.UseVisualStyleBackColor = true;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(1395, 1460);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(187, 68);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "Exit Game";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // lbl_PlayerTurn
            // 
            this.lbl_PlayerTurn.AutoSize = true;
            this.lbl_PlayerTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PlayerTurn.Location = new System.Drawing.Point(19, 1478);
            this.lbl_PlayerTurn.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbl_PlayerTurn.Name = "lbl_PlayerTurn";
            this.lbl_PlayerTurn.Size = new System.Drawing.Size(238, 40);
            this.lbl_PlayerTurn.TabIndex = 2;
            this.lbl_PlayerTurn.Text = "Player\'s Turn!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(2, 3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(222, 215);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Single
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.BackgroundImage = global::CIS153_GitHubFinal.Properties.Resources.connect4;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1601, 1546);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_PlayerTurn);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Menu);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Single";
            this.Text = "Single";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Menu;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label lbl_PlayerTurn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}