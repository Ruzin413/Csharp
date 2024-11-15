using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ruzin
{
    public class BaseClass{
        public  void Display()
        {
            Console.WriteLine("this is from base class");
        }
    }
    public class DerivedClass:BaseClass
    {

        public new void Display()
        {
            Console.WriteLine("this is from Derived class");
        }
    }

}
