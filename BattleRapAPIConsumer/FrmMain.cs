using BattleRapAPIConsumer.Controls;
using BattleRapAPIConsumer.Models;
using BattleRapAPIConsumer.Models.DTOs;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleRapAPIConsumer
{
    public partial class FrmMain : Form
    {
        List<Button> menuButtons = new List<Button>();
        Button currentMenuButton;
        Dictionary<Button, Panel> buttonPanel = new Dictionary<Button, Panel>();
        Panel activePanel;

        public FrmMain()
        {
            InitializeComponent();

            MinimumSize = MaximumSize = Size;

            menuButtons.AddRange(flpMenu.Controls
                .OfType<Button>()
                .Where(x => x.Name.Contains("btnMenu")));

            currentMenuButton = btnMenuBattles;
            activePanel = pnlBattles;
            buttonPanel.Add(btnMenuBattles, pnlBattles);
            buttonPanel.Add(btnMenuTop10, pnlTop10);
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
            if (buttonPanel.ContainsKey(button))
            {
                currentMenuButton = button;
                currentMenuButton.ForeColor = Color.SkyBlue;

                menuButtons
                    .Where(x => x != currentMenuButton)
                    .ToList()
                    .ForEach(x => x.ForeColor = Color.FromArgb(120, 120, 120));

                var selectedPanel = buttonPanel[button];

                if (selectedPanel != activePanel)
                {
                    activePanel.Visible = false;
                    activePanel = selectedPanel;
                    activePanel.Visible = true;
                }
            }
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

        private void txtSearchInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(txtSearchInput.Text))
                FillBattlesContainer(txtSearchInput.Text);
        }

        private void FillBattlesContainer(string filter = "null")
        {
            pnlBattleContainer.Visible = false;
            pnlBattleContainer.Controls.Clear();
            pnlBattleContainer.Invoke(new Action<string>(GetBattleInfos), filter);
        }

        private async void GetBattleInfos(string filter = "null")
        {
            var client = new HttpClient();
            var response = await client.GetAsync($"https://localhost:7131/battles?page=0&pageSize=10&filter={filter}");
            var json = await response.Content.ReadAsStringAsync();
            var battles = JsonConvert.DeserializeObject<List<BattleDTO>>(json);
            var height = 0;
            var count = 0;

            using (var battleUserControl = new BattleUserControl(null))
                height = battleUserControl.Height;

            battles.ForEach(x =>
            {
                pnlBattleContainer.Controls.Add(new BattleUserControl(x.ToBattleInfo()) 
                { 
                    Location = new Point(0, (height + 15) * count)
                });
                count++;
            });

            pnlBattleContainer.Visible = true;
        }

        private void btnMenuScore_Click(object sender, EventArgs e)
        {
            MenuButtonClick(btnMenuScore);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            FillBattlesContainer();
        }
    }
}
