﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
   public class OperationSubstract: IStrategy
    {

        public int DoOperation(int num1, int num2) {
            return num1 - num2;
        }
    }
}
