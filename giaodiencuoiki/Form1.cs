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
    public partial class Form1 : Form
    {
        private QuanLyBanHang db = new QuanLyBanHang();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void quảnLýBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FrmQuanLyBanHang form = new FrmQuanLyBanHang())
            {
                this.Hide();
                form.ShowDialog();
                this.Show();
            }  
        }

        private void quảnLýKhoHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (FrmQuanLyKhoHangcs form = new FrmQuanLyKhoHangcs())
            {
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
        }

        private void quảnLýRủiRoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FrmQuanLyRuiRo form = new FrmQuanLyRuiRo())
            {
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormBaoCaoThongKe form = new FormBaoCaoThongKe())
            {
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Modify.Account.Type == 1)
            {
                using (FormQuanLyNhanVien form = new FormQuanLyNhanVien())
                {
                    this.Hide();
                    form.ShowDialog();
                    this.Show();
                }
            }
            else 
            {
                MessageBox.Show("Bạn không có quyền truy cập tính năng này", "Hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            btn_save.Enabled = true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            int idUser = Convert.ToInt32(txt_idUser.Text);
            Account account = this.db.Accounts.Where(obj => obj.Id_User == idUser).FirstOrDefault();
            User user = this.db.Users.Where(obj => obj.Id == idUser).FirstOrDefault();
            account.Password = txt_password.Text;
            user.Name = txt_name.Text;
            user.Phone = txt_phone.Text;
            user.Address = txt_address.Text;
            user.Birthday = birthday.Value;
            DialogResult dialog = MessageBox.Show("Bạn có chắn chắn rằng sẽ cập nhật mọi thứ", "Hệ thống", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.db.SaveChanges();
                MessageBox.Show("Cập nhật thành công", "Hệ thống");
            }
        }

        private void loadData()
        {
            MyAccount account = Modify.Account;
            txt_idUser.Text = account.User.Id.ToString();
            txt_account.Text = account.Account;
            txt_password.Text = account.Password;
            txt_name.Text = account.User.Name;
            txt_phone.Text = account.User.Phone;
            txt_address.Text = account.User.Address;
            birthday.Value = (DateTime) account.User.Birthday;
        }
    }
}
