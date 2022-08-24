using BattleRapAPI.Models;

namespace BattleRapAPI.Repositories.Interfaces
{
    public interface IBattleRepository
    {
        IEnumerable<Battle> Battles { get; }
        Battle? GetBattleById(int id);
        int AddBattle(Battle battle);
        bool UpdateBattle(Battle battle);
        bool RemoveBattle(int id);
        bool RemoveBattle(Battle battle);
    }
}
