using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tournament1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            lbl_Tournament_name.Text = Tournament_Data.Tournament_name;

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Addteams_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtbox_TeamName.Text == "")
                {
                    MessageBox.Show("Enter Team Name");
                }
                else if (Player1_Box.Text == "")
                {
                    MessageBox.Show("Enter Name Of Player 1");
                }
                else if (Player2_Box.Text == "")
                {
                    MessageBox.Show("Enter Name Of Player 2");
                }
                else if (Player3_Box.Text == "")
                {
                    MessageBox.Show("Enter Name Of Player 3");
                }
                else if (Player4_Box.Text == "")
                {
                    MessageBox.Show("Enter Name Of Player 4");
                }
                else if (Player5_Box.Text == "")
                {
                    MessageBox.Show("Enter Name Of Player 5");
                }
                else
                {
                    bool t_name = false;
                    foreach (var st in Tournament_Data.Teams1)
                    {
                        if (st.TeamName == txtbox_TeamName.Text)
                        {
                            t_name = true;
                        }
                    }
                    if (t_name)
                    {
                        MessageBox.Show("Team Name Already Exists");
                        txtbox_TeamName.Text = "";
                    }
                    else
                    {
                        Tournament_Data.TeamModel t1 = new Tournament_Data.TeamModel();
                        t1.TeamName = txtbox_TeamName.Text;
                        t1.Player.Add(Player1_Box.Text);
                        t1.Player.Add(Player2_Box.Text);
                        t1.Player.Add(Player3_Box.Text);
                        t1.Player.Add(Player4_Box.Text);
                        t1.Player.Add(Player5_Box.Text);
                        Tournament_Data.Teams1.Add(t1);

                        Player1_Box.Clear();
                        Player2_Box.Clear();
                        Player3_Box.Clear();
                        Player4_Box.Clear();
                        Player5_Box.Clear();
                        txtbox_TeamName.Focus();
                        txtbox_TeamName.Clear();
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Enter a Valid Input");
                Application.DoEvents();
                txtbox_TeamName.Focus();
            }

            }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            try
            {

                if (Tournament_Data.Teams1.Count < 3)
                {
                    MessageBox.Show("Add More Teams to Continue");
                }
                else
                {
                    RoundData.Totalteam = Tournament_Data.Teams1;
                    Form3 f3 = new Form3();
                    Form2.ActiveForm.Hide();
                    f3.Show();
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Enter a Valid Input");
                Application.DoEvents();
                txtbox_TeamName.Focus();
            }
        }
    }

     
 }

