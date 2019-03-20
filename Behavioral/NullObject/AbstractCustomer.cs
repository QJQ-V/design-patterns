using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObject
{
    public abstract class AbstractCustomer
    {
        protected string name;
        public abstract bool IsNil();

        public abstract string GetName();

    }
}
