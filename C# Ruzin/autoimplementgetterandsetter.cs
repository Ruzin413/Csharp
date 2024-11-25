using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ruzin
{
    internal class autoimplementgetterandsetter
    {
        public String Race {  get; set; }
        public String continent { get; set; }
        
        public void call()
        {
            Console.WriteLine(Race + " " + continent);
        }
    }
}
