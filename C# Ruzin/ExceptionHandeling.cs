using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ruzin
{
    internal class ExceptionHandeling
    {
        public void exception() {  int[] a = { 1, 2, 3, 4, 5, 6, 7 };
        try{
        Console.WriteLine(a[9]);
        }
        catch(Exception e){
        Console.WriteLine(e.Message);
        } 
        }
      
    }
}
