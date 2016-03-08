using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern
{
    public abstract class Resource
    {
        public string Name
        {
            get;
            set;
        }

        public string Author
        {
            get;
            set;
        }

        public float Size
        {
            get;
            set;
        }

        protected Resource()
        {

        }

        protected Resource(string name, string author, float size)
        {
            Name = name;
            Author = author;
            Size = size;
        }

        public virtual void Input()
        {
            Console.WriteLine("Name: ");
            Name = Console.ReadLine();

            Console.WriteLine("Author: ");
            Author = Console.ReadLine();

            Console.WriteLine("Size: ");
            Size = Int16.Parse(Console.ReadLine());
        }

        public abstract Resource Clone();

        public abstract Resource CreateNew(User uploader);
    }
}
