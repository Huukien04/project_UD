using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProjectLTUD
{
    public partial class FormMatches : Form
    {
        ConnectDatabase data = new ConnectDatabase();
        string serverName, dbName;

        // Tạo dictionary để ánh xạ giữa mã và tên đội bóng
        Dictionary<string, string> clubNames = new Dictionary<string, string>()
        {
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

        private string GetIDByClubName(string clubName)
        {
            return clubNames.FirstOrDefault(x => x.Value == clubName).Key;
        }


        // Tạo dictionary để ánh xạ giữa mã và tên vòng đấu
        Dictionary<string, string> roundNames = new Dictionary<string, string>()
        {
            {"MW1", "Matchweek 1"},
            {"MW2", "Matchweek 2"},
            {"MW3", "Matchweek 3"},
            {"MW4", "Matchweek 4"},
            {"MW5", "Matchweek 5"},
            {"MW6", "Matchweek 6"},
            {"MW7", "Matchweek 7"},
            {"MW8", "Matchweek 8"},
            {"MW9", "Matchweek 9"},
            {"MW10", "Matchweek 10"},
            {"MW11", "Matchweek 11"},
            {"MW12", "Matchweek 12"},
            {"MW13", "Matchweek 13"},
            {"MW14", "Matchweek 14"},
            {"MW15", "Matchweek 15"},
            {"MW16", "Matchweek 16"},
            {"MW17", "Matchweek 17"},
            {"MW18", "Matchweek 18"},
            {"MW19", "Matchweek 19"},
            {"MW20", "Matchweek 20"}
        };

        private string GetIDByMatchweek(string matchweekName)
        {
            return roundNames.FirstOrDefault(x => x.Value == matchweekName).Key;
        }

        private string GetRoundName(string roundID)
        {
            if (roundNames.TryGetValue(roundID, out string roundName))
                return roundName;

            else
                return "N/A";
        }


        public FormMatches(string serverName, string dbName)
        {
            InitializeComponent();
            this.serverName = serverName;
            this.dbName = dbName;
            data = new ConnectDatabase(serverName, dbName);
            dtpMatchTime.Format = DateTimePickerFormat.Custom;
            dtpMatchTime.CustomFormat = "  HH:mm:ss  dd/MM/yyyy";
            
            this.Load += new EventHandler(FormMatches_Load);
        }

        private void FormMatches_Load(object sender, EventArgs e)
        {
            dgvMatch.DataSource = data.LoadData("usp_ShowAllMatches");
            dgvMatch.Size = new System.Drawing.Size(705, 694);
            lblFindMW.Size = new System.Drawing.Size(149, 40);
            cboFindMW.Size = new System.Drawing.Size(190, 36);
            btnAddMatch.Size = new System.Drawing.Size(133, 42);
            btnEditMatch.Size = new System.Drawing.Size(133, 42);
            btnDelMatch.Size = new System.Drawing.Size(133, 42);
            btnRefresh.Size = new System.Drawing.Size(133, 42);
            btnPlayersAwayInMatch.Size = new System.Drawing.Size(282, 42);
            btnPlayersHomeInMatch.Size = new System.Drawing.Size(282, 42);
            btnMatchDetail.Size = new System.Drawing.Size(282, 42);
            grbMatchInfo.Size = new System.Drawing.Size(701, 281);
            lblMW.Size = new System.Drawing.Size(149, 40);
            lblHome.Size = new System.Drawing.Size(159, 40);
            lblAway.Size = new System.Drawing.Size(150, 40);
            cboMW.Size = new System.Drawing.Size(233, 36);
            cboHome.Size = new System.Drawing.Size(233, 36);
            cboAway.Size = new System.Drawing.Size(233, 36);
            txtMatchID.Size = new System.Drawing.Size(244, 42);
            txtMatchName.Size = new System.Drawing.Size(244, 42);
            dtpMatchTime.Size = new System.Drawing.Size(244, 42);

            btnAddMatch.Location = new System.Drawing.Point(863, 446);
            btnRefresh.Location = new System.Drawing.Point(863, 514);
            btnEditMatch.Location = new System.Drawing.Point(1073, 446);
            btnDelMatch.Location = new System.Drawing.Point(1073, 514);
            btnPlayersHomeInMatch.Location = new System.Drawing.Point(1281, 447);
            btnPlayersAwayInMatch.Location = new System.Drawing.Point(1281, 513);
            btnMatchDetail.Location = new System.Drawing.Point(1281, 582);

            grbMatchInfo.Location = new System.Drawing.Point(863, 137);
            lblMW.Location = new System.Drawing.Point(14, 54);
            lblHome.Location = new System.Drawing.Point(14, 133);
            lblAway.Location = new System.Drawing.Point(14, 207);
            cboMW.Location = new System.Drawing.Point(180, 54);
            cboHome.Location = new System.Drawing.Point(180, 133);
            cboAway.Location = new System.Drawing.Point(180, 207);
            txtMatchID.Location = new System.Drawing.Point(441, 54);
            txtMatchName.Location = new System.Drawing.Point(441, 133);
            dtpMatchTime.Location = new System.Drawing.Point(441, 207);


        }

        private void cboFindMW_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboFindMW.SelectedIndex >= 0)
            {
                if (cboFindMW.SelectedIndex == 0)
                {
                    dgvMatch.DataSource = data.LoadData("usp_ShowAllMatches");
                }
                else
                {
                    string selectedMatchweek = cboFindMW.SelectedItem.ToString();
                    string roundID = GetIDByMatchweek(selectedMatchweek);

                    dgvMatch.DataSource = data.LoadDataByID("usp_ShowMatchByRoundID", "@RoundID", roundID);
                }
            }
        }

        private void dgvMatch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearAllFields();
            if (e.RowIndex >= 0 && e.RowIndex < dgvMatch.Rows.Count)
            {
                cboMW.Enabled = false;
                cboHome.Enabled = false;
                cboAway.Enabled = false;

                DataGridViewRow selectRow = dgvMatch.Rows[e.RowIndex];

                string roundID = selectRow.Cells["RoundID"]?.Value?.ToString().Trim() ?? string.Empty;
                string roundName = GetRoundName(roundID);

                cboMW.Text = roundName;

                DisplayHomeAndAwayTeamToCombobox(selectRow);

                txtMatchID.Text = selectRow.Cells["MatchID"]?.Value?.ToString().Trim() ?? string.Empty;
                txtMatchName.Text = selectRow.Cells["MatchName"]?.Value?.ToString().Trim() ?? string.Empty;

                if (selectRow.Cells["MatchTime"]?.Value is DateTime)
                    dtpMatchTime.Value = (DateTime)selectRow.Cells["MatchTime"].Value;
                else
                    dtpMatchTime.Value = DateTime.Now;
            }
            else
                ClearAllFields();
        }

        private void DisplayHomeAndAwayTeamToCombobox(DataGridViewRow selectRow)
        {
            string matchID = selectRow.Cells["MatchID"]?.Value?.ToString().Trim() ?? string.Empty;

            // Tách chuỗi lần 1 từ "MW1_LIV-MUN" -> "MW1_LIV" và "MUN"
            string[] str1 = matchID.Split('-');
            string part1 = str1[0].Trim();
            string awayID = str1[1].Trim();

            // Tách chuỗi lần 2 từ "MW1_LIV" -> "MW1" và "LIV"
            string[] str2 = part1.Split('_');
            string roundID = str2[0].Trim();
            string homeID = str2[1].Trim();

            string homeClubName = GetNameClub(homeID);
            string awayClubName = GetNameClub(awayID);

            cboHome.Text = homeClubName;
            cboAway.Text = awayClubName;
        }

        private void ClearAllFields()
        {
            cboMW.SelectedIndex = -1;
            cboHome.SelectedIndex = -1;
            cboAway.SelectedIndex = -1;

            txtMatchID.Enabled = true;
            txtMatchID.Clear();
            txtMatchID.Enabled = false;

            txtMatchName.Enabled = true;
            txtMatchName.Clear();
            txtMatchName.Enabled = false;

            dtpMatchTime.Value = DateTime.Now;
            cboMW.Enabled = true;
            cboHome.Enabled = true;
            cboAway.Enabled = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearAllFields();
        }

        private void cboMW_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayMatchID();
        }

        private void cboHome_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayMatchID();
        }

        private void cboAway_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayMatchID();
        }

        private void DisplayMatchID()
        {
            if (cboHome.SelectedIndex != -1 && cboAway.SelectedIndex != -1 && cboMW.SelectedIndex != -1)
            {
                string matchweekID = GetIDByMatchweek(cboMW.SelectedItem.ToString());
                string homeID = GetIDByClubName(cboHome.Text);
                string awayID = GetIDByClubName(cboAway.Text);
                txtMatchID.Text = matchweekID + "_" + homeID + "-" + awayID;
                txtMatchName.Text = cboHome.Text + " - " + cboAway.Text;
            }
        }


        private void cmdParameters(SqlCommand cmd)
        {
            cmd.Parameters.Clear();

            string roundID = GetIDByMatchweek(cboMW.Text);

            cmd.Parameters.AddWithValue("@MatchID", txtMatchID.Text);

            cmd.Parameters.AddWithValue("@RoundID", roundID);

            cmd.Parameters.AddWithValue("@MatchName", txtMatchName.Text);

            cmd.Parameters.AddWithValue("@MatchTime", dtpMatchTime.Value);
        }

        private bool isInvalidValue()
        {
            if (txtMatchID.Text == "")
            {
                msgNotify.Show("Match ID not blank!");
                return false;
            }
            if (cboMW.SelectedIndex == 0 || cboMW.SelectedIndex == -1)
            {
                msgNotify.Show("You haven't select a Matchweek!");
                return false;
            }
            if (txtMatchName.Text == "")
            {
                msgNotify.Show("Match name not blank!");
                return false;
            }
            if (cboHome.Text == "")
            {
                msgNotify.Show("You haven't select a home team!");
                return false;
            }
            if (cboAway.Text == "")
            {
                msgNotify.Show("You haven't select a away team!");
                return false;
            }
            return true;
        }


        private void btnAddMatch_Click(object sender, EventArgs e)
        {
            if (!isInvalidValue())
                return;

            using (SqlCommand cmd = new SqlCommand())
            {
                data.InitializeCommand("usp_AddMatch", cmd);
                cmdParameters(cmd);

                try
                {
                    cmd.ExecuteNonQuery();
                    msgNotify.Show("Match added successfully");
                    dgvMatch.DataSource = data.LoadData("usp_ShowAllMatches");
                }
                catch (SqlException ex)
                {
                    msgNotify.Show("An error occurred: " + ex.Message);
                }
            }
        }


        private void btnDelMatch_Click(object sender, EventArgs e)
        {
            if (txtMatchID.Text == "")
            {
                msgNotify.Show("You haven't choose match!");
                return;
            }
            DialogResult result = msgConfirm.Show($"Are your sure to delete {txtMatchName.Text} ?", "Confirm");

            if (result == DialogResult.Yes)
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    data.InitializeCommand("usp_DeleteMatch", cmd);
                    cmd.Parameters.AddWithValue("@MatchID", txtMatchID.Text);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        msgNotify.Show("Match deleted successfully");
                        dgvMatch.DataSource = data.LoadData("usp_ShowAllMatches");
                    }
                    catch (SqlException ex)
                    {
                        msgNotify.Show("Delete failed " + ex.Message);
                    }
                }
            }
            ClearAllFields();
        }

        private void btnEditMatch_Click(object sender, EventArgs e)
        {
            if (!isInvalidValue())
                return;

            using (SqlCommand cmd = new SqlCommand())
            {
                data.InitializeCommand("usp_EditMatch", cmd);
                cmdParameters(cmd);

                try
                {
                    cmd.ExecuteNonQuery();
                    msgNotify.Show("Match edited successfully");
                    dgvMatch.DataSource = data.LoadData("usp_ShowAllMatches");
                }
                catch (SqlException ex)
                {
                    msgNotify.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void OpenChildForm(Form childForm)
        {
            try
            {
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                pnlDesktop.Controls.Add(childForm);
                dgvMatch.Dock = DockStyle.None;
                pnlDesktop.Refresh();
                childForm.BringToFront();
                childForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnPlayersAwayInMatch_Click(object sender, EventArgs e)
        {
            FormPlayersInMatch frm = new FormPlayersInMatch(serverName, dbName);
            if (txtMatchName.Text == "")
            {
                msgNotify.Show("You have not select match!");
                return;
            }
            frm.setAndGetInfo(txtMatchName.Text, txtMatchID.Text, cboAway.Text, 0);
            OpenChildForm(frm);
        }

        private void btnPlayersHomeInMatch_Click(object sender, EventArgs e)
        {
            FormPlayersInMatch frm = new FormPlayersInMatch(serverName, dbName);
            if (txtMatchName.Text == "")
            {
                msgNotify.Show("You have not select match!");
                return;
            }
            frm.setAndGetInfo(txtMatchName.Text, txtMatchID.Text, cboHome.Text, 1);
            OpenChildForm(frm);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cboFindMW.Size.ToString());
        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(pnlDesktop.Size.ToString());
        }

        private void btnMatchDetail_Click(object sender, EventArgs e)
        {
            FormMatchDetail frm = new FormMatchDetail(serverName, dbName);
            if (txtMatchName.Text == "")
            {
                msgNotify.Show("You have not select match!");
                return;
            }
            frm.setAndGetInfoForMatchDetail(txtMatchName.Text, txtMatchID.Text);
            OpenChildForm(frm);
        }
    }
}
