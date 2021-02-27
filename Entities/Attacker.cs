using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BattleShipBoard.Entities
{
    public partial class Attacker
    {
        public string AttackerId { get; set; }
        public string NewGameId { get; set; }
        public int ShootRow { get; set; }
        public int ShootColumn { get; set; }
        public string ShootStatus { get; set; }
        public string DefenderId { get; set; }

        public virtual NewGame NewGame { get; set; }
    }
}
