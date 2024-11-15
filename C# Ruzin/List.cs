using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ruzin
{
    internal class List
    {
        public void list() {
        List<String> food = new List<String>();
        food.Add("pizza");
            food.Add("Noodles");
            food.Add("Drinks");
            foreach(String item in food)
            {
                Console.WriteLine(item);
            }
        }
        
    }
}
