using BattleRapAPI.Context;
using BattleRapAPI.Models;
using BattleRapAPI.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BattleRapAPI.Repositories
{
    public class BattleRepository : IBattleRepository
    {
        private readonly AppDbContext _context;

        public BattleRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Battle> Battles => _context.Battles
            .Include(x => x.Rounds);

        public Battle? GetBattleById(int id) => _context.Battles
            .Include(x => x.Rounds)
            .FirstOrDefault(x => x.Id == id);

        public int AddBattle(Battle battle)
        {
            _context.Battles.Add(battle);
            _context.SaveChanges();
            return battle.Id;
        }

        public bool UpdateBattle(Battle battle)
        {
            _context.Battles.Update(battle);
            return _context.SaveChanges() >= battle.Rounds.Count + 1;
        }

        public bool RemoveBattle(int id)
        {
            var battle = _context.Battles
                .FirstOrDefault(x => x.Id == id);

            if (battle == null)
                return false;

            return RemoveBattle(battle);
        }

        public bool RemoveBattle(Battle battle)
        {
            _context.Battles.Remove(battle);
            return _context.SaveChanges() >= battle.Rounds.Count + 1;
        }
    }
}
