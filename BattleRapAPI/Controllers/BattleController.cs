using BattleRapAPI.Models;
using BattleRapAPI.Models.DTOs;
using BattleRapAPI.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BattleRapAPI.Controllers
{
    [Route("battles")]
    [ApiController]
    public class BattleController : ControllerBase
    {
        private static IBattleRepository _battleRepository;

        public BattleController(IBattleRepository battleRepository)
        {
            _battleRepository = battleRepository;
        }

        [HttpGet(Name = "GetBattles")]
        public async Task<ActionResult<List<Battle>>> Get(string filter = "null", int page = 1, int pageSize = 10)
        {
            List<Battle> battles = null;

            if (filter != "null")
                battles = _battleRepository.Battles
                    .Where(x => 
                        x.Participant1.Contains(filter, StringComparison.InvariantCultureIgnoreCase) || 
                        x.Participant2.Contains(filter, StringComparison.InvariantCultureIgnoreCase) || 
                        x.VideoTitle.Contains(filter, StringComparison.InvariantCultureIgnoreCase))
                    .ToList();

            else
                battles = _battleRepository.Battles
                    .ToList();

            return Ok(battles
                .Skip((page - 1) * pageSize)
                .Take(pageSize));
        }

        [HttpGet("{id}", Name = "GetBattleById")]
        public async Task<ActionResult<List<Battle>>> GetById(int id)
        {
            var battle = _battleRepository.GetBattleById(id);

            if (battle == null)
                return NotFound("Batalha não encontrada.");

            return Ok(battle);
        }

        [HttpGet("mcs/top10", Name = "GetTop10Winners")]
        public async Task<ActionResult<List<object>>> GetTop10Winners()
        {
            return Ok(_battleRepository.Battles
                .GroupBy(x => x.Winner)
                .OrderByDescending(x => x.Count())
                .ThenBy(x => x.Key)
                .Select((x, index) => new
                {
                    ranking = index + 1,
                    mc = x.Key,
                    victories = x.Count()
                }));
        }

        //[HttpGet("mcs/score", Name = "GetScoreBetweenTwoMcs")]
        //public async Task<ActionResult<List<object>>> GetScore(string mc1, string mc2)
        //{
        //    var battles = _battleRepository.Battles
        //        .Where(x =>
        //            (x.Participant1.Equals(mc1, StringComparison.InvariantCultureIgnoreCase) &&
        //                x.Participant2.Equals(mc2, StringComparison.InvariantCultureIgnoreCase) ||
        //            (x.Participant1.Equals(mc2, StringComparison.InvariantCultureIgnoreCase) &&
        //                x.Participant2.Equals(mc1, StringComparison.InvariantCultureIgnoreCase))))
        //        .ToList();

        //    if (battles.Count == 0)
        //        return BadRequest("Não foram encontradas batalhas entre esses dois MC's");

        //    var mc1Wins = battles
        //        .Where(x => x.Winner.Equals(mc1, StringComparison.InvariantCultureIgnoreCase))
        //        .Count();
        //    var mc2Wins = battles
        //        .Where(x => x.Winner.Equals(mc2, StringComparison.InvariantCultureIgnoreCase))
        //        .Count();

        //    if (mc2Wins > mc1Wins)
        //    {
        //        var auxMc = mc1;
        //        var auxMcWins = mc1Wins;

        //        mc1 = mc2;
        //        mc1Wins = mc2Wins;

        //        mc2 = auxMc;
        //        mc2Wins = auxMcWins;
        //    }

        //    return Ok(new Dictionary<string, string>
        //    {
        //        { mc1, mc1Wins.ToString() },
        //        { mc2, mc2Wins.ToString() }
        //    });
        //}

        [HttpGet("mcs/score", Name = "GetScoreBetweenTwoMcs")]
        public async Task<ActionResult<List<object>>> GetScore(string mc1, string mc2)
        {
            var battles = _battleRepository.Battles
                .Where(x =>
                    (x.Participant1.Equals(mc1, StringComparison.InvariantCultureIgnoreCase) &&
                        x.Participant2.Equals(mc2, StringComparison.InvariantCultureIgnoreCase) ||
                    (x.Participant1.Equals(mc2, StringComparison.InvariantCultureIgnoreCase) &&
                        x.Participant2.Equals(mc1, StringComparison.InvariantCultureIgnoreCase))))
                .ToList();

            if (battles.Count == 0)
                return BadRequest("Não foram encontradas batalhas entre esses dois MC's");

            var mc1Wins = battles
                .Where(x => x.Winner.Equals(mc1, StringComparison.InvariantCultureIgnoreCase))
                .Count();
            var mc2Wins = battles
                .Where(x => x.Winner.Equals(mc2, StringComparison.InvariantCultureIgnoreCase))
                .Count();

            return Ok(new Dictionary<string, string>
            {
                { "mc1", mc1Wins.ToString() },
                { "mc2", mc2Wins.ToString() }
            });
        }

        [HttpPost(Name = "CreateBattle")]
        public async Task<ActionResult<Battle>> Post(BattleDTO battle)
        {
            var battleId = _battleRepository.AddBattle(battle.ToBattle());

            return battleId > 0 ? 
                Created($"https://localhost:7131/Battles/{battleId}", battle) : 
                BadRequest("Não foi possível adicionar essa batalha.");
        }

        [HttpPut(Name = "UpdateBattle")]
        public async Task<ActionResult<Battle>> Put(Battle battle)
        {
            return _battleRepository.UpdateBattle(battle) ? 
                Ok(battle) : 
                BadRequest("Não foi possível atualizar as informações dessa batalha.");
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Battle>> Delete(int id)
        {
            return _battleRepository.RemoveBattle(id) ? 
                Ok("Batalha excluída com sucesso!") : 
                BadRequest("Não foi possível excluir essa batalha.");
        }
    }
}
