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
    public partial class FrmQuanLyRuiRo : Form
    {
        public QuanLyBanHang db = new QuanLyBanHang();
        public FrmQuanLyRuiRo()
        {
            InitializeComponent();
        }

        private void FrmQuanLyRuiRo_Load(object sender, EventArgs e)
        {

        }

        public void loadData() 
        {
            data_risk.DataSource = this.db.Risks.ToList();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if(txt_idRisk.Text == null || txt_title.Text == null)
            {
                MessageBox.Show("Không thể để trống thông tin!", "Hệ thống");
            }
            else
            {
                Risk risk = new Risk
                {
                    IdInvoice = Convert.ToInt32(txt_idInvoice.Text),
                    Title = txt_title.Text,
                    Value = Convert.ToInt32(txt_value.Text),
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                };
                this.db.Risks.Add(risk);
                this.db.SaveChanges();
                loadData();
                resetData();
            }
        }

        private void data_risk_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_save.Enabled = false;
            btn_edit.Enabled = true;
            int idRisk = Convert.ToInt32(data_risk.Rows[e.RowIndex].Cells[0].Value);
            Risk risk = this.db.Risks.Where(obj => obj.Id == idRisk).First();
            txt_idRisk.Text = risk.Id.ToString();
            txt_title.Text = risk.Title;
            txt_idInvoice.Text = risk.IdInvoice.ToString();
            txt_value.Text = risk.Value.ToString();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            int idRisk = Convert.ToInt32(txt_idRisk.Text);
            Risk risk = this.db.Risks.Where(obj => obj.Id == idRisk).First();
            risk.Title = txt_title.Text;
            risk.Value = Convert.ToInt32(txt_value.Text);
            risk.IdInvoice = Convert.ToInt32(txt_idInvoice.Text);
            this.db.SaveChanges();
            MessageBox.Show("Cập nhật thành công!", "Hệ thống");
            resetData();
        }

        private void resetData() 
        {
            txt_idRisk.Text = null;
            txt_idRisk.Text = null;
            txt_title.Text = null;
            txt_value.Text = null;
            btn_edit.Enabled = false;
            btn_save.Enabled = true;
        }

        private void txt_idInvoice_TextChanged(object sender, EventArgs e)
        {
            int idInvoice = txt_idInvoice.Text != "" ? Convert.ToInt32(txt_idInvoice.Text) : 0;
            var customer = this.db.Invoices.Where(obj => obj.IdInvoice == idInvoice).FirstOrDefault();
            if (customer != null)
                txt_customer.Text = customer.Customer.Name.ToString();
            else
                txt_customer.Text = null;
        }
    }
}
