using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern
{
    public class BasicUser : User
    {
        public BasicUser(string name, string email)
            : base(name, email)
        {
            Level = "Basic";
        }
    }
}
