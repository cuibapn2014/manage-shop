
namespace giaodiencuoiki
{
    partial class FrmQuanLyRuiRo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.data_risk = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_value = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_customer = new System.Windows.Forms.TextBox();
            this.txt_idInvoice = new System.Windows.Forms.TextBox();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.txt_idRisk = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_risk)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1066, 522);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.data_risk);
            this.panel3.Location = new System.Drawing.Point(3, 125);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1060, 394);
            this.panel3.TabIndex = 1;
            // 
            // data_risk
            // 
            this.data_risk.AllowUserToAddRows = false;
            this.data_risk.AllowUserToDeleteRows = false;
            this.data_risk.AllowUserToResizeColumns = false;
            this.data_risk.AllowUserToResizeRows = false;
            this.data_risk.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_risk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_risk.Location = new System.Drawing.Point(3, 3);
            this.data_risk.Name = "data_risk";
            this.data_risk.RowHeadersWidth = 51;
            this.data_risk.RowTemplate.Height = 24;
            this.data_risk.Size = new System.Drawing.Size(1054, 388);
            this.data_risk.TabIndex = 0;
            this.data_risk.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_risk_CellDoubleClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_delete);
            this.panel2.Controls.Add(this.btn_edit);
            this.panel2.Controls.Add(this.btn_save);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_value);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_customer);
            this.panel2.Controls.Add(this.txt_idInvoice);
            this.panel2.Controls.Add(this.txt_title);
            this.panel2.Controls.Add(this.txt_idRisk);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1060, 116);
            this.panel2.TabIndex = 0;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(956, 77);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(101, 35);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // btn_edit
            // 
            this.btn_edit.Enabled = false;
            this.btn_edit.Location = new System.Drawing.Point(957, 40);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(100, 34);
            this.btn_edit.TabIndex = 2;
            this.btn_edit.Text = "Chỉnh sửa";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(956, 3);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(98, 33);
            this.btn_save.TabIndex = 2;
            this.btn_save.Text = "Lưu";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(403, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mô tả rủi ro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(383, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Giá trị thiệt hại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tên khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã hóa đơn";
            // 
            // txt_value
            // 
            this.txt_value.Location = new System.Drawing.Point(489, 77);
            this.txt_value.Name = "txt_value";
            this.txt_value.Size = new System.Drawing.Size(222, 22);
            this.txt_value.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã sự cố";
            // 
            // txt_customer
            // 
            this.txt_customer.Location = new System.Drawing.Point(130, 77);
            this.txt_customer.Name = "txt_customer";
            this.txt_customer.Size = new System.Drawing.Size(222, 22);
            this.txt_customer.TabIndex = 0;
            // 
            // txt_idInvoice
            // 
            this.txt_idInvoice.Location = new System.Drawing.Point(130, 44);
            this.txt_idInvoice.Name = "txt_idInvoice";
            this.txt_idInvoice.Size = new System.Drawing.Size(222, 22);
            this.txt_idInvoice.TabIndex = 0;
            this.txt_idInvoice.TextChanged += new System.EventHandler(this.txt_idInvoice_TextChanged);
            this.txt_idInvoice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_idInvoice_KeyPress);
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(489, 13);
            this.txt_title.Multiline = true;
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(327, 53);
            this.txt_title.TabIndex = 0;
            // 
            // txt_idRisk
            // 
            this.txt_idRisk.Enabled = false;
            this.txt_idRisk.Location = new System.Drawing.Point(130, 11);
            this.txt_idRisk.Name = "txt_idRisk";
            this.txt_idRisk.Size = new System.Drawing.Size(222, 22);
            this.txt_idRisk.TabIndex = 0;
            // 
            // FrmQuanLyRuiRo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 546);
            this.Controls.Add(this.panel1);
            this.Name = "FrmQuanLyRuiRo";
            this.Text = "FrmQuanLyRuiRo";
            this.Load += new System.EventHandler(this.FrmQuanLyRuiRo_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_risk)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView data_risk;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_idRisk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_idInvoice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_value;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_customer;
    }
}