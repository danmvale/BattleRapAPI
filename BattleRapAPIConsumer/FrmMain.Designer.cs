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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenuTop10 = new System.Windows.Forms.Button();
            this.btnMenuBattles = new System.Windows.Forms.Button();
            this.pnlBattles = new System.Windows.Forms.Panel();
            this.txtSearchInput = new System.Windows.Forms.TextBox();
            this.pnlBattleContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.pnlBattles.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(976, 54);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.label1.Location = new System.Drawing.Point(374, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "BATALHAS DE RIMA";
            // 
            // btnMenuTop10
            // 
            this.btnMenuTop10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenuTop10.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnMenuTop10.FlatAppearance.BorderSize = 0;
            this.btnMenuTop10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuTop10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuTop10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btnMenuTop10.Location = new System.Drawing.Point(134, 62);
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
            this.btnMenuBattles.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnMenuBattles.Location = new System.Drawing.Point(12, 62);
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
            this.pnlBattles.Location = new System.Drawing.Point(12, 115);
            this.pnlBattles.Name = "pnlBattles";
            this.pnlBattles.Size = new System.Drawing.Size(952, 416);
            this.pnlBattles.TabIndex = 3;
            // 
            // txtSearchInput
            // 
            this.txtSearchInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.txtSearchInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.txtSearchInput.Location = new System.Drawing.Point(16, 12);
            this.txtSearchInput.Name = "txtSearchInput";
            this.txtSearchInput.Size = new System.Drawing.Size(914, 29);
            this.txtSearchInput.TabIndex = 0;
            this.txtSearchInput.Text = "Buscar...";
            this.txtSearchInput.Enter += new System.EventHandler(this.txtSearchInput_Enter);
            this.txtSearchInput.Leave += new System.EventHandler(this.txtSearchInput_Leave);
            // 
            // pnlBattleContainer
            // 
            this.pnlBattleContainer.Location = new System.Drawing.Point(16, 57);
            this.pnlBattleContainer.Name = "pnlBattleContainer";
            this.pnlBattleContainer.Size = new System.Drawing.Size(914, 340);
            this.pnlBattleContainer.TabIndex = 1;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(976, 543);
            this.Controls.Add(this.pnlBattles);
            this.Controls.Add(this.btnMenuBattles);
            this.Controls.Add(this.btnMenuTop10);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Batalhas de Rima";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlBattles.ResumeLayout(false);
            this.pnlBattles.PerformLayout();
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
    }
}

