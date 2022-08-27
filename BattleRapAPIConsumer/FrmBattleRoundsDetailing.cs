using BattleRapAPIConsumer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleRapAPIConsumer
{
    public partial class FrmBattleRoundsDetailing : Form
    {
        List<BattleRoundInfo> _rounds;

        public FrmBattleRoundsDetailing(List<BattleRoundInfo> rounds)
        {
            _rounds = rounds;
            InitializeComponent();

            foreach (var round in rounds)
                flowLayoutPanel1.Controls.Add(new Label() { Text = $"Round {round.RoundNumber}: {round.Winner}" });
        }
    }
}
