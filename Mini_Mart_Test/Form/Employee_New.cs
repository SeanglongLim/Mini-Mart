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
    public partial class Employee_New : Form
    {
        public Employee_New()
        {
            InitializeComponent();
            BTN_Save.Click += BTN_Save_Click;
            BTN_Update.Visible = false;
            BTN_Update.Enabled = false;
            tabControl1.Click += TabControl1_Click;
            dataGridView1.KeyDown += DataGridView1_KeyDown;
            dataGridView1.CellDoubleClick += DataGridView1_CellDoubleClick;
            BTN_Update.Click += BTN_Update_Click;
            BTN_Clear.Click += BTN_Clear_Click;
            BTN_Show.Click += BTN_Show_Click;
            textBox2.TextChanged += TextBox2_TextChanged;
            label1.Hide();
            Txt_ID.Hide();
            
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection($"Data Source=DESKTOP-KH27LVJ\\SQLEXPRESS;Initial Catalog=Mini_Shop;Integrated Security=True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Employee WHERE Name = @Name", conn);
                cmd.Parameters.AddWithValue("@Name", textBox2.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void BTN_Show_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new DBconnect().SelectTable("SELECT *FROM Employee");
        }
        private void BTN_Clear_Click(object sender, EventArgs e)
        {
            Txt_ID.Text = ""; Txt_Name.Text = ""; Txt_Phone.Text = ""; Txt_Password.Text = ""; Txt_Confirm_Password.Text = "";
            BTN_Update.Visible = false;
            BTN_Update.Enabled = false;
            BTN_Save.Visible = true;
            BTN_Save.Enabled = true;
        }
        private void BTN_Update_Click(object sender, EventArgs e)
        {
            if (Txt_Password.Text == Txt_Confirm_Password.Text)
            {
                new DBconnect().ExecuteSqlCommand("UPDATE Employee SET Name = N'" + Txt_Name.Text + "', Phone = N'" + Txt_Phone.Text + "', EmpPassword = N'" + Txt_Password.Text + "' WHERE ID = '" + Txt_ID.Text + "'");
                MessageBox.Show("Update Sucessfully");
                Txt_Name.Text = ""; Txt_Phone.Text = ""; Txt_Password.Text = ""; Txt_Confirm_Password.Text = "";
                tabControl1.SelectedTab = tabPage2;
                tabPage1.Hide();
                dataGridView1.DataSource = new DBconnect().SelectTable("SELECT *FROM Employee");
                Update_Show_False();
                Save_Show();
                tabPage2.Show();
            }
            else
            {
                MessageBox.Show("Password and Confirm Password Must be the Same");
            }
            
        }
        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tabPage1.Show();
            Txt_ID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Txt_Name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Txt_Phone.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            Txt_Password.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            Txt_Confirm_Password.Text = Txt_Password.Text;
            Update_Show();
            Save_Show_False();
         
        }
        private void DataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                string message = "Do you want to delete?"; string title = "Delete";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    int ID = Convert.ToInt32(dataGridView1.SelectedCells[0].Value);
                    new DBconnect().ExecuteSqlCommand("DELETE FROM Employee WHERE ID =  '" + ID + "'");

                }
                if (result == DialogResult.No)
                {
                    BTN_Show.PerformClick();
                }
            }
        }
        private void TabControl1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new DBconnect().SelectTable("SELECT *FROM Employee");
        }
        private void BTN_Save_Click(object sender, EventArgs e)
        {
            if (Txt_Password.Text == Txt_Confirm_Password.Text)
            {
                new DBconnect().ExecuteSqlCommand("INSERT INTO Employee(Name,Phone,EmpPassword) VALUES(N'" + Txt_Name.Text + "',N'" + Txt_Phone.Text + "',N'" + Txt_Password.Text + "')");
                Txt_Name.Text = ""; Txt_Phone.Text = ""; Txt_Password.Text = ""; Txt_Confirm_Password.Text ="";
                MessageBox.Show("Saved");
            }
            else
            {
                MessageBox.Show("Password and Confirm Password Must be the Same");
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
