using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleShipBoard.Models
{
    public class NewGameModel : StatusCodeModel
    {
        public string NewGameId { get; set; }
        public DateTime StartGameDatetime { get; set; }
        public DateTime? EndGameDatetime { get; set; }
        public string DefenderStatus { get; set; }
        public string AttackerWinStatus { get; set; }
    }
}
