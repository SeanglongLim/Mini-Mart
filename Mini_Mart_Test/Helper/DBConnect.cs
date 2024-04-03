using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mini_Mart_Test.Helper
{
    class DBconnect
    {
        string ConnectionString = $"Data Source=DESKTOP-KH27LVJ\\SQLEXPRESS;Initial Catalog=Mini_Shop;Integrated Security=True";
        SqlConnection conn = null;

        public DBconnect()
        {
            conn = new SqlConnection(ConnectionString);
        }

        public void OpenConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void CloseConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public void ExecuteSqlCommand(string Query, params string[] Values)
        {
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand(Query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Do not close the connection here
            }
        }

        public SqlDataReader Select(string Query, params string[] Values)
        {
            try
            {
                OpenConnection();
                SqlCommand cmd = new SqlCommand(Query, conn);
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return null;
        }

        public DataTable SelectTable(string Query, params string[] Values)
        {
            var reader = Select(Query, Values);
            DataTable table = new DataTable();
            table.Load(reader);
            return table;
        }

        public object ExecuteScalar(string query)
        {
            object result = null;

            try
            {
                OpenConnection();

                using (SqlCommand command = new SqlCommand(query, conn))
                {
                    result = command.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Do not close the connection here
            }

            return result;
        }

        public SqlConnection GetConnection()
        {
            return conn;
        }
    }
}
