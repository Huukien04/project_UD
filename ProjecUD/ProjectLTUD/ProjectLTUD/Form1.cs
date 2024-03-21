using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectLTUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string serverName = txtServerName.Text;
            string dbName = txtDBName.Text;

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
                //this.Close();
                FormMain frm = new FormMain();
                frm.GetServerAndDBName(serverName, dbName);
                frm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi kết nối: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Đóng kết nối sau khi sử dụng
                data.CloseConnection();
            }
        }
    }
}
