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
    public partial class Form3 : Form
    {
        public static int Rounds = 1;
        int firstIndex = 0;
        int lastIndex=RoundData.Totalteam.Count-1;
        public static List<RoundData.Teams> TotalMatches = new List<RoundData.Teams>();


        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lbl_Tournament_Name.Text = Tournament_Data.Tournament_name;
           
            Lbl_Team_A.Text = RoundData.Totalteam[firstIndex].TeamName;
            Lbl_Team_B.Text = RoundData.Totalteam[firstIndex].TeamName;
            MatchUp();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Txtbox_Team_B_Score.Text == "")
                {
                    MessageBox.Show("Enter Score for Team1");
                }
                else if (Txtbox_TeamB_Score.Text == "")
                {
                    MessageBox.Show("Enter Score For Team2");
                }
                else
                {
                    RoundData.Teams tm = new RoundData.Teams();

                    Int32 TeamA_Score = Convert.ToInt32(Txtbox_Team_B_Score.Text);
                    Int32 TeamB_Score = Convert.ToInt32(Txtbox_TeamB_Score.Text);

                    if (TeamA_Score == TeamB_Score)
                    {
                        MessageBox.Show("This is a Draw! Enter Score Again");
                        Application.DoEvents();
                        Txtbox_Team_B_Score.Text = "";
                        Txtbox_TeamB_Score.Text = "";
                        return;
                    }
                    tm.TeamA_Name = RoundData.Totalteam[firstIndex].TeamName;
                    tm.TeamB_Name = RoundData.Totalteam[lastIndex].TeamName;
                    tm.PlayerA = RoundData.Totalteam[firstIndex].Player;
                    tm.PlayerB = RoundData.Totalteam[lastIndex].Player;
                    tm.scoreA = TeamA_Score;
                    tm.scoreB = TeamB_Score;
                    TotalMatches.Add(tm);

                    if (TeamA_Score > TeamB_Score)
                    {
                        MessageBox.Show("Team " + RoundData.Totalteam[firstIndex].TeamName + " Win");
                        RoundData.Matchup.Add(RoundData.Totalteam[firstIndex]);
                    }
                    else
                    {
                        MessageBox.Show("Team " + RoundData.Totalteam[lastIndex].TeamName + " Win");
                        RoundData.Matchup.Add(RoundData.Totalteam[lastIndex]);
                    }
                    if (firstIndex < RoundData.Totalteam.Count / 2 - 1)
                    {
                        firstIndex++;
                        lastIndex--;
                        Application.DoEvents();
                        MatchUp();

                    }
                    else
                    {
                        Rounds++;
                        RoundData.Team Tds = new RoundData.Team();
                        Tds.Total = TotalMatches;
                        RoundData.Rounds.Add(Tds);
                        TotalMatches = new List<RoundData.Teams>();
                        if (RoundData.Totalteam.Count % 2 != 0)
                        {
                            RoundData.Matchup.Add(RoundData.Totalteam[RoundData.Totalteam.Count / 2]);
                        }
                        firstIndex = 0;
                        var x = RoundData.Matchup;
                        RoundData.Totalteam = x;
                        lastIndex = RoundData.Totalteam.Count() - 1;
                        RoundData.Matchup = new List<Tournament_Data.TeamModel>();
                        Application.DoEvents();
                        if (RoundData.Totalteam.Count == 2)
                        {
                            MessageBox.Show("This is the Final Round");
                        }
                        if (RoundData.Totalteam.Count == 1)
                        {
                            MessageBox.Show("Hurray! We Got the Winner For the Tournament");
                            btn_next_round.Show();
                            MessageBox.Show("Click on Next To Continue");
                            btn_Chk_Result.Enabled = false;

                        }
                        else
                        {
                            MatchUp();

                        }
                    }



                }
            }catch(Exception ex)
            {
                MessageBox.Show("Enter a valid Input");
                Application.DoEvents();
                Txtbox_Team_B_Score.Focus();
            }

        }
        public void MatchUp()
        {
            grp_round.Text = "Round " + Rounds;
            lb_Matches.Items.Clear();
            Lbl_Team_A.Text = RoundData.Totalteam[firstIndex].TeamName;
            Lbl_Team_B.Text = RoundData.Totalteam[lastIndex].TeamName;
            Txtbox_Team_B_Score.Text = "";
            Txtbox_TeamB_Score.Text = "";
            Txtbox_Team_B_Score.Focus();
            if (RoundData.Totalteam.Count % 2 == 0)
            {
                for (int j = 0; j < RoundData.Totalteam.Count / 2; j++)
                {
                    lb_Matches.Items.Add(RoundData.Totalteam[j].TeamName + " VS " + RoundData.Totalteam[RoundData.Totalteam.Count - j - 1].TeamName);
                }
                lbl_bias_team_update.Text = "NA";
                //Btmp.Items.Clear();
            }
            else
            {
               
                lbl_bias_team_update.Text = RoundData.Totalteam[RoundData.Totalteam.Count() / 2].TeamName;
                for (int j = 0; j < RoundData.Totalteam.Count / 2; j++)
                {
                    lb_Matches.Items.Add(RoundData.Totalteam[j].TeamName + " VS " + RoundData.Totalteam[RoundData.Totalteam.Count - 1 - j].TeamName);
                }  
            }
          

        }

        private void btn_next_round_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            Form.ActiveForm.Hide();
            form4.Show();
        }
    }
}
