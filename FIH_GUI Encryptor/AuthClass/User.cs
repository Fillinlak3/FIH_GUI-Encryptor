using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace FIH_GUI_Encryptor.AuthClass
{
    public class User
    {
        public int Index { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PrivateKey { get; set; }

        public User()
        {
            Index = -1;
            Username = string.Empty;
            Password = string.Empty;
            Email = string.Empty;
        }

        public User(int index, string username, string password, string email, string privateKey)
        {
            Index = index;
            Username = username;
            Password = password;
            Email = email;
            PrivateKey = privateKey;
        }
    }
}
