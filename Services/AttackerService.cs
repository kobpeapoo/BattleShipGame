using BattleShipBoard.Entities;
using BattleShipBoard.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleShipBoard.Services
{
    public class AttackerService : IAttackerService
    {
        private readonly IUnitOfWork _context;
        public AttackerService(IUnitOfWork context)
        {
            this._context = context;
        }
        public string checkAllHit(string newGameId)
        {
            return _context.attackerRepository.checkAllHit(newGameId);
        }

        public async Task<string> ShootShip(Attacker attacker)
        {
            string strResult = "";
            //Check Win
            int countAllMarkX = _context.defenderRepository.CheckWin(attacker.NewGameId);
            if (countAllMarkX == 2)
            {
                strResult = "Win";

                strResult = _context.attackerRepository.SummaryAfterWin(attacker.NewGameId);

            }
            else
            {
                var shootResult = await _context.attackerRepository.ShootShip(attacker);

                 strResult = shootResult.Item1;

                if (strResult.Equals("Mark X"))
                {
                    await _context.defenderRepository.UpdateMarkX(shootResult.Item2);

                }
            }

            
            return strResult;
        }
    }
}
