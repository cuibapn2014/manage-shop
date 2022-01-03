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
    public partial class FormQuanLyNhanVien : Form
    {
        public QuanLyBanHang db = new QuanLyBanHang();
        public FormQuanLyNhanVien()
        {
            InitializeComponent();
        }

        private void FormQuanLyNhanVien_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            cb_type.SelectedIndex = 0;
            data_employee.DataSource = this.db.Users.ToList();
        }

        private void data_employee_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btn_edit.Enabled = true;
            int idUser = Convert.ToInt32(data_employee.Rows[e.RowIndex].Cells[0].Value);
            Account account = this.db.Accounts.Where(obj => obj.Id_User == idUser).FirstOrDefault();
            if(account != null)
            {
                txt_idUser.Text = idUser.ToString();
                txt_account.Text = account.Username;
                txt_password.Text = account.Password;
                txt_phone.Text = account.User.Phone;
                txt_address.Text = account.User.Address;
                txt_name.Text = account.User.Name;
                dateTimePicker1.Value = (DateTime) account.User.Birthday;
                cb_type.SelectedIndex = (int) account.Type; 
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string keyword = txt_findUser.Text;
            if(keyword != "")
            {
                data_employee.DataSource = this.db.Users.Where(obj => obj.Name.Contains(keyword)).ToList();
            }
            else
            {
                data_employee.DataSource = this.db.Users.ToList();
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (txt_account.Text == "" || txt_password.Text == "" || txt_name.Text == "" ||
                txt_phone.Text == "" || txt_address.Text == "")
            {
                MessageBox.Show("Vui lòng không để trống thông tin", "Hệ thống");
            }
            else 
            {
                User user = new User
                {
                    Name = txt_name.Text,
                    Phone = txt_phone.Text,
                    Birthday = dateTimePicker1.Value,
                    Address = txt_address.Text,
                    CreatedAt = DateTime.Now,
                };
                this.db.Users.Add(user);
                this.db.SaveChanges();

                int lastIdUser = this.db.Users.ToList().Last().Id;

                Account account = new Account
                {
                    Id_User = lastIdUser,
                    Username = txt_account.Text,
                    Password = txt_password.Text,
                    Type = cb_type.SelectedIndex
                };
                this.db.Accounts.Add(account);
                this.db.SaveChanges();
                MessageBox.Show("Đã thêm dữ liệu vào hệ thống", "Hệ thống");
                loadData();
                resetData();
            }
        }

        private void resetData()
        {
            txt_idUser.Text = null;
            txt_account.Text = null;
            txt_password.Text = null;
            txt_phone.Text = null;
            txt_address.Text = null;
            txt_name.Text = null;
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            int idUser = Convert.ToInt32(txt_idUser.Text);
            Account account = this.db.Accounts.Where(obj => obj.Id_User == idUser).FirstOrDefault();
            if(account != null)
            {
                if (txt_account.Text == "" || txt_password.Text == "" || txt_name.Text == "" ||
               txt_phone.Text == "" || txt_address.Text == "")
                {
                    MessageBox.Show("Vui lòng không để trống thông tin", "Hệ thống");
                }
                else
                {
                    account.User.Name = txt_name.Text;
                    account.User.Phone = txt_phone.Text;
                    account.User.Address = txt_address.Text;
                    account.User.Birthday = dateTimePicker1.Value;
                    account.Type = cb_type.SelectedIndex;
                    this.db.SaveChanges();
                    loadData();
                    resetData();
                    btn_edit.Enabled = false;
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(data_employee.SelectedRows.Count > 0)
            {
                int idUser = Convert.ToInt32(data_employee.SelectedRows[0].Cells[0].Value);
                Account account = this.db.Accounts.Where(obj => obj.Id_User == idUser).FirstOrDefault();
                DialogResult dialog = MessageBox.Show("Bạn có chắn chắn muốn xóa " + account.User.Name, "Hệ thống", MessageBoxButtons.YesNo);
                if(dialog == DialogResult.Yes)
                {
                    this.db.Users.Remove(account.User);
                    this.db.Accounts.Remove(account);
                    this.db.SaveChanges();
                    loadData();
                    MessageBox.Show("Đã xóa thành công", "Hệ thống");
                }
            }
            else 
            {
                MessageBox.Show("Hãy chọn dữ liệu cần xóa", "Hệ thống");
            }
        }
    }
}
