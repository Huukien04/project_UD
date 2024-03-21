using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ProjectLTUD
{
    public partial class FormMatchDetail : Form
    {
        ConnectDatabase data = new ConnectDatabase();
        string matchID;
        Dictionary<int, string> playersInMatch;
        Dictionary<int, string> homePlayers;
        Dictionary<int, string> awayPlayers;


        // Tạo dictionary để ánh xạ giữa mã và tên đội bóng
        Dictionary<string, string> clubNames = new Dictionary<string, string>()
        {
            {"ARS", "Arsenal"},
            {"AVL", "Aston Villa"},
            {"BOU", "Bournemouth"},
            {"BRE", "Brentford"},
            {"BHA", "Brighton"},
            {"BUR", "Burnley"},
            {"CHE", "Chelsea"},
            {"CRY", "Crystal Palace"},
            {"EVE", "Everton"},
            {"FUL", "Fulham"},
            {"LIV", "Liverpool"},
            {"LUT", "Luton"},
            {"MCI", "Man City"},
            {"MUN", "Man United"},
            {"NEW", "Newcastle"},
            {"NFO", "Nottingham Forest"},
            {"SHU", "Sheffield United"},
            {"TOT", "Tottenham"},
            {"WHU", "West Ham"},
            {"WOL", "Wolverhampton"}
        };


        private string GetNameClub(string clubID)
        {
            if (clubNames.TryGetValue(clubID, out string clubName))
                return clubName;

            else
                return "CLUB NAME";
        }

        private string GetIDByClubName(string clubName)
        {
            return clubNames.FirstOrDefault(x => x.Value == clubName).Key;
        }


        public FormMatchDetail(string serverName, string dbName)
        {
            InitializeComponent();
            data = new ConnectDatabase(serverName, dbName);
        }


        internal void setAndGetInfoForMatchDetail(string matchName, string mID)
        {
            lblMatchName.Text = matchName;
            txtMatchID.Text = mID;
            matchID = mID;
            string[] str = matchName.Split('-');
            txtHomeName.Text = str[0].Trim();
            txtAwayName.Text = str[1].Trim();
        }


        private void FormMatchDetail_Load(object sender, EventArgs e)
        {
            dgvMatchDetail.DataSource = data.LoadDataByID("usp_ShowMatchDetail", "@MatchID", matchID);

            GetAllPlayersInMatch();

            GetHomePlayersInMatch(1);

            GetAwayPlayersInMatch(0);
        }

        private void dgvMatchDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearAllFields();
            if (e.RowIndex == 0 && e.RowIndex < dgvMatchDetail.Rows.Count)
            {
                DataGridViewRow selectRow = dgvMatchDetail.Rows[e.RowIndex];

                UploadToGroupboxHomeClub(selectRow);

                UploadToGroupboxAwayClub(selectRow);

                txtMatchID.Text = selectRow.Cells[0]?.Value?.ToString().Trim() ?? string.Empty;

                txtReferee.Text = selectRow.Cells["Referee"]?.Value?.ToString().Trim() ?? string.Empty;

                // Lấy tất cả cầu thủ trong trận và hiển thị tên cầu thủ là motm lên cboMOTM
                int motmID = selectRow.Cells["MotmID"].Value != null ? Convert.ToInt32(selectRow.Cells["MotmID"].Value) : 0;
                GetAllPlayersInMatch();
                cboMOTM.Text = DisplayPLayerHasPlayerID(motmID, playersInMatch);

                // Lấy tất cả cầu thủ là đội nhà trong trận
                int homeCapID = (int)selectRow.Cells["HomeCapID"].Value;
                GetHomePlayersInMatch(1);
                cboHomeCap.Text = DisplayPLayerHasPlayerID(homeCapID, homePlayers);

                // Lấy tất cả cầu thủ là đội nhà trong trận
                int awayCapID = (int)selectRow.Cells["AwayCapID"].Value;
                GetAwayPlayersInMatch(0);
                cboAwayCap.Text = DisplayPLayerHasPlayerID(awayCapID, awayPlayers);
            }
            else
                ClearAllFields();
        }


        // Lấy các cầu thủ đội khách
        private void GetAwayPlayersInMatch(int isHomeTeam)
        {
            awayPlayers = new Dictionary<int, string>();
            using (SqlCommand cmd = new SqlCommand())
            {
                data.InitializeCommand("usp_GetHalfPlayersInMatch2", cmd);
                cmd.Parameters.AddWithValue("@MatchID", matchID);
                cmd.Parameters.AddWithValue("@IsHomeTeam", isHomeTeam);

                try
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int playerID = (int)reader["PlayerID"];
                            string playerName = reader["PlayerName"].ToString();

                            awayPlayers.Add(playerID, playerName);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    msgNotify.Show("An error occurred: " + ex.Message);
                }
            }
            cboAwayCap.DisplayMember = "Value";
            cboAwayCap.ValueMember = "Key";
            cboAwayCap.DataSource = new BindingSource(awayPlayers, null);
        }


        // Lấy các cầu thủ đội nhà
        private void GetHomePlayersInMatch(int isHomeTeam)
        {
            homePlayers = new Dictionary<int, string>();
            using (SqlCommand cmd = new SqlCommand())
            {
                data.InitializeCommand("usp_GetHalfPlayersInMatch2", cmd);
                cmd.Parameters.AddWithValue("@MatchID", matchID);
                cmd.Parameters.AddWithValue("@IsHomeTeam", isHomeTeam);

                try
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int playerID = (int)reader["PlayerID"];
                            string playerName = reader["PlayerName"].ToString();

                            homePlayers.Add(playerID, playerName);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    msgNotify.Show("An error occurred: " + ex.Message);
                }
            }
            cboHomeCap.DisplayMember = "Value";
            cboHomeCap.ValueMember = "Key";
            cboHomeCap.DataSource = new BindingSource(homePlayers, null);
        }


        // Hiển thị cầu thủ có ID lên combobox (VD: MotmID = 1234 -> cbo sẽ hiển thị tên cầu thủ có mã 1234)
        private string DisplayPLayerHasPlayerID(int playerID, Dictionary<int, string> players)
        {
            if (players.ContainsKey(playerID))
            {
                return players[playerID];
            }
            else
            {
                return "Player Not Found"; 
            }
        }


        // Lấy tất cả cầu thủ trong trận đấu
        private void GetAllPlayersInMatch()
        {
            playersInMatch = new Dictionary<int, string>();
            using (SqlCommand cmd = new SqlCommand())
            {
                data.InitializeCommand("usp_GetAllPlayersInMatch", cmd);
                cmd.Parameters.AddWithValue("@MatchID", matchID);

                try
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int playerID = (int)reader["PlayerID"];
                            string playerName = reader["PlayerName"].ToString();

                            playersInMatch.Add(playerID, playerName);
                        }
                    }
                }
                catch (SqlException ex)
                {
                    msgNotify.Show("An error occurred: " + ex.Message);
                }
            }
            cboMOTM.DisplayMember = "Value";
            cboMOTM.ValueMember = "Key";
            cboMOTM.DataSource = new BindingSource(playersInMatch, null);
        }


        // Load dữ liệu lên home club groupbox 
        private void UploadToGroupboxHomeClub(DataGridViewRow selectRow)
        {
            string homeID = selectRow.Cells["HomeID"]?.Value?.ToString().Trim() ?? string.Empty;

            txtHomeName.Text = GetNameClub(homeID);

            txtHomeTactical.Text = selectRow.Cells["HomeTactical"]?.Value?.ToString().Trim() ?? string.Empty;

            txtHomeGoals.Text = selectRow.Cells["HomeGoals"]?.Value?.ToString().Trim() ?? string.Empty;
        }


        // Load dữ liệu lên away club groupbox 
        private void UploadToGroupboxAwayClub(DataGridViewRow selectRow)
        {
            string awayID = selectRow.Cells["AwayID"]?.Value?.ToString().Trim() ?? string.Empty;

            txtAwayName.Text = GetNameClub(awayID);

            txtAwayTactical.Text = selectRow.Cells["AwayTactical"]?.Value?.ToString().Trim() ?? string.Empty;

            txtAwayGoals.Text = selectRow.Cells["AwayGoals"]?.Value?.ToString().Trim() ?? string.Empty;
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            FormMatches frm = Application.OpenForms.OfType<FormMatches>().FirstOrDefault();
            if (frm != null)
                frm.Show();
        }


        private void ClearAllFields()
        {
            cboHomeCap.SelectedIndex = -1;
            cboAwayCap.SelectedIndex = -1;
            cboMOTM.SelectedIndex = -1;

            txtHomeGoals.Clear();
            txtHomeTactical.Clear();
            txtAwayGoals.Clear();
            txtAwayTactical.Clear();
            txtReferee.Clear();
        }

        
        private void cmdParameters(SqlCommand cmd)
        {
            cmd.Parameters.Clear();

            string homeID = GetIDByClubName(txtHomeName.Text);
            string awayID = GetIDByClubName(txtAwayName.Text);
            int homeCapID = GetPlayerID(cboHomeCap.Text);
            int awayCapID = GetPlayerID(cboAwayCap.Text);
            int motmID = GetPlayerID(cboMOTM.Text);

            cmd.Parameters.AddWithValue("@MatchID", txtMatchID.Text);

            cmd.Parameters.AddWithValue("@HomeID", homeID);

            cmd.Parameters.AddWithValue("@AwayID", awayID);

            cmd.Parameters.AddWithValue("@MotmID", motmID);

            cmd.Parameters.AddWithValue("@HomeGoals", string.IsNullOrEmpty(txtHomeGoals.Text) ? 0 : int.Parse(txtHomeGoals.Text));

            cmd.Parameters.AddWithValue("@AwayGoals", string.IsNullOrEmpty(txtAwayGoals.Text) ? 0 : int.Parse(txtAwayGoals.Text));

            cmd.Parameters.AddWithValue("@HomeCapID", homeCapID);

            cmd.Parameters.AddWithValue("@AwayCapID", awayCapID);

            cmd.Parameters.AddWithValue("@HomeTactical", txtHomeTactical.Text);

            cmd.Parameters.AddWithValue("@AwayTactical", txtAwayTactical.Text);

            cmd.Parameters.AddWithValue("@Referee", txtReferee.Text);

        }


        public int GetPlayerID(string playerName)
        {
            KeyValuePair<int, string> selectedPlayer = playersInMatch.FirstOrDefault(x => x.Value == playerName);
            return selectedPlayer.Key;
        }


        private bool isInvalidValue()
        {
            if (txtMatchID.Text == "")
            {
                msgNotify.Show("Match ID not blank!");
                return false;
            }
            if (cboHomeCap.Text == "")
            {
                msgNotify.Show("You haven't select a home captain!");
                return false;
            }
            if (txtHomeTactical.Text == "" || txtAwayTactical.Text == "")
            {
                msgNotify.Show("Tactical not blank!");
                return false;
            }
            if (cboAwayCap.Text == "")
            {
                msgNotify.Show("You haven't select a away captain!");
                return false;
            }
            if (cboMOTM.Text == "")
            {
                msgNotify.Show("You haven't select a MOTM!");
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
                data.InitializeCommand("usp_AddMatchDetail", cmd);
                cmdParameters(cmd);

                try
                {
                    SqlParameter outputMsgParam = new SqlParameter("@OutputMsg", SqlDbType.NVarChar, -1);
                    outputMsgParam.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(outputMsgParam);

                    cmd.ExecuteNonQuery();

                    string outputMsg = cmd.Parameters["@OutputMsg"].Value.ToString();
                    if (!string.IsNullOrEmpty(outputMsg))
                        msgNotify.Show(outputMsg);

                    else
                    {
                        msgNotify.Show("Add successfully");
                        dgvMatchDetail.DataSource = data.LoadDataByID("usp_ShowMatchDetail", "@MatchID", matchID);
                    }
                }
                catch (SqlException ex)
                {
                    msgNotify.Show("An error occurred: " + ex.Message);
                }
            }
        }


        private void btnDelMatch_Click(object sender, EventArgs e)
        {
            DialogResult result = msgConfirm.Show($"Are your sure to delete?", "Confirm");
            if (result == DialogResult.Yes)
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    data.InitializeCommand("usp_DeleteMatchDetail", cmd);
                    cmd.Parameters.AddWithValue("@MatchID", txtMatchID.Text);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        msgNotify.Show("Delete successfully");
                        dgvMatchDetail.DataSource = data.LoadDataByID("usp_ShowMatchDetail", "@MatchID", matchID);
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
                data.InitializeCommand("usp_EditMatchDetail", cmd);
                cmdParameters(cmd);

                try
                {
                    cmd.ExecuteNonQuery();
                    msgNotify.Show("Edit successfully");
                    dgvMatchDetail.DataSource = data.LoadDataByID("usp_ShowMatchDetail", "@MatchID", matchID);
                }
                catch (SqlException ex)
                {
                    msgNotify.Show("Edit failed " + ex.Message);
                }
            }
            ClearAllFields();
        }
    }
}
