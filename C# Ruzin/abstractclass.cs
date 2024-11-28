using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Ruzin
{
    internal class abstractclass
    {
    }
     abstract class Animals
    {
        // Abstract method animalsound
        public abstract void animalSound();

        // Non-abstract method sleep
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

    //Class Pig inherits from Animal
     class Pigs : Animals
    {
        // Override the animalsound method
        public override void animalSound()
        {
            Console.WriteLine("The pig says: Wee wee");
        }
    }


}
