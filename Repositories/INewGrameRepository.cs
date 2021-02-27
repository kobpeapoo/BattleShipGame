using BattleShipBoard.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleShipBoard.Repositories
{
    public interface INewGrameRepository : IRepository<NewGame>
    {
        Task NewGame(NewGame newGame);
        Task<NewGame> NewGameStatus(string NewGameId);
    }
}
