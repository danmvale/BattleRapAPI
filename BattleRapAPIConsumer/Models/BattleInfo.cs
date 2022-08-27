using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleRapAPIConsumer.Models
{
    public class BattleInfo
    {
        public string Participant1 { get; set; }
        public string Participant2 { get; set; }
        public string Title { get; set; }
        public string VideoUrl { get; set; }
        public string VideoThumbnailUrl { get; set; }
        public string Winner { get; set; }
        public string Score { get; set; }
        public List<BattleRoundInfo> Rounds { get; set; }
    }
}
