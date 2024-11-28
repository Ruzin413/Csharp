using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ruzin
{
    internal class Delegate
    {
        public delegate void SDelegate(string msg);

        public static void ShowMessage(string msg)
        {
            Console.WriteLine("message: " + msg);
        }

    }
    public class dele
    {
        public void calldel()
        {
            Delegate.SDelegate del = new Delegate.SDelegate(Delegate.ShowMessage);
            del("Hello, this is a single delegate!");
        }
       
    }
}
