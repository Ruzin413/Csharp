using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ruzin
{
    interface Iprey
    {
        void prey();
    }
    interface Ipredator
    {
        void predy();
    }
    internal class test6interface
    { }
    public class rabbit : Iprey
    {
        public void prey()
        {
            Console.WriteLine("this is prey");
        }
    }
    public class hawk : Ipredator, Iprey
    {
        public void predy()
        {
            Console.WriteLine("this is predator");
        }
        public void  prey()
        {
            Console.Write("this is hawk");
        }
    }
}
