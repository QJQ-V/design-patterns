using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    public class RealImage: IImage
    {
        private string fileName;

        public RealImage(string fileName) {
            this.fileName = fileName;
            LoadFormDisk(fileName); 
        }

        public void Display() {
            Console.WriteLine("Displaying "+ fileName);
        }

        public void LoadFormDisk(string fileName)
        {
            Console.WriteLine("LoadFormDisk " + fileName);
        }
    }
}
