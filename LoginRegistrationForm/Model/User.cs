using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LoginRegistrationForm.Model
{
    internal class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User(int userId, string username, string email, string password)
        {
            UserId = userId;
            Username = username;
            Email = email;
            Password = password;
        }
    }

}
