namespace ProjectLTUD
{
    partial class Form1
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
            this.txtServerName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtDBName = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnConnect = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // txtServerName
            // 
            this.txtServerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtServerName.DefaultText = "";
            this.txtServerName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtServerName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtServerName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtServerName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtServerName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtServerName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtServerName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtServerName.Location = new System.Drawing.Point(118, 55);
            this.txtServerName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.PasswordChar = '\0';
            this.txtServerName.PlaceholderText = "Server Name";
            this.txtServerName.SelectedText = "";
            this.txtServerName.Size = new System.Drawing.Size(229, 48);
            this.txtServerName.TabIndex = 0;
            // 
            // txtDBName
            // 
            this.txtDBName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDBName.DefaultText = "";
            this.txtDBName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDBName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDBName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDBName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDBName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDBName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDBName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDBName.Location = new System.Drawing.Point(118, 167);
            this.txtDBName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDBName.Name = "txtDBName";
            this.txtDBName.PasswordChar = '\0';
            this.txtDBName.PlaceholderText = "Database Name";
            this.txtDBName.SelectedText = "";
            this.txtDBName.Size = new System.Drawing.Size(229, 48);
            this.txtDBName.TabIndex = 1;
            // 
            // btnConnect
            // 
            this.btnConnect.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConnect.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConnect.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConnect.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConnect.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnConnect.ForeColor = System.Drawing.Color.White;
            this.btnConnect.Location = new System.Drawing.Point(118, 252);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(180, 45);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtDBName);
            this.Controls.Add(this.txtServerName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtServerName;
        private Guna.UI2.WinForms.Guna2TextBox txtDBName;
        private Guna.UI2.WinForms.Guna2Button btnConnect;
    }
}