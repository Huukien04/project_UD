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
    public partial class FormStats : Form
    {
        ConnectDatabase data = new ConnectDatabase();

        public FormStats(string serverName, string dbName)
        {
            InitializeComponent();
            data = new ConnectDatabase(serverName, dbName);
        }

        private void FormStats_Load(object sender, EventArgs e)
        {
            dgvTop5Goals.DataSource = data.LoadData("usp_Top5MostGoals");
            dgvTopSalary.DataSource = data.LoadData("usp_Top5MostSalary");
            dgvTop5ClubsGoals.DataSource = data.LoadData("usp_Top5TeamsMostGoals");
            dgvClubRedCards.DataSource = data.LoadData("usp_Top5TeamsMostRedCards");
        }
    }
}
