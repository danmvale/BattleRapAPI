using BattleRapAPIConsumer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleRapAPIConsumer.Controls
{
    public partial class BattleUserControl : UserControl
    {
        private readonly BattleInfo _battleInfo;

        public BattleUserControl(BattleInfo battleInfo)
        {
            _battleInfo = battleInfo;
            InitializeComponent();
        }

        public async void GetThumbnailImage()
        {
            var client = new HttpClient();
            var response = await client.GetAsync(_battleInfo.VideoThumbnailUrl);
            var imageStream = await response.Content.ReadAsStreamAsync();
            pbxThumbnail.BackgroundImage = SetImageOpacity(Image.FromStream(imageStream), 0.75f);
        }

        public void FillUserControl()
        {
            txtTitle.Text = _battleInfo.Title;
            lblWinner.Text = _battleInfo.Winner;
            lblScore.Text = _battleInfo.Score;
            pbxThumbnail.Invoke(new Action(GetThumbnailImage));
        }

        private void BattleUserControl_Load(object sender, EventArgs e)
        {
            FillUserControl();
        }

        private void pbxThumbnail_Click(object sender, EventArgs e)
        {
            OpenVideo();
        }

        public Image SetImageOpacity(Image image, float opacity)
        {
            Bitmap bmp = new Bitmap(image.Width, image.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                ColorMatrix matrix = new ColorMatrix();
                matrix.Matrix33 = opacity;
                ImageAttributes attributes = new ImageAttributes();
                attributes.SetColorMatrix(matrix, ColorMatrixFlag.Default,
                                                  ColorAdjustType.Bitmap);
                g.DrawImage(image, new Rectangle(0, 0, bmp.Width, bmp.Height),
                                   0, 0, image.Width, image.Height,
                                   GraphicsUnit.Pixel, attributes);
            }
            return bmp;
        }

        private void txtTitle_Click(object sender, EventArgs e)
        {
            OpenVideo();
        }

        private void OpenVideo()
        {
            Process.Start(_battleInfo.VideoUrl);
        }

        private void btnDetailRounds_Click(object sender, EventArgs e)
        {
            new FrmBattleRoundsDetailing(_battleInfo).ShowDialog();
        }
    }
}
