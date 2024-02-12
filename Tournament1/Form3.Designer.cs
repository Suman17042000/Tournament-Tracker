namespace Tournament1
{
    partial class Form3
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
            this.lbl_Tournament_Name = new System.Windows.Forms.Label();
            this.grp_round = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Chk_Result = new System.Windows.Forms.Button();
            this.Txtbox_TeamB_Score = new System.Windows.Forms.TextBox();
            this.Txtbox_Team_B_Score = new System.Windows.Forms.TextBox();
            this.Lbl_Team_A = new System.Windows.Forms.Label();
            this.Lbl_Team_B = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpbox_Matches = new System.Windows.Forms.GroupBox();
            this.lbl_bias_team_update = new System.Windows.Forms.Label();
            this.lbl_bias_team = new System.Windows.Forms.Label();
            this.btn_next_round = new System.Windows.Forms.Button();
            this.lb_Matches = new System.Windows.Forms.ListBox();
            this.grp_round.SuspendLayout();
            this.grpbox_Matches.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Tournament_Name
            // 
            this.lbl_Tournament_Name.AutoSize = true;
            this.lbl_Tournament_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tournament_Name.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lbl_Tournament_Name.Location = new System.Drawing.Point(167, 69);
            this.lbl_Tournament_Name.Name = "lbl_Tournament_Name";
            this.lbl_Tournament_Name.Size = new System.Drawing.Size(216, 25);
            this.lbl_Tournament_Name.TabIndex = 0;
            this.lbl_Tournament_Name.Text = "<Tournament Name>";
            // 
            // grp_round
            // 
            this.grp_round.Controls.Add(this.label1);
            this.grp_round.Controls.Add(this.btn_Chk_Result);
            this.grp_round.Controls.Add(this.Txtbox_TeamB_Score);
            this.grp_round.Controls.Add(this.Txtbox_Team_B_Score);
            this.grp_round.Controls.Add(this.Lbl_Team_A);
            this.grp_round.Controls.Add(this.Lbl_Team_B);
            this.grp_round.Controls.Add(this.label2);
            this.grp_round.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_round.Location = new System.Drawing.Point(35, 130);
            this.grp_round.Name = "grp_round";
            this.grp_round.Size = new System.Drawing.Size(348, 213);
            this.grp_round.TabIndex = 1;
            this.grp_round.TabStop = false;
            this.grp_round.Text = "Round: 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "vs";
            // 
            // btn_Chk_Result
            // 
            this.btn_Chk_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Chk_Result.Location = new System.Drawing.Point(162, 97);
            this.btn_Chk_Result.Name = "btn_Chk_Result";
            this.btn_Chk_Result.Size = new System.Drawing.Size(106, 64);
            this.btn_Chk_Result.TabIndex = 7;
            this.btn_Chk_Result.Text = "Check Result";
            this.btn_Chk_Result.UseVisualStyleBackColor = true;
            this.btn_Chk_Result.Click += new System.EventHandler(this.button1_Click);
            // 
            // Txtbox_TeamB_Score
            // 
            this.Txtbox_TeamB_Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtbox_TeamB_Score.Location = new System.Drawing.Point(27, 142);
            this.Txtbox_TeamB_Score.Name = "Txtbox_TeamB_Score";
            this.Txtbox_TeamB_Score.Size = new System.Drawing.Size(100, 26);
            this.Txtbox_TeamB_Score.TabIndex = 6;
            // 
            // Txtbox_Team_B_Score
            // 
            this.Txtbox_Team_B_Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txtbox_Team_B_Score.Location = new System.Drawing.Point(27, 72);
            this.Txtbox_Team_B_Score.Name = "Txtbox_Team_B_Score";
            this.Txtbox_Team_B_Score.Size = new System.Drawing.Size(100, 26);
            this.Txtbox_Team_B_Score.TabIndex = 5;
            // 
            // Lbl_Team_A
            // 
            this.Lbl_Team_A.AutoSize = true;
            this.Lbl_Team_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Team_A.Location = new System.Drawing.Point(11, 49);
            this.Lbl_Team_A.Name = "Lbl_Team_A";
            this.Lbl_Team_A.Size = new System.Drawing.Size(82, 20);
            this.Lbl_Team_A.TabIndex = 4;
            this.Lbl_Team_A.Text = "<Team A>";
            // 
            // Lbl_Team_B
            // 
            this.Lbl_Team_B.AutoSize = true;
            this.Lbl_Team_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Team_B.Location = new System.Drawing.Point(11, 119);
            this.Lbl_Team_B.Name = "Lbl_Team_B";
            this.Lbl_Team_B.Size = new System.Drawing.Size(82, 20);
            this.Lbl_Team_B.TabIndex = 3;
            this.Lbl_Team_B.Text = "<Team B>";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Scores";
            // 
            // grpbox_Matches
            // 
            this.grpbox_Matches.Controls.Add(this.lb_Matches);
            this.grpbox_Matches.Controls.Add(this.lbl_bias_team_update);
            this.grpbox_Matches.Controls.Add(this.lbl_bias_team);
            this.grpbox_Matches.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbox_Matches.Location = new System.Drawing.Point(450, 130);
            this.grpbox_Matches.Name = "grpbox_Matches";
            this.grpbox_Matches.Size = new System.Drawing.Size(280, 231);
            this.grpbox_Matches.TabIndex = 2;
            this.grpbox_Matches.TabStop = false;
            this.grpbox_Matches.Text = "Matches";
            // 
            // lbl_bias_team_update
            // 
            this.lbl_bias_team_update.AutoSize = true;
            this.lbl_bias_team_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bias_team_update.Location = new System.Drawing.Point(120, 197);
            this.lbl_bias_team_update.Name = "lbl_bias_team_update";
            this.lbl_bias_team_update.Size = new System.Drawing.Size(107, 20);
            this.lbl_bias_team_update.TabIndex = 9;
            this.lbl_bias_team_update.Text = "<B_T_Name>";
            // 
            // lbl_bias_team
            // 
            this.lbl_bias_team.AutoSize = true;
            this.lbl_bias_team.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bias_team.Location = new System.Drawing.Point(17, 197);
            this.lbl_bias_team.Name = "lbl_bias_team";
            this.lbl_bias_team.Size = new System.Drawing.Size(97, 20);
            this.lbl_bias_team.TabIndex = 8;
            this.lbl_bias_team.Text = "Bias Team: -";
            // 
            // btn_next_round
            // 
            this.btn_next_round.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next_round.Location = new System.Drawing.Point(499, 374);
            this.btn_next_round.Name = "btn_next_round";
            this.btn_next_round.Size = new System.Drawing.Size(99, 50);
            this.btn_next_round.TabIndex = 9;
            this.btn_next_round.Text = "Next ";
            this.btn_next_round.UseVisualStyleBackColor = true;
            this.btn_next_round.Visible = false;
            this.btn_next_round.Click += new System.EventHandler(this.btn_next_round_Click);
            // 
            // lb_Matches
            // 
            this.lb_Matches.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Matches.FormattingEnabled = true;
            this.lb_Matches.ItemHeight = 20;
            this.lb_Matches.Location = new System.Drawing.Point(21, 40);
            this.lb_Matches.Name = "lb_Matches";
            this.lb_Matches.Size = new System.Drawing.Size(206, 144);
            this.lb_Matches.TabIndex = 10;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_next_round);
            this.Controls.Add(this.grpbox_Matches);
            this.Controls.Add(this.grp_round);
            this.Controls.Add(this.lbl_Tournament_Name);
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.grp_round.ResumeLayout(false);
            this.grp_round.PerformLayout();
            this.grpbox_Matches.ResumeLayout(false);
            this.grpbox_Matches.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Tournament_Name;
        private System.Windows.Forms.GroupBox grp_round;
        private System.Windows.Forms.Button btn_Chk_Result;
        private System.Windows.Forms.TextBox Txtbox_TeamB_Score;
        private System.Windows.Forms.TextBox Txtbox_Team_B_Score;
        private System.Windows.Forms.Label Lbl_Team_A;
        private System.Windows.Forms.Label Lbl_Team_B;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpbox_Matches;
        private System.Windows.Forms.Label lbl_bias_team;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_next_round;
        private System.Windows.Forms.Label lbl_bias_team_update;
        private System.Windows.Forms.ListBox lb_Matches;
    }
}