using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTCM
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }
        public string Phonenumber { get; set; }
        public string Email { get; set; }

        public string Address { get; set; }

        public User(int Id, string Username, string Password, string Fullname, string Phonenumber, string Email, string Address)
        {
            this.Id = Id;
            this.UserName = Username;
            this.Password = Password;
            this.Fullname = Fullname;
            this.Phonenumber = Phonenumber;
            this.Email = Email;
            this.Address = Address;
        }
    }
}
