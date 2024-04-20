using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonarchHotel
{
    internal class User
    {
        public static List<User> UserData = new List<User>();

        public string Username;
        public string Password;
        public string Name;

        public User(string Username, string Password, string Name)
        {
            this.Username = Username;
            this.Password = Password;
            this.Name = Name;
        }
        public static void AddUserToList (User user)
        {
            UserData.Add(user);
        }
    }
}
