using Microsoft.Reporting.WinForms;
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

namespace Mini_Mart_Test
{
    public partial class SaleReport : Form
    {
        public SaleReport()
        {
            InitializeComponent();
            BTN_Show.Click += BTN_Show_Click;
        }

        private void BTN_Show_Click(object sender, EventArgs e)
        {
            ReportLoad();
        }

        private void SaleReport_Load(object sender, EventArgs e)
        {
        }
        private void ReportLoad()
        {
            DateTime from = dateTimePicker1.Value;
            DateTime to = dateTimePicker2.Value;
            string connectionString = $"Data Source=DESKTOP-KH27LVJ\\SQLEXPRESS;Initial Catalog=Mini_Shop;Integrated Security=True";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT Sale.ID, Sale.DateOfSale, SalePayment.PaymentDate, SalePayment.Amount, PaymentMethod.Method, Employee.Name, Customer.Name AS Expr1 " +
                       "FROM Sale " +
                       "INNER JOIN SalePayment ON Sale.ID = SalePayment.SaleID " +
                       "INNER JOIN Employee ON Sale.EmployeeID = Employee.ID AND SalePayment.Employee = Employee.ID " +
                       "INNER JOIN PaymentMethod ON SalePayment.MethodID = PaymentMethod.ID " +
                       "INNER JOIN Customer ON Sale.CustomerID = Customer.ID " +
                       "WHERE Sale.DateOfSale BETWEEN '"+from+"' AND '"+to+"'", conn))
                {
                    using (SqlDataAdapter d = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        d.Fill(dt);
                        reportViewer1.LocalReport.DataSources.Clear();
                        ReportDataSource reportData = new ReportDataSource("DataSet1", dt);
                        reportViewer1.LocalReport.DataSources.Add(reportData);
                        reportViewer1.LocalReport.ReportPath = @"C:\Users\U-ser\Documents\C# Mini Mart\Mini_Mart_Test - Copy\Mini_Mart_Test - Copy\Mini_Mart_Test\Report1.rdlc";
                        reportViewer1.RefreshReport();
                    }
                }
            }
            this.reportViewer1.RefreshReport();
        }
    }
}
