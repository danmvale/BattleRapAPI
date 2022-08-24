using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BattleRapAPI.Models
{
    public class BattleRound
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Range(1, 5)]
        public byte RoundNumber { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(50)]
        public string Winner { get; set; }

        [ForeignKey("Id")]
        public int BattleId { get; set; }
    }
}
