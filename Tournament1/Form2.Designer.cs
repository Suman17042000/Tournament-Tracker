namespace Tournament1
{
    partial class Form2
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
            this.lbl_Tournament_name = new System.Windows.Forms.Label();
            this.lbl_Team_Name = new System.Windows.Forms.Label();
            this.lbl_Player_Name = new System.Windows.Forms.Label();
            this.txtbox_TeamName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Player5_Box = new System.Windows.Forms.TextBox();
            this.Player4_Box = new System.Windows.Forms.TextBox();
            this.Player2_Box = new System.Windows.Forms.TextBox();
            this.Player3_Box = new System.Windows.Forms.TextBox();
            this.Player1_Box = new System.Windows.Forms.TextBox();
            this.lbl_Player5 = new System.Windows.Forms.Label();
            this.lbl_Player4 = new System.Windows.Forms.Label();
            this.lbl_Player3 = new System.Windows.Forms.Label();
            this.lbl_Player2 = new System.Windows.Forms.Label();
            this.lbl_Player1 = new System.Windows.Forms.Label();
            this.btn_Addteams = new System.Windows.Forms.Button();
            this.btn_Next = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Tournament_name
            // 
            this.lbl_Tournament_name.AutoSize = true;
            this.lbl_Tournament_name.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_Tournament_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tournament_name.Location = new System.Drawing.Point(272, 62);
            this.lbl_Tournament_name.Name = "lbl_Tournament_name";
            this.lbl_Tournament_name.Size = new System.Drawing.Size(216, 25);
            this.lbl_Tournament_name.TabIndex = 0;
            this.lbl_Tournament_name.Text = "<Tournament Name>";
            // 
            // lbl_Team_Name
            // 
            this.lbl_Team_Name.AutoSize = true;
            this.lbl_Team_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Team_Name.Location = new System.Drawing.Point(107, 141);
            this.lbl_Team_Name.Name = "lbl_Team_Name";
            this.lbl_Team_Name.Size = new System.Drawing.Size(129, 25);
            this.lbl_Team_Name.TabIndex = 1;
            this.lbl_Team_Name.Text = "Team Name";
            // 
            // lbl_Player_Name
            // 
            this.lbl_Player_Name.AutoSize = true;
            this.lbl_Player_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Player_Name.Location = new System.Drawing.Point(107, 219);
            this.lbl_Player_Name.Name = "lbl_Player_Name";
            this.lbl_Player_Name.Size = new System.Drawing.Size(135, 25);
            this.lbl_Player_Name.TabIndex = 2;
            this.lbl_Player_Name.Text = "Player Name";
            // 
            // txtbox_TeamName
            // 
            this.txtbox_TeamName.Location = new System.Drawing.Point(300, 140);
            this.txtbox_TeamName.Name = "txtbox_TeamName";
            this.txtbox_TeamName.Size = new System.Drawing.Size(258, 26);
            this.txtbox_TeamName.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Player5_Box);
            this.groupBox1.Controls.Add(this.Player4_Box);
            this.groupBox1.Controls.Add(this.Player2_Box);
            this.groupBox1.Controls.Add(this.Player3_Box);
            this.groupBox1.Controls.Add(this.Player1_Box);
            this.groupBox1.Controls.Add(this.lbl_Player5);
            this.groupBox1.Controls.Add(this.lbl_Player4);
            this.groupBox1.Controls.Add(this.lbl_Player3);
            this.groupBox1.Controls.Add(this.lbl_Player2);
            this.groupBox1.Controls.Add(this.lbl_Player1);
            this.groupBox1.Location = new System.Drawing.Point(290, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 208);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // Player5_Box
            // 
            this.Player5_Box.Location = new System.Drawing.Point(86, 163);
            this.Player5_Box.Name = "Player5_Box";
            this.Player5_Box.Size = new System.Drawing.Size(163, 26);
            this.Player5_Box.TabIndex = 11;
            // 
            // Player4_Box
            // 
            this.Player4_Box.Location = new System.Drawing.Point(86, 125);
            this.Player4_Box.Name = "Player4_Box";
            this.Player4_Box.Size = new System.Drawing.Size(163, 26);
            this.Player4_Box.TabIndex = 10;
            // 
            // Player2_Box
            // 
            this.Player2_Box.Location = new System.Drawing.Point(86, 54);
            this.Player2_Box.Name = "Player2_Box";
            this.Player2_Box.Size = new System.Drawing.Size(163, 26);
            this.Player2_Box.TabIndex = 9;
            // 
            // Player3_Box
            // 
            this.Player3_Box.Location = new System.Drawing.Point(86, 90);
            this.Player3_Box.Name = "Player3_Box";
            this.Player3_Box.Size = new System.Drawing.Size(163, 26);
            this.Player3_Box.TabIndex = 8;
            this.Player3_Box.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // Player1_Box
            // 
            this.Player1_Box.Location = new System.Drawing.Point(86, 16);
            this.Player1_Box.Name = "Player1_Box";
            this.Player1_Box.Size = new System.Drawing.Size(163, 26);
            this.Player1_Box.TabIndex = 5;
            // 
            // lbl_Player5
            // 
            this.lbl_Player5.AutoSize = true;
            this.lbl_Player5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Player5.Location = new System.Drawing.Point(6, 163);
            this.lbl_Player5.Name = "lbl_Player5";
            this.lbl_Player5.Size = new System.Drawing.Size(61, 20);
            this.lbl_Player5.TabIndex = 7;
            this.lbl_Player5.Text = "Player5";
            // 
            // lbl_Player4
            // 
            this.lbl_Player4.AutoSize = true;
            this.lbl_Player4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Player4.Location = new System.Drawing.Point(6, 125);
            this.lbl_Player4.Name = "lbl_Player4";
            this.lbl_Player4.Size = new System.Drawing.Size(61, 20);
            this.lbl_Player4.TabIndex = 6;
            this.lbl_Player4.Text = "Player4";
            // 
            // lbl_Player3
            // 
            this.lbl_Player3.AutoSize = true;
            this.lbl_Player3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Player3.Location = new System.Drawing.Point(6, 90);
            this.lbl_Player3.Name = "lbl_Player3";
            this.lbl_Player3.Size = new System.Drawing.Size(61, 20);
            this.lbl_Player3.TabIndex = 5;
            this.lbl_Player3.Text = "Player3";
            // 
            // lbl_Player2
            // 
            this.lbl_Player2.AutoSize = true;
            this.lbl_Player2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Player2.Location = new System.Drawing.Point(6, 57);
            this.lbl_Player2.Name = "lbl_Player2";
            this.lbl_Player2.Size = new System.Drawing.Size(61, 20);
            this.lbl_Player2.TabIndex = 4;
            this.lbl_Player2.Text = "Player2";
            // 
            // lbl_Player1
            // 
            this.lbl_Player1.AutoSize = true;
            this.lbl_Player1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Player1.Location = new System.Drawing.Point(6, 19);
            this.lbl_Player1.Name = "lbl_Player1";
            this.lbl_Player1.Size = new System.Drawing.Size(61, 20);
            this.lbl_Player1.TabIndex = 3;
            this.lbl_Player1.Text = "Player1";
            // 
            // btn_Addteams
            // 
            this.btn_Addteams.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Addteams.Location = new System.Drawing.Point(627, 265);
            this.btn_Addteams.Name = "btn_Addteams";
            this.btn_Addteams.Size = new System.Drawing.Size(104, 60);
            this.btn_Addteams.TabIndex = 5;
            this.btn_Addteams.Text = "Add Team";
            this.btn_Addteams.UseVisualStyleBackColor = true;
            this.btn_Addteams.Click += new System.EventHandler(this.btn_Addteams_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Next.Location = new System.Drawing.Point(435, 410);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(89, 55);
            this.btn_Next.TabIndex = 6;
            this.btn_Next.Text = "Next";
            this.btn_Next.UseVisualStyleBackColor = true;
            this.btn_Next.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 472);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.btn_Addteams);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtbox_TeamName);
            this.Controls.Add(this.lbl_Player_Name);
            this.Controls.Add(this.lbl_Team_Name);
            this.Controls.Add(this.lbl_Tournament_name);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Form2cs";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Tournament_name;
        private System.Windows.Forms.Label lbl_Team_Name;
        private System.Windows.Forms.Label lbl_Player_Name;
        private System.Windows.Forms.TextBox txtbox_TeamName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Player5_Box;
        private System.Windows.Forms.TextBox Player4_Box;
        private System.Windows.Forms.TextBox Player2_Box;
        private System.Windows.Forms.TextBox Player3_Box;
        private System.Windows.Forms.TextBox Player1_Box;
        private System.Windows.Forms.Label lbl_Player5;
        private System.Windows.Forms.Label lbl_Player4;
        private System.Windows.Forms.Label lbl_Player3;
        private System.Windows.Forms.Label lbl_Player2;
        private System.Windows.Forms.Label lbl_Player1;
        private System.Windows.Forms.Button btn_Addteams;
        private System.Windows.Forms.Button btn_Next;
    }
}