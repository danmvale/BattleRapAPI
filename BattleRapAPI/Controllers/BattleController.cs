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
                        x.VideoTitle.Contains(filter))
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
