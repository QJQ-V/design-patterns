using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            IImage image = new ProxyImage("test_10mb.jpg");

            //图像将从磁盘加载
            image.Display();

            Console.ReadKey();
        }
    }
}
