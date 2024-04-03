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
    public partial class Product_New : Form
    {
        public Product_New()
        {
            InitializeComponent();
            BTN_Update.Visible = false;
            BTN_Update.Enabled = false;
            BTN_Save.Click += BTN_Save_Click;
            tabControl1.Click += TabControl1_Click;
            BTN_Show.Click += BTN_Show_Click;
            BTN_Clear.Click += BTN_Clear_Click;
            dataGridView1.CellDoubleClick += DataGridView1_CellDoubleClick;
            BTN_Update.Click += BTN_Update_Click;
            dataGridView1.KeyDown += DataGridView1_KeyDown;
            textBox2.TextChanged += TextBox2_TextChanged;
            label1.Hide();
            Txt_ID.Hide();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection($"Data Source=DESKTOP-KH27LVJ\\SQLEXPRESS;Initial Catalog=Mini_Shop;Integrated Security=True"))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Product WHERE Name = @Name", conn);
                cmd.Parameters.AddWithValue("@Name", textBox2.Text);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
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
                    new DBconnect().ExecuteSqlCommand("DELETE FROM Product WHERE ID =  '" + ID + "'");

                }
                if (result == DialogResult.No)
                {
                    BTN_Show.PerformClick();
                }
            }
        }
        private void BTN_Update_Click(object sender, EventArgs e)
        {
            new DBconnect().ExecuteSqlCommand("UPDATE Product SET Name = N'" + Txt_Name.Text + "', Price = '" + double.Parse(Txt_Price.Text) + "', Barcode = '" + Txt_Barcode.Text + "' WHERE ID = '" + Txt_ID.Text + "'");
            MessageBox.Show("Update Sucessfully");
            Clear();
            tabControl1.SelectedTab = tabPage2;
            tabPage1.Hide();
            dataGridView1.DataSource = new DBconnect().SelectTable("SELECT *FROM Product");
            Update_Show_False();
            Save_Show();
            tabPage2.Show();
        }

        private void DataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            tabPage1.Show();
            Txt_ID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Txt_Name.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Txt_Price.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            Txt_Barcode.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            Update_Show();
            Save_Show_False();
        }
        private void BTN_Clear_Click(object sender, EventArgs e)
        {
            Txt_Name.Text = ""; Txt_Price.Text = ""; Txt_Barcode.Text = "";
            BTN_Update.Visible = false;
            BTN_Update.Enabled = false;
            BTN_Save.Visible = true;
            BTN_Save.Enabled = true;
        }
        private void BTN_Show_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new DBconnect().SelectTable("SELECT *FROM Product");
        }
        private void TabControl1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new DBconnect().SelectTable("SELECT *FROM Product");
        }
        private void BTN_Save_Click(object sender, EventArgs e)
        {
            new DBconnect().ExecuteSqlCommand("INSERT INTO Product(Name,Price,Barcode) VALUES(N'" + Txt_Name.Text + "','" + double.Parse(Txt_Price.Text) + "',N'" + Txt_Barcode.Text + "')");
            Clear();
            MessageBox.Show("Saved");
        }
        private void Clear()
        {
            Txt_ID.Text = ""; Txt_Name.Text = ""; Txt_Price.Text = ""; Txt_Barcode.Text = "";
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
