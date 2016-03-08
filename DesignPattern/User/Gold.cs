using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern
{
    public class GoldUser : User
    {
        public GoldUser(string name, string email)
            : base(name, email)
        {
            Level = "Gold";
        }
    }
}
