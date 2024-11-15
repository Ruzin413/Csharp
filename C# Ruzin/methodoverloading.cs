using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ruzin
{
    internal class methodOverloading {}
    public class Calculate
    {
        public int add(int x, int y)
        {
            return x + y;
        }
        public int add(int x,int y,int z)
        {
        return x + y + z;
        }
    }
       
}
