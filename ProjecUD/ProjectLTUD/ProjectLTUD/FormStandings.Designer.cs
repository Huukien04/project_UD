namespace ProjectLTUD
{
    partial class FormStandings
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvStandings = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colRank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPlayed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDraw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGoalsFor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGoalsAganist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGoalsDifference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPoints = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStandings)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStandings
            // 
            this.dgvStandings.AllowUserToResizeColumns = false;
            this.dgvStandings.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvStandings.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvStandings.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStandings.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvStandings.ColumnHeadersHeight = 45;
            this.dgvStandings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvStandings.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colRank,
            this.colClub,
            this.colPlayed,
            this.colWon,
            this.colDraw,
            this.colLose,
            this.colGoalsFor,
            this.colGoalsAganist,
            this.colGoalsDifference,
            this.colPoints});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStandings.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvStandings.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvStandings.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvStandings.Location = new System.Drawing.Point(0, 0);
            this.dgvStandings.Name = "dgvStandings";
            this.dgvStandings.ReadOnly = true;
            this.dgvStandings.RowHeadersVisible = false;
            this.dgvStandings.RowHeadersWidth = 51;
            this.dgvStandings.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvStandings.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStandings.RowTemplate.Height = 35;
            this.dgvStandings.Size = new System.Drawing.Size(835, 902);
            this.dgvStandings.TabIndex = 71;
            this.dgvStandings.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvStandings.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvStandings.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvStandings.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvStandings.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvStandings.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvStandings.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvStandings.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvStandings.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvStandings.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStandings.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvStandings.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvStandings.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvStandings.ThemeStyle.ReadOnly = true;
            this.dgvStandings.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvStandings.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvStandings.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStandings.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvStandings.ThemeStyle.RowsStyle.Height = 35;
            this.dgvStandings.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvStandings.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvStandings.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStandings_CellContentClick);
            // 
            // colRank
            // 
            this.colRank.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colRank.DataPropertyName = "Ranking";
            this.colRank.FillWeight = 15.5486F;
            this.colRank.Frozen = true;
            this.colRank.HeaderText = "Ranking";
            this.colRank.MinimumWidth = 6;
            this.colRank.Name = "colRank";
            this.colRank.ReadOnly = true;
            this.colRank.Width = 70;
            // 
            // colClub
            // 
            this.colClub.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colClub.DataPropertyName = "ClubName";
            this.colClub.FillWeight = 799.4648F;
            this.colClub.Frozen = true;
            this.colClub.HeaderText = "Club";
            this.colClub.MinimumWidth = 6;
            this.colClub.Name = "colClub";
            this.colClub.ReadOnly = true;
            this.colClub.Width = 170;
            // 
            // colPlayed
            // 
            this.colPlayed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colPlayed.DataPropertyName = "Played";
            this.colPlayed.FillWeight = 16.56745F;
            this.colPlayed.HeaderText = "Played";
            this.colPlayed.MinimumWidth = 6;
            this.colPlayed.Name = "colPlayed";
            this.colPlayed.ReadOnly = true;
            this.colPlayed.Width = 70;
            // 
            // colWon
            // 
            this.colWon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colWon.DataPropertyName = "Won";
            this.colWon.FillWeight = 16.56745F;
            this.colWon.HeaderText = "Won";
            this.colWon.MinimumWidth = 6;
            this.colWon.Name = "colWon";
            this.colWon.ReadOnly = true;
            this.colWon.Width = 70;
            // 
            // colDraw
            // 
            this.colDraw.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colDraw.DataPropertyName = "Drawn";
            this.colDraw.FillWeight = 16.56745F;
            this.colDraw.HeaderText = "Drawn";
            this.colDraw.MinimumWidth = 6;
            this.colDraw.Name = "colDraw";
            this.colDraw.ReadOnly = true;
            this.colDraw.Width = 70;
            // 
            // colLose
            // 
            this.colLose.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colLose.DataPropertyName = "Lost";
            this.colLose.FillWeight = 16.56745F;
            this.colLose.HeaderText = "Lost";
            this.colLose.MinimumWidth = 6;
            this.colLose.Name = "colLose";
            this.colLose.ReadOnly = true;
            this.colLose.Width = 70;
            // 
            // colGoalsFor
            // 
            this.colGoalsFor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colGoalsFor.DataPropertyName = "GoalsFor";
            this.colGoalsFor.FillWeight = 16.56745F;
            this.colGoalsFor.HeaderText = "GF";
            this.colGoalsFor.MinimumWidth = 6;
            this.colGoalsFor.Name = "colGoalsFor";
            this.colGoalsFor.ReadOnly = true;
            this.colGoalsFor.Width = 70;
            // 
            // colGoalsAganist
            // 
            this.colGoalsAganist.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colGoalsAganist.DataPropertyName = "GoalsAgainst";
            this.colGoalsAganist.FillWeight = 16.56745F;
            this.colGoalsAganist.HeaderText = "GA";
            this.colGoalsAganist.MinimumWidth = 6;
            this.colGoalsAganist.Name = "colGoalsAganist";
            this.colGoalsAganist.ReadOnly = true;
            this.colGoalsAganist.Width = 70;
            // 
            // colGoalsDifference
            // 
            this.colGoalsDifference.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colGoalsDifference.DataPropertyName = "GoalDifference";
            this.colGoalsDifference.FillWeight = 16.56745F;
            this.colGoalsDifference.HeaderText = "GD";
            this.colGoalsDifference.MinimumWidth = 6;
            this.colGoalsDifference.Name = "colGoalsDifference";
            this.colGoalsDifference.ReadOnly = true;
            this.colGoalsDifference.Width = 70;
            // 
            // colPoints
            // 
            this.colPoints.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colPoints.DataPropertyName = "Points";
            this.colPoints.FillWeight = 16.56745F;
            this.colPoints.HeaderText = "Points";
            this.colPoints.MinimumWidth = 6;
            this.colPoints.Name = "colPoints";
            this.colPoints.ReadOnly = true;
            this.colPoints.Width = 70;
            // 
            // FormStandings
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1669, 902);
            this.Controls.Add(this.dgvStandings);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormStandings";
            this.Text = "Standings";
            this.Load += new System.EventHandler(this.FormStandings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStandings)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView dgvStandings;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRank;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClub;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPlayed;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWon;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDraw;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLose;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGoalsFor;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGoalsAganist;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGoalsDifference;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPoints;
    }
}