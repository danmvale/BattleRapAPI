using System.ComponentModel.DataAnnotations;

namespace BattleRapAPI.Models.DTOs
{
    public class BattleRoundDTO
    {
        [Required]
        [Range(1, 5)]
        public byte RoundNumber { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(50)]
        public string Winner { get; set; }
    }
}
