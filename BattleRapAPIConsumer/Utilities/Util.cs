using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleRapAPIConsumer.Utilities
{
    public static class Util
    {
        public static void ShowError(Exception ex)
        {
            var message = $"Erro: {ex.GetType()}";
            message += $"Mensagem: {ex.Message}";
            message += $"Local: {ex.StackTrace}";

            MessageBox.Show(message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
