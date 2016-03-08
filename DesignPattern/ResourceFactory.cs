using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern
{
    class ResourceFactory
    {
        private static Dictionary<string, Resource> prototypes = new Dictionary<string, Resource>();

        public static Resource CreateNew(string resourceType)
        {
            if (prototypes.ContainsKey(resourceType))
            {
                return prototypes[resourceType].Clone();
            }

            return null;
        }

        public static Resource CreateNew(User uploader, string resourceType)
        {
            if (prototypes.ContainsKey(resourceType))
            {
                return prototypes[resourceType].CreateNew(uploader);
            }

            return null;
        }
    }
}
