using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern
{
    public class VideoClip : Resource
    {
        public float Length
        {
            get;
            set;
        }

        public string Quality
        {
            get;
            set;
        }

        public string Format
        {
            get;
            set;
        }
        
        private VideoClip()
        {

        }

        private VideoClip(string name, string author, float size, float length, string format, string quality)
            :base(name, author, size)
        {
            Length = length;
            Format = format;
            Quality = quality;
        }

        public override void Input()
        {
            Console.WriteLine("Please enter video clip information!");

            base.Input();
            Console.WriteLine("Length (minute): ");
            Length = float.Parse(Console.ReadLine());

            Console.WriteLine("Format: ");
            Format = Console.ReadLine();

            Console.WriteLine("Quality: ");
            Quality = Console.ReadLine();
        }

        public override Resource Clone()
        {
            return new VideoClip(Name, Author, Size, Length, Format, Quality);
        }

        public static Resource CreateNew(User Uploader)
        {
            if (Uploader.Level == "Gold")
                return new VideoClip();

            return null;
        }

        public static Resource CreateNew()
        {
            return new VideoClip();
        }
    }
}
