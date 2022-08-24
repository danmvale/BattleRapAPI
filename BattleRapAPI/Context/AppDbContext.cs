using BattleRapAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BattleRapAPI.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Battle> Battles { get; set; }
        public DbSet<BattleRound> BattleRounds { get; set; }
    }
}
