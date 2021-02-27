using BattleShipBoard.Entities;
using BattleShipBoard.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleShipBoard.Repositories
{
    public class AttackerRepository : Repository<Attacker>, IAttackerRepository
    {
        public AttackerRepository(BattleShipContext context) : base(context) { }
        
        public async Task<(string,string)> ShootShip(Attacker attacker)
        {
            string responseShoot = "";
            var checkDefender = BattleShipContext.Defender.Where(x => ((x.Row1 == attacker.ShootRow && x.Column1 == attacker.ShootColumn) || (x.Row2 == attacker.ShootRow && x.Column2 == attacker.ShootColumn)) && x.DefenderStatus != "Mark X").FirstOrDefault();
            if (checkDefender is null)
            {
                attacker.ShootStatus = "Miss";
                responseShoot = attacker.ShootStatus;
            }
            else
            {
                attacker.ShootStatus = "Hit";
                attacker.DefenderId = checkDefender.DefenderId;
                responseShoot = attacker.ShootStatus;
            }

            await BattleShipContext.AddAsync(attacker);
            await BattleShipContext.SaveChangesAsync();

            if (checkDefender != null)
            {
                var checkMarkX = BattleShipContext.Attacker.Where(x => x.DefenderId.Equals(checkDefender.DefenderId) && x.ShootStatus.Equals("Hit")).ToList();
                if (checkMarkX.Count == 2)
                {
                    responseShoot = "Mark X";
                }
            }
            return (responseShoot, (checkDefender==null)?null:checkDefender.DefenderId);
        }
        public string checkAllHit(string newGameId)
        {
            var attacHit = BattleShipContext.Attacker.Where(x => x.ShootStatus.Equals("Hit") && x.NewGameId.Equals(newGameId)).ToList().Count;
            return attacHit == 4 ? "Win" : "";
        }

        public string SummaryAfterWin(string newGameId)
        {
            var attacker = BattleShipContext.Attacker.Where(x=>x.NewGameId.Equals(newGameId)).ToList();
            int miss = attacker.Where(x => x.ShootStatus.Equals("Miss")).ToList().Count;
            SummaryModel summaryModel = new SummaryModel();
            summaryModel.Miss = miss;
            summaryModel.shoot = attacker.Count;
            summaryModel.Status = "Win";

            return JsonConvert.SerializeObject(summaryModel);
        }

        private BattleShipContext BattleShipContext
        {
            get { return Context as BattleShipContext; }
        }
    }
}
