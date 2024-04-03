namespace Mini_Mart_Test
{
    partial class Sale_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sale_Form));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Txt_Employee = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.Page_Print = new System.Windows.Forms.RichTextBox();
            this.txt_MethodID = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.combo_Method = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BTN_Sale = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SaleGridVIew = new System.Windows.Forms.DataGridView();
            this.Barcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sub_Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Txt_QTY = new System.Windows.Forms.TextBox();
            this.Combo_Product = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Combo_Barcode = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Txt_Total = new System.Windows.Forms.TextBox();
            this.BTN_Print = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.BTN_SaleTotal = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TextBox_Id = new System.Windows.Forms.TextBox();
            this.BTN_NEW_Customer = new System.Windows.Forms.Button();
            this.Customer_ID = new System.Windows.Forms.TextBox();
            this.Txt_Employee_ID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Combo_Customer = new System.Windows.Forms.ComboBox();
            
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            
            this.mini_ShopDataSet1 = new Mini_Mart_Test.Mini_ShopDataSet1();
            this.employeeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter1 = new Mini_Mart_Test.Mini_ShopDataSet1TableAdapters.EmployeeTableAdapter();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaleGridVIew)).BeginInit();
            this.panel4.SuspendLayout();
            
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mini_ShopDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1684, 80);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Khmer OS Content", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "លក់ចេញ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel2.Controls.Add(this.Txt_Employee);
            this.panel2.Controls.Add(this.label17);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.txt_MethodID);
            this.panel2.Controls.Add(this.label15);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.TextBox_Id);
            this.panel2.Controls.Add(this.BTN_NEW_Customer);
            this.panel2.Controls.Add(this.Customer_ID);
            this.panel2.Controls.Add(this.Txt_Employee_ID);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.Combo_Customer);
            this.panel2.Location = new System.Drawing.Point(0, 81);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1689, 974);
            this.panel2.TabIndex = 1;
            // 
            // Txt_Employee
            // 
            this.Txt_Employee.Font = new System.Drawing.Font("Khmer OS Content", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Employee.Location = new System.Drawing.Point(365, 23);
            this.Txt_Employee.Name = "Txt_Employee";
            this.Txt_Employee.ReadOnly = true;
            this.Txt_Employee.Size = new System.Drawing.Size(131, 36);
            this.Txt_Employee.TabIndex = 48;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Khmer OS Content", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(265, 29);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 31);
            this.label17.TabIndex = 47;
            this.label17.Text = "Employee:";
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.Controls.Add(this.Page_Print);
            this.panel6.Location = new System.Drawing.Point(983, 21);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(640, 768);
            this.panel6.TabIndex = 44;
            // 
            // Page_Print
            // 
            this.Page_Print.BackColor = System.Drawing.SystemColors.Window;
            this.Page_Print.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Page_Print.Font = new System.Drawing.Font("Khmer OS Content", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Page_Print.Location = new System.Drawing.Point(0, 0);
            this.Page_Print.Margin = new System.Windows.Forms.Padding(4);
            this.Page_Print.Name = "Page_Print";
            this.Page_Print.ReadOnly = true;
            this.Page_Print.Size = new System.Drawing.Size(640, 768);
            this.Page_Print.TabIndex = 0;
            this.Page_Print.Text = "";
            // 
            // txt_MethodID
            // 
            this.txt_MethodID.Font = new System.Drawing.Font("Khmer OS Content", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_MethodID.Location = new System.Drawing.Point(730, 26);
            this.txt_MethodID.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MethodID.Name = "txt_MethodID";
            this.txt_MethodID.ReadOnly = true;
            this.txt_MethodID.Size = new System.Drawing.Size(27, 38);
            this.txt_MethodID.TabIndex = 43;
            this.txt_MethodID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_MethodID.Visible = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Khmer OS Content", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(686, 29);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(36, 31);
            this.label15.TabIndex = 42;
            this.label15.Text = "ID:";
            this.label15.Visible = false;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.combo_Method);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.BTN_Sale);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Controls.Add(this.Txt_QTY);
            this.panel5.Controls.Add(this.Combo_Product);
            this.panel5.Controls.Add(this.label11);
            this.panel5.Controls.Add(this.Combo_Barcode);
            this.panel5.Location = new System.Drawing.Point(19, 151);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(885, 610);
            this.panel5.TabIndex = 41;
            // 
            // combo_Method
            // 
            this.combo_Method.Font = new System.Drawing.Font("Khmer OS Content", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_Method.FormattingEnabled = true;
            this.combo_Method.Location = new System.Drawing.Point(677, 27);
            this.combo_Method.Margin = new System.Windows.Forms.Padding(4);
            this.combo_Method.Name = "combo_Method";
            this.combo_Method.Size = new System.Drawing.Size(93, 37);
            this.combo_Method.TabIndex = 36;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Khmer OS Content", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(605, 37);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 31);
            this.label14.TabIndex = 35;
            this.label14.Text = "Method:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Khmer OS Content", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 1);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 31);
            this.label8.TabIndex = 20;
            this.label8.Text = "Sale";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Khmer OS Content", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(245, 33);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 31);
            this.label9.TabIndex = 23;
            this.label9.Text = "Product:";
            // 
            // BTN_Sale
            // 
            this.BTN_Sale.Location = new System.Drawing.Point(780, 27);
            this.BTN_Sale.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Sale.Name = "BTN_Sale";
            this.BTN_Sale.Size = new System.Drawing.Size(61, 41);
            this.BTN_Sale.TabIndex = 34;
            this.BTN_Sale.Text = "Add";
            this.BTN_Sale.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Khmer OS Content", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(479, 34);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 31);
            this.label10.TabIndex = 24;
            this.label10.Text = "QTY:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.SaleGridVIew);
            this.panel3.Location = new System.Drawing.Point(11, 74);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(831, 521);
            this.panel3.TabIndex = 33;
            // 
            // SaleGridVIew
            // 
            this.SaleGridVIew.AllowUserToAddRows = false;
            this.SaleGridVIew.AllowUserToResizeColumns = false;
            this.SaleGridVIew.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaleGridVIew.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.SaleGridVIew.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.SaleGridVIew.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.SaleGridVIew.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.SaleGridVIew.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Khmer OS Content", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SaleGridVIew.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.SaleGridVIew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SaleGridVIew.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Barcode,
            this.Name1,
            this.Price,
            this.Quantity,
            this.Sub_Total,
            this.Delete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Khmer OS Content", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SaleGridVIew.DefaultCellStyle = dataGridViewCellStyle3;
            this.SaleGridVIew.Location = new System.Drawing.Point(0, 2);
            this.SaleGridVIew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaleGridVIew.Name = "SaleGridVIew";
            this.SaleGridVIew.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Khmer OS Content", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SaleGridVIew.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.SaleGridVIew.RowHeadersVisible = false;
            this.SaleGridVIew.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Khmer OS Content", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaleGridVIew.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.SaleGridVIew.RowTemplate.Height = 24;
            this.SaleGridVIew.Size = new System.Drawing.Size(831, 517);
            this.SaleGridVIew.TabIndex = 5;
            this.SaleGridVIew.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SaleGridVIew_CellContentClick);
            // 
            // Barcode
            // 
            this.Barcode.HeaderText = "Barcode";
            this.Barcode.MinimumWidth = 6;
            this.Barcode.Name = "Barcode";
            this.Barcode.ReadOnly = true;
            // 
            // Name1
            // 
            this.Name1.HeaderText = "Product";
            this.Name1.MinimumWidth = 6;
            this.Name1.Name = "Name1";
            this.Name1.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.MinimumWidth = 6;
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Sub_Total
            // 
            this.Sub_Total.HeaderText = "Sub Total";
            this.Sub_Total.MinimumWidth = 6;
            this.Sub_Total.Name = "Sub_Total";
            this.Sub_Total.ReadOnly = true;
            // 
            // Delete
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.MenuBar;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Khmer OS Content", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.Delete.DefaultCellStyle = dataGridViewCellStyle2;
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // Txt_QTY
            // 
            this.Txt_QTY.Font = new System.Drawing.Font("Khmer OS Content", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_QTY.Location = new System.Drawing.Point(539, 28);
            this.Txt_QTY.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_QTY.Name = "Txt_QTY";
            this.Txt_QTY.Size = new System.Drawing.Size(57, 38);
            this.Txt_QTY.TabIndex = 25;
            this.Txt_QTY.Text = "1";
            // 
            // Combo_Product
            // 
            this.Combo_Product.Font = new System.Drawing.Font("Khmer OS Content", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combo_Product.FormattingEnabled = true;
            this.Combo_Product.Location = new System.Drawing.Point(333, 27);
            this.Combo_Product.Margin = new System.Windows.Forms.Padding(4);
            this.Combo_Product.Name = "Combo_Product";
            this.Combo_Product.Size = new System.Drawing.Size(135, 37);
            this.Combo_Product.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Khmer OS Content", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(4, 31);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 31);
            this.label11.TabIndex = 27;
            this.label11.Text = "Barcode:";
            // 
            // Combo_Barcode
            // 
            this.Combo_Barcode.Font = new System.Drawing.Font("Khmer OS Content", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combo_Barcode.FormattingEnabled = true;
            this.Combo_Barcode.Location = new System.Drawing.Point(92, 27);
            this.Combo_Barcode.Margin = new System.Windows.Forms.Padding(4);
            this.Combo_Barcode.Name = "Combo_Barcode";
            this.Combo_Barcode.Size = new System.Drawing.Size(136, 37);
            this.Combo_Barcode.TabIndex = 28;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Txt_Total);
            this.panel4.Controls.Add(this.BTN_Print);
            this.panel4.Controls.Add(this.label12);
            this.panel4.Controls.Add(this.BTN_SaleTotal);
            this.panel4.Location = new System.Drawing.Point(19, 765);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(885, 62);
            this.panel4.TabIndex = 40;
            // 
            // Txt_Total
            // 
            this.Txt_Total.Font = new System.Drawing.Font("Khmer OS Content", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Total.Location = new System.Drawing.Point(71, 4);
            this.Txt_Total.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Total.Name = "Txt_Total";
            this.Txt_Total.ReadOnly = true;
            this.Txt_Total.Size = new System.Drawing.Size(135, 38);
            this.Txt_Total.TabIndex = 39;
            // 
            // BTN_Print
            // 
            this.BTN_Print.Location = new System.Drawing.Point(214, 5);
            this.BTN_Print.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_Print.Name = "BTN_Print";
            this.BTN_Print.Size = new System.Drawing.Size(100, 41);
            this.BTN_Print.TabIndex = 38;
            this.BTN_Print.Text = "Print";
            this.BTN_Print.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Khmer OS Content", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(5, 10);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 31);
            this.label12.TabIndex = 35;
            this.label12.Text = "Total:";
            // 
            // BTN_SaleTotal
            // 
            this.BTN_SaleTotal.Location = new System.Drawing.Point(322, 5);
            this.BTN_SaleTotal.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_SaleTotal.Name = "BTN_SaleTotal";
            this.BTN_SaleTotal.Size = new System.Drawing.Size(100, 41);
            this.BTN_SaleTotal.TabIndex = 37;
            this.BTN_SaleTotal.Text = "Sale";
            this.BTN_SaleTotal.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Khmer OS Content", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 28);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 31);
            this.label7.TabIndex = 19;
            this.label7.Text = "Invoice No.";
            // 
            // TextBox_Id
            // 
            this.TextBox_Id.Font = new System.Drawing.Font("Khmer OS Content", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Id.Location = new System.Drawing.Point(116, 26);
            this.TextBox_Id.Margin = new System.Windows.Forms.Padding(4);
            this.TextBox_Id.Name = "TextBox_Id";
            this.TextBox_Id.ReadOnly = true;
            this.TextBox_Id.Size = new System.Drawing.Size(135, 38);
            this.TextBox_Id.TabIndex = 18;
            // 
            // BTN_NEW_Customer
            // 
            this.BTN_NEW_Customer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BTN_NEW_Customer.BackgroundImage")));
            this.BTN_NEW_Customer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BTN_NEW_Customer.FlatAppearance.BorderSize = 0;
            this.BTN_NEW_Customer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_NEW_Customer.Font = new System.Drawing.Font("Khmer OS Content", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTN_NEW_Customer.Location = new System.Drawing.Point(271, 76);
            this.BTN_NEW_Customer.Margin = new System.Windows.Forms.Padding(4);
            this.BTN_NEW_Customer.Name = "BTN_NEW_Customer";
            this.BTN_NEW_Customer.Size = new System.Drawing.Size(31, 41);
            this.BTN_NEW_Customer.TabIndex = 17;
            this.BTN_NEW_Customer.UseVisualStyleBackColor = true;
            // 
            // Customer_ID
            // 
            this.Customer_ID.Font = new System.Drawing.Font("Khmer OS Content", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Customer_ID.Location = new System.Drawing.Point(650, 26);
            this.Customer_ID.Margin = new System.Windows.Forms.Padding(4);
            this.Customer_ID.Name = "Customer_ID";
            this.Customer_ID.ReadOnly = true;
            this.Customer_ID.Size = new System.Drawing.Size(27, 38);
            this.Customer_ID.TabIndex = 15;
            this.Customer_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Customer_ID.Visible = false;
            // 
            // Txt_Employee_ID
            // 
            this.Txt_Employee_ID.Font = new System.Drawing.Font("Khmer OS Content", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_Employee_ID.Location = new System.Drawing.Point(563, 21);
            this.Txt_Employee_ID.Margin = new System.Windows.Forms.Padding(4);
            this.Txt_Employee_ID.Name = "Txt_Employee_ID";
            this.Txt_Employee_ID.ReadOnly = true;
            this.Txt_Employee_ID.Size = new System.Drawing.Size(27, 38);
            this.Txt_Employee_ID.TabIndex = 14;
            this.Txt_Employee_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Txt_Employee_ID.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Khmer OS Content", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(606, 30);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 31);
            this.label6.TabIndex = 13;
            this.label6.Text = "ID:";
            this.label6.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Khmer OS Content", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(519, 31);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 31);
            this.label5.TabIndex = 12;
            this.label5.Text = "ID:";
            this.label5.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Khmer OS Content", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Customer:";
            // 
            // Combo_Customer
            // 
            this.Combo_Customer.Font = new System.Drawing.Font("Khmer OS Content", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Combo_Customer.FormattingEnabled = true;
            this.Combo_Customer.Location = new System.Drawing.Point(113, 76);
            this.Combo_Customer.Margin = new System.Windows.Forms.Padding(4);
            this.Combo_Customer.Name = "Combo_Customer";
            this.Combo_Customer.Size = new System.Drawing.Size(138, 37);
            this.Combo_Customer.TabIndex = 6;
            // 
            // mini_ShopDataSet
            // 
          
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            
            // 
            // employeeTableAdapter
            // 
            
            // 
            // mini_ShopDataSet1
            // 
            this.mini_ShopDataSet1.DataSetName = "Mini_ShopDataSet1";
            this.mini_ShopDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource1
            // 
            this.employeeBindingSource1.DataMember = "Employee";
            this.employeeBindingSource1.DataSource = this.mini_ShopDataSet1;
            // 
            // employeeTableAdapter1
            // 
            this.employeeTableAdapter1.ClearBeforeFill = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Sale_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1684, 1055);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Sale_Form";
            this.Text = "Sale_Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Sale_Form_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SaleGridVIew)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
       
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mini_ShopDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Combo_Customer;
      
        private System.Windows.Forms.BindingSource employeeBindingSource;
     
        private Mini_ShopDataSet1 mini_ShopDataSet1;
        private System.Windows.Forms.BindingSource employeeBindingSource1;
        private Mini_ShopDataSet1TableAdapters.EmployeeTableAdapter employeeTableAdapter1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Customer_ID;
        private System.Windows.Forms.TextBox Txt_Employee_ID;
        private System.Windows.Forms.Button BTN_NEW_Customer;
        private System.Windows.Forms.TextBox TextBox_Id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Txt_QTY;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox Combo_Product;
        private System.Windows.Forms.ComboBox Combo_Barcode;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView SaleGridVIew;
        private System.Windows.Forms.Button BTN_Sale;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button BTN_SaleTotal;
        private System.Windows.Forms.Button BTN_Print;
        private System.Windows.Forms.TextBox Txt_Total;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox combo_Method;
        private System.Windows.Forms.TextBox txt_MethodID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RichTextBox Page_Print;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.TextBox Txt_Employee;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Barcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sub_Total;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}