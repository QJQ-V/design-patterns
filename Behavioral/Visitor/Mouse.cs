﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    public class Mouse: IComputerPart
    {
        public void Accept(IComputerPartVisitor computerPartVisitor) {
            computerPartVisitor.Visit(this);
        }
    }
}
