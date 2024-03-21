using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProjectLTUD
{
    public partial class FormPlayers : Form
    {
        ConnectDatabase data = new ConnectDatabase();

        // Tạo dictionary để ánh xạ giữa mã và tên đội bóng
        Dictionary<string, string> clubNames = new Dictionary<string, string>()
        {
            {"", "NONE"},
            {"ARS", "Arsenal"},
            {"AVL", "Aston Villa"},
            {"BOU", "Bournemouth"},
            {"BRE", "Brentford"},
            {"BHA", "Brighton"},
            {"BUR", "Burnley FC"},
            {"CHE", "Chelsea"},
            {"CRY", "Crystal Palace"},
            {"EVE", "Everton"},
            {"FUL", "Fulham"},
            {"LIV", "Liverpool"},
            {"LUT", "Luton Town FC"},
            {"MCI", "Manchester City"},
            {"MUN", "Manchester United"},
            {"NEW", "Newcastle"},
            {"NFO", "Nottingham Forest"},
            {"SHU", "Sheffield United"},
            {"TOT", "Tottenham"},
            {"WHU", "West Ham United"},
            {"WOL", "Wolverhampton"}
        };


        private string GetNameClub(string clubID)
        {
            if (clubNames.TryGetValue(clubID, out string clubName))
                return clubName;

            else
                return "N/A";
        }


        public FormPlayers(string serverName, string dbName)
        {
            InitializeComponent();
            data = new ConnectDatabase(serverName, dbName);
            dtpDOB.Format = DateTimePickerFormat.Short;
            dtpDOB.Value = DateTime.Now;
        }


        private void FormPlayers_Load(object sender, EventArgs e)
        {
            dgvPlayer.DataSource = data.LoadData("usp_ShowAllPlayers");
        }


        private void dgvPlayer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvPlayer.Rows.Count)
            {
                DataGridViewRow selectRow = dgvPlayer.Rows[e.RowIndex];

                string idClub = selectRow.Cells["ClubID"]?.Value?.ToString().Trim() ?? string.Empty;

                string fullClubName = GetNameClub(idClub);

                cboClubs.Text = fullClubName;

                cboFoot.Text = selectRow.Cells["Foot"]?.Value?.ToString() ?? string.Empty;

                txtPlayerID.Text = selectRow.Cells["PlayerID"]?.Value?.ToString() ?? string.Empty;

                txtName.Text = selectRow.Cells["PlayerName"]?.Value?.ToString() ?? string.Empty;

                txtNumber.Text = selectRow.Cells["Number"]?.Value?.ToString() ?? string.Empty;

                txtNation.Text = selectRow.Cells["Nation"]?.Value?.ToString() ?? string.Empty;

                txtHeight.Text = selectRow.Cells["Height"]?.Value?.ToString() ?? string.Empty;

                txtWeight.Text = selectRow.Cells["Weight"]?.Value?.ToString() ?? string.Empty;

                txtSalary.Text = selectRow.Cells["Salary"]?.Value?.ToString() ?? string.Empty;

                cboPosition.Text = selectRow.Cells["Position"]?.Value?.ToString() ?? string.Empty;

                if (selectRow.Cells["PlayerDOB"]?.Value is DateTime)
                    dtpDOB.Value = (DateTime)selectRow.Cells["PlayerDOB"].Value;
                else
                    dtpDOB.Value = DateTime.Now;
            }
            else
                ClearPlayerFields();
        }


        private void ClearPlayerFields()
        {
            txtPlayerID.Enabled = true;
            txtPlayerID.Clear();
            txtPlayerID.Enabled = false;
            txtName.Clear();
            txtNumber.Clear();
            txtNation.Clear();
            txtHeight.Clear();
            txtWeight.Clear();
            txtSalary.Clear();
            cboPosition.SelectedIndex = -1;
            cboClubs.SelectedIndex = -1;
            cboFoot.SelectedIndex = -1;
            dtpDOB.Value = DateTime.Now;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearPlayerFields();
        }


        private string GetIDByClubName(string clubName)
        {
            return clubNames.FirstOrDefault(x => x.Value == clubName).Key;
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!CheckClubAndNameField())
                return; 
            
            string clubID = GetIDByClubName(cboClubs.SelectedItem.ToString());

            using (SqlCommand cmd = new SqlCommand())
            {
                data.InitializeCommand("usp_AddPlayer", cmd);
                cmdParameters(cmd, clubID);

                try
                {
                    cmd.ExecuteNonQuery();
                    msgNotify.Show("Player added successfully");
                    dgvPlayer.DataSource = data.LoadData("usp_ShowAllPlayers");
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                        msgNotify.Show("A player with the same name already exists. Please choose a different name.");

                    else
                        msgNotify.Show("An error occurred: " + ex.Message);

                }
            }
            ClearPlayerFields();
        }


        private void cmdParameters(SqlCommand cmd, string clubID)
        {
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@ClubID", clubID);

            cmd.Parameters.AddWithValue("@Number", txtNumber.Text == "" ? "" : txtNumber.Text.Trim());

            cmd.Parameters.AddWithValue("@PlayerName", txtName.Text.Trim());

            cmd.Parameters.AddWithValue("@Nation", txtNation.Text.Trim());

            cmd.Parameters.AddWithValue("@Height", txtHeight.Text == "" ? "" : txtHeight.Text.Trim());

            cmd.Parameters.AddWithValue("@Weight", txtWeight.Text == "" ? "" : txtWeight.Text.Trim());

            cmd.Parameters.AddWithValue("@PlayerDOB", dtpDOB.Value);

            cmd.Parameters.AddWithValue("@Salary", txtSalary.Text == "" ? "" : txtSalary.Text.Trim());

            cmd.Parameters.AddWithValue("@Position", cboPosition.SelectedIndex == -1 ? "" : cboPosition.SelectedItem.ToString());

            cmd.Parameters.AddWithValue("@Foot", cboPosition.SelectedIndex == -1 ? "" : cboFoot.SelectedItem.ToString());
        }


        private void btnDel_Click(object sender, EventArgs e)
        {
            DialogResult result = msgConfirm.Show($"Are your sure to delete {txtName.Text} ?", "Confirm");
            if (result == DialogResult.Yes)
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    data.InitializeCommand("usp_DeletePlayer", cmd);
                    cmd.Parameters.AddWithValue("@PlayerID", txtPlayerID.Text);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        msgNotify.Show("Player deleted successfully");
                        dgvPlayer.DataSource = data.LoadData("usp_ShowAllPlayers");
                    }
                    catch (SqlException ex)
                    {
                        msgNotify.Show("Delete failed " + ex.Message);
                    }
                }
            }
            ClearPlayerFields();
        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!CheckClubAndNameField())
                return;
            
            string clubID = GetIDByClubName(cboClubs.SelectedItem.ToString());

            using (SqlCommand cmd = new SqlCommand())
            {
                data.InitializeCommand("usp_EditPlayer", cmd);
                cmdParameters(cmd, clubID);
                cmd.Parameters.AddWithValue("@PlayerID", txtPlayerID.Text);

                try
                {
                    cmd.ExecuteNonQuery();
                    msgNotify.Show("Player edited successfully");
                    dgvPlayer.DataSource = data.LoadData("usp_ShowAllPlayers");
                }
                catch (SqlException ex)
                {
                    msgNotify.Show("Edit failed " + ex.Message);
                }
            }
            ClearPlayerFields();
        }


        private bool CheckClubAndNameField()
        {
            if (cboClubs.SelectedIndex == -1)
            {
                msgNotify.Show("You haven't select a club!");
                return false;
            }
            if (txtName.Text == "")
            {
                msgNotify.Show("Player name not null!");
                return false;
            }
            return true;
        }


        private void cboFindPlayerByTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFindPlayerByTeam.SelectedIndex > 0)
            {
                string fullClubName = cboFindPlayerByTeam.SelectedItem.ToString();
                string clubID = GetIDByClubName(fullClubName);
                using (SqlCommand cmd = new SqlCommand())
                {
                    dgvPlayer.DataSource = data.LoadDataByID("usp_ShowPlayerByClubID", "@ClubID", clubID);
                }
            }
            else
                dgvPlayer.DataSource = data.LoadData("usp_ShowAllPlayers");

        }


        private void btnFindID_Click(object sender, EventArgs e)
        {
            if (txtFindID.Text != "")
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    dgvPlayer.DataSource = data.LoadDataByID("usp_ShowPlayerByID", "@PlayerID", txtFindID.Text);
                    txtFindID.Clear();
                }
            }
            else
                return;
        }


        private void btnFindName_Click(object sender, EventArgs e)
        {
            if (txtFindName.Text != "")
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    dgvPlayer.DataSource = data.LoadDataByID("usp_ShowPlayerByName", "@PlayerName", txtFindName.Text);
                    txtFindName.Clear();
                }
            }
            else
                return;
        }


        private void FormPlayers_MouseClick(object sender, MouseEventArgs e)
        {
            dgvPlayer.DataSource = data.LoadData("usp_ShowAllPlayers");
        }

        
    }
}
