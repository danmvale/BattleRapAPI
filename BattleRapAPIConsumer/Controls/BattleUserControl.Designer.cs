namespace BattleRapAPIConsumer.Controls
{
    partial class BattleUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbxThumbnail = new System.Windows.Forms.PictureBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDetailRounds = new System.Windows.Forms.Button();
            this.ttp = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbxThumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxThumbnail
            // 
            this.pbxThumbnail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbxThumbnail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxThumbnail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxThumbnail.Location = new System.Drawing.Point(352, 18);
            this.pbxThumbnail.Name = "pbxThumbnail";
            this.pbxThumbnail.Size = new System.Drawing.Size(400, 225);
            this.pbxThumbnail.TabIndex = 0;
            this.pbxThumbnail.TabStop = false;
            this.ttp.SetToolTip(this.pbxThumbnail, "Abrir vídeo");
            this.pbxThumbnail.Click += new System.EventHandler(this.pbxThumbnail_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.ForeColor = System.Drawing.Color.Snow;
            this.txtTitle.Location = new System.Drawing.Point(12, 23);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.ReadOnly = true;
            this.txtTitle.Size = new System.Drawing.Size(312, 97);
            this.txtTitle.TabIndex = 1;
            this.txtTitle.Text = "Orochi vs Jhony (🥶O DIA QUE OROCHI FOI PARADO) - FINAL-#ReiDoTanque Edição 183º " +
    "da Batalha do Tanque";
            this.ttp.SetToolTip(this.txtTitle, "Abrir vídeo");
            this.txtTitle.Click += new System.EventHandler(this.txtTitle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Vencedor:";
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Location = new System.Drawing.Point(111, 129);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(51, 21);
            this.lblWinner.TabIndex = 3;
            this.lblWinner.Text = "Jhony";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(86, 160);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(43, 21);
            this.lblScore.TabIndex = 5;
            this.lblScore.Tag = "";
            this.lblScore.Text = "2 x 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Placar:";
            // 
            // btnDetailRounds
            // 
            this.btnDetailRounds.BackColor = System.Drawing.Color.SkyBlue;
            this.btnDetailRounds.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetailRounds.FlatAppearance.BorderSize = 0;
            this.btnDetailRounds.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetailRounds.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetailRounds.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDetailRounds.Location = new System.Drawing.Point(12, 204);
            this.btnDetailRounds.Name = "btnDetailRounds";
            this.btnDetailRounds.Size = new System.Drawing.Size(312, 39);
            this.btnDetailRounds.TabIndex = 6;
            this.btnDetailRounds.Text = "Detalhamento dos Rounds";
            this.btnDetailRounds.UseVisualStyleBackColor = false;
            this.btnDetailRounds.Click += new System.EventHandler(this.btnDetailRounds_Click);
            // 
            // BattleUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnDetailRounds);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.pbxThumbnail);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BattleUserControl";
            this.Size = new System.Drawing.Size(765, 255);
            this.Load += new System.EventHandler(this.BattleUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxThumbnail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxThumbnail;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDetailRounds;
        private System.Windows.Forms.ToolTip ttp;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}
