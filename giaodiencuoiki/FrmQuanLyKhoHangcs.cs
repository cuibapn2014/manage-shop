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
    public partial class FrmQuanLyKhoHangcs : Form
    {
        public QuanLyBanHang db = new QuanLyBanHang();
        public FrmQuanLyKhoHangcs()
        {
            InitializeComponent();
        }

        private void FrmQuanLyKhoHangcs_Load(object sender, EventArgs e)
        {
            loadData();
        }

        public void loadData() 
        {
            data_product.DataSource = this.db.Products.ToList();
            data_productType.DataSource = db.ProductTypes.ToList();
            cb_type.DataSource = db.ProductTypes.ToList();
            cb_type.DisplayMember = "Name";
            cb_type.ValueMember = "IdType";
        }

        private void btn_addType_Click(object sender, EventArgs e)
        {
            if (txt_typeName.Text != null) 
            {
                ProductType pt = new ProductType
                {
                    Name = txt_typeName.Text
                };
                this.db.ProductTypes.Add(pt);
                this.db.SaveChanges();
                loadData();
                resetData();
            }
        }

        private void data_productType_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_addType.Enabled = false;
            btn_editType.Enabled = true;
            int idType = Convert.ToInt32(data_productType.Rows[e.RowIndex].Cells[0].Value);
            ProductType pt = db.ProductTypes.Where(obj => obj.IdType == idType).First();
            txt_typeCode.Text = pt.IdType.ToString();
            txt_typeName.Text = pt.Name.ToString();
        }

        private void btn_editType_Click(object sender, EventArgs e)
        {
            int idType = Convert.ToInt32(txt_typeCode.Text);
            ProductType pt = db.ProductTypes.Where(obj => obj.IdType == idType).First();
            pt.Name = txt_typeName.Text;
            this.db.SaveChanges();
            loadData();
            resetData();
            btn_addType.Enabled = true;
            btn_editType.Enabled = false;
        }

        private void btn_deleteType_Click(object sender, EventArgs e)
        {
            if (data_productType.SelectedRows.Count > 0)
            {
                int idType = Convert.ToInt32(data_productType.SelectedRows[0].Cells[0].Value);
                ProductType pt = db.ProductTypes.Where(obj => obj.IdType == idType).First();
                DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn xóa " + pt.Name, "Hệ thống", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    this.db.ProductTypes.Remove(pt);
                    this.db.SaveChanges();
                    loadData();
                }     
            }
            else 
            {
                MessageBox.Show("Hãy chọn loại bạn mong muốn xóa", "Hệ thống");
            }
        }

        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            if (txt_title.Text == null || txt_price.Text == null || txt_qty.Text == null) 
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin","Hệ thống");
            }
            else 
            {
                Product product = new Product
                {
                    IdProductType = Convert.ToInt32(cb_type.SelectedValue),
                    Qty = Convert.ToInt32(txt_qty.Text),
                    Sold = 0,
                    Title = txt_title.Text,
                    Price = Convert.ToInt32(txt_price.Text)
                };
                this.db.Products.Add(product);
                this.db.SaveChanges();
                loadData();
                resetData();
            }
        }

        private void btn_editProduct_Click(object sender, EventArgs e)
        {
            int idProduct = Convert.ToInt32(txt_codeProduct.Text);
            Product product = this.db.Products.Where(obj => obj.IdProduct == idProduct).First();
            product.Title = txt_title.Text;
            product.IdProductType = Convert.ToInt32(cb_type.SelectedValue);
            product.Price = Convert.ToInt32(txt_price.Text);
            product.Qty = Convert.ToInt32(txt_qty.Text);
            this.db.SaveChanges();
            loadData();
            btn_addProduct.Enabled = true;
            btn_editProduct.Enabled = false;
            MessageBox.Show("Đã chỉnh sửa thông tin sản phẩm!", "Hệ thống");
            resetData();
        }

        private void btn_deleteProduct_Click(object sender, EventArgs e)
        {
            if(data_product.SelectedRows.Count > 0)
            {
                int idProduct = Convert.ToInt32(data_product.SelectedRows[0].Cells[0].Value);
                Product product = this.db.Products.Where(obj => obj.IdProduct == idProduct).First();
                DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm này ?", "Hệ thống",MessageBoxButtons.YesNo);
                if(dialog == DialogResult.Yes)
                {
                    this.db.Products.Remove(product);
                    this.db.SaveChanges();
                    loadData();
                    MessageBox.Show("Đã xóa sản phẩm khỏi hệ thống!","Hệ thống");
                }
            }
            else 
            {
                MessageBox.Show("Hãy chọn sản phẩm bạn muốn xóa","Hệ thống");
            }
        }

        private void txt_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_qty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void data_product_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_addProduct.Enabled = false;
            btn_editProduct.Enabled = true;
            int idProduct = Convert.ToInt32(data_product.Rows[e.RowIndex].Cells[0].Value);
            Product product = this.db.Products.Where(obj => obj.IdProduct == idProduct).First();
            if (product != null)
            {
                txt_codeProduct.Text = product.IdProduct.ToString();
                txt_title.Text = product.Title;
                cb_type.SelectedValue = product.IdProductType;
                txt_price.Text = product.Price.ToString();
                txt_qty.Text = product.Qty.ToString();
            }
        }

        private void resetData()
        {
            txt_codeProduct.Text = null;
            txt_title.Text = null;
            txt_price.Text = null;
            txt_qty.Text = null;
            txt_typeCode = null;
            txt_typeName = null;
        }
    }
}
