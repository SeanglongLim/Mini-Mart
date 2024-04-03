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
using Microsoft.Reporting.Map.WebForms.BingMaps;
using Mini_Mart_Test.Helper;

namespace Mini_Mart_Test
{
    public partial class Customer_New : Form
    {

        public Customer_New()
        {
            InitializeComponent();
            BTN_Save.Click += BTN_Save_Click;
            BTN_Clear.Click += BTN_Clear_Click;
            BTN_Show.Click += BTN_Show_Click;
            BTN_Update.Visible = false;
            BTN_Update.Enabled = false;
            textBox1.TextChanged += TextBox1_TextChanged;
            tabcontrol1.Click += Tab_control_Click;
            label1.Hide();
            Txt_ID.Hide();
            CustomerGridView.KeyDown += CustomerGridView_KeyDown;
            CustomerGridView.CellDoubleClick += CustomerGridView_CellDoubleClick;

        }

        private void CustomerGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tabPage1.Show();
            Txt_ID.Text = CustomerGridView.CurrentRow.Cells[0].Value.ToString();
            Txt_Name.Text = CustomerGridView.CurrentRow.Cells[1].Value.ToString();
            Txt_Phone.Text = CustomerGridView.CurrentRow.Cells[2].Value.ToString();
            Txt_Address.Text = CustomerGridView.CurrentRow.Cells[3].Value.ToString();
            Save_Show_False();
            Update_Show();
            BTN_Update.Click += BTN_Update_Click;
        }

        private void CustomerGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                string message = "Do you want to delete?"; string title = "Delete";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    int ID = Convert.ToInt32(CustomerGridView.SelectedCells[0].Value);
                    new DBconnect().ExecuteSqlCommand("DELETE FROM Customer WHERE ID =  '" + ID + "'");
                }
                else if (result == DialogResult.No)
                {
                    BTN_Show.PerformClick();
                }
            }
        }

        private void Tab_control_Click(object sender, EventArgs e)
        {
            CustomerGridView.DataSource = new DBconnect().SelectTable("SELECT *FROM Customer");
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection($"Data Source=DESKTOP-KH27LVJ\\SQLEXPRESS;Initial Catalog=Mini_Shop;Integrated Security=True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Customer WHERE Name = @Name", conn);
                cmd.Parameters.AddWithValue("@Name", textBox1.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                CustomerGridView.DataSource = dt;
              
            }
        }

  

        private void BTN_Show_Click(object sender, EventArgs e)
        {
            CustomerGridView.DataSource = new DBconnect().SelectTable("SELECT *FROM Customer");

        }
        private void BTN_Clear_Click(object sender, EventArgs e)
        {
            Txt_Name.Text = ""; Txt_Phone.Text = ""; Txt_Address.Text = "";
            BTN_Update.Visible = false;
            BTN_Update.Enabled = false;
            BTN_Save.Visible = true;
            BTN_Save.Enabled = true;

        }
        private void BTN_Save_Click(object sender, EventArgs e)
        {
            new DBconnect().ExecuteSqlCommand("INSERT INTO Customer(Name,Phone,AddressLine) VALUES(N'" + Txt_Name.Text + "',N'" + Txt_Phone.Text + "',N'" + Txt_Address.Text + "')");
            MessageBox.Show("Saved");
            Txt_Name.Text = ""; Txt_Phone.Text = ""; Txt_Address.Text = "";
        }
       
        private void BTN_Update_Click(object sender, EventArgs e)
        {
            new DBconnect().ExecuteSqlCommand("UPDATE Customer SET Name = N'" + Txt_Name.Text + "', Phone = N'" + Txt_Phone.Text + "', AddressLine = N'" + Txt_Address.Text + "' WHERE ID = '" + Txt_ID.Text + "'");
            MessageBox.Show("Update Sucessfully");
            Txt_Name.Text = ""; Txt_Phone.Text = ""; Txt_Address.Text = "";
            tabcontrol1.SelectedTab = tabPage2;
            tabPage1.Hide();
            CustomerGridView.DataSource = new DBconnect().SelectTable("SELECT *FROM Customer");
            Update_Show_False();
            Save_Show();
            tabPage2.Show();
          
        }
        
        private void Update_Show()
        {
            BTN_Update.Visible = true; BTN_Update.Enabled = true;
        }
        private void Save_Show_False()
        {
            BTN_Save.Visible = false; BTN_Save.Enabled = false;
        }
        private void Update_Show_False()
        {
            BTN_Update.Visible = false; BTN_Update.Enabled = false;
        }
        private void Save_Show()
        {
            BTN_Save.Visible = true; BTN_Save.Enabled = true;
        }

        private void Customer_New_Load(object sender, EventArgs e)
        {

        }
    }
}