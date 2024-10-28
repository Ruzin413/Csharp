using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ruzin
{
    internal class multidimentionalarray
    {
        public void Marray()
        {
            int[,] a = new int[2,2] { { 1, 2 }, { 1, 2 } };
            foreach(int i in a)
            {
                Console.WriteLine(i);
            }
        }
    }
}
