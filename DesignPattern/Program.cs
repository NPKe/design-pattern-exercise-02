using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            Library fitHCMUSLibrary = new Library();

            //Resource res = Ebook.CreateNew();
            //fitHCMUSLibrary.Input(res);

            //res = AudioClip.CreateNew();
            //fitHCMUSLibrary.Input(res);

            //res = VideoClip.CreateNew();
            //fitHCMUSLibrary.Input(res);

            //res = Software.CreateNew();
            //fitHCMUSLibrary.Input(res);


            User[] Student = new User[3];

            Student[0] = new BasicUser("Nguyen Phu Ke", "kenguyen@gmail.com");
            Student[1] = new SliverUser("Nguyen Van Tuan", "tuanvan@gmail.com");
            Student[2] = new GoldUser("Nguyen Anh Huy", "anhhuy@gmail.com");

            Resource res = Student[0].Upload("Ebook");
            fitHCMUSLibrary.UploadToLibrary(res);

            res = Student[0].Upload("AudioClip");
            fitHCMUSLibrary.UploadToLibrary(res);

            res = Student[1].Upload("AudioClip");
            fitHCMUSLibrary.UploadToLibrary(res);

            res = Student[2].Upload("VideoClip");
            fitHCMUSLibrary.UploadToLibrary(res);
        }
    }
}
