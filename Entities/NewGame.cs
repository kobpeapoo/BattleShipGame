using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BattleShipBoard.Entities
{
    public partial class NewGame
    {
        public NewGame()
        {
            Attacker = new HashSet<Attacker>();
            Defender = new HashSet<Defender>();
        }

        public string NewGameId { get; set; }
        public DateTime StartGameDatetime { get; set; }
        public DateTime? EndGameDatetime { get; set; }
        public string DefenderStatus { get; set; }
        public string AttackerWinStatus { get; set; }

        public virtual ICollection<Attacker> Attacker { get; set; }
        public virtual ICollection<Defender> Defender { get; set; }
    }
}
