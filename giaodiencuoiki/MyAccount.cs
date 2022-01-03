using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace giaodiencuoiki
{
    class MyAccount
    {
        private string username;
        private int? type;
        private MyUser myUser;

        public string Account { get; set; }
        public int Type { get; set; }
        public MyUser User { get; set; }

        public string Password { get; set; }

        public MyAccount(string account, string password, int type, MyUser user)
        {
            Account = account;
            Password = password;
            Type = type;
            User = user;
        }
    }
}
