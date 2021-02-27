using BattleShipBoard.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleShipBoard.Repositories
{
    public interface IAttackerRepository : IRepository<Attacker>
    {
        Task<(string, string)> ShootShip(Attacker attacker);
        string checkAllHit(string newGameId);
        string SummaryAfterWin(string newGameId);
    }
}
