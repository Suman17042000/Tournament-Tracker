using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Tournament1
{
    public partial class Form4 : Form
    {

        public static int idx = 0;
        public static int idx1 = 0;
        public Form4()
        {
            InitializeComponent();
            idx = 0; idx1 = 0;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

            lbl_T_Name.Text = Tournament_Data.Tournament_name;
            Tournament_Data.TotalFund = Tournament_Data.EntryFee * Tournament_Data.Teams1.Count;
            Tournament_Data.Organizer_fees = 0.2 * Tournament_Data.TotalFund;
            Tournament_Data.Winner_Prize = 0.55 * (Tournament_Data.TotalFund - Tournament_Data.Organizer_fees);
            Tournament_Data.Runner_up_Prize = 0.45 * (Tournament_Data.TotalFund - Tournament_Data.Organizer_fees);
            Lbl_w_Prize.Text += "Rs " + Math.Floor(Tournament_Data.Winner_Prize).ToString();
            lbl_r_prize.Text += "Rs " + Math.Floor(Tournament_Data.Runner_up_Prize).ToString();
            lbl_O_Fees.Text += "Rs " + Math.Floor(Tournament_Data.Organizer_fees).ToString();

            for (int i = 0; i < RoundData.Rounds.Count; i++)
            {
                lb_rounds.Items.Add("Round " + (i + 1));
            }
            lb_rounds.SetSelected(idx, true);
            int x = RoundData.Rounds[RoundData.Rounds.Count() - 1].Total[0].scoreA;
            int y = RoundData.Rounds[RoundData.Rounds.Count() - 1].Total[0].scoreB;
            if (x > y)
            {
                lbl_win_team.Text = "Team " + RoundData.Rounds[RoundData.Rounds.Count() - 1].Total[0].TeamA_Name;
                lbl_ru_team.Text = "Team " + RoundData.Rounds[RoundData.Rounds.Count() - 1].Total[0].TeamB_Name;
            }
            else
            {
                lbl_win_team.Text = "Team " + RoundData.Rounds[RoundData.Rounds.Count() - 1].Total[0].TeamB_Name;
                lbl_ru_team.Text = "Team " + RoundData.Rounds[RoundData.Rounds.Count() - 1].Total[0].TeamA_Name;
            }
        }

        private void lb_rounds_SelectedIndexChanged(object sender, EventArgs e)
        {
            listbox_matches.Items.Clear();
            idx = lb_rounds.SelectedIndex;
            for (int i = 0; i < RoundData.Rounds[idx].Total.Count; i++)
            {
                listbox_matches.Items.Add(RoundData.Rounds[idx].Total[i].TeamA_Name + " VS " + RoundData.Rounds[idx].Total[i].TeamB_Name);
            }

            listbox_matches.SetSelected(0, true);

            lb_Winners.Items.Clear();
            lb_Knocked.Items.Clear();


            for (int j = 0; j < RoundData.Rounds[idx].Total.Count; j++)
            {

                if (RoundData.Rounds[idx].Total[j].scoreA > RoundData.Rounds[idx].Total[j].scoreB)
                {
                    lb_Winners.Items.Add(RoundData.Rounds[idx].Total[j].TeamA_Name);
                    lb_Knocked.Items.Add(RoundData.Rounds[idx].Total[j].TeamB_Name);
                }
                else
                {
                    lb_Winners.Items.Add(RoundData.Rounds[idx].Total[j].TeamB_Name);
                    lb_Knocked.Items.Add(RoundData.Rounds[idx].Total[j].TeamA_Name);
                }
            }

        }

        private void lb_Winners_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lb_Knocked_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listbox_matches_SelectedIndexChanged(object sender, EventArgs e)
        {
            lb_Player.Items.Clear();
            lb_playerk.Items.Clear();

            idx1 = listbox_matches.SelectedIndex;
            for (int k = 0; k < RoundData.Rounds[idx].Total[idx1].PlayerA.Count(); k++)
            {
                if (RoundData.Rounds[idx].Total[idx1].scoreA > RoundData.Rounds[idx].Total[idx1].scoreB)
                {
                    lb_Player.Items.Add(RoundData.Rounds[idx].Total[idx1].PlayerA[k]);
                    lb_playerk.Items.Add(RoundData.Rounds[idx].Total[idx1].PlayerB[k]);

                }
                else
                {
                    lb_Player.Items.Add(RoundData.Rounds[idx].Total[idx1].PlayerB[k]);
                    lb_playerk.Items.Add(RoundData.Rounds[idx].Total[idx1].PlayerA[k]);
                }


            }

        }

        public void create_Json()
        {
            string tname = Tournament_Data.Tournament_name;
            
        }
    

                public void create_Xml()
                {
                    string tname = Tournament_Data.Tournament_name;
                    XmlWriter writer = XmlWriter.Create(ConfigurationManager.AppSettings["XmlPath"] + tname + ".xml");

                    writer.WriteStartDocument();

                    writer.WriteStartElement("Root");

                    writer.WriteStartElement("Tournament_Data");
                    writer.WriteStartElement("Tournament");
                    writer.WriteStartAttribute("Tname");
                    writer.WriteValue(Tournament_Data.Tournament_name);
                    writer.WriteEndAttribute();
                    writer.WriteStartAttribute("Entey_fee");
                    writer.WriteValue(Tournament_Data.EntryFee.ToString());
                    writer.WriteEndAttribute();
                    writer.WriteStartAttribute("Organisers_Fund");
                    writer.WriteValue((Tournament_Data.TotalFund - (Tournament_Data.Winner_Prize + Tournament_Data.Runner_up_Prize)).ToString());
                    writer.WriteEndAttribute();
                    writer.WriteStartAttribute("FIRST_Prize");
                    writer.WriteValue((Tournament_Data.Winner_Prize.ToString()));
                    writer.WriteEndAttribute();
                    writer.WriteStartAttribute("Second_Prize");
                    writer.WriteValue((Tournament_Data.Runner_up_Prize.ToString()));
                    writer.WriteEndAttribute();
                    writer.WriteEndElement();

                    writer.WriteStartElement("Teams_Data");
                    for (int ii = 0; ii < Tournament_Data.Teams1.Count; ii++)
                    {
                        writer.WriteStartElement("Team_" + (ii + 1));
                        writer.WriteStartAttribute("Team_Name");
                        writer.WriteValue(Tournament_Data.Teams1[ii].TeamName);
                        writer.WriteEndAttribute();
                        for (int jj = 0; jj < Tournament_Data.Teams1[ii].Player.Count; jj++)
                        {
                            writer.WriteStartElement("Players_" + (jj + 1));
                            writer.WriteStartAttribute("Name");
                            writer.WriteValue(Tournament_Data.Teams1[ii].Player[jj]);
                            writer.WriteEndAttribute();
                            writer.WriteEndElement();
                        }
                        writer.WriteEndElement();
                    }
                    writer.WriteEndElement();


                    writer.WriteStartElement("Round_Data");
                    for (int ii = 0; ii < RoundData.Rounds.Count; ii++)
                    {
                        writer.WriteStartElement("Round_" + (ii + 1));
                        for (int jj = 0; jj < RoundData.Rounds[ii].Total.Count; jj++)
                        {
                            writer.WriteStartElement("Match_" + (jj + 1));
                            if (RoundData.Rounds[idx].Total[idx1].scoreA > RoundData.Rounds[ii].Total[jj].scoreB)
                            {
                                writer.WriteStartAttribute("Win");
                                writer.WriteValue(RoundData.Rounds[ii].Total[jj].TeamA_Name);
                                writer.WriteEndAttribute();
                            }
                            else
                            {
                                writer.WriteStartAttribute("Win");
                                writer.WriteValue(RoundData.Rounds[ii].Total[jj].TeamB_Name);
                                writer.WriteEndAttribute();
                            }

                            writer.WriteStartElement("TeamA");
                            writer.WriteStartAttribute("Name");
                            writer.WriteValue(RoundData.Rounds[ii].Total[jj].TeamA_Name);
                            writer.WriteEndAttribute();
                            writer.WriteStartAttribute("Score");
                            writer.WriteValue(RoundData.Rounds[ii].Total[jj].scoreA.ToString());
                            writer.WriteEndAttribute();

                            writer.WriteStartElement("Players");
                            for (int kk = 0; kk < RoundData.Rounds[ii].Total[jj].PlayerA.Count; kk++)
                            {
                                writer.WriteStartElement("Player_" + (kk + 1));
                                writer.WriteStartAttribute("Name");
                                writer.WriteValue(RoundData.Rounds[ii].Total[jj].PlayerA[kk]);
                                writer.WriteEndAttribute();
                                writer.WriteEndElement();
                            }
                            writer.WriteEndElement();

                            writer.WriteEndElement();

                            writer.WriteStartElement("TeamB");
                            writer.WriteStartAttribute("Name");
                            writer.WriteValue(RoundData.Rounds[ii].Total[jj].TeamB_Name);
                            writer.WriteEndAttribute();
                            writer.WriteStartAttribute("Score");
                            writer.WriteValue(RoundData.Rounds[ii].Total[jj].scoreB.ToString());
                            writer.WriteEndAttribute();

                            writer.WriteStartElement("Players");
                            for (int kk = 0; kk < RoundData.Rounds[ii].Total[jj].PlayerB.Count; kk++)
                            {
                                writer.WriteStartElement("Player_" + (kk + 1));
                                writer.WriteStartAttribute("Name");
                                writer.WriteValue(RoundData.Rounds[ii].Total[jj].PlayerB[kk]);
                                writer.WriteEndAttribute();
                                writer.WriteEndElement();
                            }
                            writer.WriteEndElement();

                            writer.WriteEndElement();
                            writer.WriteEndElement();
                        }
                        writer.WriteEndElement();
                    }
                    writer.WriteEndElement();
                    writer.WriteEndElement();
                    writer.WriteEndElement();
                    writer.WriteEndDocument();
                    writer.Close();
                }

                private void button1_Click(object sender, EventArgs e)
                {
                    create_Xml();
                    MessageBox.Show("Xml is created");
                }
            }
        }
    


