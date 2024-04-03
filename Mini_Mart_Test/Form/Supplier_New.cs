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
    public partial class Supplier_New : Form
    {
        public Supplier_New()
        {
            InitializeComponent();
            BTN_Save.Click += BTN_Save_Click;
            BTN_Clear.Click += BTN_Clear_Click;
            BTN_Show.Click += BTN_Show_Click;
            BTN_Update.Visible = false;
            BTN_Update.Enabled = false;
            textBox1.TextChanged += TextBox1_TextChanged;
            tabControl1.Click += Tab_control_Click;
            dataGridView1.CellDoubleClick += DataGridView1_CellDoubleClick;
            dataGridView1.KeyDown += dataGridView1_KeyDown;
            textBox1.TextChanged += TextBox1_TextChanged1;
            label1.Hide();
            Txt_ID.Hide();
        }

        private void TextBox1_TextChanged1(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection($"Data Source=DESKTOP-KH27LVJ\\SQLEXPRESS;Initial Catalog=Mini_Shop;Integrated Security=True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Supplier WHERE Name = @Name", conn);
                cmd.Parameters.AddWithValue("@Name", textBox1.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tabPage1.Show();
            Txt_ID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Txt_Name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Txt_Phone.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            Txt_Address.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            Save_Show_False();
            Update_Show();
            BTN_Update.Click += BTN_Update_Click;
        }

        private void Tab_control_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new DBconnect().SelectTable("SELECT *FROM Supplier");
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection($"Data Source=LAPTOP-5E99J0J9\\SQLEXPRESS02;Initial Catalog=Mini_Shop;Integrated Security=True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Supplier WHERE Name = @Name", conn);
                cmd.Parameters.AddWithValue("@Name", textBox1.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }
        private void BTN_Show_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new DBconnect().SelectTable("SELECT *FROM Supplier");

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
            new DBconnect().ExecuteSqlCommand("INSERT INTO Supplier(Name,Phone,AddressLine) VALUES(N'" + Txt_Name.Text + "',N'" + Txt_Phone.Text + "',N'" + Txt_Address.Text + "')");
            Txt_Name.Text = ""; Txt_Phone.Text = ""; Txt_Address.Text = "";
            MessageBox.Show("Saved");
        }
      
        private void BTN_Update_Click(object sender, EventArgs e)
        {
            new DBconnect().ExecuteSqlCommand("UPDATE Supplier SET Name = N'" + Txt_Name.Text + "', Phone = N'" + Txt_Phone.Text + "', AddressLine = N'" + Txt_Address.Text + "' WHERE ID = '" + Txt_ID.Text + "'");
            MessageBox.Show("Update Sucessfully");
             Txt_Name.Text = ""; Txt_Phone.Text = ""; Txt_Address.Text = "";
            tabControl1.SelectedTab = tabPage2;
            tabPage1.Hide();
            dataGridView1.DataSource = new DBconnect().SelectTable("SELECT *FROM Supplier");
            Update_Show_False();
            Save_Show();
            tabPage2.Show();
        }
        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                string message = "Do you want to delete?"; string title = "Delete";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    int ID = Convert.ToInt32(dataGridView1.SelectedCells[0].Value);
                    new DBconnect().ExecuteSqlCommand("DELETE FROM Supplier WHERE ID =  '" + ID + "'");

                }
                if (result == DialogResult.No)
                {
                    BTN_Show.PerformClick();
                }

            }
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
    }
}
