using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;

namespace Iterator
{
    public interface IContainer
    {
         IIterator GetIterator();
    }
}
