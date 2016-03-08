using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern
{
    public class User
    {
        public string Name
        {
            get;
            set;
        }

        public string Email
        {
            get;
            set;
        }

        public string Level
        {
            get;
            set;
        }

        public User(string name, string email, string level)
        {
            Name = name;
            Email = email;
            Level = level;
        }

    }
}
