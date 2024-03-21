using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Media;
using System.Drawing;

namespace ProjectLTUD
{
    public partial class FormPlayersInMatch : Form
    {
        ConnectDatabase data = new ConnectDatabase();
        int isHomeTeam;
        string matchID;


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


        public FormPlayersInMatch(string serverName, string dbName)
        {
            InitializeComponent();
            data = new ConnectDatabase(serverName, dbName);
        }


        internal void setAndGetInfo(string matchName, string matchID2, string homeClub, int isHT)
        {
            lblMatchName.Text = matchName;
            lblClubName.Text = homeClub;
            matchID = matchID2;
            isHomeTeam = isHT;
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            FormClubs frm = Application.OpenForms.OfType<FormClubs>().FirstOrDefault();
            if (frm != null)
                frm.Show();
        }


        private void FormPlayersInMatch_Load(object sender, EventArgs e)
        {
            string clubID = GetClubID(lblClubName.Text);
            dgvPlayersInMatch.DataSource = LoadPlayersInMatch(isHomeTeam);
            dgvPlayersInClub.DataSource = data.LoadDataByID("usp_GetPlayerByClubID", "@ClubID", clubID);
        }


        private DataTable LoadPlayersInMatch(int isHomeTeam)
        {
            DataTable dt = new DataTable();
            try
            {
                data.OpenConnect();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "usp_GetHalfPlayersInMatch";
                    command.Connection = data.connection;
                    command.Parameters.AddWithValue("@MatchID", matchID);
                    command.Parameters.AddWithValue("@IsHomeTeam", isHomeTeam);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
                Console.WriteLine(ex.StackTrace); // In ra StackTrace để xem chi tiết lỗi
            }
            finally
            {
                data.CloseConnection();
            }
            return dt;
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ClearAllFields();
            dgvPlayersInClub.ClearSelection();
            dgvPlayersInMatch.ClearSelection();
            ChangeButtonEnableToFalse(btnAdd);
            ChangeButtonEnableToFalse(btnDel);
            ChangeButtonEnableToFalse(btnEdit);
        }


        private void ClearAllFields()
        {
            txtPlayerID.Enabled = true;
            txtPlayerID.Clear();
            txtPlayerID.Enabled = false;

            txtPlayerName.Enabled = true;
            txtPlayerName.Clear();
            txtPlayerName.Enabled = false;

            cboPosition.SelectedIndex = -1;

            txtGoal.Clear();
            txtYC.Clear();
            txtRC.Clear();
            txtOG.Clear();
        }


        private void dgvPlayerInClub_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearAllFields();
            dgvPlayersInMatch.ClearSelection();
            ChangeButtonEnableToFalse(btnDel);
            ChangeButtonEnableToFalse(btnEdit);

            if (e.RowIndex >= 0 && e.RowIndex < dgvPlayersInClub.Rows.Count)
            {
                DataGridViewRow selectRow = dgvPlayersInClub.Rows[e.RowIndex];
                string playerID = selectRow.Cells["PlayerIDInClub"]?.Value?.ToString().Trim() ?? string.Empty;
                string playerName = selectRow.Cells["PLayerNameInClub"]?.Value?.ToString().Trim() ?? string.Empty;
                txtPlayerID.Text = playerID;
                txtPlayerName.Text = playerName;
                
                ChangeButtonEnableToTrue(btnAdd);
            }
            else
            {
                btnAdd.Enabled = false;
                ClearAllFields();
            }
        }


        private void dgvPlayersInMatch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ClearAllFields();
            dgvPlayersInClub.ClearSelection();
            ChangeButtonEnableToFalse(btnAdd);

            if (e.RowIndex >= 0 && e.RowIndex < dgvPlayersInMatch.Rows.Count)
            {
                DataGridViewRow selectRow = dgvPlayersInMatch.Rows[e.RowIndex];

                string playerID = selectRow.Cells["PLayerID"]?.Value?.ToString().Trim() ?? string.Empty;
                string playerName = selectRow.Cells["PLayerName"]?.Value?.ToString().Trim() ?? string.Empty;
                string position = selectRow.Cells["Position"]?.Value?.ToString().Trim() ?? string.Empty;
                string goal = selectRow.Cells["Goal"]?.Value?.ToString().Trim() ?? string.Empty;
                string yellowCard = selectRow.Cells["YellowCard"]?.Value?.ToString().Trim() ?? string.Empty;
                string redCard = selectRow.Cells["RedCard"]?.Value?.ToString().Trim() ?? string.Empty;
                string ownGoal = selectRow.Cells["OwnGoal"]?.Value?.ToString().Trim() ?? string.Empty;

                txtPlayerID.Text = playerID;
                txtPlayerName.Text = playerName;
                cboPosition.Text = position;
                txtGoal.Text = goal;
                txtYC.Text = yellowCard;
                txtRC.Text = redCard;
                txtOG.Text = ownGoal;

                ChangeButtonEnableToTrue(btnDel);
                ChangeButtonEnableToTrue(btnEdit);
            }
            else
                ClearAllFields();
        }


        // Thay đổi enable của button sang true
        private void ChangeButtonEnableToTrue(IconButton button)
        {
            button.Enabled = true;
            button.ForeColor = System.Drawing.Color.White;
            button.IconColor = System.Drawing.Color.White;
            button.BackColor = System.Drawing.Color.FromArgb(50, 0, 60);
        }


        // Thay đổi enable của button sang false
        private void ChangeButtonEnableToFalse(IconButton button)
        {
            button.Enabled = false;
            button.ForeColor = System.Drawing.Color.Black;
            button.IconColor = System.Drawing.Color.Black;
            button.BackColor = System.Drawing.Color.FromArgb(224, 224, 224);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                data.InitializeCommand("usp_AddPlayerToMatch", cmd);
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
                        msgNotify.Show("Add successfully!");
                        dgvPlayersInMatch.DataSource = LoadPlayersInMatch(isHomeTeam);
                    }
                }
                catch (SqlException ex)
                {
                    msgNotify.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void cmdParameters(SqlCommand cmd)
        {
            cmd.Parameters.Clear();

            cmd.Parameters.AddWithValue("@MatchID", matchID);

            cmd.Parameters.AddWithValue("@PlayerID", txtPlayerID.Text);

            cmd.Parameters.AddWithValue("@IsHomeTeam", isHomeTeam);

            cmd.Parameters.AddWithValue("@Position", cboPosition.Text);

            cmd.Parameters.AddWithValue("@Goal", string.IsNullOrEmpty(txtGoal.Text) ? 0 : int.Parse(txtGoal.Text));

            cmd.Parameters.AddWithValue("@YellowCard", string.IsNullOrEmpty(txtYC.Text) ? 0 : int.Parse(txtYC.Text));

            cmd.Parameters.AddWithValue("@RedCard", string.IsNullOrEmpty(txtRC.Text) ? 0 : int.Parse(txtRC.Text));

            cmd.Parameters.AddWithValue("@OwnGoal", string.IsNullOrEmpty(txtOG.Text) ? 0 : int.Parse(txtOG.Text));
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                data.InitializeCommand("usp_EditPlayerInMatch", cmd);
                cmdParameters(cmd);

                try
                {
                    cmd.ExecuteNonQuery();
                    msgNotify.Show("Edit successfully!");
                    dgvPlayersInMatch.DataSource = LoadPlayersInMatch(isHomeTeam);
                }
                catch (SqlException ex)
                {
                    msgNotify.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                data.InitializeCommand("usp_DeletePlayerInMatch", cmd);
                cmd.Parameters.AddWithValue("@MatchID", matchID);
                cmd.Parameters.AddWithValue("@PlayerID", txtPlayerID.Text);

                try
                {
                    cmd.ExecuteNonQuery();
                    msgNotify.Show("Delete successfully!");
                    dgvPlayersInMatch.DataSource = LoadPlayersInMatch(isHomeTeam);
                }
                catch (SqlException ex)
                {
                    msgNotify.Show("An error occurred: " + ex.Message);
                }
            }
        }
    }
}
