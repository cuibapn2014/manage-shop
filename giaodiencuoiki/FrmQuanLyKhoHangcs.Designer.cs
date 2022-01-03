
namespace giaodiencuoiki
{
    partial class FrmQuanLyKhoHangcs
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
            this.tab_product = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.btn_addProduct = new System.Windows.Forms.Button();
            this.btn_editProduct = new System.Windows.Forms.Button();
            this.btn_deleteProduct = new System.Windows.Forms.Button();
            this.panel12 = new System.Windows.Forms.Panel();
            this.txt_qty = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel11 = new System.Windows.Forms.Panel();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.txt_codeProduct = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_findProduct = new System.Windows.Forms.Button();
            this.txt_findProduct = new System.Windows.Forms.TextBox();
            this.data_product = new System.Windows.Forms.DataGridView();
            this.tab_type = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btn_addType = new System.Windows.Forms.Button();
            this.btn_editType = new System.Windows.Forms.Button();
            this.btn_deleteType = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txt_typeName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_typeCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.data_productType = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tab_product.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_product)).BeginInit();
            this.tab_type.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_productType)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_product);
            this.tabControl1.Controls.Add(this.tab_type);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1066, 516);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_product
            // 
            this.tab_product.Controls.Add(this.panel2);
            this.tab_product.Controls.Add(this.panel1);
            this.tab_product.Location = new System.Drawing.Point(4, 25);
            this.tab_product.Name = "tab_product";
            this.tab_product.Padding = new System.Windows.Forms.Padding(3);
            this.tab_product.Size = new System.Drawing.Size(1058, 487);
            this.tab_product.TabIndex = 0;
            this.tab_product.Text = "Quản lí sản phẩm";
            this.tab_product.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel13);
            this.panel2.Controls.Add(this.panel12);
            this.panel2.Controls.Add(this.panel11);
            this.panel2.Controls.Add(this.panel10);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(326, 475);
            this.panel2.TabIndex = 1;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.btn_addProduct);
            this.panel13.Controls.Add(this.btn_editProduct);
            this.panel13.Controls.Add(this.btn_deleteProduct);
            this.panel13.Location = new System.Drawing.Point(3, 288);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(320, 51);
            this.panel13.TabIndex = 0;
            // 
            // btn_addProduct
            // 
            this.btn_addProduct.Location = new System.Drawing.Point(48, 3);
            this.btn_addProduct.Name = "btn_addProduct";
            this.btn_addProduct.Size = new System.Drawing.Size(85, 44);
            this.btn_addProduct.TabIndex = 0;
            this.btn_addProduct.Text = "Thêm";
            this.btn_addProduct.UseVisualStyleBackColor = true;
            this.btn_addProduct.Click += new System.EventHandler(this.btn_addProduct_Click);
            // 
            // btn_editProduct
            // 
            this.btn_editProduct.Enabled = false;
            this.btn_editProduct.Location = new System.Drawing.Point(139, 3);
            this.btn_editProduct.Name = "btn_editProduct";
            this.btn_editProduct.Size = new System.Drawing.Size(85, 44);
            this.btn_editProduct.TabIndex = 0;
            this.btn_editProduct.Text = "Chỉnh sửa";
            this.btn_editProduct.UseVisualStyleBackColor = true;
            this.btn_editProduct.Click += new System.EventHandler(this.btn_editProduct_Click);
            // 
            // btn_deleteProduct
            // 
            this.btn_deleteProduct.Location = new System.Drawing.Point(230, 4);
            this.btn_deleteProduct.Name = "btn_deleteProduct";
            this.btn_deleteProduct.Size = new System.Drawing.Size(85, 44);
            this.btn_deleteProduct.TabIndex = 0;
            this.btn_deleteProduct.Text = "Xóa";
            this.btn_deleteProduct.UseVisualStyleBackColor = true;
            this.btn_deleteProduct.Click += new System.EventHandler(this.btn_deleteProduct_Click);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.txt_qty);
            this.panel12.Controls.Add(this.label7);
            this.panel12.Location = new System.Drawing.Point(3, 231);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(320, 51);
            this.panel12.TabIndex = 0;
            // 
            // txt_qty
            // 
            this.txt_qty.Location = new System.Drawing.Point(105, 13);
            this.txt_qty.Name = "txt_qty";
            this.txt_qty.Size = new System.Drawing.Size(212, 22);
            this.txt_qty.TabIndex = 1;
            this.txt_qty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_qty_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Số lượng";
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.txt_price);
            this.panel11.Controls.Add(this.label6);
            this.panel11.Location = new System.Drawing.Point(3, 174);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(320, 51);
            this.panel11.TabIndex = 0;
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(105, 16);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(212, 22);
            this.txt_price.TabIndex = 1;
            this.txt_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_price_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Giá sản phẩm";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.cb_type);
            this.panel10.Controls.Add(this.label5);
            this.panel10.Location = new System.Drawing.Point(3, 117);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(320, 51);
            this.panel10.TabIndex = 0;
            // 
            // cb_type
            // 
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Location = new System.Drawing.Point(105, 12);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(211, 24);
            this.cb_type.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Loại sản phẩm";
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.txt_title);
            this.panel9.Controls.Add(this.label4);
            this.panel9.Location = new System.Drawing.Point(3, 60);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(320, 51);
            this.panel9.TabIndex = 0;
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(105, 15);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(212, 22);
            this.txt_title.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên sản phẩm";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txt_codeProduct);
            this.panel8.Controls.Add(this.label3);
            this.panel8.Location = new System.Drawing.Point(3, 3);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(320, 51);
            this.panel8.TabIndex = 0;
            // 
            // txt_codeProduct
            // 
            this.txt_codeProduct.Enabled = false;
            this.txt_codeProduct.Location = new System.Drawing.Point(105, 14);
            this.txt_codeProduct.Name = "txt_codeProduct";
            this.txt_codeProduct.Size = new System.Drawing.Size(212, 22);
            this.txt_codeProduct.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Mã sản phẩm";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel14);
            this.panel1.Controls.Add(this.data_product);
            this.panel1.Location = new System.Drawing.Point(338, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 475);
            this.panel1.TabIndex = 0;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.label8);
            this.panel14.Controls.Add(this.btn_findProduct);
            this.panel14.Controls.Add(this.txt_findProduct);
            this.panel14.Location = new System.Drawing.Point(4, 4);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(707, 39);
            this.panel14.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(218, 10);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 17);
            this.label8.TabIndex = 2;
            this.label8.Text = "Tên sản phẩm";
            // 
            // btn_findProduct
            // 
            this.btn_findProduct.Location = new System.Drawing.Point(614, 4);
            this.btn_findProduct.Name = "btn_findProduct";
            this.btn_findProduct.Size = new System.Drawing.Size(90, 31);
            this.btn_findProduct.TabIndex = 1;
            this.btn_findProduct.Text = "Tìm kiếm";
            this.btn_findProduct.UseVisualStyleBackColor = true;
            // 
            // txt_findProduct
            // 
            this.txt_findProduct.Location = new System.Drawing.Point(323, 7);
            this.txt_findProduct.Name = "txt_findProduct";
            this.txt_findProduct.Size = new System.Drawing.Size(285, 22);
            this.txt_findProduct.TabIndex = 0;
            // 
            // data_product
            // 
            this.data_product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_product.Location = new System.Drawing.Point(3, 49);
            this.data_product.Name = "data_product";
            this.data_product.RowHeadersWidth = 51;
            this.data_product.RowTemplate.Height = 24;
            this.data_product.Size = new System.Drawing.Size(708, 423);
            this.data_product.TabIndex = 0;
            this.data_product.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_product_CellDoubleClick);
            // 
            // tab_type
            // 
            this.tab_type.Controls.Add(this.panel4);
            this.tab_type.Controls.Add(this.panel3);
            this.tab_type.Location = new System.Drawing.Point(4, 25);
            this.tab_type.Name = "tab_type";
            this.tab_type.Padding = new System.Windows.Forms.Padding(3);
            this.tab_type.Size = new System.Drawing.Size(1058, 487);
            this.tab_type.TabIndex = 1;
            this.tab_type.Text = "Quản lí loại sản phẩm";
            this.tab_type.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(6, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(512, 475);
            this.panel4.TabIndex = 1;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btn_addType);
            this.panel7.Controls.Add(this.btn_editType);
            this.panel7.Controls.Add(this.btn_deleteType);
            this.panel7.Location = new System.Drawing.Point(3, 101);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(509, 52);
            this.panel7.TabIndex = 0;
            // 
            // btn_addType
            // 
            this.btn_addType.Location = new System.Drawing.Point(152, 3);
            this.btn_addType.Name = "btn_addType";
            this.btn_addType.Size = new System.Drawing.Size(114, 46);
            this.btn_addType.TabIndex = 0;
            this.btn_addType.Text = "Thêm";
            this.btn_addType.UseVisualStyleBackColor = true;
            this.btn_addType.Click += new System.EventHandler(this.btn_addType_Click);
            // 
            // btn_editType
            // 
            this.btn_editType.Location = new System.Drawing.Point(272, 3);
            this.btn_editType.Name = "btn_editType";
            this.btn_editType.Size = new System.Drawing.Size(114, 46);
            this.btn_editType.TabIndex = 0;
            this.btn_editType.Text = "Chỉnh sửa";
            this.btn_editType.UseVisualStyleBackColor = true;
            this.btn_editType.Click += new System.EventHandler(this.btn_editType_Click);
            // 
            // btn_deleteType
            // 
            this.btn_deleteType.Location = new System.Drawing.Point(392, 3);
            this.btn_deleteType.Name = "btn_deleteType";
            this.btn_deleteType.Size = new System.Drawing.Size(114, 46);
            this.btn_deleteType.TabIndex = 0;
            this.btn_deleteType.Text = "Xóa";
            this.btn_deleteType.UseVisualStyleBackColor = true;
            this.btn_deleteType.Click += new System.EventHandler(this.btn_deleteType_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txt_typeName);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Location = new System.Drawing.Point(3, 52);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(506, 43);
            this.panel6.TabIndex = 0;
            // 
            // txt_typeName
            // 
            this.txt_typeName.Location = new System.Drawing.Point(152, 12);
            this.txt_typeName.Name = "txt_typeName";
            this.txt_typeName.Size = new System.Drawing.Size(334, 22);
            this.txt_typeName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên loại sản phẩm";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txt_typeCode);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(506, 43);
            this.panel5.TabIndex = 0;
            // 
            // txt_typeCode
            // 
            this.txt_typeCode.Enabled = false;
            this.txt_typeCode.Location = new System.Drawing.Point(152, 12);
            this.txt_typeCode.Name = "txt_typeCode";
            this.txt_typeCode.Size = new System.Drawing.Size(334, 22);
            this.txt_typeCode.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã loại sản phẩm";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.data_productType);
            this.panel3.Location = new System.Drawing.Point(524, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(528, 475);
            this.panel3.TabIndex = 0;
            // 
            // data_productType
            // 
            this.data_productType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_productType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_productType.Location = new System.Drawing.Point(3, 3);
            this.data_productType.Name = "data_productType";
            this.data_productType.RowHeadersWidth = 51;
            this.data_productType.RowTemplate.Height = 24;
            this.data_productType.Size = new System.Drawing.Size(522, 469);
            this.data_productType.TabIndex = 0;
            this.data_productType.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_productType_CellDoubleClick);
            // 
            // FrmQuanLyKhoHangcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 540);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmQuanLyKhoHangcs";
            this.Text = "FrmQuanLyKhoHangcs";
            this.Load += new System.EventHandler(this.FrmQuanLyKhoHangcs_Load);
            this.tabControl1.ResumeLayout(false);
            this.tab_product.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel12.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_product)).EndInit();
            this.tab_type.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_productType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_product;
        private System.Windows.Forms.TabPage tab_type;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView data_product;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView data_productType;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btn_addType;
        private System.Windows.Forms.Button btn_editType;
        private System.Windows.Forms.Button btn_deleteType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_typeName;
        private System.Windows.Forms.TextBox txt_typeCode;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox txt_qty;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_codeProduct;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_type;
        private System.Windows.Forms.Button btn_addProduct;
        private System.Windows.Forms.Button btn_editProduct;
        private System.Windows.Forms.Button btn_deleteProduct;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_findProduct;
        private System.Windows.Forms.TextBox txt_findProduct;
    }
}