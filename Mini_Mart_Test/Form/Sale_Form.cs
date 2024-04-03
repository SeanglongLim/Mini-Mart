using Mini_Mart_Test.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace Mini_Mart_Test
{
    public partial class Sale_Form : Form
    {
        private static int currentID = 1;
        
        public Sale_Form(EmployeeInfo employeeInfo)
        {
            InitializeComponent();
            MessageBox.Show($"Logged in as: {employeeInfo.EmployeeName} (ID: {employeeInfo.EmployeeID})");
            Txt_Employee.Text = employeeInfo.EmployeeName;
            Txt_Employee_ID.Text = employeeInfo.EmployeeID;
            loadSaleID();
            Combo_Customer.SelectedIndexChanged += Combo_Customer_SelectedIndexChanged;
            BTN_NEW_Customer.Click += BTN_NEW_Customer_Click;
            BTN_Sale.Click += BTN_Sale_Click;
            combo_Method.SelectedIndexChanged += Combo_Method_SelectedIndexChanged;
            BTN_Print.Click += BTN_Print_Click;
            BTN_SaleTotal.Click += BTN_SaleTotal_Click;
            
                 
        }
        private void loadSaleID()
        {
            DBconnect dbConnect = new DBconnect();
            string saleIDQuery = "SELECT MAX(ID) FROM Sale;";
            object saleIDResult = dbConnect.ExecuteScalar(saleIDQuery);
            int saleIDRes = Convert.ToInt32(saleIDResult)+1;
            if (saleIDResult != null && saleIDResult != DBNull.Value )
            {
                
                TextBox_Id.Text = saleIDRes.ToString();
            }
            else
            {
                TextBox_Id.Text = "No Sale ID available yet";
            }
        }

        

        private void BTN_SaleTotal_Click(object sender, EventArgs e)
        {
            DBconnect dbConnect = new DBconnect();
            string saleInsertQuery = $"INSERT INTO Sale(DateOfSale, EmployeeID, CustomerID) " +
                $"VALUES('{DateTime.Now}', N'{Txt_Employee_ID.Text}', N'{Customer_ID.Text}')";
            dbConnect.ExecuteSqlCommand(saleInsertQuery);
            string saleIDQuery = "SELECT MAX(ID) FROM Sale;";
            object saleIDResult = dbConnect.ExecuteScalar(saleIDQuery);
            if (saleIDResult != null && saleIDResult != DBNull.Value)
            {
                int saleID = Convert.ToInt32(saleIDResult);
                for (int i = 0; i < SaleGridVIew.Rows.Count; i++)
                {
                    DataGridViewRowCollection rows = SaleGridVIew.Rows;
                    if (rows[i] != null)
                    {
                        double price = Convert.ToDouble(rows[i].Cells[2].Value.ToString());
                        int quantity = Convert.ToInt32(rows[i].Cells[3].Value.ToString());                
                        int productID = GetProductIDFromDataSource(rows[i]);
                        string insertQuery = "INSERT INTO SaleProduct (SaleID, ProductID, Quantity, Price) " +
                                             "VALUES (@SaleID, @ProductID, @Quantity, @Price)";
                        using (SqlCommand cmd = new SqlCommand(insertQuery, dbConnect.GetConnection()))
                        {
                            cmd.Parameters.AddWithValue("@SaleID", saleID);
                            cmd.Parameters.AddWithValue("@ProductID", productID);
                            cmd.Parameters.AddWithValue("@Quantity", quantity);
                            cmd.Parameters.AddWithValue("@Price", price);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            if (saleIDResult != null && saleIDResult != DBNull.Value)
            {
                double total = 0.0;
                for (int i = 0; i < SaleGridVIew.Rows.Count; i++)
                {
                    total += Convert.ToDouble(SaleGridVIew.Rows[i].Cells[4].Value);
                }
                string salePaymentQuery = $"INSERT INTO SalePayment(SaleID,Employee,PaymentDate,Amount,MethodID)" +
                    $"VALUES('{saleIDResult}',N'{Txt_Employee_ID.Text}','{DateTime.Now}','{total}','{combo_Method.SelectedValue}')";
                dbConnect.ExecuteSqlCommand(salePaymentQuery);
            }
            PagePrint();
            Page_Print.Clear();
            SaleGridVIew.Rows.Clear();
            loadSaleID();
        }
        private int GetProductIDFromDataSource(DataGridViewRow row)
        {
            return Convert.ToInt32(row.Cells[2].Value);
        }
        private void pagepreview()
        {
            Page_Print.Clear();
            string title = "Mini Mart Receipt";
            string saleLine = "Sale Date: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string invoice = "Invoice:" + TextBox_Id.Text;
            int padding = (Page_Print.Width - title.Length) / 2;
            int paddingSale = (Page_Print.Width - saleLine.Length) / 2;
            int paddingInvoice = (Page_Print.Width - invoice.Length) / 2;
            string centeredTitle = new string(' ', padding) + title;
            string centeredSaleLine = new string(' ', paddingSale) + saleLine;
            string centeredInvoiceLine = new string(' ', paddingInvoice) + invoice;


            Page_Print.SelectionAlignment = HorizontalAlignment.Center;
            Page_Print.AppendText(centeredTitle + "\n");
            Page_Print.SelectionAlignment = HorizontalAlignment.Center;
            Page_Print.AppendText(centeredSaleLine + "\n");
            Page_Print.SelectionAlignment = HorizontalAlignment.Center;
            Page_Print.AppendText(centeredInvoiceLine + "\n");

            DataRowView selectedCustomerRow = (DataRowView)Combo_Customer.SelectedItem;
            string customerName = selectedCustomerRow["Name"].ToString();
            Page_Print.AppendText("Customer: " + customerName + "\n");


            Page_Print.AppendText("Employee: " + Txt_Employee.Text + "\n");

            DataRowView selectedMethodRow = (DataRowView)combo_Method.SelectedItem;
            string method = selectedMethodRow["Method"].ToString();
            Page_Print.AppendText("Method: " + method + "\n");

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Barcode       Price           Product       Quantity");
            sb.AppendLine("------------------------------------------------------------------------------------------");

            for (int i = 0; i < SaleGridVIew.Rows.Count; i++)
            {
                DataGridViewRowCollection rows = SaleGridVIew.Rows;

                if (rows[i] != null)
                {
                    string barcode = rows[i].Cells[0].Value?.ToString().PadRight(15);
                    string productName = rows[i].Cells[1].Value?.ToString().PadRight(15);
                    double price = Convert.ToDouble(rows[i].Cells[2].Value.ToString().PadRight(15));
                    int quantity = Convert.ToInt32(rows[i].Cells[3].Value.ToString().PadRight(15));

                    string line = string.Format("{0,-10}{1,-15}{2,-15}{3,-15}",
                        barcode, price, productName, quantity);

                    sb.AppendLine(line);
                }
            }

            string total = "Total: " + Txt_Total.Text + "$";
            sb.AppendLine("------------------------------------------------------------------------------------------");
            sb.AppendLine(total);

            Page_Print.AppendText(sb.ToString());
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += printDocument1_PrintPage;
        }
        private void PagePrint()
        {
            Page_Print.Clear();
            string title = "Mini Mart Receipt";
            string saleLine = "Sale Date: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            string invoice = "Invoice:" + TextBox_Id.Text;
            int padding = (Page_Print.Width - title.Length) / 2;
            int paddingSale = (Page_Print.Width - saleLine.Length) / 2;
            int paddingInvoice = (Page_Print.Width - invoice.Length) / 2;
            string centeredTitle = new string(' ', padding) + title;
            string centeredSaleLine = new string(' ', paddingSale) + saleLine;
            string centeredInvoiceLine = new string(' ', paddingInvoice) + invoice;


            Page_Print.SelectionAlignment = HorizontalAlignment.Center;
            Page_Print.AppendText(centeredTitle + "\n");
            Page_Print.SelectionAlignment = HorizontalAlignment.Center;
            Page_Print.AppendText(centeredSaleLine + "\n");
            Page_Print.SelectionAlignment = HorizontalAlignment.Center;
            Page_Print.AppendText(centeredInvoiceLine + "\n");

            DataRowView selectedCustomerRow = (DataRowView)Combo_Customer.SelectedItem;
            string customerName = selectedCustomerRow["Name"].ToString();
            Page_Print.AppendText("Customer: " + customerName + "\n");


            Page_Print.AppendText("Employee: " + Txt_Employee.Text + "\n");

            DataRowView selectedMethodRow = (DataRowView)combo_Method.SelectedItem;
            string method = selectedMethodRow["Method"].ToString();
            Page_Print.AppendText("Method: " + method + "\n");

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Barcode       Price           Product       Quantity");
            sb.AppendLine("------------------------------------------------------------------------------------------");

            for (int i = 0; i < SaleGridVIew.Rows.Count; i++)
            {
                DataGridViewRowCollection rows = SaleGridVIew.Rows;

                if (rows[i] != null)
                {
                    string barcode = rows[i].Cells[0].Value?.ToString().PadRight(15);
                    string productName = rows[i].Cells[1].Value?.ToString().PadRight(15);
                    double price = Convert.ToDouble(rows[i].Cells[2].Value.ToString().PadRight(15));
                    int quantity = Convert.ToInt32(rows[i].Cells[3].Value.ToString().PadRight(15));

                    string line = string.Format("{0,-10}{1,-15}{2,-15}{3,-15}",
                        barcode, price, productName, quantity);

                    sb.AppendLine(line);
                }
            }

            string total = "Total: " + Txt_Total.Text + "$";
            sb.AppendLine("------------------------------------------------------------------------------------------");
            sb.AppendLine(total);

            Page_Print.AppendText(sb.ToString());
            PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += printDocument1_PrintPage;

            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = printDocument;

            if (printPreviewDialog.ShowDialog() == DialogResult.OK)
            {
                PrintDialog printDialog = new PrintDialog();
                printDialog.Document = printDocument;


                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.Print();
                }
            }
        }
        private void BTN_Print_Click(object sender, EventArgs e)
        {
            PagePrint();

        }
        private void Combo_Method_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_Method.SelectedIndex != -1)
            {
                DataRowView selectedRow = (DataRowView)combo_Method.SelectedItem;
                string id = selectedRow["ID"].ToString();
                txt_MethodID.Text = id;
            }
            else
            {
                txt_MethodID.Text = string.Empty;
            }
        }
        private void BTN_Sale_Click(object sender, EventArgs e)
        {
            
            DataRowView barcodeItem = Combo_Barcode.SelectedItem as DataRowView;
            DataRowView productItem = Combo_Product.SelectedItem as DataRowView;
            if (barcodeItem != null && productItem != null)
            {
                string barcode = barcodeItem["Barcode"].ToString();
                if (productItem.Row.Table.Columns.Contains("Name") && productItem.Row.Table.Columns.Contains("Price"))
                {
                    string product_name = productItem["Name"].ToString();
                    double price = Convert.ToDouble(productItem["Price"]);

                    int quantity = int.Parse(Txt_QTY.Text);
                    double totalPrice = quantity * price;

                    SaleGridVIew.Rows.Add(new object[] { barcode,product_name,price, quantity, totalPrice });
                }
                else
                {
                    MessageBox.Show("Selected product item is not valid.");
                }
            }
            else
            { 
                MessageBox.Show("Please select both a barcode and a product.");
            }
            double total = 0.0;
            for (int i = 0; i < SaleGridVIew.Rows.Count; i++)
            {
                total += Convert.ToDouble(SaleGridVIew.Rows[i].Cells[4].Value);
            }
            Txt_Total.Text = total.ToString();
            pagepreview();
        }
        private void BTN_NEW_Customer_Click(object sender, EventArgs e)
        {
            Customer_New customer = new Customer_New();
            customer.Show();
            customer.FormClosed += Customer_FormClosed;
        }
        private void Customer_FormClosed(object sender, FormClosedEventArgs e)
        {
            RefreshComboCustomer();
        }
        private void Combo_Customer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Combo_Customer.SelectedIndex != -1) 
            {
                DataRowView selectedRow = (DataRowView)Combo_Customer.SelectedItem;
                string id = selectedRow["ID"].ToString();
                Customer_ID.Text = id;
                
            }
            else
            {
                Customer_ID.Text = string.Empty; 
            }
        }
        private void Sale_Form_Load(object sender, EventArgs e)
        {
            
            LoadComboCustomer();    
            LoadComboProduct();
            LoadComboBarcode();
            LoadComboMethod();
         
        }

        private void LoadComboCustomer()
        {
            string query1 = "SELECT * FROM Customer";
            DataTable dataTable1 = new DBconnect().SelectTable(query1);

            Combo_Customer.DisplayMember = "Name";
            Combo_Customer.ValueMember = "ID";
            Combo_Customer.DataSource = dataTable1;
            Combo_Customer.AutoCompleteMode = AutoCompleteMode.Suggest;    
            Combo_Customer.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
        private void LoadComboBarcode()
        {
            string query = "SELECT *FROM Product";
            DataTable dataTable = new DBconnect().SelectTable(query);

            Combo_Barcode.DisplayMember = "BarCode";
            Combo_Barcode.ValueMember = "ID";
            Combo_Barcode.DataSource = dataTable;
            Combo_Barcode.AutoCompleteMode = AutoCompleteMode.Suggest;
            Combo_Barcode.AutoCompleteSource = AutoCompleteSource.ListItems;
            Combo_Barcode.SelectedIndexChanged += Combo_Barcode_SelectedIndexChanged;
        }
        private void Combo_Barcode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Combo_Barcode.SelectedItem != null)
            {
                DataRowView selectedRow = (DataRowView)Combo_Barcode.SelectedItem;
                int selectedID = (int)selectedRow["ID"];

                foreach (DataRowView item in Combo_Product.Items)
                {
                    if ((int)item["ID"] == selectedID)
                    {
                        Combo_Product.SelectedItem = item;
                        break;
                    }
                }
            }
        }
        private void LoadComboProduct()
        {
            string query = "SELECT *FROM Product";
            DataTable dataTable = new DBconnect().SelectTable(query);

            Combo_Product.DisplayMember = "Name";
            Combo_Product.ValueMember = "ID";
            Combo_Product.DataSource = dataTable;
            Combo_Product.AutoCompleteMode = AutoCompleteMode.Suggest;
            Combo_Product.AutoCompleteSource = AutoCompleteSource.ListItems;
            Combo_Product.SelectedIndexChanged += Combo_Product_SelectedIndexChanged;
        }

        private void Combo_Product_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Combo_Product.SelectedItem != null)
            {
                DataRowView selectedRow = (DataRowView)Combo_Product.SelectedItem;
                int selectedID = (int)selectedRow["ID"];
                
                foreach (DataRowView item in Combo_Barcode.Items) 
                {
                    if ((int)item["ID"] == selectedID)
                    {
                        Combo_Barcode.SelectedItem = item;  
                        break;
                    }
                }
            }
        }

        private void RefreshComboCustomer()
        {
            LoadComboCustomer();
        }
        
       


        private void LoadComboMethod()
        {
            string query = "SELECT *FROM PaymentMethod";
            DataTable dataTable = new DBconnect().SelectTable(query);

            combo_Method.DisplayMember = "Method";
            combo_Method.ValueMember = "ID";
            combo_Method.DataSource = dataTable;
            combo_Method.AutoCompleteMode = AutoCompleteMode.Suggest;
            combo_Method.AutoCompleteSource = AutoCompleteSource.ListItems;
            combo_Method.SelectedIndexChanged += Combo_Barcode_SelectedIndexChanged;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

         
            Font font = new Font("Courier New", 15);
            Brush brush = Brushes.Black;

    
            string title = "Mini Mart Receipt";
            string date = "Date: " + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

           
            float titleX = e.MarginBounds.Left;
            float titleY = e.MarginBounds.Top;

            float dateX = e.MarginBounds.Left;
            float dateY = titleY + font.GetHeight();

            e.Graphics.DrawString(title, font, brush, titleX, titleY);
            e.Graphics.DrawString(date, font, brush, dateX, dateY);

            float receiptX = e.MarginBounds.Left;
            float receiptY = dateY + font.GetHeight();
            string receiptText = Page_Print.Text;
            e.Graphics.DrawString(receiptText, font, brush, receiptX, receiptY);
            float signatureX = e.MarginBounds.Left;
            float signatureY = e.MarginBounds.Bottom - 2 * font.GetHeight();
            string signatureText = "Signature: ______________________";
            float imageY = receiptY + font.GetHeight();
            e.Graphics.DrawString(signatureText, font, brush, signatureX, signatureY);


        }

        private void SaleGridVIew_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (SaleGridVIew.Columns[e.ColumnIndex].Name == "Delete") 
            {
                if (SaleGridVIew.Rows.Count > 0)
                {
                    string message = "Do you want to delete?"; string title = "Delete";
                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result == DialogResult.Yes)
                    {
                        SaleGridVIew.Rows.RemoveAt(e.RowIndex);
                        UpdateTotal();
                    }
                    else if(result == DialogResult.No)
                    {
                        UpdateTotal();
                    }
                }
                else
                {
                    MessageBox.Show("You can't remove an empty row");
                }
            }
        }
        private void UpdateTotal()
        {
            double total = 0.0;

            for (int i = 0; i < SaleGridVIew.Rows.Count; i++)
            {
                total += Convert.ToDouble(SaleGridVIew.Rows[i].Cells[4].Value);
            }

            Txt_Total.Text = total.ToString();
        }
    }
    
}
