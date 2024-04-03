using Mini_Mart_Test.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Mini_Mart_Test
{
    public partial class MasterForm : Form
    {
        private readonly EmployeeInfo employeeInfo;

        public MasterForm(EmployeeInfo employeeInfo)
        {

            InitializeComponent();
            this.employeeInfo = employeeInfo;
            អតថជនToolStripMenuItem.Click += អតថជនToolStripMenuItem_Click;
            បគគលកToolStripMenuItem.Click += បគគលកToolStripMenuItem_Click;
            ទកទងToolStripMenuItem.Click += ទកទងToolStripMenuItem_Click;
            ទនញToolStripMenuItem.Click += ទនញToolStripMenuItem_Click;
            អនកផគតផគងToolStripMenuItem.Click += អនកផគតផគងToolStripMenuItem_Click;
            telegramToolStripMenuItem.Click += TelegramToolStripMenuItem_Click;
            faceBookToolStripMenuItem.Click += FaceBookToolStripMenuItem_Click;
            លកចញToolStripMenuItem1.Click += លកចញToolStripMenuItem1_Click;
            ទញចលToolStripMenuItem.Click += ទញចលToolStripMenuItem_Click;
            បញ្ញីលកចញToolStripMenuItem.Click += បញ្ញីលកចញToolStripMenuItem_Click;

        }

        private void បញ្ញីលកចញToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaleReport saleReport = new SaleReport()
            { TopLevel = false, TopMost = false };
            saleReport.FormBorderStyle = FormBorderStyle.None;
            PCustomer.Controls.Add(saleReport);
            saleReport.Show();
            saleReport.Visible = true;
        }

        private void ទញចលToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PurchaseForm purchaseForm = new PurchaseForm() { TopLevel = false, TopMost = false }; ;
            purchaseForm.FormBorderStyle = FormBorderStyle.None;
            PCustomer.Controls.Add(purchaseForm);
            purchaseForm.Show();
            purchaseForm.Visible = true;
        }

        private void លកចញToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            PCustomer.Controls.Clear();
            Sale_Form sale_Form = new Sale_Form(employeeInfo) { TopLevel = false, TopMost = false };
            sale_Form.FormBorderStyle = FormBorderStyle.None;
            PCustomer.Controls.Add(sale_Form);
            sale_Form.Show();
            sale_Form.Visible = true;
        }

        private void FaceBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://web.facebook.com/messages/t/100027886353159");
        }

        private void TelegramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://t.me/SeanglongLim");
        }

        private void អនកផគតផគងToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PCustomer.Controls.Clear();
            Supplier_New supplier_New = new Supplier_New() { TopLevel = false, TopMost = false };
            supplier_New.FormBorderStyle = FormBorderStyle.None;
            PCustomer.Controls.Add(supplier_New);
            supplier_New.Show();
            supplier_New.Visible = true;
        }

        private void ទនញToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PCustomer.Controls.Clear();
            Product_New product_New = new Product_New() { TopLevel = false, TopMost = false };
            product_New.FormBorderStyle = FormBorderStyle.None;
            PCustomer.Controls.Add(product_New);
            product_New.Show();
            product_New.Visible = true;
        }

        private void ទកទងToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void បគគលកToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PCustomer.Controls.Clear();
            Employee_New employee_New = new Employee_New() { TopLevel = false, TopMost = false };
            employee_New.FormBorderStyle = FormBorderStyle.None;
            PCustomer.Controls.Add(employee_New);
            employee_New.Show();
        }

        private void អតថជនToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PCustomer.Controls.Clear();
            Customer_New customer_New = new Customer_New() { TopLevel = false, TopMost = false };
            customer_New.FormBorderStyle = FormBorderStyle.None;
            PCustomer.Controls.Add(customer_New);
            customer_New.Show();
            customer_New.Visible = true;

        }


    }
}
