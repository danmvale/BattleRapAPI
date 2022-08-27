using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleRapAPIConsumer.Models.DTOs
{
    public class BattleDTO
    {
        public int Id { get; set; }
        public string Participant1 { get; set; }
        public string Participant2 { get; set; }
        public string Winner { get; set; }
        public string VideoTitle { get; set; }
        public string VideoThumbnailUrl { get; set; }
        public string VideoUrl { get; set; }
        public List<BattleRoundDTO> Rounds { get; set; }

        public BattleInfo ToBattleInfo()
        {
            return new BattleInfo
            {
                Title = VideoTitle,
                Winner = Winner,
                Score = $"{string.Join(" x ", Rounds.GroupBy(x => x.Winner).Select(x => x.Count()).OrderByDescending(x => x))}",
                VideoThumbnailUrl = VideoThumbnailUrl,
                VideoUrl = VideoUrl,
                Rounds = Rounds.Select(x => new BattleRoundInfo
                {
                    RoundNumber = x.RoundNumber,
                    Winner = x.Winner,
                }).ToList()
            };
        }
    }
}
