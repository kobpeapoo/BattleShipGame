using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleShipBoard.Models
{
    public class DefenderModel : StatusCodeModel
    {
        public string NewGameId { get; set; }
        public int Row1 { get; set; }
        public int Column1 { get; set; }
        public int Row2 { get; set; }
        public int Column2 { get; set; }
    }
}
