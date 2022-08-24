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
    public partial class FrmMain : Form
    {
        List<Button> menuButtons = new List<Button>();
        Button currentMenuButton;

        public FrmMain()
        {
            InitializeComponent();

            menuButtons.AddRange(this.Controls
                .OfType<Button>()
                .Where(x => x.Name.Contains("btnMenu")));

            currentMenuButton = btnMenuBattles;
        }

        private void btnBattles_Click(object sender, EventArgs e)
        {
            MenuButtonClick(btnMenuBattles);
        }

        private void btnTop10_Click(object sender, EventArgs e)
        {
            MenuButtonClick(btnMenuTop10);
        }

        private void MenuButtonClick(Button button)
        {
            currentMenuButton = button;
            currentMenuButton.ForeColor = Color.WhiteSmoke;

            menuButtons
                .Where(x => x != currentMenuButton)
                .ToList()
                .ForEach(x => x.ForeColor = Color.FromArgb(120, 120, 120));
        }

        private void txtSearchInput_Enter(object sender, EventArgs e)
        {
            if (txtSearchInput.Text == "Buscar...")
            {
                txtSearchInput.Clear();
                txtSearchInput.ForeColor = Color.WhiteSmoke;
            }
        }

        private void txtSearchInput_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchInput.Text))
            {
                txtSearchInput.ForeColor = Color.FromArgb(120, 120, 120);
                txtSearchInput.Text = "Buscar...";
            }
        }
    }
}
