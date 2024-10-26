using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ruzin
{
    internal class loop
    {
        public void loop1()
        {
            List<int> A = new List<int>() { 1, 2, 3, 4, 5 };

            Console.WriteLine("For loop:");
            for (int i = 0; i < A.Count; i++)
            {
                Console.WriteLine(A[i]);
            }

            Console.WriteLine("\nForeach loop:");
            foreach (int b in A)
            {
                Console.WriteLine(b);
            }

            Console.WriteLine("\nWhile loop:");
            int index = 0;
            while (index < A.Count)
            {
                Console.WriteLine(A[index]);
                index++;
            }

            Console.WriteLine("\nDo-while loop:");
            index = 0;
            do
            {
                Console.WriteLine(A[index]);
                index++;
            }
            while (index < A.Count);
        }
    }
}
