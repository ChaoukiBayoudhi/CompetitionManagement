using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionManagement
{
    class Team
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public int NbrOfSubsucribers { get; set; }
        public DateTime CreationDate { get; set; }
        public List<Player> LstPlayers { get; set; }
        public Team()
        {
            LstPlayers = new List<Player>();
        }
        public bool AddPlayer(Player P)
        {
            bool ok = true;
            if (!LstPlayers.Contains(P))
                LstPlayers.Add(P);
            else
                ok = false;
            return ok;

        }

        public override bool Equals(object obj)
        {
            var team = obj as Team;
            return team != null &&
                   Name == team.Name;
        }

        public override int GetHashCode()
        {
            return 539060726 + EqualityComparer<string>.Default.GetHashCode(Name);
        }
    }
}
