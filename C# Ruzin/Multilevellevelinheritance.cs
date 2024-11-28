using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ruzin
{
    internal class Multilevellevelinheritance
    { }

    public class Animal
    {
        public void eat()
        {
            Console.WriteLine("Eating...");
        }
    }
    public class Dogs : Animal
    {
        public void bark()
        {
            Console.WriteLine("Barking--");
        }
    }
    public class BabyDog : Dogs
    {
        public void weep()
        {
            Console.WriteLine("Weeping---");
        }
    }
}

