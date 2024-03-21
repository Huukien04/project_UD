namespace ProjectLTUD
{
    partial class FormMatches
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
            this.msgNotify = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.msgConfirm = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.dgvMatch = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MatchID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RoundID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatchName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatchTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboFindMW = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnEditMatch = new FontAwesome.Sharp.IconButton();
            this.btnDelMatch = new FontAwesome.Sharp.IconButton();
            this.btnAddMatch = new FontAwesome.Sharp.IconButton();
            this.btnRefresh = new FontAwesome.Sharp.IconButton();
            this.btnPlayersHomeInMatch = new FontAwesome.Sharp.IconButton();
            this.grbMatchInfo = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lblAway = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblHome = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cboAway = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dtpMatchTime = new System.Windows.Forms.DateTimePicker();
            this.cboHome = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboMW = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtMatchName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMatchID = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblMW = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.btnMatchDetail = new FontAwesome.Sharp.IconButton();
            this.btnPlayersAwayInMatch = new FontAwesome.Sharp.IconButton();
            this.pnlDesktop = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.lblFindMW = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatch)).BeginInit();
            this.grbMatchInfo.SuspendLayout();
            this.pnlDesktop.SuspendLayout();
            this.SuspendLayout();
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
            // msgConfirm
            // 
            this.msgConfirm.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNo;
            this.msgConfirm.Caption = null;
            this.msgConfirm.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
            this.msgConfirm.Parent = null;
            this.msgConfirm.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.msgConfirm.Text = null;
            // 
            // dgvMatch
            // 
            this.dgvMatch.AllowUserToResizeColumns = false;
            this.dgvMatch.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvMatch.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMatch.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMatch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMatch.ColumnHeadersHeight = 50;
            this.dgvMatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvMatch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MatchID,
            this.RoundID,
            this.MatchName,
            this.MatchTime});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMatch.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMatch.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMatch.Location = new System.Drawing.Point(12, 137);
            this.dgvMatch.Name = "dgvMatch";
            this.dgvMatch.ReadOnly = true;
            this.dgvMatch.RowHeadersVisible = false;
            this.dgvMatch.RowHeadersWidth = 51;
            this.dgvMatch.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvMatch.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMatch.RowTemplate.Height = 45;
            this.dgvMatch.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvMatch.Size = new System.Drawing.Size(705, 694);
            this.dgvMatch.TabIndex = 102;
            this.dgvMatch.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMatch.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMatch.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvMatch.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvMatch.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvMatch.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvMatch.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMatch.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvMatch.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMatch.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMatch.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMatch.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvMatch.ThemeStyle.HeaderStyle.Height = 50;
            this.dgvMatch.ThemeStyle.ReadOnly = true;
            this.dgvMatch.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMatch.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMatch.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMatch.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMatch.ThemeStyle.RowsStyle.Height = 45;
            this.dgvMatch.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMatch.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMatch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatch_CellClick);
            // 
            // MatchID
            // 
            this.MatchID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MatchID.DataPropertyName = "MatchID";
            this.MatchID.FillWeight = 116.2929F;
            this.MatchID.Frozen = true;
            this.MatchID.HeaderText = "Match ID";
            this.MatchID.MinimumWidth = 6;
            this.MatchID.Name = "MatchID";
            this.MatchID.ReadOnly = true;
            this.MatchID.Width = 190;
            // 
            // RoundID
            // 
            this.RoundID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.RoundID.DataPropertyName = "RoundID";
            this.RoundID.FillWeight = 799.4648F;
            this.RoundID.Frozen = true;
            this.RoundID.HeaderText = "Round ID";
            this.RoundID.MinimumWidth = 6;
            this.RoundID.Name = "RoundID";
            this.RoundID.ReadOnly = true;
            this.RoundID.Width = 110;
            // 
            // MatchName
            // 
            this.MatchName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MatchName.DataPropertyName = "MatchName";
            this.MatchName.FillWeight = 15.5486F;
            this.MatchName.Frozen = true;
            this.MatchName.HeaderText = "Match Name";
            this.MatchName.MinimumWidth = 6;
            this.MatchName.Name = "MatchName";
            this.MatchName.ReadOnly = true;
            this.MatchName.Width = 200;
            // 
            // MatchTime
            // 
            this.MatchTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MatchTime.DataPropertyName = "MatchTime";
            this.MatchTime.FillWeight = 16.56745F;
            this.MatchTime.Frozen = true;
            this.MatchTime.HeaderText = "Match Time";
            this.MatchTime.MinimumWidth = 6;
            this.MatchTime.Name = "MatchTime";
            this.MatchTime.ReadOnly = true;
            this.MatchTime.Width = 170;
            // 
            // cboFindMW
            // 
            this.cboFindMW.BackColor = System.Drawing.Color.Transparent;
            this.cboFindMW.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.cboFindMW.BorderRadius = 5;
            this.cboFindMW.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboFindMW.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFindMW.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboFindMW.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboFindMW.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cboFindMW.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.cboFindMW.ItemHeight = 30;
            this.cboFindMW.Items.AddRange(new object[] {
            "All",
            "Matchweek 1",
            "Matchweek 2",
            "Matchweek 3",
            "Matchweek 4",
            "Matchweek 5",
            "Matchweek 6",
            "Matchweek 7",
            "Matchweek 8",
            "Matchweek 9",
            "Matchweek 10",
            "Matchweek 11",
            "Matchweek 12",
            "Matchweek 12",
            "Matchweek 13",
            "Matchweek 14",
            "Matchweek 15",
            "Matchweek 16",
            "Matchweek 17",
            "Matchweek 18",
            "Matchweek 19",
            "Matchweek 20"});
            this.cboFindMW.Location = new System.Drawing.Point(201, 16);
            this.cboFindMW.Name = "cboFindMW";
            this.cboFindMW.Size = new System.Drawing.Size(190, 36);
            this.cboFindMW.StartIndex = 0;
            this.cboFindMW.TabIndex = 104;
            this.cboFindMW.SelectedIndexChanged += new System.EventHandler(this.cboFindMW_SelectedIndexChanged);
            // 
            // btnEditMatch
            // 
            this.btnEditMatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.btnEditMatch.FlatAppearance.BorderSize = 0;
            this.btnEditMatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditMatch.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditMatch.ForeColor = System.Drawing.Color.White;
            this.btnEditMatch.IconChar = FontAwesome.Sharp.IconChar.RotateBackward;
            this.btnEditMatch.IconColor = System.Drawing.Color.White;
            this.btnEditMatch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditMatch.IconSize = 25;
            this.btnEditMatch.Location = new System.Drawing.Point(1073, 446);
            this.btnEditMatch.Margin = new System.Windows.Forms.Padding(5);
            this.btnEditMatch.Name = "btnEditMatch";
            this.btnEditMatch.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnEditMatch.Size = new System.Drawing.Size(133, 42);
            this.btnEditMatch.TabIndex = 107;
            this.btnEditMatch.Text = "Edit";
            this.btnEditMatch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditMatch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditMatch.UseVisualStyleBackColor = false;
            this.btnEditMatch.Click += new System.EventHandler(this.btnEditMatch_Click);
            // 
            // btnDelMatch
            // 
            this.btnDelMatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.btnDelMatch.FlatAppearance.BorderSize = 0;
            this.btnDelMatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelMatch.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelMatch.ForeColor = System.Drawing.Color.White;
            this.btnDelMatch.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnDelMatch.IconColor = System.Drawing.Color.White;
            this.btnDelMatch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelMatch.IconSize = 25;
            this.btnDelMatch.Location = new System.Drawing.Point(1073, 514);
            this.btnDelMatch.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelMatch.Name = "btnDelMatch";
            this.btnDelMatch.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDelMatch.Size = new System.Drawing.Size(133, 42);
            this.btnDelMatch.TabIndex = 106;
            this.btnDelMatch.Text = "Delete";
            this.btnDelMatch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelMatch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelMatch.UseVisualStyleBackColor = false;
            this.btnDelMatch.Click += new System.EventHandler(this.btnDelMatch_Click);
            // 
            // btnAddMatch
            // 
            this.btnAddMatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.btnAddMatch.FlatAppearance.BorderSize = 0;
            this.btnAddMatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddMatch.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMatch.ForeColor = System.Drawing.Color.White;
            this.btnAddMatch.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnAddMatch.IconColor = System.Drawing.Color.White;
            this.btnAddMatch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddMatch.IconSize = 25;
            this.btnAddMatch.Location = new System.Drawing.Point(863, 446);
            this.btnAddMatch.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddMatch.Name = "btnAddMatch";
            this.btnAddMatch.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAddMatch.Size = new System.Drawing.Size(133, 42);
            this.btnAddMatch.TabIndex = 105;
            this.btnAddMatch.Text = "Add";
            this.btnAddMatch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddMatch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddMatch.UseVisualStyleBackColor = false;
            this.btnAddMatch.Click += new System.EventHandler(this.btnAddMatch_Click);
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
            this.btnRefresh.Location = new System.Drawing.Point(863, 514);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnRefresh.Size = new System.Drawing.Size(133, 42);
            this.btnRefresh.TabIndex = 108;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnPlayersHomeInMatch
            // 
            this.btnPlayersHomeInMatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.btnPlayersHomeInMatch.FlatAppearance.BorderSize = 0;
            this.btnPlayersHomeInMatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayersHomeInMatch.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayersHomeInMatch.ForeColor = System.Drawing.Color.White;
            this.btnPlayersHomeInMatch.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnPlayersHomeInMatch.IconColor = System.Drawing.Color.White;
            this.btnPlayersHomeInMatch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPlayersHomeInMatch.IconSize = 25;
            this.btnPlayersHomeInMatch.Location = new System.Drawing.Point(1281, 447);
            this.btnPlayersHomeInMatch.Margin = new System.Windows.Forms.Padding(5);
            this.btnPlayersHomeInMatch.Name = "btnPlayersHomeInMatch";
            this.btnPlayersHomeInMatch.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnPlayersHomeInMatch.Size = new System.Drawing.Size(282, 42);
            this.btnPlayersHomeInMatch.TabIndex = 109;
            this.btnPlayersHomeInMatch.Text = "Players in Match (Home)";
            this.btnPlayersHomeInMatch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlayersHomeInMatch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPlayersHomeInMatch.UseVisualStyleBackColor = false;
            this.btnPlayersHomeInMatch.Click += new System.EventHandler(this.btnPlayersHomeInMatch_Click);
            // 
            // grbMatchInfo
            // 
            this.grbMatchInfo.BackColor = System.Drawing.Color.LightGray;
            this.grbMatchInfo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.grbMatchInfo.BorderRadius = 10;
            this.grbMatchInfo.Controls.Add(this.lblAway);
            this.grbMatchInfo.Controls.Add(this.lblHome);
            this.grbMatchInfo.Controls.Add(this.cboAway);
            this.grbMatchInfo.Controls.Add(this.dtpMatchTime);
            this.grbMatchInfo.Controls.Add(this.cboHome);
            this.grbMatchInfo.Controls.Add(this.cboMW);
            this.grbMatchInfo.Controls.Add(this.txtMatchName);
            this.grbMatchInfo.Controls.Add(this.txtMatchID);
            this.grbMatchInfo.Controls.Add(this.lblMW);
            this.grbMatchInfo.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.grbMatchInfo.FillColor = System.Drawing.Color.Transparent;
            this.grbMatchInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbMatchInfo.ForeColor = System.Drawing.Color.White;
            this.grbMatchInfo.Location = new System.Drawing.Point(863, 137);
            this.grbMatchInfo.Name = "grbMatchInfo";
            this.grbMatchInfo.Size = new System.Drawing.Size(701, 281);
            this.grbMatchInfo.TabIndex = 110;
            this.grbMatchInfo.Text = "Match Info";
            this.grbMatchInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAway
            // 
            this.lblAway.BackColor = System.Drawing.Color.LightGray;
            this.lblAway.Font = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAway.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.lblAway.Location = new System.Drawing.Point(14, 207);
            this.lblAway.Name = "lblAway";
            this.lblAway.Size = new System.Drawing.Size(150, 40);
            this.lblAway.TabIndex = 103;
            this.lblAway.Text = "Away Team";
            this.lblAway.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHome
            // 
            this.lblHome.BackColor = System.Drawing.Color.LightGray;
            this.lblHome.Font = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.lblHome.Location = new System.Drawing.Point(14, 133);
            this.lblHome.Name = "lblHome";
            this.lblHome.Size = new System.Drawing.Size(159, 40);
            this.lblHome.TabIndex = 82;
            this.lblHome.Text = "Home Team";
            this.lblHome.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboAway
            // 
            this.cboAway.BackColor = System.Drawing.Color.Transparent;
            this.cboAway.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.cboAway.BorderRadius = 5;
            this.cboAway.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboAway.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAway.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboAway.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboAway.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cboAway.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.cboAway.ItemHeight = 30;
            this.cboAway.Items.AddRange(new object[] {
            "Arsenal",
            "Aston Villa",
            "Bournemouth",
            "Brentford",
            "Brighton",
            "Burnley FC",
            "Chelsea",
            "Crystal Palace",
            "Everton",
            "Fulham",
            "Liverpool",
            "Luton Town FC",
            "Manchester City",
            "Manchester United",
            "Newcastle",
            "Nottingham Forest",
            "Sheffield United",
            "Tottenham",
            "West Ham United",
            "Wolverhampton"});
            this.cboAway.Location = new System.Drawing.Point(180, 207);
            this.cboAway.Name = "cboAway";
            this.cboAway.Size = new System.Drawing.Size(233, 36);
            this.cboAway.TabIndex = 48;
            this.cboAway.SelectedIndexChanged += new System.EventHandler(this.cboAway_SelectedIndexChanged);
            // 
            // dtpMatchTime
            // 
            this.dtpMatchTime.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpMatchTime.Location = new System.Drawing.Point(441, 207);
            this.dtpMatchTime.MaxDate = new System.DateTime(2024, 12, 31, 0, 0, 0, 0);
            this.dtpMatchTime.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.dtpMatchTime.Name = "dtpMatchTime";
            this.dtpMatchTime.Size = new System.Drawing.Size(244, 38);
            this.dtpMatchTime.TabIndex = 81;
            // 
            // cboHome
            // 
            this.cboHome.BackColor = System.Drawing.Color.Transparent;
            this.cboHome.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.cboHome.BorderRadius = 5;
            this.cboHome.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboHome.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHome.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboHome.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboHome.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cboHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.cboHome.ItemHeight = 30;
            this.cboHome.Items.AddRange(new object[] {
            "Arsenal",
            "Aston Villa",
            "Bournemouth",
            "Brentford",
            "Brighton",
            "Burnley FC",
            "Chelsea",
            "Crystal Palace",
            "Everton",
            "Fulham",
            "Liverpool",
            "Luton Town FC",
            "Manchester City",
            "Manchester United",
            "Newcastle",
            "Nottingham Forest",
            "Sheffield United",
            "Tottenham",
            "West Ham United",
            "Wolverhampton"});
            this.cboHome.Location = new System.Drawing.Point(180, 133);
            this.cboHome.Name = "cboHome";
            this.cboHome.Size = new System.Drawing.Size(233, 36);
            this.cboHome.TabIndex = 48;
            this.cboHome.SelectedIndexChanged += new System.EventHandler(this.cboHome_SelectedIndexChanged);
            // 
            // cboMW
            // 
            this.cboMW.BackColor = System.Drawing.Color.Transparent;
            this.cboMW.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.cboMW.BorderRadius = 5;
            this.cboMW.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMW.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMW.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboMW.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboMW.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cboMW.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.cboMW.ItemHeight = 30;
            this.cboMW.Items.AddRange(new object[] {
            "Matchweek 1",
            "Matchweek 2",
            "Matchweek 3",
            "Matchweek 4",
            "Matchweek 5",
            "Matchweek 6",
            "Matchweek 7",
            "Matchweek 8",
            "Matchweek 9",
            "Matchweek 10",
            "Matchweek 11",
            "Matchweek 12",
            "Matchweek 12",
            "Matchweek 13",
            "Matchweek 14",
            "Matchweek 15",
            "Matchweek 16",
            "Matchweek 17",
            "Matchweek 18",
            "Matchweek 19",
            "Matchweek 20"});
            this.cboMW.Location = new System.Drawing.Point(180, 54);
            this.cboMW.Name = "cboMW";
            this.cboMW.Size = new System.Drawing.Size(233, 36);
            this.cboMW.TabIndex = 76;
            this.cboMW.SelectedIndexChanged += new System.EventHandler(this.cboMW_SelectedIndexChanged);
            // 
            // txtMatchName
            // 
            this.txtMatchName.BorderThickness = 3;
            this.txtMatchName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatchName.DefaultText = "";
            this.txtMatchName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMatchName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMatchName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatchName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatchName.Enabled = false;
            this.txtMatchName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatchName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtMatchName.ForeColor = System.Drawing.Color.Black;
            this.txtMatchName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatchName.Location = new System.Drawing.Point(441, 133);
            this.txtMatchName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMatchName.Name = "txtMatchName";
            this.txtMatchName.PasswordChar = '\0';
            this.txtMatchName.PlaceholderText = "MATCH NAME";
            this.txtMatchName.SelectedText = "";
            this.txtMatchName.Size = new System.Drawing.Size(244, 42);
            this.txtMatchName.TabIndex = 79;
            // 
            // txtMatchID
            // 
            this.txtMatchID.BorderThickness = 3;
            this.txtMatchID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatchID.DefaultText = "";
            this.txtMatchID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMatchID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMatchID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatchID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatchID.Enabled = false;
            this.txtMatchID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatchID.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtMatchID.ForeColor = System.Drawing.Color.Black;
            this.txtMatchID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatchID.Location = new System.Drawing.Point(441, 54);
            this.txtMatchID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMatchID.Name = "txtMatchID";
            this.txtMatchID.PasswordChar = '\0';
            this.txtMatchID.PlaceholderText = "MATCH ID";
            this.txtMatchID.SelectedText = "";
            this.txtMatchID.Size = new System.Drawing.Size(244, 42);
            this.txtMatchID.TabIndex = 78;
            // 
            // lblMW
            // 
            this.lblMW.BackColor = System.Drawing.Color.LightGray;
            this.lblMW.Font = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMW.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.lblMW.Location = new System.Drawing.Point(14, 54);
            this.lblMW.Name = "lblMW";
            this.lblMW.Size = new System.Drawing.Size(149, 40);
            this.lblMW.TabIndex = 77;
            this.lblMW.Text = "Matchweek";
            this.lblMW.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnMatchDetail
            // 
            this.btnMatchDetail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.btnMatchDetail.FlatAppearance.BorderSize = 0;
            this.btnMatchDetail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMatchDetail.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMatchDetail.ForeColor = System.Drawing.Color.White;
            this.btnMatchDetail.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            this.btnMatchDetail.IconColor = System.Drawing.Color.White;
            this.btnMatchDetail.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMatchDetail.IconSize = 25;
            this.btnMatchDetail.Location = new System.Drawing.Point(1281, 582);
            this.btnMatchDetail.Margin = new System.Windows.Forms.Padding(5);
            this.btnMatchDetail.Name = "btnMatchDetail";
            this.btnMatchDetail.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnMatchDetail.Size = new System.Drawing.Size(280, 42);
            this.btnMatchDetail.TabIndex = 111;
            this.btnMatchDetail.Text = "Match Detail";
            this.btnMatchDetail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMatchDetail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMatchDetail.UseVisualStyleBackColor = false;
            this.btnMatchDetail.Click += new System.EventHandler(this.btnMatchDetail_Click);
            // 
            // btnPlayersAwayInMatch
            // 
            this.btnPlayersAwayInMatch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.btnPlayersAwayInMatch.FlatAppearance.BorderSize = 0;
            this.btnPlayersAwayInMatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayersAwayInMatch.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlayersAwayInMatch.ForeColor = System.Drawing.Color.White;
            this.btnPlayersAwayInMatch.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnPlayersAwayInMatch.IconColor = System.Drawing.Color.White;
            this.btnPlayersAwayInMatch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPlayersAwayInMatch.IconSize = 25;
            this.btnPlayersAwayInMatch.Location = new System.Drawing.Point(1281, 513);
            this.btnPlayersAwayInMatch.Margin = new System.Windows.Forms.Padding(5);
            this.btnPlayersAwayInMatch.Name = "btnPlayersAwayInMatch";
            this.btnPlayersAwayInMatch.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnPlayersAwayInMatch.Size = new System.Drawing.Size(282, 42);
            this.btnPlayersAwayInMatch.TabIndex = 112;
            this.btnPlayersAwayInMatch.Text = "Players in Match (Away)";
            this.btnPlayersAwayInMatch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPlayersAwayInMatch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPlayersAwayInMatch.UseVisualStyleBackColor = false;
            this.btnPlayersAwayInMatch.Click += new System.EventHandler(this.btnPlayersAwayInMatch_Click);
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.Controls.Add(this.iconButton1);
            this.pnlDesktop.Controls.Add(this.btnPlayersAwayInMatch);
            this.pnlDesktop.Controls.Add(this.cboFindMW);
            this.pnlDesktop.Controls.Add(this.lblFindMW);
            this.pnlDesktop.Controls.Add(this.btnMatchDetail);
            this.pnlDesktop.Controls.Add(this.grbMatchInfo);
            this.pnlDesktop.Controls.Add(this.btnPlayersHomeInMatch);
            this.pnlDesktop.Controls.Add(this.btnRefresh);
            this.pnlDesktop.Controls.Add(this.btnAddMatch);
            this.pnlDesktop.Controls.Add(this.btnDelMatch);
            this.pnlDesktop.Controls.Add(this.btnEditMatch);
            this.pnlDesktop.Controls.Add(this.dgvMatch);
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktop.Location = new System.Drawing.Point(0, 0);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(1674, 873);
            this.pnlDesktop.TabIndex = 0;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.Location = new System.Drawing.Point(768, 50);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(5);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton1.Size = new System.Drawing.Size(133, 42);
            this.iconButton1.TabIndex = 113;
            this.iconButton1.Text = "Add";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click_1);
            // 
            // lblFindMW
            // 
            this.lblFindMW.BackColor = System.Drawing.Color.Transparent;
            this.lblFindMW.Font = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFindMW.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.lblFindMW.Location = new System.Drawing.Point(12, 16);
            this.lblFindMW.Name = "lblFindMW";
            this.lblFindMW.Size = new System.Drawing.Size(149, 40);
            this.lblFindMW.TabIndex = 103;
            this.lblFindMW.Text = "Matchweek";
            this.lblFindMW.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormMatches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1674, 873);
            this.Controls.Add(this.pnlDesktop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMatches";
            this.Text = "Matches";
            this.Load += new System.EventHandler(this.FormMatches_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatch)).EndInit();
            this.grbMatchInfo.ResumeLayout(false);
            this.grbMatchInfo.PerformLayout();
            this.pnlDesktop.ResumeLayout(false);
            this.pnlDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2MessageDialog msgNotify;
        private Guna.UI2.WinForms.Guna2MessageDialog msgConfirm;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMatch;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatchID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RoundID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatchName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatchTime;
        private Guna.UI2.WinForms.Guna2ComboBox cboFindMW;
        private FontAwesome.Sharp.IconButton btnEditMatch;
        private FontAwesome.Sharp.IconButton btnDelMatch;
        private FontAwesome.Sharp.IconButton btnAddMatch;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private FontAwesome.Sharp.IconButton btnPlayersHomeInMatch;
        private Guna.UI2.WinForms.Guna2GroupBox grbMatchInfo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAway;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblHome;
        private Guna.UI2.WinForms.Guna2ComboBox cboAway;
        private System.Windows.Forms.DateTimePicker dtpMatchTime;
        private Guna.UI2.WinForms.Guna2ComboBox cboHome;
        private Guna.UI2.WinForms.Guna2ComboBox cboMW;
        private Guna.UI2.WinForms.Guna2TextBox txtMatchName;
        private Guna.UI2.WinForms.Guna2TextBox txtMatchID;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblMW;
        private FontAwesome.Sharp.IconButton btnMatchDetail;
        private FontAwesome.Sharp.IconButton btnPlayersAwayInMatch;
        private System.Windows.Forms.Panel pnlDesktop;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblFindMW;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}