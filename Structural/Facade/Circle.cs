﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Shape: Circle");
        }
    }
}
