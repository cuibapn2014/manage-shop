
namespace giaodiencuoiki
{
    partial class FrmQuanLyBanHang
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_sell = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btn_save = new System.Windows.Forms.Button();
            this.data_addProduct = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btn_editProduct = new System.Windows.Forms.Button();
            this.btn_deleteProduct = new System.Windows.Forms.Button();
            this.btn_addProduct = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.txt_productTitle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.txt_inventory = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_findProduct = new System.Windows.Forms.TextBox();
            this.txt_productCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.txt_addressCustomer = new System.Windows.Forms.TextBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_phoneCustomer = new System.Windows.Forms.TextBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_customer = new System.Windows.Forms.TextBox();
            this.panel15 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_idCustomer = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_nameCustomer = new System.Windows.Forms.TextBox();
            this.tab_customer = new System.Windows.Forms.TabPage();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txt_findCustomer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_findCustomer = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.data_customer = new System.Windows.Forms.DataGridView();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btn_deleteCustomer = new System.Windows.Forms.Button();
            this.btn_editCustomer = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.btn_addCustomer = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_address = new System.Windows.Forms.TextBox();
            this.txt_phone = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_idCustomer_first = new System.Windows.Forms.TextBox();
            this.tab_invoice = new System.Windows.Forms.TabPage();
            this.data_invoice = new System.Windows.Forms.DataGridView();
            this.label17 = new System.Windows.Forms.Label();
            this.txt_idInvoice = new System.Windows.Forms.TextBox();
            this.btn_findInvoice = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tab_sell.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_addProduct)).BeginInit();
            this.panel13.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel5.SuspendLayout();
            this.tab_customer.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_customer)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel8.SuspendLayout();
            this.tab_invoice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_invoice)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_sell);
            this.tabControl1.Controls.Add(this.tab_customer);
            this.tabControl1.Controls.Add(this.tab_invoice);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1006, 598);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_sell
            // 
            this.tab_sell.Controls.Add(this.panel2);
            this.tab_sell.Controls.Add(this.panel1);
            this.tab_sell.Location = new System.Drawing.Point(4, 25);
            this.tab_sell.Name = "tab_sell";
            this.tab_sell.Padding = new System.Windows.Forms.Padding(3);
            this.tab_sell.Size = new System.Drawing.Size(998, 569);
            this.tab_sell.TabIndex = 0;
            this.tab_sell.Text = "Quản lý bán hàng";
            this.tab_sell.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(297, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(695, 557);
            this.panel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btn_save);
            this.panel4.Controls.Add(this.data_addProduct);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.panel13);
            this.panel4.Controls.Add(this.panel12);
            this.panel4.Controls.Add(this.panel3);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(689, 551);
            this.panel4.TabIndex = 0;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(554, 506);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(129, 37);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Lưu hóa đơn";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // data_addProduct
            // 
            this.data_addProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_addProduct.Location = new System.Drawing.Point(0, 202);
            this.data_addProduct.Name = "data_addProduct";
            this.data_addProduct.RowHeadersWidth = 51;
            this.data_addProduct.RowTemplate.Height = 24;
            this.data_addProduct.Size = new System.Drawing.Size(683, 298);
            this.data_addProduct.TabIndex = 0;
            this.data_addProduct.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_addProduct_CellDoubleClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(7, 172);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(152, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "Sản phẩm đã thêm";
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.btn_editProduct);
            this.panel13.Controls.Add(this.btn_deleteProduct);
            this.panel13.Controls.Add(this.btn_addProduct);
            this.panel13.Location = new System.Drawing.Point(3, 110);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(680, 49);
            this.panel13.TabIndex = 0;
            // 
            // btn_editProduct
            // 
            this.btn_editProduct.Enabled = false;
            this.btn_editProduct.Location = new System.Drawing.Point(311, 6);
            this.btn_editProduct.Name = "btn_editProduct";
            this.btn_editProduct.Size = new System.Drawing.Size(118, 37);
            this.btn_editProduct.TabIndex = 2;
            this.btn_editProduct.Text = "Chỉnh sửa";
            this.btn_editProduct.UseVisualStyleBackColor = true;
            this.btn_editProduct.Click += new System.EventHandler(this.btn_editProduct_Click);
            // 
            // btn_deleteProduct
            // 
            this.btn_deleteProduct.Location = new System.Drawing.Point(435, 5);
            this.btn_deleteProduct.Name = "btn_deleteProduct";
            this.btn_deleteProduct.Size = new System.Drawing.Size(118, 37);
            this.btn_deleteProduct.TabIndex = 2;
            this.btn_deleteProduct.Text = "Làm sạch";
            this.btn_deleteProduct.UseVisualStyleBackColor = true;
            this.btn_deleteProduct.Click += new System.EventHandler(this.btn_deleteProduct_Click);
            // 
            // btn_addProduct
            // 
            this.btn_addProduct.Enabled = false;
            this.btn_addProduct.Location = new System.Drawing.Point(559, 5);
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.Size = new System.Drawing.Size(118, 37);
            this.btn_addProduct.TabIndex = 2;
            this.btn_addProduct.Text = "Thêm";
            this.btn_addProduct.UseVisualStyleBackColor = true;
            this.btn_addProduct.Click += new System.EventHandler(this.btn_addProduct_Click);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.txt_productTitle);
            this.panel12.Controls.Add(this.label8);
            this.panel12.Controls.Add(this.label7);
            this.panel12.Controls.Add(this.label9);
            this.panel12.Controls.Add(this.txt_qty);
            this.panel12.Controls.Add(this.txt_inventory);
            this.panel12.Location = new System.Drawing.Point(3, 58);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(680, 49);
            this.panel12.TabIndex = 0;
            // 
            // txt_productTitle
            // 
            this.txt_productTitle.Enabled = false;
            this.txt_productTitle.Location = new System.Drawing.Point(103, 14);
            this.txt_productTitle.Name = "txt_productTitle";
            this.txt_productTitle.Size = new System.Drawing.Size(270, 22);
            this.txt_productTitle.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(507, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Số lượng mua";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(380, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Kho";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tên sản phẩm";
            // 
            // txt_qty
            // 
            this.txt_qty.Location = new System.Drawing.Point(608, 15);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(69, 22);
            this.txt_qty.TabIndex = 1;
            // 
            // txt_inventory
            // 
            this.txt_inventory.Enabled = false;
            this.txt_inventory.Location = new System.Drawing.Point(419, 15);
            this.txt_inventory.Name = "txt_inventory";
            this.txt_inventory.Size = new System.Drawing.Size(69, 22);
            this.txt_inventory.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txt_findProduct);
            this.panel3.Controls.Add(this.txt_productCode);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(680, 49);
            this.panel3.TabIndex = 0;
            // 
            // txt_findProduct
            // 
            this.txt_findProduct.Location = new System.Drawing.Point(103, 15);
            this.txt_findProduct.Name = "txt_findProduct";
            this.txt_findProduct.Size = new System.Drawing.Size(188, 22);
            this.txt_findProduct.TabIndex = 2;
            this.txt_findProduct.TextChanged += new System.EventHandler(this.txt_findProduct_TextChanged);
            // 
            // txt_productCode
            // 
            this.txt_productCode.Enabled = false;
            this.txt_productCode.Location = new System.Drawing.Point(407, 15);
            this.txt_productCode.Name = "txt_productCode";
            this.txt_productCode.Size = new System.Drawing.Size(270, 22);
            this.txt_productCode.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(308, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Mã sản phẩm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tìm kiếm";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.panel10);
            this.panel1.Controls.Add(this.panel14);
            this.panel1.Controls.Add(this.panel15);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 557);
            this.panel1.TabIndex = 0;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.label14);
            this.panel11.Controls.Add(this.txt_addressCustomer);
            this.panel11.Location = new System.Drawing.Point(3, 226);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(279, 124);
            this.panel11.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 17);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "Địa chỉ";
            // 
            // txt_addressCustomer
            // 
            this.txt_addressCustomer.Enabled = false;
            this.txt_addressCustomer.Location = new System.Drawing.Point(100, 10);
            this.txt_addressCustomer.Multiline = true;
            this.txt_addressCustomer.Name = "txt_addressCustomer";
            this.txt_addressCustomer.Size = new System.Drawing.Size(176, 111);
            this.txt_addressCustomer.TabIndex = 1;
            this.txt_addressCustomer.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label13);
            this.panel10.Controls.Add(this.txt_phoneCustomer);
            this.panel10.Location = new System.Drawing.Point(3, 171);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(279, 49);
            this.panel10.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "Số điện thoại";
            // 
            // txt_phoneCustomer
            // 
            this.txt_phoneCustomer.Enabled = false;
            this.txt_phoneCustomer.Location = new System.Drawing.Point(100, 13);
            this.txt_phoneCustomer.Name = "txt_phoneCustomer";
            this.txt_phoneCustomer.Size = new System.Drawing.Size(176, 22);
            this.txt_phoneCustomer.TabIndex = 1;
            this.txt_phoneCustomer.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.label15);
            this.panel14.Controls.Add(this.txt_customer);
            this.panel14.Location = new System.Drawing.Point(3, 6);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(279, 49);
            this.panel14.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 18);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 17);
            this.label15.TabIndex = 0;
            this.label15.Text = "Tìm kiếm";
            // 
            // txt_customer
            // 
            this.txt_customer.Location = new System.Drawing.Point(100, 15);
            this.txt_customer.Name = "txt_customer";
            this.txt_customer.Size = new System.Drawing.Size(176, 22);
            this.txt_customer.TabIndex = 1;
            this.txt_customer.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.label10);
            this.panel15.Controls.Add(this.txt_idCustomer);
            this.panel15.Location = new System.Drawing.Point(3, 61);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(279, 49);
            this.panel15.TabIndex = 0;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Mã khách ";
            // 
            // txt_idCustomer
            // 
            this.txt_idCustomer.Enabled = false;
            this.txt_idCustomer.Location = new System.Drawing.Point(100, 15);
            this.txt_idCustomer.Name = "txt_idCustomer";
            this.txt_idCustomer.Size = new System.Drawing.Size(176, 22);
            this.txt_idCustomer.TabIndex = 1;
            this.txt_idCustomer.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label12);
            this.panel5.Controls.Add(this.txt_nameCustomer);
            this.panel5.Location = new System.Drawing.Point(3, 116);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(279, 49);
            this.panel5.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Tên khách";
            // 
            // txt_nameCustomer
            // 
            this.txt_nameCustomer.Enabled = false;
            this.txt_nameCustomer.Location = new System.Drawing.Point(100, 15);
            this.txt_nameCustomer.Name = "txt_nameCustomer";
            this.txt_nameCustomer.Size = new System.Drawing.Size(176, 22);
            this.txt_nameCustomer.TabIndex = 1;
            this.txt_nameCustomer.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tab_customer
            // 
            this.tab_customer.Controls.Add(this.panel9);
            this.tab_customer.Controls.Add(this.panel7);
            this.tab_customer.Controls.Add(this.panel6);
            this.tab_customer.Location = new System.Drawing.Point(4, 25);
            this.tab_customer.Name = "tab_customer";
            this.tab_customer.Padding = new System.Windows.Forms.Padding(3);
            this.tab_customer.Size = new System.Drawing.Size(998, 569);
            this.tab_customer.TabIndex = 1;
            this.tab_customer.Text = "Quản lí khách hàng";
            this.tab_customer.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.txt_findCustomer);
            this.panel9.Controls.Add(this.label4);
            this.panel9.Controls.Add(this.btn_findCustomer);
            this.panel9.Location = new System.Drawing.Point(6, 501);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(986, 55);
            this.panel9.TabIndex = 1;
            // 
            // txt_findCustomer
            // 
            this.txt_findCustomer.Location = new System.Drawing.Point(586, 17);
            this.txt_findCustomer.Name = "txt_findCustomer";
            this.txt_findCustomer.Size = new System.Drawing.Size(292, 22);
            this.txt_findCustomer.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(469, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên khách hàng";
            // 
            // btn_findCustomer
            // 
            this.btn_findCustomer.Location = new System.Drawing.Point(884, 7);
            this.btn_findCustomer.Name = "btn_findCustomer";
            this.btn_findCustomer.Size = new System.Drawing.Size(99, 42);
            this.btn_findCustomer.TabIndex = 1;
            this.btn_findCustomer.Text = "Tìm kiếm";
            this.btn_findCustomer.UseVisualStyleBackColor = true;
            this.btn_findCustomer.Click += new System.EventHandler(this.btn_addCustomer_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.data_customer);
            this.panel7.Location = new System.Drawing.Point(6, 117);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(987, 378);
            this.panel7.TabIndex = 0;
            // 
            // data_customer
            // 
            this.data_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_customer.Location = new System.Drawing.Point(3, 3);
            this.data_customer.Name = "data_customer";
            this.data_customer.RowHeadersWidth = 51;
            this.data_customer.RowTemplate.Height = 24;
            this.data_customer.Size = new System.Drawing.Size(981, 372);
            this.data_customer.TabIndex = 0;
            this.data_customer.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_customer_CellDoubleClick);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btn_deleteCustomer);
            this.panel6.Controls.Add(this.btn_editCustomer);
            this.panel6.Controls.Add(this.label16);
            this.panel6.Controls.Add(this.btn_addCustomer);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.txt_idCustomer_first);
            this.panel6.Location = new System.Drawing.Point(6, 6);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(987, 105);
            this.panel6.TabIndex = 0;
            // 
            // btn_deleteCustomer
            // 
            this.btn_deleteCustomer.Location = new System.Drawing.Point(884, 59);
            this.btn_deleteCustomer.Name = "btn_deleteCustomer";
            this.btn_deleteCustomer.Size = new System.Drawing.Size(99, 42);
            this.btn_deleteCustomer.TabIndex = 1;
            this.btn_deleteCustomer.Text = "Xóa";
            this.btn_deleteCustomer.UseVisualStyleBackColor = true;
            this.btn_deleteCustomer.Click += new System.EventHandler(this.btn_deleteCustomer_Click);
            // 
            // btn_editCustomer
            // 
            this.btn_editCustomer.Location = new System.Drawing.Point(779, 57);
            this.btn_editCustomer.Name = "btn_editCustomer";
            this.btn_editCustomer.Size = new System.Drawing.Size(99, 42);
            this.btn_editCustomer.TabIndex = 1;
            this.btn_editCustomer.Text = "Chỉnh sửa";
            this.btn_editCustomer.UseVisualStyleBackColor = true;
            this.btn_editCustomer.Click += new System.EventHandler(this.btn_editCustomer_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(504, 8);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(105, 17);
            this.label16.TabIndex = 1;
            this.label16.Text = "Mã khách hàng";
            // 
            // btn_addCustomer
            // 
            this.btn_addCustomer.Location = new System.Drawing.Point(674, 57);
            this.btn_addCustomer.Name = "btn_addCustomer";
            this.btn_addCustomer.Size = new System.Drawing.Size(99, 42);
            this.btn_addCustomer.TabIndex = 1;
            this.btn_addCustomer.Text = "Thêm";
            this.btn_addCustomer.UseVisualStyleBackColor = true;
            this.btn_addCustomer.Click += new System.EventHandler(this.btn_addCustomer_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label3);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Controls.Add(this.label1);
            this.panel8.Controls.Add(this.txt_address);
            this.panel8.Controls.Add(this.txt_phone);
            this.panel8.Controls.Add(this.txt_name);
            this.panel8.Location = new System.Drawing.Point(3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(481, 99);
            this.panel8.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số điện thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Địa chỉ giao hàng";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên khách hàng";
            // 
            // txt_address
            // 
            this.txt_address.Location = new System.Drawing.Point(186, 56);
            this.txt_address.Multiline = true;
            this.txt_address.Name = "txt_address";
            this.txt_address.Size = new System.Drawing.Size(292, 40);
            this.txt_address.TabIndex = 0;
            // 
            // txt_phone
            // 
            this.txt_phone.Location = new System.Drawing.Point(186, 28);
            this.txt_phone.Name = "txt_phone";
            this.txt_phone.Size = new System.Drawing.Size(292, 22);
            this.txt_phone.TabIndex = 0;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(186, 0);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(292, 22);
            this.txt_name.TabIndex = 0;
            // 
            // txt_idCustomer_first
            // 
            this.txt_idCustomer_first.Enabled = false;
            this.txt_idCustomer_first.Location = new System.Drawing.Point(629, 8);
            this.txt_idCustomer_first.Name = "txt_idCustomer_first";
            this.txt_idCustomer_first.Size = new System.Drawing.Size(292, 22);
            this.txt_idCustomer_first.TabIndex = 0;
            // 
            // tab_invoice
            // 
            this.tab_invoice.Controls.Add(this.btn_findInvoice);
            this.tab_invoice.Controls.Add(this.txt_idInvoice);
            this.tab_invoice.Controls.Add(this.label17);
            this.tab_invoice.Controls.Add(this.data_invoice);
            this.tab_invoice.Location = new System.Drawing.Point(4, 25);
            this.tab_invoice.Name = "tab_invoice";
            this.tab_invoice.Padding = new System.Windows.Forms.Padding(3);
            this.tab_invoice.Size = new System.Drawing.Size(998, 569);
            this.tab_invoice.TabIndex = 2;
            this.tab_invoice.Text = "Quản lý hóa đơn";
            this.tab_invoice.UseVisualStyleBackColor = true;
            // 
            // data_invoice
            // 
            this.data_invoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_invoice.Location = new System.Drawing.Point(6, 50);
            this.data_invoice.Name = "data_invoice";
            this.data_invoice.RowHeadersWidth = 51;
            this.data_invoice.RowTemplate.Height = 24;
            this.data_invoice.Size = new System.Drawing.Size(986, 513);
            this.data_invoice.TabIndex = 0;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 18);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(83, 17);
            this.label17.TabIndex = 1;
            this.label17.Text = "Mã hóa đơn";
            // 
            // txt_idInvoice
            // 
            this.txt_idInvoice.Location = new System.Drawing.Point(96, 18);
            this.txt_idInvoice.Name = "txt_idInvoice";
            this.txt_idInvoice.Size = new System.Drawing.Size(221, 22);
            this.txt_idInvoice.TabIndex = 2;
            // 
            // btn_findInvoice
            // 
            this.btn_findInvoice.Location = new System.Drawing.Point(336, 12);
            this.btn_findInvoice.Name = "btn_findInvoice";
            this.btn_findInvoice.Size = new System.Drawing.Size(87, 35);
            this.btn_findInvoice.TabIndex = 3;
            this.btn_findInvoice.Text = "Tìm kiếm";
            this.btn_findInvoice.UseVisualStyleBackColor = true;
            this.btn_findInvoice.Click += new System.EventHandler(this.btn_findInvoice_Click);
            // 
            // FrmQuanLyBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 612);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmQuanLyBanHang";
            this.Text = "FrmQuanLyBanHang";
            this.Load += new System.EventHandler(this.FrmQuanLyBanHang_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab_sell.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_addProduct)).EndInit();
            this.panel13.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tab_customer.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_customer)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.tab_invoice.ResumeLayout(false);
            this.tab_invoice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_invoice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_sell;
        private System.Windows.Forms.TabPage tab_customer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView data_addProduct;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_address;
        private System.Windows.Forms.TextBox txt_phone;
        private System.Windows.Forms.DataGridView data_customer;
        private System.Windows.Forms.Button btn_deleteCustomer;
        private System.Windows.Forms.Button btn_editCustomer;
        private System.Windows.Forms.Button btn_addCustomer;
        private System.Windows.Forms.TextBox txt_findCustomer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_findCustomer;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_qty;
        private System.Windows.Forms.TextBox txt_inventory;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_productCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Button btn_addProduct;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_nameCustomer;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txt_addressCustomer;
        private System.Windows.Forms.TextBox txt_phoneCustomer;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txt_customer;
        private System.Windows.Forms.Button btn_deleteProduct;
        private System.Windows.Forms.Button btn_editProduct;
        private System.Windows.Forms.TextBox txt_productTitle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_idCustomer;
        private System.Windows.Forms.TabPage tab_invoice;
        private System.Windows.Forms.DataGridView data_invoice;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txt_idCustomer_first;
        private System.Windows.Forms.TextBox txt_findProduct;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btn_findInvoice;
        private System.Windows.Forms.TextBox txt_idInvoice;
    }
}