using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ruzin
{
    internal class Fibbonaci
    {
        public void FibonacciIterative(int n)
        {
            if (n <= 0) return;

            long first = 0, second = 1;

            Console.WriteLine("Fibonacci Sequence:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(first);
                long next = first + second; // Calculate next term
                first = second; // Update first
                second = next; // Update second
            }
        }
    }
}
