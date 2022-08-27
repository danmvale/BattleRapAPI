using BattleRapAPIConsumer.Utilities;
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
            buttonPanel.Add(btnMenuScore, pnlScore);
        }

        private void btnBattles_Click(object sender, EventArgs e)
        {
            try
            {
                MenuButtonClick(btnMenuBattles);
            }

            catch (Exception ex)
            {
                Util.ShowError(ex);
            }
        }

        private void btnTop10_Click(object sender, EventArgs e)
        {
            try
            {
                MenuButtonClick(btnMenuTop10);
                FillTop10Container();
            }

            catch (Exception ex)
            {
                Util.ShowError(ex);
            }
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
            try
            {
                if (txtSearchInput.Text == "Buscar...")
                {
                    txtSearchInput.Clear();
                    txtSearchInput.ForeColor = Color.WhiteSmoke;
                }
            }

            catch (Exception ex)
            {
                Util.ShowError(ex);
            }
        }

        private void txtSearchInput_Leave(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtSearchInput.Text))
                {
                    txtSearchInput.ForeColor = Color.FromArgb(120, 120, 120);
                    txtSearchInput.Text = "Buscar...";
                }
            }

            catch (Exception ex)
            {
                Util.ShowError(ex);
            }
        }

        private void txtSearchInput_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter && !string.IsNullOrWhiteSpace(txtSearchInput.Text))
                    FillBattlesContainer(txtSearchInput.Text);
            }

            catch (Exception ex)
            {
                Util.ShowError(ex);
            }
        }

        private void FillBattlesContainer(string filter = "null")
        {
            pnlBattleContainer.Visible = false;
            pnlBattleContainer.Controls.Clear();
            pnlBattleContainer.Invoke(new Action<string>(GetBattleInfos), filter);
        }

        private async void GetBattleInfos(string filter = "null")
        {
            try
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

            catch (Exception ex)
            {
                Util.ShowError(ex);
            }
        }

        private void FillTop10Container()
        {
            pnlTop10Container.Visible = false;
            pnlTop10Container.Controls.Clear();
            pnlTop10Container.Invoke(new Action(GetTop10MCs));
        }

        private async void GetTop10MCs()
        {
            try
            {
                var client = new HttpClient();
                var response = await client.GetAsync($"https://localhost:7131/battles/mcs/top10");
                var json = await response.Content.ReadAsStringAsync();
                var mcs = JsonConvert.DeserializeObject<List<JObject>>(json);
                var height = 0;
                var count = 0;

                mcs.ForEach(x =>
                {
                    pnlTop10Container.Controls.Add(new Label
                    {
                        Text = $"{x["ranking"]} - {x["mc"]} ({x["victories"]} vitória(s))",
                        Width = pnlTop10Container.Width - 30,
                        Height = 60,
                        Margin = new Padding(0),
                        Font = new Font(new FontFamily("Segoe UI"), 26F, FontStyle.Bold),
                        ForeColor = Color.WhiteSmoke,
                        //BorderStyle = BorderStyle.FixedSingle,
                    });
                    count++;
                });

                pnlTop10Container.Visible = true;
            }

            catch (Exception ex)
            {
                Util.ShowError(ex);
            }
        }

        private void btnMenuScore_Click(object sender, EventArgs e)
        {
            try
            {
                MenuButtonClick(btnMenuScore);
            }

            catch (Exception ex)
            {
                Util.ShowError(ex);
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            try
            {
                FillBattlesContainer();
            }

            catch (Exception ex)
            {
                Util.ShowError(ex);
            }
        }

        private void btnSearchScore_Click(object sender, EventArgs e)
        {
            SearchScore();
        }

        private async void SearchScore()
        {
            var client = new HttpClient();
            var response = await client.GetAsync($"https://localhost:7131/battles/mcs/score?mc1={txtScoreNameMc1.Text}&mc2={txtScoreNameMc2.Text}");

            if (response.StatusCode == System.Net.HttpStatusCode.OK)
            {
                var json = await response.Content.ReadAsStringAsync();
                var score = JsonConvert.DeserializeObject<JObject>(json);
            
                txtScoreScoreMc1.Invoke(new Action(() => txtScoreScoreMc1.Text = score["mc1"].ToString()));
                txtScoreScoreMc2.Invoke(new Action(() => txtScoreScoreMc2.Text = score["mc2"].ToString()));
            }

            else
                MessageBox.Show("Não foram encontradas batalhas entre esses dois mcs.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
