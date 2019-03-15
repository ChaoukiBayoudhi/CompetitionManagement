using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompetitionManagement
{
    class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDay { get; set; }
        public int TshirtNumer { get; set; }

        public override bool Equals(object obj)
        {
            var player = obj as Player;
            return player != null &&
                   Id == player.Id;
        }

        public override int GetHashCode()
        {
            return 2108858624 + Id.GetHashCode();
        }
    }
}
