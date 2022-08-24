using Microsoft.AspNetCore.Mvc.Routing;
using System.ComponentModel.DataAnnotations;

namespace BattleRapAPI.Models.DTOs
{
    public class BattleDTO
    {
        [Required]
        [MinLength(1)]
        [MaxLength(50)]
        public string Participant1 { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(50)]
        public string Participant2 { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(50)]
        public string Winner { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(500)]
        public string VideoTitle { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(500)]
        public string VideoThumbnailUrl { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(500)]
        public string VideoUrl { get; set; }

        public List<BattleRoundDTO> Rounds { get; set; }

        public Battle ToBattle()
        {
            var battle = new Battle();

            battle.VideoTitle = VideoTitle;
            battle.VideoUrl = VideoUrl;
            battle.VideoThumbnailUrl = VideoThumbnailUrl;
            battle.Participant1 = Participant1;
            battle.Participant2 = Participant2;
            battle.Winner = Winner;

            Rounds.ForEach(x => battle.Rounds.Add(new BattleRound
            {
                RoundNumber = x.RoundNumber,
                Winner = x.Winner
            }));

            return battle;
        }
    }
}
