using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tournament1
{
    public class Tournament_Data
    {
        public static double EntryFee { get; set; }
        public static string Tournament_name { get; set; }

        public static List<TeamModel> Teams1 = new List<TeamModel>();
        public class TeamModel
        {
            public string TeamName { get; set; }
            public List<string> Player = new List<string>();
        }

        public static double TotalFund;
        public static double Organizer_fees;
        public static double Winner_Prize;
        public static double Runner_up_Prize;
    }

    public partial class RoundData
    {
        public static List<Team> Rounds = new List<Team>();
        public static List<Tournament_Data.TeamModel> Totalteam = new List<Tournament_Data.TeamModel>();
        public static List<Tournament_Data.TeamModel> Matchup = new List<Tournament_Data.TeamModel>();

       
        
        public class Team
        {
            public List<Teams> Total = new List<Teams>();
        }
        public class Teams
        {
            public string TeamA_Name { get; set; }
            public string TeamB_Name { get; set; }
            public List<string> PlayerA = new List<string>();
            public List<string> PlayerB = new List<string>();
            public int scoreA { get; set; }
            public int scoreB { get; set; }
        }
    }
}
