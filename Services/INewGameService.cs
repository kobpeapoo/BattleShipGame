using BattleShipBoard.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleShipBoard.Services
{
   public interface INewGameService
    {
        Task<string> CreateNewGame();
        Task<NewGame> CheckNewGameStatus(string newGameId);
    }
}
