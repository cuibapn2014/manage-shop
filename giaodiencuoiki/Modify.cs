using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace giaodiencuoiki
{
    public partial class Modify
    {
        private QuanLyBanHang db = new QuanLyBanHang();
        private static MyAccount account;

        internal static MyAccount Account { get => account; set => account = value; }

        public bool Login(string username, string password)
        {
            Account account = this.db.Accounts.Where(obj => obj.Username.Equals(username) && obj.Password.Equals(password)).FirstOrDefault();
            if (account != null)
            {
                Modify.Account = new MyAccount(account.Username, account.Password,Convert.ToInt32(account.Type), 
                    new MyUser(account.User.Id, account.User.Name,account.User.Phone,(DateTime) account.User.Birthday, account.User.Address));
                return true;
            }
            return false;
        }
    }
}
