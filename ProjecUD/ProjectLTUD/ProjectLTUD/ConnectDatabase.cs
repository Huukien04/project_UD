using System.Data;
using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Xml.Linq;

namespace ProjectLTUD
{
    internal class ConnectDatabase
    {
        private string serverName;
        private string dbName;

        //public string connectionString = "Data Source=LAPTOP-5I4BGSNV\\HOANGVU;Initial Catalog=QLGDEPL2324;Integrated Security=True";

        public SqlConnection connection = null;


        public ConnectDatabase(string serverName, string dbName)
        {
            this.serverName = serverName;
            this.dbName = dbName;
        }

        public ConnectDatabase()
        {
        }

        public string connectionString
        {
            get
            {
                return $"Data Source={serverName};Initial Catalog={dbName};Integrated Security=True";
            }
        }


        // Phương thức mở kết nối
        public void OpenConnect()
        {
            connection = new SqlConnection(connectionString);
            if (connection.State == ConnectionState.Closed)
                connection.Open();
        }


        // Phương thức đóng kết nối
        public void CloseConnection()
        {
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
                connection.Dispose();
            }
        }


        // Phương thức lấy dữ liệu
        public DataTable LoadData(string storedProcedure)
        {
            DataTable dt = new DataTable();
            try
            {
                OpenConnect();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = storedProcedure;
                    command.Connection = connection;
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        dt.Load(reader);
                    }
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
            
            return dt;
        }


        public DataTable LoadDataByID(string storedProcedure, string paramName, string paramValue)
        {
            DataTable dt = new DataTable();
            try
            {
                OpenConnect();
                using (SqlCommand command = new SqlCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = storedProcedure;
                    command.Connection = connection;
                    command.Parameters.AddWithValue(paramName, paramValue);
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
                CloseConnection();
            }
            return dt;
        }

        public void InitializeCommand(string storedProcedure, SqlCommand cmd)
        {
            OpenConnect();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = storedProcedure;
            cmd.Connection = connection;
        }
    }
}
