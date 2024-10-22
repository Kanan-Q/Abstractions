using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New
{
    internal class User : Iaccount
    {
        private double _id = 1;

        public double Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public User[] users;
        public User(double id, string fullName, string email, string password)
        {
            Id = id++;
            FullName = fullName;
            Email = email;
            Password = password;
        }

        public User()
        {
            users = new User[0];
            Id = ++_id;
        }

        public void AddUser(User user)
        {
            Array.Resize(ref users, users.Length + 1);
            users[users.Length - 1] = user;
        }



        public bool PasswordChecker(string password)
        {
            bool check = false;
            if (password.Length >= 4)
            {
                check = true;
            }
            return check;
        }




        public void ShowInfo()
        {
            for (int i = 0; i < users.Length; i++)
            {
                Console.WriteLine($"Id:{users[i].Id},Name:{users[i].FullName},Email:{users[i].Email}");
            }
        }
    }
}
