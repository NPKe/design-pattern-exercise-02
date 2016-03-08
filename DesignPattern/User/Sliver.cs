using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern
{
    public class SliverUser : User
    {
        public SliverUser(string name, string email)
            : base(name, email)
        {
            Level = "Sliver";
        }
    }
}
