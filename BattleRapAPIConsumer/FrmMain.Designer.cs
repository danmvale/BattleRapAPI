namespace BattleRapAPIConsumer
{
    partial class FrmMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenuTop10 = new System.Windows.Forms.Button();
            this.btnMenuBattles = new System.Windows.Forms.Button();
            this.pnlBattles = new System.Windows.Forms.Panel();
            this.pnlBattleContainer = new System.Windows.Forms.Panel();
            this.txtSearchInput = new System.Windows.Forms.TextBox();
            this.pnlTop10 = new System.Windows.Forms.Panel();
            this.btnMenuScore = new System.Windows.Forms.Button();
            this.flpMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlTop10Container = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlScore = new System.Windows.Forms.Panel();
            this.txtScoreNameMc1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtScoreNameMc2 = new System.Windows.Forms.TextBox();
            this.txtScoreScoreMc1 = new System.Windows.Forms.TextBox();
            this.txtScoreScoreMc2 = new System.Windows.Forms.TextBox();
            this.btnSearchScore = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnlBattles.SuspendLayout();
            this.pnlTop10.SuspendLayout();
            this.flpMenu.SuspendLayout();
            this.pnlScore.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(894, 54);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(91)))), ((int)(((byte)(91)))));
            this.label2.Location = new System.Drawing.Point(525, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "🩸";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(338, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "BATALHAS DE RIMA 🩸";
            // 
            // btnMenuTop10
            // 
            this.btnMenuTop10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuTop10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMenuTop10.FlatAppearance.BorderSize = 0;
            this.btnMenuTop10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuTop10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuTop10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnMenuTop10.Location = new System.Drawing.Point(125, 3);
            this.btnMenuTop10.Name = "btnMenuTop10";
            this.btnMenuTop10.Size = new System.Drawing.Size(116, 39);
            this.btnMenuTop10.TabIndex = 1;
            this.btnMenuTop10.Text = "Top 10 MC\'s";
            this.btnMenuTop10.UseVisualStyleBackColor = true;
            this.btnMenuTop10.Click += new System.EventHandler(this.btnTop10_Click);
            // 
            // btnMenuBattles
            // 
            this.btnMenuBattles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuBattles.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMenuBattles.FlatAppearance.BorderSize = 0;
            this.btnMenuBattles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuBattles.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuBattles.ForeColor = System.Drawing.Color.SkyBlue;
            this.btnMenuBattles.Location = new System.Drawing.Point(3, 3);
            this.btnMenuBattles.Name = "btnMenuBattles";
            this.btnMenuBattles.Size = new System.Drawing.Size(116, 39);
            this.btnMenuBattles.TabIndex = 2;
            this.btnMenuBattles.Text = "Batalhas";
            this.btnMenuBattles.UseVisualStyleBackColor = true;
            this.btnMenuBattles.Click += new System.EventHandler(this.btnBattles_Click);
            // 
            // pnlBattles
            // 
            this.pnlBattles.Controls.Add(this.pnlBattleContainer);
            this.pnlBattles.Controls.Add(this.txtSearchInput);
            this.pnlBattles.Location = new System.Drawing.Point(35, 115);
            this.pnlBattles.Name = "pnlBattles";
            this.pnlBattles.Size = new System.Drawing.Size(828, 421);
            this.pnlBattles.TabIndex = 3;
            // 
            // pnlBattleContainer
            // 
            this.pnlBattleContainer.AutoScroll = true;
            this.pnlBattleContainer.Location = new System.Drawing.Point(16, 64);
            this.pnlBattleContainer.Name = "pnlBattleContainer";
            this.pnlBattleContainer.Size = new System.Drawing.Size(791, 340);
            this.pnlBattleContainer.TabIndex = 1;
            // 
            // txtSearchInput
            // 
            this.txtSearchInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtSearchInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtSearchInput.Location = new System.Drawing.Point(16, 12);
            this.txtSearchInput.Name = "txtSearchInput";
            this.txtSearchInput.Size = new System.Drawing.Size(791, 29);
            this.txtSearchInput.TabIndex = 0;
            this.txtSearchInput.Text = "Buscar...";
            this.txtSearchInput.Enter += new System.EventHandler(this.txtSearchInput_Enter);
            this.txtSearchInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchInput_KeyDown);
            this.txtSearchInput.Leave += new System.EventHandler(this.txtSearchInput_Leave);
            // 
            // pnlTop10
            // 
            this.pnlTop10.Controls.Add(this.pnlTop10Container);
            this.pnlTop10.Location = new System.Drawing.Point(35, 115);
            this.pnlTop10.Name = "pnlTop10";
            this.pnlTop10.Size = new System.Drawing.Size(828, 421);
            this.pnlTop10.TabIndex = 4;
            this.pnlTop10.Visible = false;
            // 
            // btnMenuScore
            // 
            this.btnMenuScore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuScore.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMenuScore.FlatAppearance.BorderSize = 0;
            this.btnMenuScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuScore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnMenuScore.Location = new System.Drawing.Point(247, 3);
            this.btnMenuScore.Name = "btnMenuScore";
            this.btnMenuScore.Size = new System.Drawing.Size(116, 39);
            this.btnMenuScore.TabIndex = 5;
            this.btnMenuScore.Text = "Placar";
            this.btnMenuScore.UseVisualStyleBackColor = true;
            this.btnMenuScore.Click += new System.EventHandler(this.btnMenuScore_Click);
            // 
            // flpMenu
            // 
            this.flpMenu.Controls.Add(this.btnMenuBattles);
            this.flpMenu.Controls.Add(this.btnMenuTop10);
            this.flpMenu.Controls.Add(this.btnMenuScore);
            this.flpMenu.Location = new System.Drawing.Point(35, 59);
            this.flpMenu.Name = "flpMenu";
            this.flpMenu.Size = new System.Drawing.Size(828, 50);
            this.flpMenu.TabIndex = 6;
            // 
            // pnlTop10Container
            // 
            this.pnlTop10Container.AutoScroll = true;
            this.pnlTop10Container.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop10Container.Location = new System.Drawing.Point(16, 12);
            this.pnlTop10Container.Name = "pnlTop10Container";
            this.pnlTop10Container.Size = new System.Drawing.Size(791, 388);
            this.pnlTop10Container.TabIndex = 0;
            // 
            // pnlScore
            // 
            this.pnlScore.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlScore.Controls.Add(this.btnSearchScore);
            this.pnlScore.Controls.Add(this.txtScoreScoreMc2);
            this.pnlScore.Controls.Add(this.txtScoreScoreMc1);
            this.pnlScore.Controls.Add(this.label5);
            this.pnlScore.Controls.Add(this.txtScoreNameMc2);
            this.pnlScore.Controls.Add(this.label4);
            this.pnlScore.Controls.Add(this.label3);
            this.pnlScore.Controls.Add(this.txtScoreNameMc1);
            this.pnlScore.Location = new System.Drawing.Point(35, 115);
            this.pnlScore.Name = "pnlScore";
            this.pnlScore.Size = new System.Drawing.Size(828, 421);
            this.pnlScore.TabIndex = 5;
            this.pnlScore.Visible = false;
            // 
            // txtScoreNameMc1
            // 
            this.txtScoreNameMc1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtScoreNameMc1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtScoreNameMc1.Font = new System.Drawing.Font("Segoe UI", 26F);
            this.txtScoreNameMc1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtScoreNameMc1.Location = new System.Drawing.Point(40, 132);
            this.txtScoreNameMc1.Name = "txtScoreNameMc1";
            this.txtScoreNameMc1.Size = new System.Drawing.Size(231, 54);
            this.txtScoreNameMc1.TabIndex = 0;
            this.txtScoreNameMc1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(114, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 37);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mc 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 100F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(300, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(163, 177);
            this.label4.TabIndex = 3;
            this.label4.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(563, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 37);
            this.label5.TabIndex = 5;
            this.label5.Text = "Mc 2";
            // 
            // txtScoreNameMc2
            // 
            this.txtScoreNameMc2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtScoreNameMc2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtScoreNameMc2.Font = new System.Drawing.Font("Segoe UI", 26F);
            this.txtScoreNameMc2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtScoreNameMc2.Location = new System.Drawing.Point(486, 132);
            this.txtScoreNameMc2.Name = "txtScoreNameMc2";
            this.txtScoreNameMc2.Size = new System.Drawing.Size(231, 54);
            this.txtScoreNameMc2.TabIndex = 1;
            this.txtScoreNameMc2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtScoreScoreMc1
            // 
            this.txtScoreScoreMc1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.txtScoreScoreMc1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtScoreScoreMc1.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold);
            this.txtScoreScoreMc1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtScoreScoreMc1.Location = new System.Drawing.Point(40, 189);
            this.txtScoreScoreMc1.Name = "txtScoreScoreMc1";
            this.txtScoreScoreMc1.ReadOnly = true;
            this.txtScoreScoreMc1.Size = new System.Drawing.Size(231, 128);
            this.txtScoreScoreMc1.TabIndex = 8;
            this.txtScoreScoreMc1.Text = "0";
            this.txtScoreScoreMc1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtScoreScoreMc2
            // 
            this.txtScoreScoreMc2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.txtScoreScoreMc2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtScoreScoreMc2.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Bold);
            this.txtScoreScoreMc2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtScoreScoreMc2.Location = new System.Drawing.Point(486, 190);
            this.txtScoreScoreMc2.Name = "txtScoreScoreMc2";
            this.txtScoreScoreMc2.ReadOnly = true;
            this.txtScoreScoreMc2.Size = new System.Drawing.Size(231, 128);
            this.txtScoreScoreMc2.TabIndex = 9;
            this.txtScoreScoreMc2.Text = "0";
            this.txtScoreScoreMc2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSearchScore
            // 
            this.btnSearchScore.BackColor = System.Drawing.Color.SkyBlue;
            this.btnSearchScore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchScore.FlatAppearance.BorderSize = 0;
            this.btnSearchScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchScore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSearchScore.Location = new System.Drawing.Point(731, 132);
            this.btnSearchScore.Name = "btnSearchScore";
            this.btnSearchScore.Size = new System.Drawing.Size(72, 43);
            this.btnSearchScore.TabIndex = 2;
            this.btnSearchScore.Text = "Buscar";
            this.btnSearchScore.UseVisualStyleBackColor = false;
            this.btnSearchScore.Click += new System.EventHandler(this.btnSearchScore_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(894, 548);
            this.Controls.Add(this.pnlScore);
            this.Controls.Add(this.pnlBattles);
            this.Controls.Add(this.pnlTop10);
            this.Controls.Add(this.flpMenu);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Batalhas de Rima";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlBattles.ResumeLayout(false);
            this.pnlBattles.PerformLayout();
            this.pnlTop10.ResumeLayout(false);
            this.flpMenu.ResumeLayout(false);
            this.pnlScore.ResumeLayout(false);
            this.pnlScore.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMenuTop10;
        private System.Windows.Forms.Button btnMenuBattles;
        private System.Windows.Forms.Panel pnlBattles;
        private System.Windows.Forms.TextBox txtSearchInput;
        private System.Windows.Forms.Panel pnlBattleContainer;
        private System.Windows.Forms.Panel pnlTop10;
        private System.Windows.Forms.Button btnMenuScore;
        private System.Windows.Forms.FlowLayoutPanel flpMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel pnlTop10Container;
        private System.Windows.Forms.Panel pnlScore;
        private System.Windows.Forms.TextBox txtScoreScoreMc2;
        private System.Windows.Forms.TextBox txtScoreScoreMc1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtScoreNameMc2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtScoreNameMc1;
        private System.Windows.Forms.Button btnSearchScore;
    }
}

