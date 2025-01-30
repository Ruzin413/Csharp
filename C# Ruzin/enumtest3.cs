using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ruzin
{
    enum student
    {
        ram = 12,
        shyam = 56,
        hari = 67
    }
    enum studentmarks{
        ramscience =1,
        shyamscience =2,
        hariscience =3,
        }
    internal class enumtest3
    {
        public void enumtest()
        {
            int marks = (int)studentmarks.ramscience;
            Console.WriteLine(student.hari + "this iss and roll is " + (Int32)student.hari +" "+ marks);
        }
    }
}
