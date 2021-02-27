using BattleShipBoard.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleShipBoard.Services
{
    public interface IAttackerService
    {
        Task<string> ShootShip(Attacker attacker);
        string checkAllHit(string newGameId);
    }
}
