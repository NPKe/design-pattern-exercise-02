using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern
{
    public class Ebook : Resource
    {
        public string Publisher
        {
            get;
            set;
        }

        public int YearOfPublication
        {
            get;
            set;
        }

        private Ebook()
        {

        }

        private Ebook(string name, string author, float size, string publisher, int yearOfPublication)
            : base(name, author, size)
        {
            YearOfPublication = yearOfPublication;
            Publisher = publisher;
        }

        public override void Input()
        {
            Console.WriteLine("Please enter ebook information!");

            base.Input();
            Console.WriteLine("Publisher: ");
            Publisher = Console.ReadLine();

            Console.WriteLine("Year of publication: ");
            YearOfPublication = int.Parse(Console.ReadLine());
        }

        public override Resource Clone()
        {
            return new Ebook(Name, Author, Size, Publisher, YearOfPublication);
        }

        public static Resource CreateNew(User Uploader)
        {
            return new Ebook();
        }

        public static Resource CreateNew()
        {
            return new Ebook();
        }
    }
}
