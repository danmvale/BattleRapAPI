using BattleRapAPIConsumer.Models;
using BattleRapAPIConsumer.Utilities;
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
        BattleInfo _battleInfo;

        public FrmBattleRoundsDetailing(BattleInfo battleInfo)
        {
            try
            {
                _battleInfo = battleInfo;
                InitializeComponent();

                MaximumSize = MinimumSize = Size;

                txtParticipants.Text = $"{battleInfo.Participant1} x {battleInfo.Participant2}";

                battleInfo.Rounds.ForEach(x =>
                {
                    flpRounds.Controls.Add(new Label()
                    {
                        Text = $"Round {x.RoundNumber}: {x.Winner}",
                        Width = flpRounds.Width
                    });
                });
            }

            catch (Exception ex)
            {
                Util.ShowError(ex);
                Close();
            }
        }
    }
}
