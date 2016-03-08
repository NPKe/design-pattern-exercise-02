using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern
{
    public abstract class User
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

        public User(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public virtual Resource Upload(string resourceName)
        {
            Resource res = null;

            if (resourceName == "Ebook")
                res = Ebook.CreateNew(this);
            else if (resourceName == "AudioClip")
                res = AudioClip.CreateNew(this);
            else if (resourceName == "VideoClip")
                res = VideoClip.CreateNew(this);
            
            if (res != null)
            {
                res.Input();
            }
            else
            {
                Console.WriteLine("You cannot upload this kind of resoure. Permisson denied!");
            }

            return res;
        }
    }
}
