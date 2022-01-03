
namespace giaodiencuoiki
{
    partial class FormBaoCaoThongKe
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
            this.total_risk = new System.Windows.Forms.Panel();
            this.txt_totalRisk = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.total_profit = new System.Windows.Forms.Panel();
            this.txt_totalProfit = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.total_customer = new System.Windows.Forms.Panel();
            this.txt_totalCustomer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_filter = new System.Windows.Forms.Button();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.data_customer = new System.Windows.Forms.DataGridView();
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.total_risk.SuspendLayout();
            this.total_profit.SuspendLayout();
            this.total_customer.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_customer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.total_risk);
            this.panel1.Controls.Add(this.total_profit);
            this.panel1.Controls.Add(this.total_customer);
            this.panel1.Controls.Add(this.btn_filter);
            this.panel1.Controls.Add(this.startDate);
            this.panel1.Controls.Add(this.endDate);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1063, 771);
            this.panel1.TabIndex = 0;
            // 
            // total_risk
            // 
            this.total_risk.BackColor = System.Drawing.Color.Gold;
            this.total_risk.Controls.Add(this.txt_totalRisk);
            this.total_risk.Controls.Add(this.label6);
            this.total_risk.Location = new System.Drawing.Point(771, 61);
            this.total_risk.Name = "total_risk";
            this.total_risk.Size = new System.Drawing.Size(286, 158);
            this.total_risk.TabIndex = 3;
            // 
            // txt_totalRisk
            // 
            this.txt_totalRisk.AutoSize = true;
            this.txt_totalRisk.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalRisk.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txt_totalRisk.Location = new System.Drawing.Point(3, 103);
            this.txt_totalRisk.Name = "txt_totalRisk";
            this.txt_totalRisk.Size = new System.Drawing.Size(262, 46);
            this.txt_totalRisk.TabIndex = 0;
            this.txt_totalRisk.Text = "100,000,000đ";
            this.txt_totalRisk.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(3, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Tổng thiệt hại";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // total_profit
            // 
            this.total_profit.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.total_profit.Controls.Add(this.txt_totalProfit);
            this.total_profit.Controls.Add(this.label4);
            this.total_profit.Location = new System.Drawing.Point(479, 61);
            this.total_profit.Name = "total_profit";
            this.total_profit.Size = new System.Drawing.Size(286, 158);
            this.total_profit.TabIndex = 3;
            // 
            // txt_totalProfit
            // 
            this.txt_totalProfit.AutoSize = true;
            this.txt_totalProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalProfit.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txt_totalProfit.Location = new System.Drawing.Point(-2, 103);
            this.txt_totalProfit.Name = "txt_totalProfit";
            this.txt_totalProfit.Size = new System.Drawing.Size(262, 46);
            this.txt_totalProfit.TabIndex = 0;
            this.txt_totalProfit.Text = "100,000,000đ";
            this.txt_totalProfit.Click += new System.EventHandler(this.label1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(3, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tổng doanh thu";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // total_customer
            // 
            this.total_customer.BackColor = System.Drawing.Color.DeepPink;
            this.total_customer.Controls.Add(this.txt_totalCustomer);
            this.total_customer.Controls.Add(this.label1);
            this.total_customer.Location = new System.Drawing.Point(177, 61);
            this.total_customer.Name = "total_customer";
            this.total_customer.Size = new System.Drawing.Size(286, 158);
            this.total_customer.TabIndex = 3;
            // 
            // txt_totalCustomer
            // 
            this.txt_totalCustomer.AutoSize = true;
            this.txt_totalCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_totalCustomer.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.txt_totalCustomer.Location = new System.Drawing.Point(7, 103);
            this.txt_totalCustomer.Name = "txt_totalCustomer";
            this.txt_totalCustomer.Size = new System.Drawing.Size(163, 46);
            this.txt_totalCustomer.TabIndex = 0;
            this.txt_totalCustomer.Text = "100,000";
            this.txt_totalCustomer.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lượng khách";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_filter
            // 
            this.btn_filter.Location = new System.Drawing.Point(941, 8);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(103, 39);
            this.btn_filter.TabIndex = 2;
            this.btn_filter.Text = "Lọc dữ liệu";
            this.btn_filter.UseVisualStyleBackColor = true;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(735, 14);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(200, 22);
            this.endDate.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.data_customer);
            this.panel3.Location = new System.Drawing.Point(3, 225);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1057, 543);
            this.panel3.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(935, 505);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Xuất file Excel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // data_customer
            // 
            this.data_customer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_customer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_customer.Location = new System.Drawing.Point(3, 3);
            this.data_customer.Name = "data_customer";
            this.data_customer.RowHeadersWidth = 51;
            this.data_customer.RowTemplate.Height = 24;
            this.data_customer.Size = new System.Drawing.Size(1051, 499);
            this.data_customer.TabIndex = 0;
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(491, 14);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(200, 22);
            this.startDate.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(697, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "đến";
            // 
            // FormBaoCaoThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1087, 795);
            this.Controls.Add(this.panel1);
            this.Name = "FormBaoCaoThongKe";
            this.Text = "FormBaoCaoThongKe";
            this.Load += new System.EventHandler(this.FormBaoCaoThongKe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.total_risk.ResumeLayout(false);
            this.total_risk.PerformLayout();
            this.total_profit.ResumeLayout(false);
            this.total_profit.PerformLayout();
            this.total_customer.ResumeLayout(false);
            this.total_customer.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_customer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView data_customer;
        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.Panel total_customer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txt_totalCustomer;
        private System.Windows.Forms.Panel total_profit;
        private System.Windows.Forms.Label txt_totalProfit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel total_risk;
        private System.Windows.Forms.Label txt_totalRisk;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker startDate;
    }
}