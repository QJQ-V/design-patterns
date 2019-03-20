using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    public class NameRepository : IContainer
    {
        public static string[] names = { "Robert", "John", "Julie", "Lora" };

        public IIterator GetIterator()
        {
            return new NameIterator();
        }

        private class NameIterator : IIterator
        {

            int index;

            public bool HasNext()
            {
                if (index < names.Length)
                {
                    return true;
                }
                return false;
            }

            public Object Next()
            {
                if (this.HasNext())
                {
                    return names[index++];
                }
                return null;
            }
        }

    }
}
