using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleRapAPIConsumer.Models.DTOs
{
    public class BattleRoundDTO
    {
        public int Id { get; set; }
        public byte RoundNumber { get; set; }
        public string Winner { get; set; }
        public int BattleId { get; set; }
    }
}
