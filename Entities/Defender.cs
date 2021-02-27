using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace BattleShipBoard.Entities
{
    public partial class Defender
    {
        public string DefenderId { get; set; }
        public string NewGameId { get; set; }
        public int ShipSeq { get; set; }
        public int Row1 { get; set; }
        public int Column1 { get; set; }
        public int Row2 { get; set; }
        public int Column2 { get; set; }
        public string DefenderStatus { get; set; }

        public virtual NewGame NewGame { get; set; }
    }
}
