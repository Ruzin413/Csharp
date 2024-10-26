using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ruzin
{
    internal class Ternaryoperator
    {
        public void Terop() {
            int numb1 = 10;
            int numb2 = 20;
            int max = (numb1 > numb2)? numb1 : numb2;
            Console.WriteLine("the maximum number is " + max);
            string result = (numb1 % 2 == 0) ? "Even" : "Odd";
            Console.WriteLine(numb1 + "is :" + result);
        }
    }
}
