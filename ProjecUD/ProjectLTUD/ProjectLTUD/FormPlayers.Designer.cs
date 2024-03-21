namespace ProjectLTUD
{
    partial class FormPlayers
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.iconDropDownButton1 = new FontAwesome.Sharp.IconDropDownButton();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.ofdPlayers = new System.Windows.Forms.OpenFileDialog();
            this.dgvPlayer = new Guna.UI2.WinForms.Guna2DataGridView();
            this.PlayerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClubID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Height = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayerDOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Foot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbAwayTeam = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.cboPosition = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtPlayerID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtSalary = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboFoot = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtNation = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtWeight = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.dtpDOB = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtHeight = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.cboClubs = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cboFindPlayerByTeam = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtFindName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnFindName = new FontAwesome.Sharp.IconButton();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtFindID = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnFindID = new FontAwesome.Sharp.IconButton();
            this.btnEdit = new FontAwesome.Sharp.IconButton();
            this.btnDel = new FontAwesome.Sharp.IconButton();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.btnRefresh = new FontAwesome.Sharp.IconButton();
            this.msgNotify = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.msgConfirm = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayer)).BeginInit();
            this.grbAwayTeam.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // iconDropDownButton1
            // 
            this.iconDropDownButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconDropDownButton1.IconColor = System.Drawing.Color.Black;
            this.iconDropDownButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconDropDownButton1.Name = "iconDropDownButton1";
            this.iconDropDownButton1.Size = new System.Drawing.Size(23, 23);
            this.iconDropDownButton1.Text = "iconDropDownButton1";
            // 
            // ofdPlayers
            // 
            this.ofdPlayers.FileName = "openFileDialog1";
            // 
            // dgvPlayer
            // 
            this.dgvPlayer.AllowUserToResizeColumns = false;
            this.dgvPlayer.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvPlayer.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPlayer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlayer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPlayer.ColumnHeadersHeight = 45;
            this.dgvPlayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPlayer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlayerID,
            this.ClubID,
            this.PlayerName,
            this.Number,
            this.Nation,
            this.Height,
            this.Weight,
            this.PlayerDOB,
            this.Salary,
            this.Position,
            this.Foot});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPlayer.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPlayer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPlayer.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPlayer.Location = new System.Drawing.Point(0, 432);
            this.dgvPlayer.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dgvPlayer.Name = "dgvPlayer";
            this.dgvPlayer.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlayer.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPlayer.RowHeadersVisible = false;
            this.dgvPlayer.RowHeadersWidth = 50;
            this.dgvPlayer.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvPlayer.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPlayer.RowTemplate.Height = 40;
            this.dgvPlayer.Size = new System.Drawing.Size(1668, 471);
            this.dgvPlayer.TabIndex = 12;
            this.dgvPlayer.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPlayer.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPlayer.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPlayer.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPlayer.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPlayer.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvPlayer.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPlayer.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvPlayer.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPlayer.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPlayer.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPlayer.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPlayer.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvPlayer.ThemeStyle.ReadOnly = true;
            this.dgvPlayer.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPlayer.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPlayer.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPlayer.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPlayer.ThemeStyle.RowsStyle.Height = 40;
            this.dgvPlayer.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPlayer.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPlayer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPlayer_CellClick);
            // 
            // PlayerID
            // 
            this.PlayerID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PlayerID.DataPropertyName = "PlayerID";
            this.PlayerID.FillWeight = 116.2929F;
            this.PlayerID.Frozen = true;
            this.PlayerID.HeaderText = "ID";
            this.PlayerID.MinimumWidth = 6;
            this.PlayerID.Name = "PlayerID";
            this.PlayerID.ReadOnly = true;
            this.PlayerID.Width = 90;
            // 
            // ClubID
            // 
            this.ClubID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.ClubID.DataPropertyName = "ClubID";
            this.ClubID.FillWeight = 799.4648F;
            this.ClubID.Frozen = true;
            this.ClubID.HeaderText = "Club";
            this.ClubID.MinimumWidth = 6;
            this.ClubID.Name = "ClubID";
            this.ClubID.ReadOnly = true;
            this.ClubID.Width = 170;
            // 
            // PlayerName
            // 
            this.PlayerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PlayerName.DataPropertyName = "PlayerName";
            this.PlayerName.FillWeight = 15.5486F;
            this.PlayerName.Frozen = true;
            this.PlayerName.HeaderText = "Full Name";
            this.PlayerName.MinimumWidth = 6;
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.ReadOnly = true;
            this.PlayerName.Width = 250;
            // 
            // Number
            // 
            this.Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Number.DataPropertyName = "Number";
            this.Number.FillWeight = 16.56745F;
            this.Number.Frozen = true;
            this.Number.HeaderText = "Number";
            this.Number.MinimumWidth = 6;
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 110;
            // 
            // Nation
            // 
            this.Nation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Nation.DataPropertyName = "Nation";
            this.Nation.FillWeight = 16.56745F;
            this.Nation.Frozen = true;
            this.Nation.HeaderText = "Nation";
            this.Nation.MinimumWidth = 6;
            this.Nation.Name = "Nation";
            this.Nation.ReadOnly = true;
            this.Nation.Width = 190;
            // 
            // Height
            // 
            this.Height.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Height.DataPropertyName = "Height";
            this.Height.FillWeight = 16.56745F;
            this.Height.Frozen = true;
            this.Height.HeaderText = "Height";
            this.Height.MinimumWidth = 6;
            this.Height.Name = "Height";
            this.Height.ReadOnly = true;
            this.Height.Width = 110;
            // 
            // Weight
            // 
            this.Weight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Weight.DataPropertyName = "Weight";
            this.Weight.FillWeight = 16.56745F;
            this.Weight.Frozen = true;
            this.Weight.HeaderText = "Weight";
            this.Weight.MinimumWidth = 6;
            this.Weight.Name = "Weight";
            this.Weight.ReadOnly = true;
            this.Weight.Width = 110;
            // 
            // PlayerDOB
            // 
            this.PlayerDOB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PlayerDOB.DataPropertyName = "PlayerDOB";
            this.PlayerDOB.FillWeight = 16.56745F;
            this.PlayerDOB.Frozen = true;
            this.PlayerDOB.HeaderText = "DOB";
            this.PlayerDOB.MinimumWidth = 6;
            this.PlayerDOB.Name = "PlayerDOB";
            this.PlayerDOB.ReadOnly = true;
            this.PlayerDOB.Width = 160;
            // 
            // Salary
            // 
            this.Salary.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Salary.DataPropertyName = "Salary";
            this.Salary.FillWeight = 16.56745F;
            this.Salary.Frozen = true;
            this.Salary.HeaderText = "Salary (£)";
            this.Salary.MinimumWidth = 6;
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            this.Salary.Width = 150;
            // 
            // Position
            // 
            this.Position.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Position.DataPropertyName = "Position";
            this.Position.FillWeight = 16.56745F;
            this.Position.Frozen = true;
            this.Position.HeaderText = "Position";
            this.Position.MinimumWidth = 6;
            this.Position.Name = "Position";
            this.Position.ReadOnly = true;
            this.Position.Width = 150;
            // 
            // Foot
            // 
            this.Foot.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Foot.DataPropertyName = "Foot";
            this.Foot.FillWeight = 16.56745F;
            this.Foot.Frozen = true;
            this.Foot.HeaderText = "Foot";
            this.Foot.MinimumWidth = 6;
            this.Foot.Name = "Foot";
            this.Foot.ReadOnly = true;
            this.Foot.Width = 160;
            // 
            // grbAwayTeam
            // 
            this.grbAwayTeam.BackColor = System.Drawing.Color.LightGray;
            this.grbAwayTeam.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.grbAwayTeam.BorderRadius = 10;
            this.grbAwayTeam.Controls.Add(this.guna2HtmlLabel3);
            this.grbAwayTeam.Controls.Add(this.guna2HtmlLabel2);
            this.grbAwayTeam.Controls.Add(this.guna2HtmlLabel1);
            this.grbAwayTeam.Controls.Add(this.cboPosition);
            this.grbAwayTeam.Controls.Add(this.txtPlayerID);
            this.grbAwayTeam.Controls.Add(this.txtSalary);
            this.grbAwayTeam.Controls.Add(this.cboFoot);
            this.grbAwayTeam.Controls.Add(this.txtNation);
            this.grbAwayTeam.Controls.Add(this.txtWeight);
            this.grbAwayTeam.Controls.Add(this.txtNumber);
            this.grbAwayTeam.Controls.Add(this.dtpDOB);
            this.grbAwayTeam.Controls.Add(this.txtHeight);
            this.grbAwayTeam.Controls.Add(this.txtName);
            this.grbAwayTeam.Controls.Add(this.cboClubs);
            this.grbAwayTeam.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.grbAwayTeam.FillColor = System.Drawing.Color.Transparent;
            this.grbAwayTeam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAwayTeam.ForeColor = System.Drawing.Color.White;
            this.grbAwayTeam.Location = new System.Drawing.Point(980, 11);
            this.grbAwayTeam.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.grbAwayTeam.Name = "grbAwayTeam";
            this.grbAwayTeam.Size = new System.Drawing.Size(640, 368);
            this.grbAwayTeam.TabIndex = 52;
            this.grbAwayTeam.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.LightGray;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(328, 241);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(105, 40);
            this.guna2HtmlLabel3.TabIndex = 73;
            this.guna2HtmlLabel3.Text = "Position";
            this.guna2HtmlLabel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.LightGray;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(328, 54);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(61, 40);
            this.guna2HtmlLabel2.TabIndex = 72;
            this.guna2HtmlLabel2.Text = "Foot";
            this.guna2HtmlLabel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.LightGray;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(34, 54);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(72, 40);
            this.guna2HtmlLabel1.TabIndex = 71;
            this.guna2HtmlLabel1.Text = "Clubs";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.cboPosition.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.cboPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.cboPosition.ItemHeight = 30;
            this.cboPosition.Items.AddRange(new object[] {
            "Goalkeeper",
            "Defender",
            "Midfielder",
            "Forward"});
            this.cboPosition.Location = new System.Drawing.Point(434, 241);
            this.cboPosition.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cboPosition.Name = "cboPosition";
            this.cboPosition.Size = new System.Drawing.Size(164, 36);
            this.cboPosition.TabIndex = 70;
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
            this.txtPlayerID.Location = new System.Drawing.Point(34, 116);
            this.txtPlayerID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPlayerID.Name = "txtPlayerID";
            this.txtPlayerID.PasswordChar = '\0';
            this.txtPlayerID.PlaceholderText = "ID";
            this.txtPlayerID.SelectedText = "";
            this.txtPlayerID.Size = new System.Drawing.Size(270, 41);
            this.txtPlayerID.TabIndex = 69;
            // 
            // txtSalary
            // 
            this.txtSalary.BorderThickness = 3;
            this.txtSalary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSalary.DefaultText = "";
            this.txtSalary.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSalary.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSalary.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSalary.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSalary.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSalary.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSalary.ForeColor = System.Drawing.Color.Black;
            this.txtSalary.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSalary.Location = new System.Drawing.Point(328, 180);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.PasswordChar = '\0';
            this.txtSalary.PlaceholderText = "SALARY";
            this.txtSalary.SelectedText = "";
            this.txtSalary.Size = new System.Drawing.Size(270, 41);
            this.txtSalary.TabIndex = 57;
            // 
            // cboFoot
            // 
            this.cboFoot.BackColor = System.Drawing.Color.Transparent;
            this.cboFoot.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.cboFoot.BorderRadius = 5;
            this.cboFoot.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboFoot.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFoot.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboFoot.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboFoot.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.cboFoot.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.cboFoot.ItemHeight = 30;
            this.cboFoot.Items.AddRange(new object[] {
            "Right",
            "Left",
            "Both"});
            this.cboFoot.Location = new System.Drawing.Point(402, 54);
            this.cboFoot.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cboFoot.Name = "cboFoot";
            this.cboFoot.Size = new System.Drawing.Size(196, 36);
            this.cboFoot.TabIndex = 58;
            // 
            // txtNation
            // 
            this.txtNation.BorderThickness = 3;
            this.txtNation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNation.DefaultText = "";
            this.txtNation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNation.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNation.ForeColor = System.Drawing.Color.Black;
            this.txtNation.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNation.Location = new System.Drawing.Point(34, 308);
            this.txtNation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNation.Name = "txtNation";
            this.txtNation.PasswordChar = '\0';
            this.txtNation.PlaceholderText = "NATION";
            this.txtNation.SelectedText = "";
            this.txtNation.Size = new System.Drawing.Size(270, 41);
            this.txtNation.TabIndex = 54;
            // 
            // txtWeight
            // 
            this.txtWeight.BorderThickness = 3;
            this.txtWeight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtWeight.DefaultText = "";
            this.txtWeight.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtWeight.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtWeight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtWeight.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtWeight.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtWeight.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtWeight.ForeColor = System.Drawing.Color.Black;
            this.txtWeight.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtWeight.Location = new System.Drawing.Point(468, 116);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.PasswordChar = '\0';
            this.txtWeight.PlaceholderText = "WEIGHT";
            this.txtWeight.SelectedText = "";
            this.txtWeight.Size = new System.Drawing.Size(132, 41);
            this.txtWeight.TabIndex = 53;
            // 
            // txtNumber
            // 
            this.txtNumber.BorderThickness = 3;
            this.txtNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNumber.DefaultText = "";
            this.txtNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumber.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtNumber.ForeColor = System.Drawing.Color.Black;
            this.txtNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtNumber.Location = new System.Drawing.Point(34, 241);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.PasswordChar = '\0';
            this.txtNumber.PlaceholderText = "NUMBER";
            this.txtNumber.SelectedText = "";
            this.txtNumber.Size = new System.Drawing.Size(270, 41);
            this.txtNumber.TabIndex = 52;
            // 
            // dtpDOB
            // 
            this.dtpDOB.BorderRadius = 5;
            this.dtpDOB.Checked = true;
            this.dtpDOB.CustomFormat = "dd/MM/yyyy";
            this.dtpDOB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.dtpDOB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDOB.ForeColor = System.Drawing.Color.White;
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpDOB.Location = new System.Drawing.Point(328, 308);
            this.dtpDOB.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.dtpDOB.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDOB.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(270, 41);
            this.dtpDOB.TabIndex = 55;
            this.dtpDOB.Value = new System.DateTime(2023, 11, 4, 23, 22, 42, 542);
            // 
            // txtHeight
            // 
            this.txtHeight.BorderThickness = 3;
            this.txtHeight.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtHeight.DefaultText = "";
            this.txtHeight.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtHeight.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtHeight.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHeight.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtHeight.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHeight.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtHeight.ForeColor = System.Drawing.Color.Black;
            this.txtHeight.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtHeight.Location = new System.Drawing.Point(328, 116);
            this.txtHeight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.PasswordChar = '\0';
            this.txtHeight.PlaceholderText = "HEIGHT";
            this.txtHeight.SelectedText = "";
            this.txtHeight.Size = new System.Drawing.Size(132, 41);
            this.txtHeight.TabIndex = 51;
            // 
            // txtName
            // 
            this.txtName.BorderThickness = 3;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Location = new System.Drawing.Point(34, 180);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "FULL NAME";
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(270, 41);
            this.txtName.TabIndex = 50;
            // 
            // cboClubs
            // 
            this.cboClubs.BackColor = System.Drawing.Color.Transparent;
            this.cboClubs.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.cboClubs.BorderRadius = 5;
            this.cboClubs.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboClubs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboClubs.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboClubs.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboClubs.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.cboClubs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.cboClubs.ItemHeight = 30;
            this.cboClubs.Items.AddRange(new object[] {
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
            this.cboClubs.Location = new System.Drawing.Point(108, 54);
            this.cboClubs.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cboClubs.Name = "cboClubs";
            this.cboClubs.Size = new System.Drawing.Size(196, 36);
            this.cboClubs.TabIndex = 49;
            // 
            // cboFindPlayerByTeam
            // 
            this.cboFindPlayerByTeam.BackColor = System.Drawing.Color.Transparent;
            this.cboFindPlayerByTeam.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.cboFindPlayerByTeam.BorderRadius = 5;
            this.cboFindPlayerByTeam.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboFindPlayerByTeam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFindPlayerByTeam.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboFindPlayerByTeam.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cboFindPlayerByTeam.Font = new System.Drawing.Font("Segoe UI", 10.2F);
            this.cboFindPlayerByTeam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.cboFindPlayerByTeam.ItemHeight = 30;
            this.cboFindPlayerByTeam.Items.AddRange(new object[] {
            "",
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
            "Manchester City",
            "Manchester United",
            "Newcastle",
            "Nottingham Forest",
            "Sheffield United",
            "Tottenham",
            "West Ham United",
            "Wolverhampton"});
            this.cboFindPlayerByTeam.Location = new System.Drawing.Point(119, 162);
            this.cboFindPlayerByTeam.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.cboFindPlayerByTeam.Name = "cboFindPlayerByTeam";
            this.cboFindPlayerByTeam.Size = new System.Drawing.Size(267, 36);
            this.cboFindPlayerByTeam.TabIndex = 55;
            this.cboFindPlayerByTeam.SelectedIndexChanged += new System.EventHandler(this.cboFindPlayerByTeam_SelectedIndexChanged);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.txtFindName);
            this.guna2Panel2.Controls.Add(this.btnFindName);
            this.guna2Panel2.Location = new System.Drawing.Point(44, 98);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(342, 41);
            this.guna2Panel2.TabIndex = 54;
            // 
            // txtFindName
            // 
            this.txtFindName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFindName.DefaultText = "";
            this.txtFindName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFindName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFindName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFindName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFindName.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtFindName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFindName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtFindName.ForeColor = System.Drawing.Color.Black;
            this.txtFindName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFindName.Location = new System.Drawing.Point(0, 0);
            this.txtFindName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFindName.Name = "txtFindName";
            this.txtFindName.PasswordChar = '\0';
            this.txtFindName.PlaceholderText = "NAME";
            this.txtFindName.SelectedText = "";
            this.txtFindName.Size = new System.Drawing.Size(228, 41);
            this.txtFindName.TabIndex = 9;
            // 
            // btnFindName
            // 
            this.btnFindName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.btnFindName.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFindName.FlatAppearance.BorderSize = 0;
            this.btnFindName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindName.ForeColor = System.Drawing.Color.White;
            this.btnFindName.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnFindName.IconColor = System.Drawing.Color.White;
            this.btnFindName.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFindName.IconSize = 25;
            this.btnFindName.Location = new System.Drawing.Point(226, 0);
            this.btnFindName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFindName.Name = "btnFindName";
            this.btnFindName.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnFindName.Size = new System.Drawing.Size(116, 41);
            this.btnFindName.TabIndex = 6;
            this.btnFindName.Text = "Find";
            this.btnFindName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFindName.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFindName.UseVisualStyleBackColor = false;
            this.btnFindName.Click += new System.EventHandler(this.btnFindName_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.txtFindID);
            this.guna2Panel1.Controls.Add(this.btnFindID);
            this.guna2Panel1.Location = new System.Drawing.Point(44, 43);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(342, 41);
            this.guna2Panel1.TabIndex = 53;
            // 
            // txtFindID
            // 
            this.txtFindID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFindID.DefaultText = "";
            this.txtFindID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFindID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFindID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFindID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFindID.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtFindID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFindID.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtFindID.ForeColor = System.Drawing.Color.Black;
            this.txtFindID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFindID.Location = new System.Drawing.Point(0, 0);
            this.txtFindID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFindID.Name = "txtFindID";
            this.txtFindID.PasswordChar = '\0';
            this.txtFindID.PlaceholderText = "ID";
            this.txtFindID.SelectedText = "";
            this.txtFindID.Size = new System.Drawing.Size(228, 41);
            this.txtFindID.TabIndex = 0;
            // 
            // btnFindID
            // 
            this.btnFindID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.btnFindID.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnFindID.FlatAppearance.BorderSize = 0;
            this.btnFindID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindID.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFindID.ForeColor = System.Drawing.Color.White;
            this.btnFindID.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnFindID.IconColor = System.Drawing.Color.White;
            this.btnFindID.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFindID.IconSize = 25;
            this.btnFindID.Location = new System.Drawing.Point(226, 0);
            this.btnFindID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFindID.Name = "btnFindID";
            this.btnFindID.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnFindID.Size = new System.Drawing.Size(116, 41);
            this.btnFindID.TabIndex = 6;
            this.btnFindID.Text = "Find";
            this.btnFindID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFindID.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFindID.UseVisualStyleBackColor = false;
            this.btnFindID.Click += new System.EventHandler(this.btnFindID_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.btnEdit.FlatAppearance.BorderSize = 0;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.IconChar = FontAwesome.Sharp.IconChar.RotateBackward;
            this.btnEdit.IconColor = System.Drawing.Color.White;
            this.btnEdit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEdit.IconSize = 25;
            this.btnEdit.Location = new System.Drawing.Point(824, 253);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnEdit.Size = new System.Drawing.Size(132, 41);
            this.btnEdit.TabIndex = 66;
            this.btnEdit.Text = "Edit";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.btnDel.IconColor = System.Drawing.Color.White;
            this.btnDel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDel.IconSize = 25;
            this.btnDel.Location = new System.Drawing.Point(824, 189);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDel.Name = "btnDel";
            this.btnDel.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDel.Size = new System.Drawing.Size(132, 41);
            this.btnDel.TabIndex = 65;
            this.btnDel.Text = "Delete";
            this.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnAdd.IconColor = System.Drawing.Color.White;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.IconSize = 25;
            this.btnAdd.Location = new System.Drawing.Point(824, 127);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAdd.Size = new System.Drawing.Size(132, 41);
            this.btnAdd.TabIndex = 64;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.btnRefresh.Location = new System.Drawing.Point(824, 319);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnRefresh.Size = new System.Drawing.Size(132, 41);
            this.btnRefresh.TabIndex = 68;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
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
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(44, 158);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(72, 40);
            this.guna2HtmlLabel4.TabIndex = 72;
            this.guna2HtmlLabel4.Text = "Clubs";
            this.guna2HtmlLabel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormPlayers
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1668, 903);
            this.Controls.Add(this.guna2HtmlLabel4);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cboFindPlayerByTeam);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.grbAwayTeam);
            this.Controls.Add(this.dgvPlayer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "FormPlayers";
            this.Text = "Players";
            this.Load += new System.EventHandler(this.FormPlayers_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.FormPlayers_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayer)).EndInit();
            this.grbAwayTeam.ResumeLayout(false);
            this.grbAwayTeam.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconDropDownButton iconDropDownButton1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.OpenFileDialog ofdPlayers;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPlayer;
        private Guna.UI2.WinForms.Guna2GroupBox grbAwayTeam;
        private Guna.UI2.WinForms.Guna2ComboBox cboFoot;
        private Guna.UI2.WinForms.Guna2TextBox txtSalary;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpDOB;
        private Guna.UI2.WinForms.Guna2TextBox txtNation;
        private Guna.UI2.WinForms.Guna2TextBox txtWeight;
        private Guna.UI2.WinForms.Guna2TextBox txtNumber;
        private Guna.UI2.WinForms.Guna2TextBox txtHeight;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private Guna.UI2.WinForms.Guna2ComboBox cboClubs;
        private Guna.UI2.WinForms.Guna2ComboBox cboFindPlayerByTeam;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtFindName;
        private FontAwesome.Sharp.IconButton btnFindName;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtFindID;
        private FontAwesome.Sharp.IconButton btnFindID;
        private FontAwesome.Sharp.IconButton btnEdit;
        private FontAwesome.Sharp.IconButton btnDel;
        private FontAwesome.Sharp.IconButton btnAdd;
        private FontAwesome.Sharp.IconButton btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClubID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nation;
        private System.Windows.Forms.DataGridViewTextBoxColumn Height;
        private System.Windows.Forms.DataGridViewTextBoxColumn Weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerDOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn Foot;
        private Guna.UI2.WinForms.Guna2MessageDialog msgNotify;
        private Guna.UI2.WinForms.Guna2MessageDialog msgConfirm;
        private Guna.UI2.WinForms.Guna2TextBox txtPlayerID;
        private Guna.UI2.WinForms.Guna2ComboBox cboPosition;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
    }
}