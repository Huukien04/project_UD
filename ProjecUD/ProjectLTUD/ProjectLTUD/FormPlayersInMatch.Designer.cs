namespace ProjectLTUD
{
    partial class FormPlayersInMatch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblClubName = new System.Windows.Forms.Label();
            this.dgvPlayersInMatch = new Guna.UI2.WinForms.Guna2DataGridView();
            this.PlayerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Goal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YellowCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RedCard = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OwnGoal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblMatchName = new System.Windows.Forms.Label();
            this.grbChoosePlayer = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel6 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.txtYC = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPlayerID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPlayerName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtOG = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cboPosition = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtRC = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGoal = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvPlayersInClub = new Guna.UI2.WinForms.Guna2DataGridView();
            this.PlayerIDInClub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayerNameInClub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Foot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefresh = new FontAwesome.Sharp.IconButton();
            this.btnDel = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.btnEdit = new FontAwesome.Sharp.IconButton();
            this.btnBack = new FontAwesome.Sharp.IconButton();
            this.msgConfirm = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.msgNotify = new Guna.UI2.WinForms.Guna2MessageDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayersInMatch)).BeginInit();
            this.grbChoosePlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayersInClub)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClubName
            // 
            this.lblClubName.AutoSize = true;
            this.lblClubName.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClubName.Location = new System.Drawing.Point(7, 99);
            this.lblClubName.Name = "lblClubName";
            this.lblClubName.Size = new System.Drawing.Size(155, 38);
            this.lblClubName.TabIndex = 6;
            this.lblClubName.Text = "Club Name";
            // 
            // dgvPlayersInMatch
            // 
            this.dgvPlayersInMatch.AllowUserToResizeColumns = false;
            this.dgvPlayersInMatch.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvPlayersInMatch.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPlayersInMatch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlayersInMatch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPlayersInMatch.ColumnHeadersHeight = 50;
            this.dgvPlayersInMatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPlayersInMatch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlayerID,
            this.PlayerName,
            this.Position,
            this.Goal,
            this.YellowCard,
            this.RedCard,
            this.OwnGoal});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPlayersInMatch.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPlayersInMatch.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPlayersInMatch.Location = new System.Drawing.Point(14, 150);
            this.dgvPlayersInMatch.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgvPlayersInMatch.Name = "dgvPlayersInMatch";
            this.dgvPlayersInMatch.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlayersInMatch.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPlayersInMatch.RowHeadersVisible = false;
            this.dgvPlayersInMatch.RowHeadersWidth = 50;
            this.dgvPlayersInMatch.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvPlayersInMatch.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPlayersInMatch.RowTemplate.Height = 40;
            this.dgvPlayersInMatch.Size = new System.Drawing.Size(608, 579);
            this.dgvPlayersInMatch.TabIndex = 13;
            this.dgvPlayersInMatch.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPlayersInMatch.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPlayersInMatch.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPlayersInMatch.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPlayersInMatch.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPlayersInMatch.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvPlayersInMatch.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPlayersInMatch.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvPlayersInMatch.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPlayersInMatch.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPlayersInMatch.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPlayersInMatch.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPlayersInMatch.ThemeStyle.HeaderStyle.Height = 50;
            this.dgvPlayersInMatch.ThemeStyle.ReadOnly = true;
            this.dgvPlayersInMatch.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPlayersInMatch.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPlayersInMatch.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPlayersInMatch.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPlayersInMatch.ThemeStyle.RowsStyle.Height = 40;
            this.dgvPlayersInMatch.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPlayersInMatch.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPlayersInMatch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlayersInMatch_CellClick);
            // 
            // PlayerID
            // 
            this.PlayerID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PlayerID.DataPropertyName = "PlayerID";
            this.PlayerID.FillWeight = 116.2929F;
            this.PlayerID.HeaderText = "ID";
            this.PlayerID.MinimumWidth = 6;
            this.PlayerID.Name = "PlayerID";
            this.PlayerID.ReadOnly = true;
            this.PlayerID.Width = 65;
            // 
            // PlayerName
            // 
            this.PlayerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PlayerName.DataPropertyName = "PlayerName";
            this.PlayerName.HeaderText = "Player Name";
            this.PlayerName.MinimumWidth = 6;
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.ReadOnly = true;
            this.PlayerName.Width = 150;
            // 
            // Position
            // 
            this.Position.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Position.DataPropertyName = "Position";
            this.Position.FillWeight = 799.4648F;
            this.Position.HeaderText = "Position";
            this.Position.MinimumWidth = 6;
            this.Position.Name = "Position";
            this.Position.ReadOnly = true;
            this.Position.Width = 130;
            // 
            // Goal
            // 
            this.Goal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Goal.DataPropertyName = "Goal";
            this.Goal.FillWeight = 15.5486F;
            this.Goal.HeaderText = "Goal";
            this.Goal.MinimumWidth = 6;
            this.Goal.Name = "Goal";
            this.Goal.ReadOnly = true;
            this.Goal.Width = 70;
            // 
            // YellowCard
            // 
            this.YellowCard.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.YellowCard.DataPropertyName = "YellowCard";
            this.YellowCard.FillWeight = 16.56745F;
            this.YellowCard.HeaderText = "YC";
            this.YellowCard.MinimumWidth = 6;
            this.YellowCard.Name = "YellowCard";
            this.YellowCard.ReadOnly = true;
            this.YellowCard.Width = 60;
            // 
            // RedCard
            // 
            this.RedCard.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.RedCard.DataPropertyName = "RedCard";
            this.RedCard.FillWeight = 16.56745F;
            this.RedCard.HeaderText = "RC";
            this.RedCard.MinimumWidth = 6;
            this.RedCard.Name = "RedCard";
            this.RedCard.ReadOnly = true;
            this.RedCard.Width = 60;
            // 
            // OwnGoal
            // 
            this.OwnGoal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.OwnGoal.DataPropertyName = "OwnGoal";
            this.OwnGoal.FillWeight = 16.56745F;
            this.OwnGoal.HeaderText = "OG";
            this.OwnGoal.MinimumWidth = 6;
            this.OwnGoal.Name = "OwnGoal";
            this.OwnGoal.ReadOnly = true;
            this.OwnGoal.Width = 60;
            // 
            // lblMatchName
            // 
            this.lblMatchName.AutoSize = true;
            this.lblMatchName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatchName.Location = new System.Drawing.Point(104, 15);
            this.lblMatchName.Name = "lblMatchName";
            this.lblMatchName.Size = new System.Drawing.Size(198, 41);
            this.lblMatchName.TabIndex = 8;
            this.lblMatchName.Text = "Match Name";
            // 
            // grbChoosePlayer
            // 
            this.grbChoosePlayer.BackColor = System.Drawing.Color.LightGray;
            this.grbChoosePlayer.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.grbChoosePlayer.BorderRadius = 10;
            this.grbChoosePlayer.Controls.Add(this.guna2HtmlLabel7);
            this.grbChoosePlayer.Controls.Add(this.guna2HtmlLabel6);
            this.grbChoosePlayer.Controls.Add(this.guna2HtmlLabel4);
            this.grbChoosePlayer.Controls.Add(this.guna2HtmlLabel3);
            this.grbChoosePlayer.Controls.Add(this.guna2HtmlLabel2);
            this.grbChoosePlayer.Controls.Add(this.guna2HtmlLabel1);
            this.grbChoosePlayer.Controls.Add(this.txtYC);
            this.grbChoosePlayer.Controls.Add(this.txtPlayerID);
            this.grbChoosePlayer.Controls.Add(this.txtPlayerName);
            this.grbChoosePlayer.Controls.Add(this.txtOG);
            this.grbChoosePlayer.Controls.Add(this.guna2HtmlLabel5);
            this.grbChoosePlayer.Controls.Add(this.cboPosition);
            this.grbChoosePlayer.Controls.Add(this.txtRC);
            this.grbChoosePlayer.Controls.Add(this.txtGoal);
            this.grbChoosePlayer.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.grbChoosePlayer.FillColor = System.Drawing.Color.Transparent;
            this.grbChoosePlayer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbChoosePlayer.ForeColor = System.Drawing.Color.White;
            this.grbChoosePlayer.Location = new System.Drawing.Point(684, 150);
            this.grbChoosePlayer.Name = "grbChoosePlayer";
            this.grbChoosePlayer.Size = new System.Drawing.Size(352, 418);
            this.grbChoosePlayer.TabIndex = 111;
            this.grbChoosePlayer.Text = "Choose Player";
            this.grbChoosePlayer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.LightGray;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(125, 57);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(79, 40);
            this.guna2HtmlLabel7.TabIndex = 92;
            this.guna2HtmlLabel7.Text = "Name";
            this.guna2HtmlLabel7.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel6
            // 
            this.guna2HtmlLabel6.BackColor = System.Drawing.Color.LightGray;
            this.guna2HtmlLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.guna2HtmlLabel6.Location = new System.Drawing.Point(14, 57);
            this.guna2HtmlLabel6.Name = "guna2HtmlLabel6";
            this.guna2HtmlLabel6.Size = new System.Drawing.Size(31, 40);
            this.guna2HtmlLabel6.TabIndex = 91;
            this.guna2HtmlLabel6.Text = "ID";
            this.guna2HtmlLabel6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.LightGray;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(184, 307);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(119, 40);
            this.guna2HtmlLabel4.TabIndex = 90;
            this.guna2HtmlLabel4.Text = "Red Card";
            this.guna2HtmlLabel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.LightGray;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(14, 307);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(153, 40);
            this.guna2HtmlLabel3.TabIndex = 89;
            this.guna2HtmlLabel3.Text = "Yellow Card";
            this.guna2HtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.LightGray;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(184, 211);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(128, 40);
            this.guna2HtmlLabel2.TabIndex = 88;
            this.guna2HtmlLabel2.Text = "Own Goal";
            this.guna2HtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.LightGray;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(14, 211);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(62, 40);
            this.guna2HtmlLabel1.TabIndex = 87;
            this.guna2HtmlLabel1.Text = "Goal";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtYC
            // 
            this.txtYC.BorderThickness = 3;
            this.txtYC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtYC.DefaultText = "";
            this.txtYC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtYC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtYC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtYC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtYC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtYC.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtYC.ForeColor = System.Drawing.Color.Black;
            this.txtYC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtYC.Location = new System.Drawing.Point(14, 344);
            this.txtYC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtYC.Name = "txtYC";
            this.txtYC.PasswordChar = '\0';
            this.txtYC.PlaceholderText = "";
            this.txtYC.SelectedText = "";
            this.txtYC.Size = new System.Drawing.Size(150, 42);
            this.txtYC.TabIndex = 84;
            // 
            // txtPlayerID
            // 
            this.txtPlayerID.BorderThickness = 3;
            this.txtPlayerID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPlayerID.DefaultText = "";
            this.txtPlayerID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPlayerID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPlayerID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPlayerID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPlayerID.Enabled = false;
            this.txtPlayerID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPlayerID.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPlayerID.ForeColor = System.Drawing.Color.Black;
            this.txtPlayerID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPlayerID.Location = new System.Drawing.Point(14, 95);
            this.txtPlayerID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPlayerID.Name = "txtPlayerID";
            this.txtPlayerID.PasswordChar = '\0';
            this.txtPlayerID.PlaceholderText = "";
            this.txtPlayerID.SelectedText = "";
            this.txtPlayerID.Size = new System.Drawing.Size(105, 42);
            this.txtPlayerID.TabIndex = 86;
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.BorderThickness = 3;
            this.txtPlayerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPlayerName.DefaultText = "";
            this.txtPlayerName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPlayerName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPlayerName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPlayerName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPlayerName.Enabled = false;
            this.txtPlayerName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPlayerName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtPlayerName.ForeColor = System.Drawing.Color.Black;
            this.txtPlayerName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPlayerName.Location = new System.Drawing.Point(125, 95);
            this.txtPlayerName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.PasswordChar = '\0';
            this.txtPlayerName.PlaceholderText = "";
            this.txtPlayerName.SelectedText = "";
            this.txtPlayerName.Size = new System.Drawing.Size(209, 42);
            this.txtPlayerName.TabIndex = 85;
            // 
            // txtOG
            // 
            this.txtOG.BorderThickness = 3;
            this.txtOG.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOG.DefaultText = "";
            this.txtOG.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtOG.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtOG.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOG.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtOG.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOG.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtOG.ForeColor = System.Drawing.Color.Black;
            this.txtOG.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtOG.Location = new System.Drawing.Point(184, 247);
            this.txtOG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOG.Name = "txtOG";
            this.txtOG.PasswordChar = '\0';
            this.txtOG.PlaceholderText = "";
            this.txtOG.SelectedText = "";
            this.txtOG.Size = new System.Drawing.Size(150, 42);
            this.txtOG.TabIndex = 83;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.LightGray;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(14, 160);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(105, 40);
            this.guna2HtmlLabel5.TabIndex = 82;
            this.guna2HtmlLabel5.Text = "Position";
            this.guna2HtmlLabel5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboPosition
            // 
            this.cboPosition.BackColor = System.Drawing.Color.Transparent;
            this.cboPosition.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.cboPosition.BorderRadius = 5;
            this.cboPosition.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboPosition.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboPosition.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboPosition.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cboPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.cboPosition.ItemHeight = 30;
            this.cboPosition.Items.AddRange(new object[] {
            "Goalkeeper",
            "Defender",
            "Midfielder",
            "Forward",
            "Substitute"});
            this.cboPosition.Location = new System.Drawing.Point(125, 160);
            this.cboPosition.Name = "cboPosition";
            this.cboPosition.Size = new System.Drawing.Size(209, 36);
            this.cboPosition.TabIndex = 48;
            // 
            // txtRC
            // 
            this.txtRC.BorderThickness = 3;
            this.txtRC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRC.DefaultText = "";
            this.txtRC.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRC.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRC.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRC.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRC.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRC.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtRC.ForeColor = System.Drawing.Color.Black;
            this.txtRC.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRC.Location = new System.Drawing.Point(184, 344);
            this.txtRC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRC.Name = "txtRC";
            this.txtRC.PasswordChar = '\0';
            this.txtRC.PlaceholderText = "";
            this.txtRC.SelectedText = "";
            this.txtRC.Size = new System.Drawing.Size(150, 42);
            this.txtRC.TabIndex = 79;
            // 
            // txtGoal
            // 
            this.txtGoal.BorderThickness = 3;
            this.txtGoal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGoal.DefaultText = "";
            this.txtGoal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGoal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGoal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGoal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGoal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGoal.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtGoal.ForeColor = System.Drawing.Color.Black;
            this.txtGoal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGoal.Location = new System.Drawing.Point(14, 247);
            this.txtGoal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGoal.Name = "txtGoal";
            this.txtGoal.PasswordChar = '\0';
            this.txtGoal.PlaceholderText = "";
            this.txtGoal.SelectedText = "";
            this.txtGoal.Size = new System.Drawing.Size(150, 42);
            this.txtGoal.TabIndex = 78;
            // 
            // dgvPlayersInClub
            // 
            this.dgvPlayersInClub.AllowUserToResizeColumns = false;
            this.dgvPlayersInClub.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgvPlayersInClub.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPlayersInClub.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlayersInClub.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPlayersInClub.ColumnHeadersHeight = 50;
            this.dgvPlayersInClub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPlayersInClub.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlayerIDInClub,
            this.PlayerNameInClub,
            this.dataGridViewTextBoxColumn3,
            this.Foot});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPlayersInClub.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPlayersInClub.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPlayersInClub.Location = new System.Drawing.Point(1094, 150);
            this.dgvPlayersInClub.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgvPlayersInClub.Name = "dgvPlayersInClub";
            this.dgvPlayersInClub.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlayersInClub.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPlayersInClub.RowHeadersVisible = false;
            this.dgvPlayersInClub.RowHeadersWidth = 50;
            this.dgvPlayersInClub.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvPlayersInClub.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPlayersInClub.RowTemplate.Height = 40;
            this.dgvPlayersInClub.Size = new System.Drawing.Size(484, 579);
            this.dgvPlayersInClub.TabIndex = 112;
            this.dgvPlayersInClub.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPlayersInClub.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPlayersInClub.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPlayersInClub.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPlayersInClub.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPlayersInClub.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvPlayersInClub.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPlayersInClub.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvPlayersInClub.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPlayersInClub.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPlayersInClub.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPlayersInClub.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPlayersInClub.ThemeStyle.HeaderStyle.Height = 50;
            this.dgvPlayersInClub.ThemeStyle.ReadOnly = true;
            this.dgvPlayersInClub.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPlayersInClub.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPlayersInClub.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPlayersInClub.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPlayersInClub.ThemeStyle.RowsStyle.Height = 40;
            this.dgvPlayersInClub.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPlayersInClub.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPlayersInClub.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlayerInClub_CellClick);
            // 
            // PlayerIDInClub
            // 
            this.PlayerIDInClub.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PlayerIDInClub.DataPropertyName = "PlayerID";
            this.PlayerIDInClub.FillWeight = 116.2929F;
            this.PlayerIDInClub.HeaderText = "ID";
            this.PlayerIDInClub.MinimumWidth = 6;
            this.PlayerIDInClub.Name = "PlayerIDInClub";
            this.PlayerIDInClub.ReadOnly = true;
            this.PlayerIDInClub.Width = 65;
            // 
            // PlayerNameInClub
            // 
            this.PlayerNameInClub.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PlayerNameInClub.DataPropertyName = "PlayerName";
            this.PlayerNameInClub.HeaderText = "Player Name";
            this.PlayerNameInClub.MinimumWidth = 6;
            this.PlayerNameInClub.Name = "PlayerNameInClub";
            this.PlayerNameInClub.ReadOnly = true;
            this.PlayerNameInClub.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Position";
            this.dataGridViewTextBoxColumn3.FillWeight = 799.4648F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Position";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 130;
            // 
            // Foot
            // 
            this.Foot.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Foot.DataPropertyName = "Foot";
            this.Foot.FillWeight = 15.5486F;
            this.Foot.HeaderText = "Foot";
            this.Foot.MinimumWidth = 6;
            this.Foot.Name = "Foot";
            this.Foot.ReadOnly = true;
            this.Foot.Width = 125;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.IconChar = FontAwesome.Sharp.IconChar.ArrowsRotate;
            this.btnRefresh.IconColor = System.Drawing.Color.White;
            this.btnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRefresh.IconSize = 25;
            this.btnRefresh.Location = new System.Drawing.Point(684, 656);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnRefresh.Size = new System.Drawing.Size(132, 41);
            this.btnRefresh.TabIndex = 114;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDel.Enabled = false;
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.Color.Black;
            this.btnDel.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnDel.IconColor = System.Drawing.Color.Black;
            this.btnDel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDel.IconSize = 25;
            this.btnDel.Location = new System.Drawing.Point(903, 656);
            this.btnDel.Margin = new System.Windows.Forms.Padding(5);
            this.btnDel.Name = "btnDel";
            this.btnDel.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDel.Size = new System.Drawing.Size(133, 42);
            this.btnDel.TabIndex = 113;
            this.btnDel.Text = "Delete";
            this.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAdd.Enabled = false;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnAdd.IconColor = System.Drawing.Color.Black;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.IconSize = 25;
            this.btnAdd.Location = new System.Drawing.Point(684, 594);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAdd.Size = new System.Drawing.Size(133, 42);
            this.btnAdd.TabIndex = 108;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnEdit.Enabled = false;
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.IconChar = FontAwesome.Sharp.IconChar.RotateBackward;
            this.btnEdit.IconColor = System.Drawing.Color.Black;
            this.btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEdit.IconSize = 25;
            this.btnEdit.Location = new System.Drawing.Point(903, 594);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnEdit.Size = new System.Drawing.Size(133, 42);
            this.btnEdit.TabIndex = 110;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.White;
            this.btnBack.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft;
            this.btnBack.IconColor = System.Drawing.Color.White;
            this.btnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBack.IconSize = 25;
            this.btnBack.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBack.Location = new System.Drawing.Point(14, 14);
            this.btnBack.Margin = new System.Windows.Forms.Padding(5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnBack.Size = new System.Drawing.Size(52, 42);
            this.btnBack.TabIndex = 1;
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // msgConfirm
            // 
            this.msgConfirm.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
            this.msgConfirm.Caption = null;
            this.msgConfirm.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
            this.msgConfirm.Parent = null;
            this.msgConfirm.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.msgConfirm.Text = null;
            // 
            // msgNotify
            // 
            this.msgNotify.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.msgNotify.Caption = null;
            this.msgNotify.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            this.msgNotify.Parent = null;
            this.msgNotify.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.msgNotify.Text = null;
            // 
            // FormPlayersInMatch
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1650, 856);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.dgvPlayersInClub);
            this.Controls.Add(this.grbChoosePlayer);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.dgvPlayersInMatch);
            this.Controls.Add(this.lblMatchName);
            this.Controls.Add(this.lblClubName);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPlayersInMatch";
            this.Text = "FormPlayersInMatch";
            this.Load += new System.EventHandler(this.FormPlayersInMatch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayersInMatch)).EndInit();
            this.grbChoosePlayer.ResumeLayout(false);
            this.grbChoosePlayer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayersInClub)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnBack;
        private System.Windows.Forms.Label lblClubName;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPlayersInMatch;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnEdit;
        private System.Windows.Forms.Label lblMatchName;
        private Guna.UI2.WinForms.Guna2GroupBox grbChoosePlayer;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2ComboBox cboPosition;
        private Guna.UI2.WinForms.Guna2TextBox txtRC;
        private Guna.UI2.WinForms.Guna2TextBox txtGoal;
        private Guna.UI2.WinForms.Guna2TextBox txtYC;
        private Guna.UI2.WinForms.Guna2TextBox txtOG;
        private Guna.UI2.WinForms.Guna2TextBox txtPlayerName;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPlayersInClub;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private FontAwesome.Sharp.IconButton btnDel;
        private Guna.UI2.WinForms.Guna2TextBox txtPlayerID;
        private Guna.UI2.WinForms.Guna2MessageDialog msgConfirm;
        private Guna.UI2.WinForms.Guna2MessageDialog msgNotify;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn Goal;
        private System.Windows.Forms.DataGridViewTextBoxColumn YellowCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn RedCard;
        private System.Windows.Forms.DataGridViewTextBoxColumn OwnGoal;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerIDInClub;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerNameInClub;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Foot;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel6;
    }
}