namespace Tournament1
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
            this.lbl_Tournament_Name = new System.Windows.Forms.Label();
            this.txtbox_Tournament_Name = new System.Windows.Forms.TextBox();
            this.Btn_c_Tournament = new System.Windows.Forms.Button();
            this.lbl_Entry_Fees = new System.Windows.Forms.Label();
            this.txtbox_Entry_Fees = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_Tournament_Name
            // 
            this.lbl_Tournament_Name.AutoSize = true;
            this.lbl_Tournament_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tournament_Name.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Tournament_Name.Location = new System.Drawing.Point(103, 139);
            this.lbl_Tournament_Name.Name = "lbl_Tournament_Name";
            this.lbl_Tournament_Name.Size = new System.Drawing.Size(190, 25);
            this.lbl_Tournament_Name.TabIndex = 0;
            this.lbl_Tournament_Name.Text = "Tournament Name";
            // 
            // txtbox_Tournament_Name
            // 
            this.txtbox_Tournament_Name.Location = new System.Drawing.Point(320, 138);
            this.txtbox_Tournament_Name.Name = "txtbox_Tournament_Name";
            this.txtbox_Tournament_Name.Size = new System.Drawing.Size(195, 26);
            this.txtbox_Tournament_Name.TabIndex = 1;
            // 
            // Btn_c_Tournament
            // 
            this.Btn_c_Tournament.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Btn_c_Tournament.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_c_Tournament.Location = new System.Drawing.Point(251, 267);
            this.Btn_c_Tournament.Name = "Btn_c_Tournament";
            this.Btn_c_Tournament.Size = new System.Drawing.Size(149, 72);
            this.Btn_c_Tournament.TabIndex = 3;
            this.Btn_c_Tournament.Text = "Create Tournament";
            this.Btn_c_Tournament.UseVisualStyleBackColor = true;
            this.Btn_c_Tournament.Click += new System.EventHandler(this.Btn_c_Tournament_Click);
            // 
            // lbl_Entry_Fees
            // 
            this.lbl_Entry_Fees.AutoSize = true;
            this.lbl_Entry_Fees.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Entry_Fees.Location = new System.Drawing.Point(132, 202);
            this.lbl_Entry_Fees.Name = "lbl_Entry_Fees";
            this.lbl_Entry_Fees.Size = new System.Drawing.Size(116, 25);
            this.lbl_Entry_Fees.TabIndex = 3;
            this.lbl_Entry_Fees.Text = "Entry Fees";
            // 
            // txtbox_Entry_Fees
            // 
            this.txtbox_Entry_Fees.Location = new System.Drawing.Point(320, 202);
            this.txtbox_Entry_Fees.Name = "txtbox_Entry_Fees";
            this.txtbox_Entry_Fees.Size = new System.Drawing.Size(195, 26);
            this.txtbox_Entry_Fees.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 387);
            this.Controls.Add(this.txtbox_Entry_Fees);
            this.Controls.Add(this.lbl_Entry_Fees);
            this.Controls.Add(this.Btn_c_Tournament);
            this.Controls.Add(this.txtbox_Tournament_Name);
            this.Controls.Add(this.lbl_Tournament_Name);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtbox_Tournament_Name;
        private System.Windows.Forms.Button Btn_c_Tournament;
        private System.Windows.Forms.Label lbl_Entry_Fees;
        private System.Windows.Forms.TextBox txtbox_Entry_Fees;
        private System.Windows.Forms.Label lbl_Tournament_Name;
    }
}

