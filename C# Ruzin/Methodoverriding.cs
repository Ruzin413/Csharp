using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ruzin
{
    internal class Methodoverriding
    {
    }
    class Dog
    {   
        virtual
        public void Makesound()
        {
            Console.WriteLine("Bark");
        }
    }
    class Cat : Dog
    {
        override
        public void Makesound()
        {
            Console.WriteLine("meow");
        }
    }
}
