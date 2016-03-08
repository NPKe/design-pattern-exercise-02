using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPattern
{

    public class Library
    {
        public List<Resource> resources = new List<Resource>();

        public void Input(Resource resource)
        {
            if (resource != null)
            {
                resource.Input();
                resources.Add(resource);
                Console.WriteLine("Resource was added sucessful!");
            }
        }

        public void Input(string resourceType)
        {
            Resource resource = ResourceFactory.CreateNew(resourceType);

            if (resource != null)
            {
                resource.Input();
                resources.Add(resource);
                Console.WriteLine("Resource was added sucessful!");
            }
        }

    }
}
