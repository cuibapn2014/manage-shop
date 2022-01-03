using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace giaodiencuoiki
{
    public partial class FormBaoCaoThongKe : Form
    {
        public QuanLyBanHang db = new QuanLyBanHang();
        public FormBaoCaoThongKe()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormBaoCaoThongKe_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            int totalCustomer = this.db.Customers.ToList().Count;
            float totalProfit = 0;
            int totalRisk = (int) this.db.Risks.ToList().Sum(obj => obj.Value);
            var list = this.db.DetailInvoices.ToList();
            foreach(DetailInvoice d in list)
            {
                totalProfit += (int)(d.Product.Price * d.Qty);
            }
            txt_totalCustomer.Text = totalCustomer.ToString("#,##0");
            txt_totalProfit.Text = totalProfit.ToString("#,##0") + "đ";
            txt_totalRisk.Text = totalRisk.ToString("#,##0") + "đ";
            data_customer.DataSource = this.db.Customers.ToList();
        }

        private void btn_filter_Click(object sender, EventArgs e)
        {
            int totalCustomer = this.db.Customers.Where(obj => obj.Created_At >= startDate.Value && obj.Created_At <= endDate.Value).ToList().Count;
            float totalProfit = 0;
            int totalRisk = (int)this.db.Risks.Where(obj => obj.CreatedAt >= startDate.Value && obj.CreatedAt <= endDate.Value).ToList().Sum(obj => obj.Value);
            var list = this.db.DetailInvoices.Where(obj => obj.Invoice.CreatedAt >= startDate.Value && obj.Invoice.CreatedAt <= endDate.Value).ToList();
            foreach (DetailInvoice d in list)
            {
                totalProfit += (int)(d.Product.Price * d.Qty);
            }
            txt_totalCustomer.Text = totalCustomer.ToString("#,##0");
            txt_totalProfit.Text = totalProfit.ToString("#,##0") + "đ";
            txt_totalRisk.Text = totalRisk.ToString("#,##0") + "đ";
            data_customer.DataSource = this.db.Customers.Where(obj => obj.Created_At >= startDate.Value && obj.Created_At <= endDate.Value).ToList();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataTable data = GetDataTableFromDGV(data_customer);
            using (SaveFileDialog sfd = new SaveFileDialog() {
                Filter = "Excel Workbook|*.xlsx" 
            })
            {
                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workBook = new XLWorkbook())
                        {
                            workBook.Worksheets.Add(data, "Customer");
                            workBook.SaveAs(sfd.FileName);
                        }
                    }catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private DataTable GetDataTableFromDGV(DataGridView dgv)
        {
            var dt = new DataTable();
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                if (column.Visible)
                {
                    // You could potentially name the column based on the DGV column name (beware of dupes)
                    // or assign a type based on the data type of the data bound to this DGV column.
                    dt.Columns.Add();
                }
            }

            object[] cellValues = new object[dgv.Columns.Count];
            foreach (DataGridViewRow row in dgv.Rows)
            {
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    cellValues[i] = row.Cells[i].Value;
                }
                dt.Rows.Add(cellValues);
            }

            return dt;
        }
    }
}
