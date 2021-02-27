using BattleShipBoard.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BattleShipBoard.Repositories
{
    public class NewGameRepository : Repository<NewGame>, INewGrameRepository
    {
        public NewGameRepository(BattleShipContext context) : base(context) { }
        public async Task NewGame(NewGame newGame)
        {
            await BattleShipContext.AddAsync(newGame);
            await BattleShipContext.SaveChangesAsync();
        }

        public async Task<NewGame> NewGameStatus(string NewGameId)
        {
            return BattleShipContext.NewGame.Where(x => x.NewGameId.Equals(NewGameId)).FirstOrDefault();
        }

        private BattleShipContext BattleShipContext
        {
            get { return Context as BattleShipContext; }
        }
    }
}
