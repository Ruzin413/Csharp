using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ruzin
{
    internal class multipledelegate
    {
        
     public delegate void Operation(int a, int b);

        public static void Add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("Result of add: " + result);
        }

        public static void Sub(int a, int b)
        {
            int result = a - b;
            Console.WriteLine("Result of subtraction: " + result);
        }

        public static void Multiply(int a, int b)
        {
            int result = a * b;
            Console.WriteLine("Result of multiply: " + result);
        }

        public static void delcall()
        {
            Operation del = new Operation(Add);
            del += Sub;
            del += Multiply;
            del(10, 5);
        }
    }
}
