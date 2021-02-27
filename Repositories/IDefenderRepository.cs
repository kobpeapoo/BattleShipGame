using BattleShipBoard.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleShipBoard.Repositories
{
    public interface IDefenderRepository : IRepository<Defender>
    {
        Task AddNewShipToBoard(Defender defender);
        List<Defender> GetAllShipOnBoard(string newGameId);
        Task UpdateMarkX(string DefenderId);
        int CheckWin(string newGameId);

    }
}
