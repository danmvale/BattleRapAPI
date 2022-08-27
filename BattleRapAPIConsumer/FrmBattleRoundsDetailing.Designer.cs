namespace BattleRapAPIConsumer
{
    partial class FrmBattleRoundsDetailing
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBattleRoundsDetailing));
            this.flpRounds = new System.Windows.Forms.FlowLayoutPanel();
            this.txtParticipants = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // flpRounds
            // 
            this.flpRounds.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flpRounds.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpRounds.Location = new System.Drawing.Point(12, 12);
            this.flpRounds.Name = "flpRounds";
            this.flpRounds.Size = new System.Drawing.Size(236, 151);
            this.flpRounds.TabIndex = 1;
            // 
            // txtParticipants
            // 
            this.txtParticipants.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.txtParticipants.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtParticipants.Enabled = false;
            this.txtParticipants.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParticipants.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtParticipants.Location = new System.Drawing.Point(12, 173);
            this.txtParticipants.Name = "txtParticipants";
            this.txtParticipants.Size = new System.Drawing.Size(236, 26);
            this.txtParticipants.TabIndex = 3;
            this.txtParticipants.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // FrmBattleRoundsDetailing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(260, 211);
            this.Controls.Add(this.txtParticipants);
            this.Controls.Add(this.flpRounds);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmBattleRoundsDetailing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalhamento de Rounds";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpRounds;
        private System.Windows.Forms.TextBox txtParticipants;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}