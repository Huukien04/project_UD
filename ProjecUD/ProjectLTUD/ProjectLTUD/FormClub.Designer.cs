namespace ProjectLTUD
{
    partial class FormClub
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBack = new FontAwesome.Sharp.IconButton();
            this.picClubLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblClubName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dgvStadium = new Guna.UI2.WinForms.Guna2DataGridView();
            this.StadiumID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StadiumName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BuiltTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbStadium = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dtpBuiltTime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtLocation = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCapacity = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddStadium = new FontAwesome.Sharp.IconButton();
            this.txtSize = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnDelStadium = new FontAwesome.Sharp.IconButton();
            this.txtStadiumName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnEditStadium = new FontAwesome.Sharp.IconButton();
            this.txtStadiumID = new Guna.UI2.WinForms.Guna2TextBox();
            this.grbCoach = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvCoach = new Guna.UI2.WinForms.Guna2DataGridView();
            this.CoachID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoachName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoachDOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpCoachDOB = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtCoachID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCoachNation = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAddCoach = new FontAwesome.Sharp.IconButton();
            this.btnDelCoach = new FontAwesome.Sharp.IconButton();
            this.btnEditCoach = new FontAwesome.Sharp.IconButton();
            this.txtCoachName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblNoteOfCoach = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.msgNote = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.lblNoteOfStadium = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.msgNotify = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.msgConfirm = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.grbPlayers = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dgvPlayers = new Guna.UI2.WinForms.Guna2DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.picClubLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStadium)).BeginInit();
            this.grbStadium.SuspendLayout();
            this.grbCoach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoach)).BeginInit();
            this.grbPlayers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).BeginInit();
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
            this.btnBack.TabIndex = 0;
            this.btnBack.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // picClubLogo
            // 
            this.picClubLogo.ImageRotate = 0F;
            this.picClubLogo.Location = new System.Drawing.Point(1506, 12);
            this.picClubLogo.Name = "picClubLogo";
            this.picClubLogo.Size = new System.Drawing.Size(130, 130);
            this.picClubLogo.TabIndex = 29;
            this.picClubLogo.TabStop = false;
            // 
            // lblClubName
            // 
            this.lblClubName.AutoSize = false;
            this.lblClubName.BackColor = System.Drawing.Color.Transparent;
            this.lblClubName.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClubName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.lblClubName.Location = new System.Drawing.Point(1093, 17);
            this.lblClubName.Name = "lblClubName";
            this.lblClubName.Size = new System.Drawing.Size(407, 39);
            this.lblClubName.TabIndex = 5;
            this.lblClubName.Text = "Club Name";
            this.lblClubName.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvStadium
            // 
            this.dgvStadium.AllowUserToResizeColumns = false;
            this.dgvStadium.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dgvStadium.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvStadium.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvStadium.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dgvStadium.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStadium.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvStadium.ColumnHeadersHeight = 40;
            this.dgvStadium.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StadiumID,
            this.StadiumName,
            this.Size,
            this.Capacity,
            this.Location,
            this.BuiltTime});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStadium.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvStadium.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvStadium.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvStadium.Location = new System.Drawing.Point(0, 40);
            this.dgvStadium.Name = "dgvStadium";
            this.dgvStadium.ReadOnly = true;
            this.dgvStadium.RowHeadersVisible = false;
            this.dgvStadium.RowHeadersWidth = 51;
            this.dgvStadium.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvStadium.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStadium.RowTemplate.Height = 35;
            this.dgvStadium.Size = new System.Drawing.Size(909, 110);
            this.dgvStadium.TabIndex = 0;
            this.dgvStadium.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvStadium.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvStadium.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvStadium.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvStadium.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvStadium.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvStadium.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvStadium.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvStadium.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvStadium.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStadium.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvStadium.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvStadium.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvStadium.ThemeStyle.ReadOnly = true;
            this.dgvStadium.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvStadium.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dgvStadium.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvStadium.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvStadium.ThemeStyle.RowsStyle.Height = 35;
            this.dgvStadium.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvStadium.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvStadium.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStadium_CellClick);
            // 
            // StadiumID
            // 
            this.StadiumID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.StadiumID.DataPropertyName = "StadiumID";
            this.StadiumID.Frozen = true;
            this.StadiumID.HeaderText = "Stadium ID";
            this.StadiumID.MinimumWidth = 6;
            this.StadiumID.Name = "StadiumID";
            this.StadiumID.ReadOnly = true;
            this.StadiumID.Width = 160;
            // 
            // StadiumName
            // 
            this.StadiumName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.StadiumName.DataPropertyName = "StadiumName";
            this.StadiumName.FillWeight = 15.5486F;
            this.StadiumName.Frozen = true;
            this.StadiumName.HeaderText = "Name";
            this.StadiumName.MinimumWidth = 6;
            this.StadiumName.Name = "StadiumName";
            this.StadiumName.ReadOnly = true;
            this.StadiumName.Width = 130;
            // 
            // Size
            // 
            this.Size.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Size.DataPropertyName = "Size";
            this.Size.FillWeight = 16.56745F;
            this.Size.Frozen = true;
            this.Size.HeaderText = "Size";
            this.Size.MinimumWidth = 6;
            this.Size.Name = "Size";
            this.Size.ReadOnly = true;
            this.Size.Width = 110;
            // 
            // Capacity
            // 
            this.Capacity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Capacity.DataPropertyName = "Capacity";
            this.Capacity.FillWeight = 16.56745F;
            this.Capacity.Frozen = true;
            this.Capacity.HeaderText = "Capacity";
            this.Capacity.MinimumWidth = 6;
            this.Capacity.Name = "Capacity";
            this.Capacity.ReadOnly = true;
            this.Capacity.Width = 110;
            // 
            // Location
            // 
            this.Location.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Location.DataPropertyName = "Location";
            this.Location.FillWeight = 16.56745F;
            this.Location.Frozen = true;
            this.Location.HeaderText = "Location";
            this.Location.MinimumWidth = 6;
            this.Location.Name = "Location";
            this.Location.ReadOnly = true;
            this.Location.Width = 270;
            // 
            // BuiltTime
            // 
            this.BuiltTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.BuiltTime.DataPropertyName = "BuiltTime";
            this.BuiltTime.FillWeight = 16.56745F;
            this.BuiltTime.Frozen = true;
            this.BuiltTime.HeaderText = "Built Time";
            this.BuiltTime.MinimumWidth = 6;
            this.BuiltTime.Name = "BuiltTime";
            this.BuiltTime.ReadOnly = true;
            this.BuiltTime.Width = 130;
            // 
            // grbStadium
            // 
            this.grbStadium.BackColor = System.Drawing.Color.LightGray;
            this.grbStadium.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.grbStadium.BorderRadius = 10;
            this.grbStadium.Controls.Add(this.dtpBuiltTime);
            this.grbStadium.Controls.Add(this.dgvStadium);
            this.grbStadium.Controls.Add(this.txtLocation);
            this.grbStadium.Controls.Add(this.txtCapacity);
            this.grbStadium.Controls.Add(this.btnAddStadium);
            this.grbStadium.Controls.Add(this.txtSize);
            this.grbStadium.Controls.Add(this.btnDelStadium);
            this.grbStadium.Controls.Add(this.txtStadiumName);
            this.grbStadium.Controls.Add(this.btnEditStadium);
            this.grbStadium.Controls.Add(this.txtStadiumID);
            this.grbStadium.CustomBorderColor = System.Drawing.Color.LightGray;
            this.grbStadium.FillColor = System.Drawing.Color.LightGray;
            this.grbStadium.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbStadium.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.grbStadium.Location = new System.Drawing.Point(14, 610);
            this.grbStadium.Name = "grbStadium";
            this.grbStadium.Size = new System.Drawing.Size(909, 378);
            this.grbStadium.TabIndex = 4;
            this.grbStadium.Text = "STADIUM";
            // 
            // dtpBuiltTime
            // 
            this.dtpBuiltTime.BorderRadius = 5;
            this.dtpBuiltTime.Checked = true;
            this.dtpBuiltTime.CustomFormat = "dd/MM/yyyy";
            this.dtpBuiltTime.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.dtpBuiltTime.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dtpBuiltTime.ForeColor = System.Drawing.Color.White;
            this.dtpBuiltTime.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpBuiltTime.Location = new System.Drawing.Point(347, 309);
            this.dtpBuiltTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpBuiltTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpBuiltTime.Name = "dtpBuiltTime";
            this.dtpBuiltTime.Size = new System.Drawing.Size(229, 42);
            this.dtpBuiltTime.TabIndex = 57;
            this.dtpBuiltTime.Value = new System.DateTime(2023, 11, 4, 23, 22, 42, 542);
            // 
            // txtLocation
            // 
            this.txtLocation.BorderThickness = 3;
            this.txtLocation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLocation.DefaultText = "";
            this.txtLocation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLocation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLocation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLocation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLocation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLocation.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.txtLocation.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLocation.Location = new System.Drawing.Point(347, 243);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.PasswordChar = '\0';
            this.txtLocation.PlaceholderText = "LOCATION";
            this.txtLocation.SelectedText = "";
            this.txtLocation.Size = new System.Drawing.Size(229, 42);
            this.txtLocation.TabIndex = 4;
            // 
            // txtCapacity
            // 
            this.txtCapacity.BorderThickness = 3;
            this.txtCapacity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCapacity.DefaultText = "";
            this.txtCapacity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCapacity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCapacity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCapacity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCapacity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCapacity.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCapacity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.txtCapacity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCapacity.Location = new System.Drawing.Point(347, 181);
            this.txtCapacity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.PasswordChar = '\0';
            this.txtCapacity.PlaceholderText = "CAPACITY";
            this.txtCapacity.SelectedText = "";
            this.txtCapacity.Size = new System.Drawing.Size(229, 42);
            this.txtCapacity.TabIndex = 3;
            // 
            // btnAddStadium
            // 
            this.btnAddStadium.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.btnAddStadium.FlatAppearance.BorderSize = 0;
            this.btnAddStadium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddStadium.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStadium.ForeColor = System.Drawing.Color.White;
            this.btnAddStadium.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnAddStadium.IconColor = System.Drawing.Color.White;
            this.btnAddStadium.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddStadium.IconSize = 25;
            this.btnAddStadium.Location = new System.Drawing.Point(654, 181);
            this.btnAddStadium.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddStadium.Name = "btnAddStadium";
            this.btnAddStadium.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAddStadium.Size = new System.Drawing.Size(133, 42);
            this.btnAddStadium.TabIndex = 5;
            this.btnAddStadium.Text = "Add";
            this.btnAddStadium.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddStadium.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddStadium.UseVisualStyleBackColor = false;
            this.btnAddStadium.Click += new System.EventHandler(this.btnAddStadium_Click);
            // 
            // txtSize
            // 
            this.txtSize.BorderThickness = 3;
            this.txtSize.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSize.DefaultText = "";
            this.txtSize.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSize.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSize.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSize.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtSize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.txtSize.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSize.Location = new System.Drawing.Point(43, 309);
            this.txtSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSize.Name = "txtSize";
            this.txtSize.PasswordChar = '\0';
            this.txtSize.PlaceholderText = "SIZE";
            this.txtSize.SelectedText = "";
            this.txtSize.Size = new System.Drawing.Size(229, 42);
            this.txtSize.TabIndex = 47;
            // 
            // btnDelStadium
            // 
            this.btnDelStadium.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.btnDelStadium.FlatAppearance.BorderSize = 0;
            this.btnDelStadium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelStadium.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelStadium.ForeColor = System.Drawing.Color.White;
            this.btnDelStadium.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnDelStadium.IconColor = System.Drawing.Color.White;
            this.btnDelStadium.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelStadium.IconSize = 25;
            this.btnDelStadium.Location = new System.Drawing.Point(654, 243);
            this.btnDelStadium.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelStadium.Name = "btnDelStadium";
            this.btnDelStadium.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDelStadium.Size = new System.Drawing.Size(133, 42);
            this.btnDelStadium.TabIndex = 6;
            this.btnDelStadium.Text = "Delete";
            this.btnDelStadium.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelStadium.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelStadium.UseVisualStyleBackColor = false;
            this.btnDelStadium.Click += new System.EventHandler(this.btnDelStadium_Click);
            // 
            // txtStadiumName
            // 
            this.txtStadiumName.BorderThickness = 3;
            this.txtStadiumName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStadiumName.DefaultText = "";
            this.txtStadiumName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStadiumName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtStadiumName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStadiumName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStadiumName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStadiumName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtStadiumName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.txtStadiumName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStadiumName.Location = new System.Drawing.Point(43, 243);
            this.txtStadiumName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStadiumName.Name = "txtStadiumName";
            this.txtStadiumName.PasswordChar = '\0';
            this.txtStadiumName.PlaceholderText = "NAME";
            this.txtStadiumName.SelectedText = "";
            this.txtStadiumName.Size = new System.Drawing.Size(229, 42);
            this.txtStadiumName.TabIndex = 2;
            // 
            // btnEditStadium
            // 
            this.btnEditStadium.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.btnEditStadium.FlatAppearance.BorderSize = 0;
            this.btnEditStadium.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditStadium.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditStadium.ForeColor = System.Drawing.Color.White;
            this.btnEditStadium.IconChar = FontAwesome.Sharp.IconChar.RotateBackward;
            this.btnEditStadium.IconColor = System.Drawing.Color.White;
            this.btnEditStadium.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditStadium.IconSize = 25;
            this.btnEditStadium.Location = new System.Drawing.Point(654, 309);
            this.btnEditStadium.Margin = new System.Windows.Forms.Padding(5);
            this.btnEditStadium.Name = "btnEditStadium";
            this.btnEditStadium.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnEditStadium.Size = new System.Drawing.Size(133, 42);
            this.btnEditStadium.TabIndex = 7;
            this.btnEditStadium.Text = "Edit";
            this.btnEditStadium.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditStadium.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditStadium.UseVisualStyleBackColor = false;
            this.btnEditStadium.Click += new System.EventHandler(this.btnEditStadium_Click);
            // 
            // txtStadiumID
            // 
            this.txtStadiumID.BorderThickness = 3;
            this.txtStadiumID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStadiumID.DefaultText = "";
            this.txtStadiumID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtStadiumID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtStadiumID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStadiumID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtStadiumID.Enabled = false;
            this.txtStadiumID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStadiumID.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtStadiumID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.txtStadiumID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStadiumID.Location = new System.Drawing.Point(43, 181);
            this.txtStadiumID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStadiumID.Name = "txtStadiumID";
            this.txtStadiumID.PasswordChar = '\0';
            this.txtStadiumID.PlaceholderText = "STADIUM ID";
            this.txtStadiumID.SelectedText = "";
            this.txtStadiumID.Size = new System.Drawing.Size(229, 42);
            this.txtStadiumID.TabIndex = 1;
            // 
            // grbCoach
            // 
            this.grbCoach.BackColor = System.Drawing.Color.LightGray;
            this.grbCoach.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.grbCoach.BorderRadius = 10;
            this.grbCoach.Controls.Add(this.dgvCoach);
            this.grbCoach.Controls.Add(this.dtpCoachDOB);
            this.grbCoach.Controls.Add(this.txtCoachID);
            this.grbCoach.Controls.Add(this.txtCoachNation);
            this.grbCoach.Controls.Add(this.btnAddCoach);
            this.grbCoach.Controls.Add(this.btnDelCoach);
            this.grbCoach.Controls.Add(this.btnEditCoach);
            this.grbCoach.Controls.Add(this.txtCoachName);
            this.grbCoach.CustomBorderColor = System.Drawing.Color.Transparent;
            this.grbCoach.FillColor = System.Drawing.Color.LightGray;
            this.grbCoach.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCoach.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.grbCoach.Location = new System.Drawing.Point(12, 157);
            this.grbCoach.Name = "grbCoach";
            this.grbCoach.Size = new System.Drawing.Size(573, 366);
            this.grbCoach.TabIndex = 2;
            this.grbCoach.Text = "HEAD COACH";
            // 
            // dgvCoach
            // 
            this.dgvCoach.AllowUserToResizeColumns = false;
            this.dgvCoach.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.dgvCoach.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvCoach.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvCoach.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dgvCoach.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCoach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvCoach.ColumnHeadersHeight = 40;
            this.dgvCoach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CoachID,
            this.CoachName,
            this.Nation,
            this.CoachDOB});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCoach.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvCoach.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvCoach.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCoach.Location = new System.Drawing.Point(0, 40);
            this.dgvCoach.Name = "dgvCoach";
            this.dgvCoach.ReadOnly = true;
            this.dgvCoach.RowHeadersVisible = false;
            this.dgvCoach.RowHeadersWidth = 51;
            this.dgvCoach.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvCoach.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvCoach.RowTemplate.Height = 35;
            this.dgvCoach.Size = new System.Drawing.Size(573, 113);
            this.dgvCoach.TabIndex = 0;
            this.dgvCoach.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCoach.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvCoach.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvCoach.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvCoach.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvCoach.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvCoach.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCoach.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvCoach.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCoach.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCoach.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvCoach.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCoach.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvCoach.ThemeStyle.ReadOnly = true;
            this.dgvCoach.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvCoach.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dgvCoach.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvCoach.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCoach.ThemeStyle.RowsStyle.Height = 35;
            this.dgvCoach.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvCoach.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvCoach.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCoach_CellClick);
            this.dgvCoach.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCoach_CellContentClick);
            // 
            // CoachID
            // 
            this.CoachID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CoachID.DataPropertyName = "CoachID";
            this.CoachID.Frozen = true;
            this.CoachID.HeaderText = "Coach ID";
            this.CoachID.MinimumWidth = 6;
            this.CoachID.Name = "CoachID";
            this.CoachID.ReadOnly = true;
            this.CoachID.Width = 120;
            // 
            // CoachName
            // 
            this.CoachName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CoachName.DataPropertyName = "CoachName";
            this.CoachName.Frozen = true;
            this.CoachName.HeaderText = "Full Name";
            this.CoachName.MinimumWidth = 6;
            this.CoachName.Name = "CoachName";
            this.CoachName.ReadOnly = true;
            this.CoachName.Width = 170;
            // 
            // Nation
            // 
            this.Nation.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Nation.DataPropertyName = "Nation";
            this.Nation.Frozen = true;
            this.Nation.HeaderText = "Nation";
            this.Nation.MinimumWidth = 6;
            this.Nation.Name = "Nation";
            this.Nation.ReadOnly = true;
            this.Nation.Width = 150;
            // 
            // CoachDOB
            // 
            this.CoachDOB.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CoachDOB.DataPropertyName = "CoachDOB";
            this.CoachDOB.Frozen = true;
            this.CoachDOB.HeaderText = "DOB";
            this.CoachDOB.MinimumWidth = 6;
            this.CoachDOB.Name = "CoachDOB";
            this.CoachDOB.ReadOnly = true;
            this.CoachDOB.Width = 130;
            // 
            // dtpCoachDOB
            // 
            this.dtpCoachDOB.BorderRadius = 5;
            this.dtpCoachDOB.Checked = true;
            this.dtpCoachDOB.CustomFormat = "dd/MM/yyyy";
            this.dtpCoachDOB.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.dtpCoachDOB.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCoachDOB.ForeColor = System.Drawing.Color.White;
            this.dtpCoachDOB.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpCoachDOB.Location = new System.Drawing.Point(220, 184);
            this.dtpCoachDOB.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpCoachDOB.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpCoachDOB.Name = "dtpCoachDOB";
            this.dtpCoachDOB.Size = new System.Drawing.Size(186, 42);
            this.dtpCoachDOB.TabIndex = 3;
            this.dtpCoachDOB.Value = new System.DateTime(2023, 11, 4, 23, 22, 42, 542);
            // 
            // txtCoachID
            // 
            this.txtCoachID.BorderThickness = 3;
            this.txtCoachID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCoachID.DefaultText = "";
            this.txtCoachID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCoachID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCoachID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCoachID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCoachID.Enabled = false;
            this.txtCoachID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCoachID.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCoachID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.txtCoachID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCoachID.Location = new System.Drawing.Point(10, 185);
            this.txtCoachID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCoachID.Name = "txtCoachID";
            this.txtCoachID.PasswordChar = '\0';
            this.txtCoachID.PlaceholderText = "COACH ID";
            this.txtCoachID.SelectedText = "";
            this.txtCoachID.Size = new System.Drawing.Size(186, 42);
            this.txtCoachID.TabIndex = 1;
            // 
            // txtCoachNation
            // 
            this.txtCoachNation.BorderThickness = 3;
            this.txtCoachNation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCoachNation.DefaultText = "";
            this.txtCoachNation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCoachNation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCoachNation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCoachNation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCoachNation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCoachNation.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCoachNation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.txtCoachNation.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCoachNation.Location = new System.Drawing.Point(220, 259);
            this.txtCoachNation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCoachNation.Name = "txtCoachNation";
            this.txtCoachNation.PasswordChar = '\0';
            this.txtCoachNation.PlaceholderText = "NATION";
            this.txtCoachNation.SelectedText = "";
            this.txtCoachNation.Size = new System.Drawing.Size(186, 42);
            this.txtCoachNation.TabIndex = 4;
            // 
            // btnAddCoach
            // 
            this.btnAddCoach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.btnAddCoach.FlatAppearance.BorderSize = 0;
            this.btnAddCoach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCoach.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCoach.ForeColor = System.Drawing.Color.White;
            this.btnAddCoach.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnAddCoach.IconColor = System.Drawing.Color.White;
            this.btnAddCoach.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddCoach.IconSize = 25;
            this.btnAddCoach.Location = new System.Drawing.Point(429, 184);
            this.btnAddCoach.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddCoach.Name = "btnAddCoach";
            this.btnAddCoach.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAddCoach.Size = new System.Drawing.Size(133, 42);
            this.btnAddCoach.TabIndex = 5;
            this.btnAddCoach.Text = "Add";
            this.btnAddCoach.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddCoach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddCoach.UseVisualStyleBackColor = false;
            this.btnAddCoach.Click += new System.EventHandler(this.btnAddCoach_Click);
            // 
            // btnDelCoach
            // 
            this.btnDelCoach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.btnDelCoach.FlatAppearance.BorderSize = 0;
            this.btnDelCoach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelCoach.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelCoach.ForeColor = System.Drawing.Color.White;
            this.btnDelCoach.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.btnDelCoach.IconColor = System.Drawing.Color.White;
            this.btnDelCoach.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelCoach.IconSize = 25;
            this.btnDelCoach.Location = new System.Drawing.Point(429, 241);
            this.btnDelCoach.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelCoach.Name = "btnDelCoach";
            this.btnDelCoach.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDelCoach.Size = new System.Drawing.Size(133, 42);
            this.btnDelCoach.TabIndex = 6;
            this.btnDelCoach.Text = "Delete";
            this.btnDelCoach.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelCoach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelCoach.UseVisualStyleBackColor = false;
            this.btnDelCoach.Click += new System.EventHandler(this.btnDelCoach_Click);
            // 
            // btnEditCoach
            // 
            this.btnEditCoach.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.btnEditCoach.FlatAppearance.BorderSize = 0;
            this.btnEditCoach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditCoach.Font = new System.Drawing.Font("Segoe UI Semibold", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCoach.ForeColor = System.Drawing.Color.White;
            this.btnEditCoach.IconChar = FontAwesome.Sharp.IconChar.RotateBackward;
            this.btnEditCoach.IconColor = System.Drawing.Color.White;
            this.btnEditCoach.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEditCoach.IconSize = 25;
            this.btnEditCoach.Location = new System.Drawing.Point(429, 299);
            this.btnEditCoach.Margin = new System.Windows.Forms.Padding(5);
            this.btnEditCoach.Name = "btnEditCoach";
            this.btnEditCoach.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnEditCoach.Size = new System.Drawing.Size(133, 42);
            this.btnEditCoach.TabIndex = 7;
            this.btnEditCoach.Text = "Edit";
            this.btnEditCoach.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditCoach.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditCoach.UseVisualStyleBackColor = false;
            this.btnEditCoach.Click += new System.EventHandler(this.btnEditCoach_Click);
            // 
            // txtCoachName
            // 
            this.txtCoachName.BorderThickness = 3;
            this.txtCoachName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCoachName.DefaultText = "";
            this.txtCoachName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCoachName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCoachName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCoachName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCoachName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCoachName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtCoachName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.txtCoachName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCoachName.Location = new System.Drawing.Point(10, 259);
            this.txtCoachName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCoachName.Name = "txtCoachName";
            this.txtCoachName.PasswordChar = '\0';
            this.txtCoachName.PlaceholderText = "FULL NAME";
            this.txtCoachName.SelectedText = "";
            this.txtCoachName.Size = new System.Drawing.Size(186, 42);
            this.txtCoachName.TabIndex = 2;
            // 
            // lblNoteOfCoach
            // 
            this.lblNoteOfCoach.BackColor = System.Drawing.Color.Transparent;
            this.lblNoteOfCoach.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoteOfCoach.Location = new System.Drawing.Point(14, 112);
            this.lblNoteOfCoach.Name = "lblNoteOfCoach";
            this.lblNoteOfCoach.Size = new System.Drawing.Size(67, 39);
            this.lblNoteOfCoach.TabIndex = 1;
            this.lblNoteOfCoach.Text = "Note";
            this.lblNoteOfCoach.Click += new System.EventHandler(this.lblNoteOfCoach_Click);
            // 
            // msgNote
            // 
            this.msgNote.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.msgNote.Caption = null;
            this.msgNote.Icon = Guna.UI2.WinForms.MessageDialogIcon.None;
            this.msgNote.Parent = null;
            this.msgNote.Style = Guna.UI2.WinForms.MessageDialogStyle.Default;
            this.msgNote.Text = null;
            // 
            // lblNoteOfStadium
            // 
            this.lblNoteOfStadium.BackColor = System.Drawing.Color.Transparent;
            this.lblNoteOfStadium.Font = new System.Drawing.Font("Segoe UI", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoteOfStadium.Location = new System.Drawing.Point(14, 565);
            this.lblNoteOfStadium.Name = "lblNoteOfStadium";
            this.lblNoteOfStadium.Size = new System.Drawing.Size(67, 39);
            this.lblNoteOfStadium.TabIndex = 3;
            this.lblNoteOfStadium.Text = "Note";
            this.lblNoteOfStadium.Click += new System.EventHandler(this.lblNoteOfStadium_Click);
            // 
            // msgNotify
            // 
            this.msgNotify.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.msgNotify.Caption = null;
            this.msgNotify.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
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
            // grbPlayers
            // 
            this.grbPlayers.BackColor = System.Drawing.Color.LightGray;
            this.grbPlayers.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.grbPlayers.BorderRadius = 10;
            this.grbPlayers.Controls.Add(this.dgvPlayers);
            this.grbPlayers.CustomBorderColor = System.Drawing.Color.LightGray;
            this.grbPlayers.FillColor = System.Drawing.Color.Transparent;
            this.grbPlayers.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbPlayers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.grbPlayers.Location = new System.Drawing.Point(957, 157);
            this.grbPlayers.Name = "grbPlayers";
            this.grbPlayers.Size = new System.Drawing.Size(679, 831);
            this.grbPlayers.TabIndex = 6;
            this.grbPlayers.Text = "PLAYERS";
            // 
            // dgvPlayers
            // 
            this.dgvPlayers.AllowUserToResizeColumns = false;
            this.dgvPlayers.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.White;
            this.dgvPlayers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvPlayers.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPlayers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPlayers.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dgvPlayers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlayers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvPlayers.ColumnHeadersHeight = 45;
            this.dgvPlayers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Number,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPlayers.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvPlayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPlayers.GridColor = System.Drawing.Color.White;
            this.dgvPlayers.Location = new System.Drawing.Point(0, 40);
            this.dgvPlayers.Name = "dgvPlayers";
            this.dgvPlayers.ReadOnly = true;
            this.dgvPlayers.RowHeadersVisible = false;
            this.dgvPlayers.RowHeadersWidth = 51;
            this.dgvPlayers.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.dgvPlayers.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.dgvPlayers.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.dgvPlayers.RowTemplate.Height = 35;
            this.dgvPlayers.Size = new System.Drawing.Size(679, 791);
            this.dgvPlayers.TabIndex = 0;
            this.dgvPlayers.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPlayers.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPlayers.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPlayers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPlayers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPlayers.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPlayers.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.dgvPlayers.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvPlayers.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvPlayers.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPlayers.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPlayers.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPlayers.ThemeStyle.HeaderStyle.Height = 45;
            this.dgvPlayers.ThemeStyle.ReadOnly = true;
            this.dgvPlayers.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPlayers.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Single;
            this.dgvPlayers.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvPlayers.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPlayers.ThemeStyle.RowsStyle.Height = 35;
            this.dgvPlayers.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPlayers.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PlayerID";
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Player ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 120;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PlayerName";
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "Full Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 170;
            // 
            // Number
            // 
            this.Number.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Number.DataPropertyName = "Number";
            this.Number.Frozen = true;
            this.Number.HeaderText = "Number";
            this.Number.MinimumWidth = 6;
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 110;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nation";
            this.dataGridViewTextBoxColumn3.Frozen = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "Nation";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PlayerDOB";
            this.dataGridViewTextBoxColumn4.Frozen = true;
            this.dataGridViewTextBoxColumn4.HeaderText = "DOB";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 130;
            // 
            // FormClub
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1669, 902);
            this.Controls.Add(this.grbPlayers);
            this.Controls.Add(this.lblNoteOfStadium);
            this.Controls.Add(this.lblNoteOfCoach);
            this.Controls.Add(this.grbCoach);
            this.Controls.Add(this.grbStadium);
            this.Controls.Add(this.lblClubName);
            this.Controls.Add(this.picClubLogo);
            this.Controls.Add(this.btnBack);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormClub";
            this.Text = "Club";
            this.Load += new System.EventHandler(this.FormClub_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picClubLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStadium)).EndInit();
            this.grbStadium.ResumeLayout(false);
            this.grbCoach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoach)).EndInit();
            this.grbPlayers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnBack;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblClubName;
        private Guna.UI2.WinForms.Guna2PictureBox picClubLogo;
        private Guna.UI2.WinForms.Guna2GroupBox grbStadium;
        private Guna.UI2.WinForms.Guna2DataGridView dgvStadium;
        private Guna.UI2.WinForms.Guna2TextBox txtLocation;
        private Guna.UI2.WinForms.Guna2TextBox txtCapacity;
        private FontAwesome.Sharp.IconButton btnAddStadium;
        private Guna.UI2.WinForms.Guna2TextBox txtSize;
        private FontAwesome.Sharp.IconButton btnDelStadium;
        private Guna.UI2.WinForms.Guna2TextBox txtStadiumName;
        private FontAwesome.Sharp.IconButton btnEditStadium;
        private Guna.UI2.WinForms.Guna2TextBox txtStadiumID;
        private Guna.UI2.WinForms.Guna2GroupBox grbCoach;
        private Guna.UI2.WinForms.Guna2DataGridView dgvCoach;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpCoachDOB;
        private Guna.UI2.WinForms.Guna2TextBox txtCoachID;
        private Guna.UI2.WinForms.Guna2TextBox txtCoachNation;
        private FontAwesome.Sharp.IconButton btnAddCoach;
        private FontAwesome.Sharp.IconButton btnDelCoach;
        private FontAwesome.Sharp.IconButton btnEditCoach;
        private Guna.UI2.WinForms.Guna2TextBox txtCoachName;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpBuiltTime;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNoteOfCoach;
        private Guna.UI2.WinForms.Guna2MessageDialog msgNote;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblNoteOfStadium;
        private Guna.UI2.WinForms.Guna2MessageDialog msgNotify;
        private Guna.UI2.WinForms.Guna2MessageDialog msgConfirm;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoachID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoachName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nation;
        private System.Windows.Forms.DataGridViewTextBoxColumn CoachDOB;
        private Guna.UI2.WinForms.Guna2GroupBox grbPlayers;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPlayers;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn StadiumID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StadiumName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Size;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Location;
        private System.Windows.Forms.DataGridViewTextBoxColumn BuiltTime;
    }
}