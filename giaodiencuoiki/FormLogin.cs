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
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txt_username.Text != "" && txt_password.Text != "")
            {
                Modify md = new Modify();
                bool success = md.Login(txt_username.Text, txt_password.Text);
                if(success)
                {
                    Form1 form = new Form1();
                    this.Hide();
                    form.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác. Vui lòng thử lại", "Hệ Thống", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
            }else
            {
                MessageBox.Show("Vui lòng không để trống tài khoản hoặc mật khẩu&", "Hệ Thống", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
