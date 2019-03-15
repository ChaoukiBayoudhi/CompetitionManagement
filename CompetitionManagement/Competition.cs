using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionManagement
{
    class Competition
    {
        public List<Team> Teams { get; set; }
        public Competition()
        {
            Teams = new List<Team>();
        }
        public List<string> TeamNames()
        {
            List<string> lstNames = new List<string>();

            
            
            for (int i = 0; i < Teams.Count; i++)
            {
                lstNames.Add(Teams[i].Name);
            }
            //Or by using foreach
            //foreach (Team T in Teams)
            //{
            //    lstNames.Add(T.Name);
            //}
            return lstNames;
        }
        public bool AddPlayerToTeam(Player P,string TeamName)
        {
            bool ok = true;
            Team T = new Team();
            T.Name = TeamName;
            int index = Teams.IndexOf(T);
            if (index==-1)
            {
                ok = false;
            }
            else
            {
                ok=Teams[index].AddPlayer(P);
            }
            return ok;
        }
        public List<Player> TeamPlayers    (string TeamName)
        {
            List<Player> lstPlyers = new List<Player>();
            Team T = new Team();
            T.Name = TeamName;
            int index = Teams.IndexOf(T);
           if (index == -1)
            {
                throw new Exception("Team is unvailable");
            }
            else
                lstPlyers = Teams[index].LstPlayers;
           return lstPlyers;
        }
        public Player PlayerOfTeam(string teamName,int IdPlayer)
        {
            
            Team T = new Team();
            T.Name = teamName;
            int index1 = Teams.IndexOf(T);
            Player P = new Player();
            P.Id = IdPlayer;
            //"index2" is the index Of the Player that is in The Team "Teams[index1]"
            int index2 = Teams[index1].LstPlayers.IndexOf(P);

            return Teams[index1].LstPlayers[index2];
        }
        public List<int> TeamPlayersIds(string teamName)
        {
            List<int> lstIds = new List<int>();
            Team T = new Team();
            T.Name = teamName;
            int index1 = Teams.IndexOf(T);
            foreach (Player P in Teams[index1].LstPlayers)
            {
                lstIds.Add(P.Id);
            }
            return lstIds;
        }
        public bool DeletePlayerOfTeam(string teamName, int idPlayer)
        {
            bool ok = true;
            Team T = new Team();
            T.Name = teamName;
            int index1 = Teams.IndexOf(T);
            Player P = new Player();
            P.Id = idPlayer;
            ok=Teams[index1].LstPlayers.Remove(P);
            return ok;
        }
    }
}
