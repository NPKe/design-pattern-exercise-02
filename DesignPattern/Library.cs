using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern
{

    public class Library
    {
        protected Dictionary<string, Resource> prototypes = new Dictionary<string, Resource>();

        public void Input(Resource resource)
        {
            if (resource != null)
            {
                resource.Input();
                prototypes.Add(resource.Name, resource.Clone());
                Console.WriteLine("Resource was added sucessful!");
            }
        }

        public Resource GetResource(string name)
        {
            if(prototypes.ContainsKey(name))
            {
                return prototypes[name].Clone();
            }

            return null;
        }

        public void UploadToLibrary(Resource resource)
        {
            if (resource != null)
            {
                prototypes.Add(resource.Name, resource.Clone());
            }
        }
    }
}
