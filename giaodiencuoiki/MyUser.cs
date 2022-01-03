using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace giaodiencuoiki
{
    public class MyUser
    {
        private DateTime? birthday;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public DateTime Birthday { get; set; }
        public string Address { get; set; }

        public MyUser(int id, string name, string phone, DateTime birthday, string address)
        {
            Id = id;
            Name = name;
            Phone = phone;
            Birthday = birthday;
            Address = address;
        }
    }
}