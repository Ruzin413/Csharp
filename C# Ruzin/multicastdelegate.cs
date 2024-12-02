using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ruzin
{
    internal class multicastdelegate
    {

        // Define a delegate
        public delegate void MultiDelegate(int a, int b);

        // Method to perform addition
        public static void Add(int a, int b)
        {
            int result = a + b;
            Console.WriteLine("Result: " + result);
        }

        // Method to perform addition and then double the result
        public static void AddDoubled(int a, int b)
        {
            int result = (a + b) * 2;
            Console.WriteLine("Result of Add and Doubled: " + result);
        }

        // Method to demonstrate multicast delegate functionality
        public static void MultDel()
        {
            MultiDelegate del = new MultiDelegate(Add); // Initialize the delegate with the Add method
            del += AddDoubled;                         // Add the AddDoubled method to the delegate chain

            del(5, 3); // Invoke the delegate, which calls both Add and AddDoubled
        }
    }
}