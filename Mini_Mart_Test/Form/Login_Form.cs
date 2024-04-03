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
using Mini_Mart_Test.Helper;

namespace Mini_Mart_Test
{
    
    public partial class Login_Form : Form
    {
        
        SqlConnection conn = new SqlConnection($"Data Source=DESKTOP-KH27LVJ\\SQLEXPRESS;Initial Catalog=Mini_Shop;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader reader;



        public Login_Form()
        {
            InitializeComponent();
            
          
            BTN_Login.Click += BTN_Login_Click;
            
          
        }

       

  
        private void BTN_Login_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection($"Data Source=DESKTOP-KH27LVJ\\SQLEXPRESS;Initial Catalog=Mini_Shop;Integrated Security=True"))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT ID, Name FROM Employee WHERE Name = @Name AND EmpPassword = @EmpPassword", conn))
                {
                    cmd.Parameters.AddWithValue("@Name", Txt_Username.Text);
                    cmd.Parameters.AddWithValue("@EmpPassword", Txt_Password.Text);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            reader.Read(); // Move to the first (and only) row
                            string employeeID = reader["ID"].ToString();
                            string employeeName = reader["Name"].ToString();

                            EmployeeInfo employeeInfo = new EmployeeInfo
                            {
                                EmployeeID = employeeID,
                                EmployeeName = employeeName
                            };

                            MasterForm masterForm = new MasterForm(employeeInfo);
                            masterForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Invalid credentials. Please try again.");
                        }
                    }
                }
            }

        }
    }
}
