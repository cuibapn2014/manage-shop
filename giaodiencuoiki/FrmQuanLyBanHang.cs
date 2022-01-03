using System;
using System.Collections;
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
    public partial class FrmQuanLyBanHang : Form
    {
        public QuanLyBanHang db = new QuanLyBanHang();
        public FrmQuanLyBanHang()
        {
            InitializeComponent();
        }

        public List<Product> ListProduct = new List<Product>();

        private void btn_addCustomer_Click(object sender, EventArgs e)
        {
            if(txt_name.Text == null || txt_phone.Text == null || txt_address.Text == null)
            {
                MessageBox.Show("Vui lồng không để trống thông tin!", "Hệ thống");
            }
            else
            {
                Customer customer = new Customer
                {
                    Name = txt_name.Text,
                    Phone = txt_phone.Text,
                    Address = txt_address.Text,
                    Created_At = DateTime.Now
                };
                this.db.Customers.Add(customer);
                this.db.SaveChanges();
                loadData();
                resetData();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string keyword = txt_customer.Text;
            Customer customer = this.db.Customers.Where(obj => obj.Name.Contains(keyword)).FirstOrDefault();
            if (customer != null)
            {
                txt_idCustomer.Text = customer.IdCustomer.ToString();
                txt_nameCustomer.Text = customer.Name;
                txt_phoneCustomer.Text = customer.Phone;
                txt_addressCustomer.Text = customer.Address;
                btn_addProduct.Enabled = true;
            }
            else
            {
                txt_idCustomer.Text = null;
                txt_nameCustomer.Text = null;
                txt_phoneCustomer.Text = null;
                txt_addressCustomer.Text = null;
                btn_addProduct.Enabled = false;
            }
        }

        private void loadData()
        {
            data_customer.DataSource = this.db.Customers.ToList();
            data_invoice.DataSource = this.db.Invoices.ToList();
        }

        private void resetData()
        {
            btn_addCustomer.Enabled = true;
            btn_editCustomer.Enabled = false;
            txt_phone.Text = null;
            txt_name.Text = null;
            txt_address.Text = null;
            txt_idCustomer_first = null;
            txt_productCode.Text = null;
            txt_productTitle.Text = null;
            txt_qty.Text = null;
            txt_inventory.Text = null;
            txt_nameCustomer.Text = null;
            txt_addressCustomer.Text = null;
            txt_phoneCustomer.Text = null;
            btn_addCustomer.Enabled = false;
            data_addProduct.DataSource = null;
        }

        private void FrmQuanLyBanHang_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void data_customer_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_addCustomer.Enabled = false;
            btn_editCustomer.Enabled = true;
            int idCustomer = Convert.ToInt32(data_customer.Rows[e.RowIndex].Cells[0].Value);
            Customer customer = this.db.Customers.Where(obj => obj.IdCustomer == idCustomer).First();
            txt_name.Text = customer.Name;
            txt_phone.Text = customer.Phone;
            txt_address.Text = customer.Address;
            txt_idCustomer_first.Text = idCustomer.ToString();
        }

        private void btn_editCustomer_Click(object sender, EventArgs e)
        {
            int idCustomer = Convert.ToInt32(txt_idCustomer_first.Text);
            if (txt_name.Text == null || txt_phone.Text == null || txt_address.Text == null)
            {
                MessageBox.Show("Vui lồng không để trống thông tin!", "Hệ thống");
            }
            else
            {
                Customer customer = this.db.Customers.Where(obj => obj.IdCustomer == idCustomer).First();
                customer.Name = txt_name.Text;
                customer.Phone = txt_phone.Text;
                customer.Address = txt_address.Text;
                this.db.SaveChanges();
                loadData();
                resetData();
                MessageBox.Show("Đã cập nhật thông tin khách hàng!", "Hệ thống");
            }
        }

        private void btn_deleteCustomer_Click(object sender, EventArgs e)
        {
            
            if (data_customer.SelectedRows.Count > 0)
            {
                int idCustomer = Convert.ToInt32(data_customer.SelectedRows[0].Cells[0].Value);
                Customer customer = this.db.Customers.Where(obj => obj.IdCustomer == idCustomer).First();
                DialogResult dialog = MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng " + customer.Name + " ?","Hệ thống", MessageBoxButtons.YesNo);
                if(dialog == DialogResult.Yes)
                {
                    this.db.Customers.Remove(customer);
                    this.db.SaveChanges();
                    loadData();
                    MessageBox.Show("Xóa thành công !", "Hệ thống");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn dữ liệu để xóa!", "Hệ thống");
            }
        }

        private void txt_findProduct_TextChanged(object sender, EventArgs e)
        {
            string keyword = txt_findProduct.Text;
            Product product = this.db.Products.Where(obj => obj.Title.Contains(keyword)).FirstOrDefault();
            if (product != null)
            {
                txt_productTitle.Text = product.Title;
                txt_productCode.Text = product.IdProduct.ToString();
                txt_inventory.Text = product.Qty.ToString();
            }
            else
            {
                txt_productTitle.Text = null;
                txt_productCode.Text = null;
                txt_inventory.Text = null;
            }
        }

        private void btn_addProduct_Click(object sender, EventArgs e)
        {
            int idProduct = Convert.ToInt32(txt_productCode.Text);
            Product product = this.db.Products.Where(obj => obj.IdProduct == idProduct).FirstOrDefault();
            Product p = new Product();
            p.Title = product.Title;
            p.IdProduct = idProduct;
            p.Qty = Convert.ToInt32(txt_qty.Text);
            p.Price = product.Price;
            p.IdProductType = product.IdProductType;
            this.ListProduct.Add(p);
            data_addProduct.DataSource = null;
            data_addProduct.DataSource = ListProduct;
            data_addProduct.Columns.Remove("Sold");
            resetData();
        }

        private void data_addProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idProduct = Convert.ToInt32(data_addProduct.Rows[e.RowIndex].Cells[0].Value);
            Product product = this.db.Products.Where(obj => obj.IdProduct == idProduct).FirstOrDefault();
            Product product1 = this.ListProduct.Where(obj => obj.IdProduct == idProduct).FirstOrDefault();
            if (product != null)
            {
                btn_editProduct.Enabled = true;
                txt_productTitle.Text = product.Title;
                txt_productCode.Text = product.IdProduct.ToString();
                txt_inventory.Text = product.Qty.ToString();
                txt_qty.Text = product1.Qty.ToString();
            }
        }

        private void btn_editProduct_Click(object sender, EventArgs e)
        {
            btn_editProduct.Enabled = false;
            int idProduct = Convert.ToInt32(txt_productCode.Text);
            Product product = this.ListProduct.Where(obj => obj.IdProduct == idProduct).FirstOrDefault();
            if (product != null)
            {
                product.Qty = Convert.ToInt32(txt_qty.Text);
            }
            data_addProduct.DataSource = null;
            data_addProduct.DataSource = ListProduct;
            data_addProduct.Columns.Remove("Sold");
            resetData();
        }

        private void btn_deleteProduct_Click(object sender, EventArgs e)
        {  
                DialogResult dialog = MessageBox.Show("Bạn có chắn chắn muốn xóa","Hệ thống",MessageBoxButtons.YesNo);
                if(dialog == DialogResult.Yes)
                {
                    this.ListProduct = null;
                    data_addProduct.DataSource = this.ListProduct;
                }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            Invoice invoice = new Invoice
            {
                IdCustomer = Convert.ToInt32(txt_idCustomer.Text),
                CreatedAt = DateTime.Now
            };
            this.db.Invoices.Add(invoice);
            this.db.SaveChanges();

            int idInvoice = this.db.Invoices.ToList() != null ? this.db.Invoices.ToList().Last().IdInvoice : 1;
            if (this.ListProduct.Count > 0)
            {
                foreach(Product product in this.ListProduct)
                {
                    DetailInvoice detailInvoice = new DetailInvoice
                    {
                        IdInvoice = idInvoice,
                        IdProduct = product.IdProduct,
                        Qty = product.Qty
                    };
                    this.db.DetailInvoices.Add(detailInvoice);
                }
            }
            this.ListProduct = null;
            this.db.SaveChanges();
            MessageBox.Show("Đã thêm hóa đơn vào hệ thống", "Hệ thống");
            resetData();
        }

        private void btn_findInvoice_Click(object sender, EventArgs e)
        {
            if(txt_idInvoice.Text != "")
            {
                int idInvoice = Convert.ToInt32(txt_idInvoice.Text);
                data_invoice.DataSource = this.db.Invoices.Where(obj => obj.IdInvoice == idInvoice).ToList();
            }
            else
            {
                data_invoice.DataSource = this.db.Invoices.ToList();
            }
        }
    }
}
