using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern
{
    public class Software : Resource
    {
        public string Version
        {
            get;
            set;
        }

        public string Manufacturer
        {
            get;
            set;
        }

        private Software()
        {

        }

        private Software(string name, string author, float size, string version, string manufacturer)
            :base(name, author, size)
        {
            Version = version;
            Manufacturer = manufacturer;
        }

        public override void Input()
        {
            Console.WriteLine("Please enter software information!");

            base.Input();
            Console.WriteLine("Version : ");
            Version = Console.ReadLine();

            Console.WriteLine("Manufacturer: ");
            Manufacturer = Console.ReadLine();
        }

        public override Resource Clone()
        {
            return new Software(Name, Author, Size, Version, Manufacturer);
        }

        public override Resource CreateNew(User Uploader)
        {
            return null;
        }

        public static Resource CreateNew()
        {
            return new Software();
        }
    }
}
