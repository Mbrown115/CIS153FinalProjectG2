
namespace CIS153_GitHubFinal
{
    partial class NewPlayer
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
            this.txBx_P1Name = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_P2Name = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_MainMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txBx_P1Name
            // 
            this.txBx_P1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txBx_P1Name.Location = new System.Drawing.Point(395, 243);
            this.txBx_P1Name.Name = "txBx_P1Name";
            this.txBx_P1Name.Size = new System.Drawing.Size(202, 32);
            this.txBx_P1Name.TabIndex = 0;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(185, 243);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(184, 29);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "Player 1 Name";
            // 
            // lbl_P2Name
            // 
            this.lbl_P2Name.AutoSize = true;
            this.lbl_P2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_P2Name.Location = new System.Drawing.Point(185, 308);
            this.lbl_P2Name.Name = "lbl_P2Name";
            this.lbl_P2Name.Size = new System.Drawing.Size(184, 29);
            this.lbl_P2Name.TabIndex = 2;
            this.lbl_P2Name.Text = "Player 2 Name";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(395, 312);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 32);
            this.textBox1.TabIndex = 3;
            // 
            // btn_Start
            // 
            this.btn_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start.Location = new System.Drawing.Point(300, 436);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(148, 50);
            this.btn_Start.TabIndex = 4;
            this.btn_Start.Text = "Play";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_MainMenu
            // 
            this.btn_MainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MainMenu.Location = new System.Drawing.Point(496, 436);
            this.btn_MainMenu.Name = "btn_MainMenu";
            this.btn_MainMenu.Size = new System.Drawing.Size(148, 50);
            this.btn_MainMenu.TabIndex = 5;
            this.btn_MainMenu.Text = "Main Menu";
            this.btn_MainMenu.UseVisualStyleBackColor = true;
            this.btn_MainMenu.Click += new System.EventHandler(this.btn_MainMenu_Click);
            // 
            // NewPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 599);
            this.Controls.Add(this.btn_MainMenu);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_P2Name);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.txBx_P1Name);
            this.Name = "NewPlayer";
            this.Text = "NewPlayer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txBx_P1Name;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_P2Name;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Button btn_MainMenu;
    }
}