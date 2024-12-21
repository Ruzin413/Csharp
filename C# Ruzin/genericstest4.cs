using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ruzin
{
    
    internal class genericstest4
    {
       public void test() {
       int[] a = { 1, 2, 3, 4 };
        String[] b = { "a" , "b" };
        double[] c = { 1.05, 2.0 };
        displaythis(a);
        displaythis(b);
        displaythis(c); 
       }
        public void displaythis<display>(display[] a)
        {
            foreach (display arr in a)
            {
                Console.WriteLine(arr);
            }
        }
    }
}
