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

            Resource res = Ebook.CreateNew();
            fitHCMUSLibrary.Input(res);

            res = AudioClip.CreateNew();
            fitHCMUSLibrary.Input(res);

            res = VideoClip.CreateNew();
            fitHCMUSLibrary.Input(res);

            res = Software.CreateNew();
            fitHCMUSLibrary.Input(res);


            User basicUser = new User("Nguyen Phu Ke", "kenguyen@gmail.com", "Basic");
            User sliverUser = new User("Nguyen Van Tuan", "tuanvan@gmail.com", "Sliver");
            User goldUser = new User("Nguyen Anh Huy", "anhhuy@gmail.com", "Gold");

            res = ResourceFactory.CreateNew(basicUser, "Ebook");
            fitHCMUSLibrary.Input(res);

            re

            res = Student[0].Upload("Ebook");
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
