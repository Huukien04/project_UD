using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Color = System.Drawing.Color;

namespace ProjectLTUD
{
    public partial class FormMain : Form
    {
        ConnectDatabase data;
        string serverName, dbName;

        #region UI
        // Fields
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;

        public FormMain()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 70);
            pnlMenu.Controls.Add(leftBorderBtn);

            // Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(153, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        private void ActivateBtn(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableBtn();
                // Button
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                // Left border button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                // Icon current child form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
                lblCurrentChildForm.ForeColor = color;
            }
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                // Open only form
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlDesktop.Controls.Add(childForm);
            childForm.BringToFront();
            childForm.Show();
            lblCurrentChildForm.Text = childForm.Text;
        }

        private void DisableBtn()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(55, 0, 60);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void btnPlayers_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, RGBColors.color1);
            OpenChildForm(new FormPlayers(serverName, dbName));
        }

        private void btnTeams_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, RGBColors.color2);
            OpenChildForm(new FormClubs(serverName, dbName));
        }

        private void btnMatches_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, RGBColors.color3);
            OpenChildForm(new FormMatches(serverName, dbName));
        }

        private void btnStandings_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, RGBColors.color4);
            OpenChildForm(new FormStandings(serverName, dbName));
        }

        private void btnStats_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, RGBColors.color5);
            OpenChildForm(new FormStats(serverName, dbName));
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            ActivateBtn(sender, RGBColors.color6);
            OpenChildForm(new FormSetting());
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
            Reset();
        }

        private void Reset()
        {
            DisableBtn();
            leftBorderBtn.Visible = false;
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.MediumPurple;
            lblCurrentChildForm.Text = "Home";
        }
        // Drag form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnMinimumSize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximunSize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
            else
                WindowState = FormWindowState.Normal;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion


        private void btnConnect_Click(object sender, EventArgs e)
        {
            serverName = txtServerName.Text;
            dbName = txtDBName.Text;

            if (string.IsNullOrEmpty(serverName) || string.IsNullOrEmpty(dbName))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ConnectDatabase data = new ConnectDatabase(serverName, dbName);
            try
            {
                data.OpenConnect();
                MessageBox.Show("Kết nối thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnPlayers.Enabled = true;
                btnClubs.Enabled = true;
                btnMatches.Enabled = true;
                btnStandings.Enabled = true;
                btnStats.Enabled = true;
                btnSetting.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kết nối: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                data.CloseConnection();
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        internal void GetServerAndDBName(string serverName, string dbName)
        {
            this.serverName = serverName;
            this.dbName = dbName;
            data = new ConnectDatabase(serverName, dbName);
        }
    }
}
