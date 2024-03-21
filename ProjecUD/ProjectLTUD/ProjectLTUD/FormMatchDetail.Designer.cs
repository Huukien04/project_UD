namespace ProjectLTUD
{
    partial class FormMatchDetail
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
            this.btnBack = new FontAwesome.Sharp.IconButton();
            this.msgNotify = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.lblMatchName = new System.Windows.Forms.Label();
            this.msgConfirm = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.dgvMatchDetail = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HomeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AwayID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MotmID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HomeGoals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AwayGoals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HomeCapID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AwayCapID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HomeTactical = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AwayTactical = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Referee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbAwayTeam = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtAwayGoals = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAwayTactical = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAwayName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cboAwayCap = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnRefresh = new FontAwesome.Sharp.IconButton();
            this.btnAddMatch = new FontAwesome.Sharp.IconButton();
            this.btnDelMatch = new FontAwesome.Sharp.IconButton();
            this.btnEditMatch = new FontAwesome.Sharp.IconButton();
            this.grbHomeTeam = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtHomeName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel5 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cboHomeCap = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtHomeGoals = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtHomeTactical = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2TextBox2 = new Guna.UI2.WinForms.Guna2TextBox();
            this.grbMatchInfo = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2HtmlLabel7 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cboMOTM = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtReferee = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMatchID = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatchDetail)).BeginInit();
            this.grbAwayTeam.SuspendLayout();
            this.grbHomeTeam.SuspendLayout();
            this.grbMatchInfo.SuspendLayout();
            this.SuspendLayout();
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
            this.btnBack.TabIndex = 115;
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
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
            // lblMatchName
            // 
            this.lblMatchName.AutoSize = true;
            this.lblMatchName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatchName.Location = new System.Drawing.Point(103, 15);
            this.lblMatchName.Name = "lblMatchName";
            this.lblMatchName.Size = new System.Drawing.Size(198, 41);
            this.lblMatchName.TabIndex = 117;
            this.lblMatchName.Text = "Match Name";
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
            // dgvMatchDetail
            // 
            this.dgvMatchDetail.AllowUserToResizeColumns = false;
            this.dgvMatchDetail.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvMatchDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMatchDetail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMatchDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvMatchDetail.ColumnHeadersHeight = 60;
            this.dgvMatchDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvMatchDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.HomeID,
            this.AwayID,
            this.MotmID,
            this.HomeGoals,
            this.AwayGoals,
            this.HomeCapID,
            this.AwayCapID,
            this.HomeTactical,
            this.AwayTactical,
            this.Referee});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvMatchDetail.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvMatchDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvMatchDetail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMatchDetail.Location = new System.Drawing.Point(0, 497);
            this.dgvMatchDetail.Name = "dgvMatchDetail";
            this.dgvMatchDetail.ReadOnly = true;
            this.dgvMatchDetail.RowHeadersVisible = false;
            this.dgvMatchDetail.RowHeadersWidth = 51;
            this.dgvMatchDetail.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvMatchDetail.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMatchDetail.RowTemplate.Height = 45;
            this.dgvMatchDetail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvMatchDetail.Size = new System.Drawing.Size(1632, 312);
            this.dgvMatchDetail.TabIndex = 125;
            this.dgvMatchDetail.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMatchDetail.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvMatchDetail.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvMatchDetail.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvMatchDetail.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvMatchDetail.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvMatchDetail.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMatchDetail.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvMatchDetail.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvMatchDetail.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMatchDetail.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvMatchDetail.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvMatchDetail.ThemeStyle.HeaderStyle.Height = 60;
            this.dgvMatchDetail.ThemeStyle.ReadOnly = true;
            this.dgvMatchDetail.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvMatchDetail.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvMatchDetail.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvMatchDetail.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMatchDetail.ThemeStyle.RowsStyle.Height = 45;
            this.dgvMatchDetail.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvMatchDetail.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvMatchDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatchDetail_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "MatchID";
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Match ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 200;
            // 
            // HomeID
            // 
            this.HomeID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.HomeID.DataPropertyName = "HomeID";
            this.HomeID.FillWeight = 16.56745F;
            this.HomeID.HeaderText = "Home Team";
            this.HomeID.MinimumWidth = 6;
            this.HomeID.Name = "HomeID";
            this.HomeID.ReadOnly = true;
            this.HomeID.Width = 150;
            // 
            // AwayID
            // 
            this.AwayID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.AwayID.DataPropertyName = "AwayID";
            this.AwayID.FillWeight = 16.56745F;
            this.AwayID.HeaderText = "Away Team";
            this.AwayID.MinimumWidth = 6;
            this.AwayID.Name = "AwayID";
            this.AwayID.ReadOnly = true;
            this.AwayID.Width = 150;
            // 
            // MotmID
            // 
            this.MotmID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MotmID.DataPropertyName = "MotmID";
            this.MotmID.FillWeight = 16.56745F;
            this.MotmID.HeaderText = "MOTM";
            this.MotmID.MinimumWidth = 6;
            this.MotmID.Name = "MotmID";
            this.MotmID.ReadOnly = true;
            this.MotmID.Width = 130;
            // 
            // HomeGoals
            // 
            this.HomeGoals.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.HomeGoals.DataPropertyName = "HomeGoals";
            this.HomeGoals.FillWeight = 16.56745F;
            this.HomeGoals.HeaderText = "Home Goals";
            this.HomeGoals.MinimumWidth = 6;
            this.HomeGoals.Name = "HomeGoals";
            this.HomeGoals.ReadOnly = true;
            this.HomeGoals.Width = 145;
            // 
            // AwayGoals
            // 
            this.AwayGoals.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.AwayGoals.DataPropertyName = "AwayGoals";
            this.AwayGoals.FillWeight = 16.56745F;
            this.AwayGoals.HeaderText = "Away Goals";
            this.AwayGoals.MinimumWidth = 6;
            this.AwayGoals.Name = "AwayGoals";
            this.AwayGoals.ReadOnly = true;
            this.AwayGoals.Width = 145;
            // 
            // HomeCapID
            // 
            this.HomeCapID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.HomeCapID.DataPropertyName = "HomeCapID";
            this.HomeCapID.FillWeight = 16.56745F;
            this.HomeCapID.HeaderText = "Home Cap";
            this.HomeCapID.MinimumWidth = 6;
            this.HomeCapID.Name = "HomeCapID";
            this.HomeCapID.ReadOnly = true;
            this.HomeCapID.Width = 130;
            // 
            // AwayCapID
            // 
            this.AwayCapID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.AwayCapID.DataPropertyName = "AwayCapID";
            this.AwayCapID.HeaderText = "Away Cap";
            this.AwayCapID.MinimumWidth = 6;
            this.AwayCapID.Name = "AwayCapID";
            this.AwayCapID.ReadOnly = true;
            this.AwayCapID.Width = 130;
            // 
            // HomeTactical
            // 
            this.HomeTactical.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.HomeTactical.DataPropertyName = "HomeTactical";
            this.HomeTactical.HeaderText = "Home Tactical";
            this.HomeTactical.MinimumWidth = 6;
            this.HomeTactical.Name = "HomeTactical";
            this.HomeTactical.ReadOnly = true;
            this.HomeTactical.Width = 170;
            // 
            // AwayTactical
            // 
            this.AwayTactical.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.AwayTactical.DataPropertyName = "AwayTactical";
            this.AwayTactical.HeaderText = "Away Tactical";
            this.AwayTactical.MinimumWidth = 6;
            this.AwayTactical.Name = "AwayTactical";
            this.AwayTactical.ReadOnly = true;
            this.AwayTactical.Width = 170;
            // 
            // Referee
            // 
            this.Referee.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Referee.DataPropertyName = "Referee";
            this.Referee.FillWeight = 16.56745F;
            this.Referee.HeaderText = "Referee";
            this.Referee.MinimumWidth = 6;
            this.Referee.Name = "Referee";
            this.Referee.ReadOnly = true;
            this.Referee.Width = 150;
            // 
            // grbAwayTeam
            // 
            this.grbAwayTeam.BackColor = System.Drawing.Color.LightGray;
            this.grbAwayTeam.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.grbAwayTeam.BorderRadius = 10;
            this.grbAwayTeam.Controls.Add(this.txtAwayGoals);
            this.grbAwayTeam.Controls.Add(this.txtAwayTactical);
            this.grbAwayTeam.Controls.Add(this.txtAwayName);
            this.grbAwayTeam.Controls.Add(this.guna2HtmlLabel1);
            this.grbAwayTeam.Controls.Add(this.cboAwayCap);
            this.grbAwayTeam.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.grbAwayTeam.FillColor = System.Drawing.Color.Transparent;
            this.grbAwayTeam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAwayTeam.ForeColor = System.Drawing.Color.White;
            this.grbAwayTeam.Location = new System.Drawing.Point(880, 101);
            this.grbAwayTeam.Name = "grbAwayTeam";
            this.grbAwayTeam.Size = new System.Drawing.Size(364, 283);
            this.grbAwayTeam.TabIndex = 127;
            this.grbAwayTeam.Text = "Away Team";
            this.grbAwayTeam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAwayGoals
            // 
            this.txtAwayGoals.BorderThickness = 3;
            this.txtAwayGoals.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAwayGoals.DefaultText = "";
            this.txtAwayGoals.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAwayGoals.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAwayGoals.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAwayGoals.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAwayGoals.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAwayGoals.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtAwayGoals.ForeColor = System.Drawing.Color.Black;
            this.txtAwayGoals.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAwayGoals.Location = new System.Drawing.Point(195, 206);
            this.txtAwayGoals.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAwayGoals.Name = "txtAwayGoals";
            this.txtAwayGoals.PasswordChar = '\0';
            this.txtAwayGoals.PlaceholderText = "GOALS";
            this.txtAwayGoals.SelectedText = "";
            this.txtAwayGoals.Size = new System.Drawing.Size(147, 42);
            this.txtAwayGoals.TabIndex = 61;
            // 
            // txtAwayTactical
            // 
            this.txtAwayTactical.BorderThickness = 3;
            this.txtAwayTactical.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAwayTactical.DefaultText = "";
            this.txtAwayTactical.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAwayTactical.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAwayTactical.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAwayTactical.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAwayTactical.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAwayTactical.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtAwayTactical.ForeColor = System.Drawing.Color.Black;
            this.txtAwayTactical.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAwayTactical.Location = new System.Drawing.Point(23, 206);
            this.txtAwayTactical.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAwayTactical.Name = "txtAwayTactical";
            this.txtAwayTactical.PasswordChar = '\0';
            this.txtAwayTactical.PlaceholderText = "TACTICAL";
            this.txtAwayTactical.SelectedText = "";
            this.txtAwayTactical.Size = new System.Drawing.Size(147, 42);
            this.txtAwayTactical.TabIndex = 60;
            // 
            // txtAwayName
            // 
            this.txtAwayName.BorderThickness = 3;
            this.txtAwayName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAwayName.DefaultText = "";
            this.txtAwayName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAwayName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAwayName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAwayName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAwayName.Enabled = false;
            this.txtAwayName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAwayName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtAwayName.ForeColor = System.Drawing.Color.Black;
            this.txtAwayName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAwayName.Location = new System.Drawing.Point(23, 64);
            this.txtAwayName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAwayName.Name = "txtAwayName";
            this.txtAwayName.PasswordChar = '\0';
            this.txtAwayName.PlaceholderText = "CLUB NAME";
            this.txtAwayName.SelectedText = "";
            this.txtAwayName.Size = new System.Drawing.Size(319, 42);
            this.txtAwayName.TabIndex = 64;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.LightGray;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(23, 131);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(100, 40);
            this.guna2HtmlLabel1.TabIndex = 63;
            this.guna2HtmlLabel1.Text = "Captain";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboAwayCap
            // 
            this.cboAwayCap.BackColor = System.Drawing.Color.Transparent;
            this.cboAwayCap.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.cboAwayCap.BorderRadius = 5;
            this.cboAwayCap.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboAwayCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAwayCap.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboAwayCap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboAwayCap.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAwayCap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.cboAwayCap.ItemHeight = 30;
            this.cboAwayCap.Location = new System.Drawing.Point(120, 135);
            this.cboAwayCap.Name = "cboAwayCap";
            this.cboAwayCap.Size = new System.Drawing.Size(222, 36);
            this.cboAwayCap.TabIndex = 62;
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
            this.btnRefresh.Location = new System.Drawing.Point(359, 343);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnRefresh.Size = new System.Drawing.Size(132, 41);
            this.btnRefresh.TabIndex = 131;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = false;
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
            this.btnAddMatch.Location = new System.Drawing.Point(359, 140);
            this.btnAddMatch.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddMatch.Name = "btnAddMatch";
            this.btnAddMatch.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAddMatch.Size = new System.Drawing.Size(133, 42);
            this.btnAddMatch.TabIndex = 128;
            this.btnAddMatch.Text = "Add";
            this.btnAddMatch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddMatch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddMatch.UseVisualStyleBackColor = false;
            this.btnAddMatch.Click += new System.EventHandler(this.btnAddMatch_Click);
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
            this.btnDelMatch.Location = new System.Drawing.Point(359, 274);
            this.btnDelMatch.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelMatch.Name = "btnDelMatch";
            this.btnDelMatch.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDelMatch.Size = new System.Drawing.Size(133, 42);
            this.btnDelMatch.TabIndex = 129;
            this.btnDelMatch.Text = "Delete";
            this.btnDelMatch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelMatch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelMatch.UseVisualStyleBackColor = false;
            this.btnDelMatch.Click += new System.EventHandler(this.btnDelMatch_Click);
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
            this.btnEditMatch.Location = new System.Drawing.Point(359, 206);
            this.btnEditMatch.Margin = new System.Windows.Forms.Padding(5);
            this.btnEditMatch.Name = "btnEditMatch";
            this.btnEditMatch.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnEditMatch.Size = new System.Drawing.Size(133, 42);
            this.btnEditMatch.TabIndex = 130;
            this.btnEditMatch.Text = "Edit";
            this.btnEditMatch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditMatch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditMatch.UseVisualStyleBackColor = false;
            this.btnEditMatch.Click += new System.EventHandler(this.btnEditMatch_Click);
            // 
            // grbHomeTeam
            // 
            this.grbHomeTeam.BackColor = System.Drawing.Color.LightGray;
            this.grbHomeTeam.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.grbHomeTeam.BorderRadius = 10;
            this.grbHomeTeam.Controls.Add(this.txtHomeName);
            this.grbHomeTeam.Controls.Add(this.guna2HtmlLabel5);
            this.grbHomeTeam.Controls.Add(this.cboHomeCap);
            this.grbHomeTeam.Controls.Add(this.txtHomeGoals);
            this.grbHomeTeam.Controls.Add(this.txtHomeTactical);
            this.grbHomeTeam.Controls.Add(this.guna2TextBox2);
            this.grbHomeTeam.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.grbHomeTeam.FillColor = System.Drawing.Color.Transparent;
            this.grbHomeTeam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbHomeTeam.ForeColor = System.Drawing.Color.White;
            this.grbHomeTeam.Location = new System.Drawing.Point(510, 101);
            this.grbHomeTeam.Name = "grbHomeTeam";
            this.grbHomeTeam.Size = new System.Drawing.Size(364, 283);
            this.grbHomeTeam.TabIndex = 126;
            this.grbHomeTeam.Text = "Home Team";
            this.grbHomeTeam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHomeName
            // 
            this.txtHomeName.BorderThickness = 3;
            this.txtHomeName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHomeName.DefaultText = "";
            this.txtHomeName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHomeName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHomeName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHomeName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHomeName.Enabled = false;
            this.txtHomeName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHomeName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtHomeName.ForeColor = System.Drawing.Color.Black;
            this.txtHomeName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHomeName.Location = new System.Drawing.Point(23, 64);
            this.txtHomeName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHomeName.Name = "txtHomeName";
            this.txtHomeName.PasswordChar = '\0';
            this.txtHomeName.PlaceholderText = "CLUB NAME";
            this.txtHomeName.SelectedText = "";
            this.txtHomeName.Size = new System.Drawing.Size(319, 42);
            this.txtHomeName.TabIndex = 65;
            // 
            // guna2HtmlLabel5
            // 
            this.guna2HtmlLabel5.BackColor = System.Drawing.Color.LightGray;
            this.guna2HtmlLabel5.Font = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.guna2HtmlLabel5.Location = new System.Drawing.Point(23, 131);
            this.guna2HtmlLabel5.Name = "guna2HtmlLabel5";
            this.guna2HtmlLabel5.Size = new System.Drawing.Size(100, 40);
            this.guna2HtmlLabel5.TabIndex = 58;
            this.guna2HtmlLabel5.Text = "Captain";
            this.guna2HtmlLabel5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboHomeCap
            // 
            this.cboHomeCap.BackColor = System.Drawing.Color.Transparent;
            this.cboHomeCap.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.cboHomeCap.BorderRadius = 5;
            this.cboHomeCap.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboHomeCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHomeCap.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboHomeCap.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboHomeCap.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboHomeCap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.cboHomeCap.ItemHeight = 30;
            this.cboHomeCap.Location = new System.Drawing.Point(120, 135);
            this.cboHomeCap.Name = "cboHomeCap";
            this.cboHomeCap.Size = new System.Drawing.Size(222, 36);
            this.cboHomeCap.TabIndex = 57;
            // 
            // txtHomeGoals
            // 
            this.txtHomeGoals.BorderThickness = 3;
            this.txtHomeGoals.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHomeGoals.DefaultText = "";
            this.txtHomeGoals.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHomeGoals.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHomeGoals.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHomeGoals.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHomeGoals.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHomeGoals.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtHomeGoals.ForeColor = System.Drawing.Color.Black;
            this.txtHomeGoals.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHomeGoals.Location = new System.Drawing.Point(195, 206);
            this.txtHomeGoals.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHomeGoals.Name = "txtHomeGoals";
            this.txtHomeGoals.PasswordChar = '\0';
            this.txtHomeGoals.PlaceholderText = "GOALS";
            this.txtHomeGoals.SelectedText = "";
            this.txtHomeGoals.Size = new System.Drawing.Size(147, 42);
            this.txtHomeGoals.TabIndex = 55;
            // 
            // txtHomeTactical
            // 
            this.txtHomeTactical.BorderThickness = 3;
            this.txtHomeTactical.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHomeTactical.DefaultText = "";
            this.txtHomeTactical.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHomeTactical.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHomeTactical.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHomeTactical.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHomeTactical.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHomeTactical.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtHomeTactical.ForeColor = System.Drawing.Color.Black;
            this.txtHomeTactical.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHomeTactical.Location = new System.Drawing.Point(23, 206);
            this.txtHomeTactical.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHomeTactical.Name = "txtHomeTactical";
            this.txtHomeTactical.PasswordChar = '\0';
            this.txtHomeTactical.PlaceholderText = "TACTICAL";
            this.txtHomeTactical.SelectedText = "";
            this.txtHomeTactical.Size = new System.Drawing.Size(147, 42);
            this.txtHomeTactical.TabIndex = 52;
            // 
            // guna2TextBox2
            // 
            this.guna2TextBox2.BorderThickness = 3;
            this.guna2TextBox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.guna2TextBox2.DefaultText = "";
            this.guna2TextBox2.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.guna2TextBox2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.guna2TextBox2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.guna2TextBox2.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2TextBox2.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2TextBox2.Location = new System.Drawing.Point(1068, 121);
            this.guna2TextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.guna2TextBox2.Name = "guna2TextBox2";
            this.guna2TextBox2.PasswordChar = '\0';
            this.guna2TextBox2.PlaceholderText = "Strategy";
            this.guna2TextBox2.SelectedText = "";
            this.guna2TextBox2.Size = new System.Drawing.Size(392, 52);
            this.guna2TextBox2.TabIndex = 47;
            // 
            // grbMatchInfo
            // 
            this.grbMatchInfo.BackColor = System.Drawing.Color.LightGray;
            this.grbMatchInfo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.grbMatchInfo.BorderRadius = 10;
            this.grbMatchInfo.Controls.Add(this.guna2HtmlLabel7);
            this.grbMatchInfo.Controls.Add(this.cboMOTM);
            this.grbMatchInfo.Controls.Add(this.txtReferee);
            this.grbMatchInfo.Controls.Add(this.txtMatchID);
            this.grbMatchInfo.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.grbMatchInfo.FillColor = System.Drawing.Color.Transparent;
            this.grbMatchInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbMatchInfo.ForeColor = System.Drawing.Color.White;
            this.grbMatchInfo.Location = new System.Drawing.Point(1253, 101);
            this.grbMatchInfo.Name = "grbMatchInfo";
            this.grbMatchInfo.Size = new System.Drawing.Size(364, 283);
            this.grbMatchInfo.TabIndex = 132;
            this.grbMatchInfo.Text = "Match Info";
            this.grbMatchInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2HtmlLabel7
            // 
            this.guna2HtmlLabel7.BackColor = System.Drawing.Color.LightGray;
            this.guna2HtmlLabel7.Font = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.guna2HtmlLabel7.Location = new System.Drawing.Point(26, 208);
            this.guna2HtmlLabel7.Name = "guna2HtmlLabel7";
            this.guna2HtmlLabel7.Size = new System.Drawing.Size(91, 40);
            this.guna2HtmlLabel7.TabIndex = 83;
            this.guna2HtmlLabel7.Text = "MOTM";
            this.guna2HtmlLabel7.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboMOTM
            // 
            this.cboMOTM.BackColor = System.Drawing.Color.Transparent;
            this.cboMOTM.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.cboMOTM.BorderRadius = 5;
            this.cboMOTM.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboMOTM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMOTM.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboMOTM.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboMOTM.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.cboMOTM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.cboMOTM.ItemHeight = 30;
            this.cboMOTM.Location = new System.Drawing.Point(116, 212);
            this.cboMOTM.Name = "cboMOTM";
            this.cboMOTM.Size = new System.Drawing.Size(222, 36);
            this.cboMOTM.TabIndex = 82;
            // 
            // txtReferee
            // 
            this.txtReferee.BorderThickness = 3;
            this.txtReferee.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtReferee.DefaultText = "";
            this.txtReferee.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtReferee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtReferee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtReferee.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtReferee.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtReferee.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtReferee.ForeColor = System.Drawing.Color.Black;
            this.txtReferee.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtReferee.Location = new System.Drawing.Point(26, 131);
            this.txtReferee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtReferee.Name = "txtReferee";
            this.txtReferee.PasswordChar = '\0';
            this.txtReferee.PlaceholderText = "REFEREE";
            this.txtReferee.SelectedText = "";
            this.txtReferee.Size = new System.Drawing.Size(312, 42);
            this.txtReferee.TabIndex = 80;
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
            this.txtMatchID.Location = new System.Drawing.Point(26, 64);
            this.txtMatchID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMatchID.Name = "txtMatchID";
            this.txtMatchID.PasswordChar = '\0';
            this.txtMatchID.PlaceholderText = "MATCH ID";
            this.txtMatchID.SelectedText = "";
            this.txtMatchID.Size = new System.Drawing.Size(312, 42);
            this.txtMatchID.TabIndex = 78;
            // 
            // FormMatchDetail
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1632, 809);
            this.Controls.Add(this.grbMatchInfo);
            this.Controls.Add(this.grbAwayTeam);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAddMatch);
            this.Controls.Add(this.btnDelMatch);
            this.Controls.Add(this.btnEditMatch);
            this.Controls.Add(this.grbHomeTeam);
            this.Controls.Add(this.dgvMatchDetail);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblMatchName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMatchDetail";
            this.Text = "FormMatchDetail";
            this.Load += new System.EventHandler(this.FormMatchDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatchDetail)).EndInit();
            this.grbAwayTeam.ResumeLayout(false);
            this.grbAwayTeam.PerformLayout();
            this.grbHomeTeam.ResumeLayout(false);
            this.grbHomeTeam.PerformLayout();
            this.grbMatchInfo.ResumeLayout(false);
            this.grbMatchInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnBack;
        private Guna.UI2.WinForms.Guna2MessageDialog msgNotify;
        private System.Windows.Forms.Label lblMatchName;
        private Guna.UI2.WinForms.Guna2MessageDialog msgConfirm;
        private Guna.UI2.WinForms.Guna2DataGridView dgvMatchDetail;
        private Guna.UI2.WinForms.Guna2GroupBox grbAwayTeam;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private FontAwesome.Sharp.IconButton btnAddMatch;
        private FontAwesome.Sharp.IconButton btnDelMatch;
        private FontAwesome.Sharp.IconButton btnEditMatch;
        private Guna.UI2.WinForms.Guna2GroupBox grbHomeTeam;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel5;
        private Guna.UI2.WinForms.Guna2ComboBox cboHomeCap;
        private Guna.UI2.WinForms.Guna2TextBox txtHomeGoals;
        private Guna.UI2.WinForms.Guna2TextBox txtHomeTactical;
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox2;
        private Guna.UI2.WinForms.Guna2GroupBox grbMatchInfo;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel7;
        private Guna.UI2.WinForms.Guna2ComboBox cboMOTM;
        private Guna.UI2.WinForms.Guna2TextBox txtReferee;
        private Guna.UI2.WinForms.Guna2TextBox txtMatchID;
        private Guna.UI2.WinForms.Guna2TextBox txtAwayName;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ComboBox cboAwayCap;
        private Guna.UI2.WinForms.Guna2TextBox txtAwayGoals;
        private Guna.UI2.WinForms.Guna2TextBox txtAwayTactical;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn HomeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AwayID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MotmID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HomeGoals;
        private System.Windows.Forms.DataGridViewTextBoxColumn AwayGoals;
        private System.Windows.Forms.DataGridViewTextBoxColumn HomeCapID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AwayCapID;
        private System.Windows.Forms.DataGridViewTextBoxColumn HomeTactical;
        private System.Windows.Forms.DataGridViewTextBoxColumn AwayTactical;
        private System.Windows.Forms.DataGridViewTextBoxColumn Referee;
        private Guna.UI2.WinForms.Guna2TextBox txtHomeName;
    }
}