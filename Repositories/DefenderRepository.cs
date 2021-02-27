using BattleShipBoard.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleShipBoard.Repositories
{
    public class DefenderRepository : Repository<Defender>, IDefenderRepository
    {
        public DefenderRepository(BattleShipContext context) : base(context) { }
        public async Task AddNewShipToBoard(Defender defender)
        {
            await BattleShipContext.AddAsync(defender);
        }

        public  List<Defender> GetAllShipOnBoard(string newGameId)
        {
            return  BattleShipContext.Defender.Where(x=>x.NewGameId.Equals(newGameId)).ToList();
        }

        public async Task UpdateMarkX(string DefenderId)
        {
            var defender = BattleShipContext.Defender.Where(x => x.DefenderId.Equals(DefenderId)).FirstOrDefault();
            if (defender != null)
            {
                defender.DefenderStatus = "Mark X";
              
            }
            await BattleShipContext.SaveChangesAsync();
        }

        public int CheckWin(string newGameId)
        {
            return BattleShipContext.Defender.Where(x => x.NewGameId.Equals(newGameId) && x.DefenderStatus.Equals("Mark X")).ToList().Count;
        }

        private BattleShipContext BattleShipContext
        {
            get { return Context as BattleShipContext; }
        }
    }
}
