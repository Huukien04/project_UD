using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Web.Configuration;
using System.Windows.Forms;
using System.Windows.Input;
using System.Xml.Linq;

namespace ProjectLTUD
{
    public partial class FormClub : Form
    {
        ConnectDatabase data = new ConnectDatabase();
        string idClub;


        // Tạo dictionary để ánh xạ giữa tên và mã đội bóng
        Dictionary<string, string> idClubs = new Dictionary<string, string>()
        {
            {"Arsenal","ARS"},
            {"Aston Villa","AVL"},
            {"Bournemouth","BOU"},
            {"Brentford","BRE"},
            {"Brighton","BHA"},
            {"Burnley FC","BUR"},
            {"Chelsea","CHE"},
            {"Crystal Palace","CRY"},
            {"Everton","EVE"},
            {"Fulham","FUL"},
            {"Liverpool","LIV"},
            {"Luton Town","ARS"},
            {"Manchester City","MCI"},
            {"Manchester United","MUN"},
            {"Newcastle","NEW"},
            {"Nottingham Forest","NFO"},
            {"Sheffield United","SHU"},
            {"Tottenham","TOT"},
            {"West Ham United","WHU"},
            {"Wolverhampton","WOL"}
        };


        // Phương thức lấy mã đội bóng bằng tên đội bóng
        private string GetClubID(string nameClub)
        {
            if (idClubs.TryGetValue(nameClub, out string clubID))
                return clubID;

            else
                return "N/A";
        }


        public FormClub(string serverName, string dbName)
        {
            InitializeComponent();
            data = new ConnectDatabase(serverName, dbName);
            dtpCoachDOB.Format = DateTimePickerFormat.Short;
            dtpBuiltTime.Format = DateTimePickerFormat.Short;
            dtpCoachDOB.Value = DateTime.Now;
            dtpBuiltTime.Value = DateTime.Now;
        }


        internal void SetClubLogo(Bitmap clubLogoPath)
        {
            picClubLogo.Image = clubLogoPath;
        }


        internal void SetTeamInfo(string nameClub)
        {
            lblClubName.Text = nameClub;
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            FormClubs frm = Application.OpenForms.OfType<FormClubs>().FirstOrDefault();
            if (frm != null)
                frm.Show();
        }


        private void FormClub_Load(object sender, EventArgs e)
        {
            idClub = GetClubID(lblClubName.Text).ToUpper();

            dgvCoach.DataSource = data.LoadDataByID("usp_ShowCoachByClubID", "@ClubID", idClub);

            dgvStadium.DataSource = data.LoadDataByID("usp_ShowStadiumByClubID", "@ClubID", idClub);

            dgvPlayers.DataSource = data.LoadDataByID("usp_ShowPlayers", "@ClubID", idClub);
        }


        private void dgvCoach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvCoach.Rows.Count)
            {
                DataGridViewRow selectRow = dgvCoach.Rows[e.RowIndex];
                txtCoachID.Text = selectRow.Cells["CoachID"]?.Value?.ToString() ?? string.Empty;
                txtCoachName.Text = selectRow.Cells["CoachName"]?.Value?.ToString() ?? string.Empty;
                txtCoachNation.Text = selectRow.Cells["Nation"]?.Value?.ToString() ?? string.Empty;

                if (selectRow.Cells["CoachDOB"]?.Value is DateTime)
                    dtpCoachDOB.Value = (DateTime)selectRow.Cells["CoachDOB"].Value;
                else
                    dtpCoachDOB.Value = DateTime.Now;
            }
            else
                ClearCoachFields();
        }


        // Clear các textbox ở trong groupbox Head Coach
        private void ClearCoachFields()
        {
            txtCoachID.Clear();
            txtCoachName.Clear();
            txtCoachNation.Clear();
            dtpCoachDOB.Value = DateTime.Now;
        }


        private void dgvStadium_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvCoach.Rows.Count)
            {
                DataGridViewRow selectRow = dgvStadium.Rows[e.RowIndex];
                txtStadiumID.Text = selectRow.Cells["StadiumID"]?.Value?.ToString() ?? string.Empty;
                txtStadiumName.Text = selectRow.Cells["StadiumName"]?.Value?.ToString() ?? string.Empty;
                txtSize.Text = selectRow.Cells["Size"]?.Value?.ToString() ?? string.Empty;
                txtCapacity.Text = selectRow.Cells["Capacity"]?.Value?.ToString() ?? string.Empty;
                txtLocation.Text = selectRow.Cells["Location"]?.Value?.ToString() ?? string.Empty;

                if (selectRow.Cells["BuiltTime"]?.Value is DateTime)
                    dtpBuiltTime.Value = (DateTime)selectRow.Cells["BuiltTime"].Value;
                else
                    dtpBuiltTime.Value = DateTime.Now;
            }
            else
                ClearStadiumFields();
        }


        // Clear các textbox ở trong groupbox Stadium
        private void ClearStadiumFields()
        {
            txtStadiumID.Clear();
            txtStadiumName.Clear();
            txtSize.Clear();
            txtCapacity.Clear();
            txtLocation.Clear();
            dtpBuiltTime.Value = DateTime.Now;
        }


        private void lblNoteOfCoach_Click(object sender, EventArgs e)
        {
            msgNote.Show("Each team has 1 head coach. If you want to add a new head coach, please delete the current head coach.");
        }


        private void lblNoteOfStadium_Click(object sender, EventArgs e)
        {
            msgNote.Show("Each team has 1 stadium. If you want to add a new stadium, please delete the current stadium.");
        }


        // Button add coach
        private void btnAddCoach_Click(object sender, EventArgs e)
        {
            string coachID = "Coach_" + idClub;

            using (SqlCommand cmd = new SqlCommand())
            {
                data.InitializeCommand("usp_AddCoach", cmd);
                cmd.Parameters.AddWithValue("@CoachID", coachID);
                cmd.Parameters.AddWithValue("@ClubID", idClub);
                cmd.Parameters.AddWithValue("@CoachName", txtCoachName.Text);
                cmd.Parameters.AddWithValue("@Nation", txtCoachNation.Text);
                cmd.Parameters.AddWithValue("@CoachDOB", dtpCoachDOB.Value.ToString("yyyy-MM-dd"));
                
                try
                {
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                        msgNotify.Show("Coach added successfully");
                    else
                        msgNotify.Show("A coach already exists for this team. Please delete the current coach before adding a new one.");
                    dgvCoach.DataSource = data.LoadDataByID("usp_ShowCoachByClubID", "@ClubID", idClub);
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                        msgNotify.Show("A coach already exists for this team. Please delete the current coach before adding a new one.");
                    else
                        msgNotify.Show($"An error occurred: {ex.Message}");
                }
            }
        }


        // Button delete coach
        private void btnDelCoach_Click(object sender, EventArgs e)
        {
            DialogResult result = msgConfirm.Show("Are you sure to delete ?", "Confirm");
            if (result == DialogResult.Yes)
            {
                string coachID = "Coach_" + idClub;
                using (SqlCommand cmd = new SqlCommand())
                {
                    data.InitializeCommand("usp_DeleteCoach", cmd);
                    cmd.Parameters.AddWithValue("@CoachID", coachID);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        msgNotify.Show("Coach deleted successfully");
                        dgvCoach.DataSource = data.LoadDataByID("usp_ShowCoachByClubID", "@ClubID", idClub);
                    }
                    catch (SqlException ex)
                    {
                        msgNotify.Show("Coach not exist " + ex.Message);
                    }
                }
            }
        }


        // Button edit coach
        private void btnEditCoach_Click(object sender, EventArgs e)
        {
            string coachID = "Coach_" + idClub;
            if (txtCoachID.Text != "")
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    data.InitializeCommand("usp_EditCoach", cmd);
                    cmd.Parameters.AddWithValue("@CoachID", coachID);
                    cmd.Parameters.AddWithValue("@ClubID", idClub);
                    cmd.Parameters.AddWithValue("@CoachName", txtCoachName.Text);
                    cmd.Parameters.AddWithValue("@Nation", txtCoachNation.Text);
                    cmd.Parameters.AddWithValue("@CoachDOB", dtpCoachDOB.Value.ToString("yyyy-MM-dd"));
                    try
                    {
                        cmd.ExecuteNonQuery();
                        msgNotify.Show("Coach edited successfully");
                        dgvCoach.DataSource = data.LoadDataByID("usp_ShowCoachByClubID", "@ClubID", idClub);
                    }
                    catch (SqlException ex)
                    {
                        msgNotify.Show("Edit failed " + ex.Message);
                    }
                }
            }
            else
                msgNotify.Show("Edit failed!");
        }


        // Button add stadium
        private void btnAddStadium_Click(object sender, EventArgs e)
        {
            string stadiumID = "Stadium_" + idClub;
            using (SqlCommand cmd = new SqlCommand())
            {
                data.InitializeCommand("usp_AddStadium", cmd);
                cmd.Parameters.AddWithValue("@StadiumID", stadiumID);
                cmd.Parameters.AddWithValue("@ClubID", idClub);
                cmd.Parameters.AddWithValue("@StadiumName", txtStadiumName.Text);
                cmd.Parameters.AddWithValue("@Size", txtSize.Text);
                cmd.Parameters.AddWithValue("@Capacity", txtCapacity.Text);
                cmd.Parameters.AddWithValue("@Location", txtLocation.Text);
                cmd.Parameters.AddWithValue("@BuiltTime", dtpBuiltTime.Value.ToString("yyyy-MM-dd"));
                try
                {
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                        msgNotify.Show("Stadium added successfully");
                    else
                        msgNotify.Show("A stadium already exists for this team. Please delete the current stadium before adding a new one.");
                    dgvStadium.DataSource = data.LoadDataByID("usp_ShowStadiumByClubID", "@ClubID", idClub);
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                        msgNotify.Show("A stadium already exists for this team. Please delete the current stadium before adding a new one.");
                    else
                        msgNotify.Show($"An error occurred: {ex.Message}");
                }
            }
        }


        // Button delete stadium
        private void btnDelStadium_Click(object sender, EventArgs e)
        {
            DialogResult result = msgConfirm.Show("Are you sure to delete ?", "Confirm");
            if (result == DialogResult.Yes)
            {
                string stadiumID = "Stadium_" + idClub;
                using (SqlCommand cmd = new SqlCommand())
                {
                    data.InitializeCommand("usp_DeleteStadium", cmd);
                    cmd.Parameters.AddWithValue("@StadiumID", stadiumID);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        msgNotify.Show("Stadium deleted successfully");
                        dgvStadium.DataSource = data.LoadDataByID("usp_ShowStadiumByClubID", "@ClubID", idClub);
                    }
                    catch (SqlException ex)
                    {
                        msgNotify.Show("Delete failed " + ex.Message);
                    }
                }
            }
        }


        // Button edit stadium
        private void btnEditStadium_Click(object sender, EventArgs e)
        {
            string stadiumID = "Stadium_" + idClub;
            if (txtCoachID.Text != "")
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    data.InitializeCommand("usp_EditStadium", cmd);
                    cmd.Parameters.AddWithValue("@StadiumID", stadiumID);
                    cmd.Parameters.AddWithValue("@ClubID", idClub);
                    cmd.Parameters.AddWithValue("@StadiumName", txtStadiumName.Text);
                    cmd.Parameters.AddWithValue("@Size", txtSize.Text);
                    cmd.Parameters.AddWithValue("@Capacity", txtCapacity.Text);
                    cmd.Parameters.AddWithValue("@Location", txtLocation.Text);
                    cmd.Parameters.AddWithValue("@BuiltTime", dtpBuiltTime.Value.ToString("yyyy-MM-dd"));
                    try
                    {
                        cmd.ExecuteNonQuery();
                        msgNotify.Show("Stadium edited successfully");
                        dgvStadium.DataSource = data.LoadDataByID("usp_ShowStadiumByClubID", "@ClubID", idClub);
                    }
                    catch (SqlException ex)
                    {
                        msgNotify.Show("Edit failed " + ex.Message);
                    }
                }
            }
            else
                msgNotify.Show($"Edit failed!");
        }

        private void dgvCoach_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
