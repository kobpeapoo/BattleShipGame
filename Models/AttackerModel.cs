using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleShipBoard.Models
{
    public class AttackerModel : StatusCodeModel
    {
        public string newGameId { get; set; }
        public int shootRow { get; set; }
        public int shootColumn { get; set; }


    }
}
