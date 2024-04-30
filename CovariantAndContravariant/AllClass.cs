using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CovariantAndContravariant
{
    internal interface IFruit { }
    internal class Apple : IFruit { }
    internal class Orange : IFruit { }
    internal interface IX<out T> where T : IFruit { }
    internal class X<T> : IX<T> where T : IFruit { }   

    internal class Test
    {
        public void GetIxFruit(IX<IFruit> fruit)
        {

        }
    }
}
