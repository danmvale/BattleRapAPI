using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace BattleRapAPI.Models
{
    public class Battle
    {
        [Key]
        public int Id { get; set; }

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

        public List<BattleRound> Rounds { get; set; } = new();
    }
}
