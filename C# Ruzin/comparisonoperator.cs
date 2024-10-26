using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ruzin
{
    internal class comparisonoperator
    {
        public void compop()
        {
            int numb1 = 10;
            int numb2 = 20;

            bool isequal = numb1 == numb2 ;
            Console.WriteLine("Is equal to" + isequal);
            bool notequal = numb1 != numb2 ;
            Console.WriteLine("Is equal to" + notequal);
            bool greaterthan = numb1 >= numb2;
            Console.WriteLine("Greaterthan" + greaterthan );
            bool Lessthan = numb1 <= numb2;
            Console.WriteLine("Less than" + Lessthan);
        }
    }
}
