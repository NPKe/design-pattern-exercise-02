using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern
{
    public class AudioClip : Resource
    {
        public float Length
        {
            get;
            set;
        }

        public string Format
        {
            get;
            set;
        }

        private AudioClip()
        {

        }

        private AudioClip(string name, string author, float size, float length, string format)
            :base(name, author, size)
        {
            Length = length;
            Format = format;
        }

        public override void Input()
        {
            Console.WriteLine("Please enter audio clip information!");

            base.Input();
            Console.WriteLine("Length (minute): ");
            Length = float.Parse(Console.ReadLine());

            Console.WriteLine("Format: ");
            Format = Console.ReadLine();
        }

        public override Resource Clone()
        {
            return new AudioClip(Name, Author, Size, Length, Format);
        }

        public static Resource CreateNew(User Uploader)
        {
            if (Uploader.Level == "Basic")
                return null;

            return new AudioClip();
        }

        public static Resource CreateNew()
        {
            return new AudioClip();
        }
    }
}
