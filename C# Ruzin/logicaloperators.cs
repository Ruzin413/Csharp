using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ruzin
{
    internal class logicaloperators
    {
        public void  logicaloperators1() {
            bool con1 = true;
            bool con2 = false;

            Console.WriteLine("logical And :" + (con1 && con2));
            Console.WriteLine("logical OR :" + (con1 || con2));
            Console.WriteLine("logical NOT :" + ( !con1));
        }
    }
}
