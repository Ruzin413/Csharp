﻿using System;


namespace C__Ruzin
{   
    
    public class test5opoverloading
    {
       public  String a, b;

        // Default Constructor
        public  test5opoverloading()
        {
            this.a = "";
            this.b = "";
        }

        // Parameterized Constructor
        public test5opoverloading(String a, String b)
        {
            this.a = a;
            this.b = b;
        }

        // Operator Overload for '+'
        public static  test5opoverloading operator +(test5opoverloading f1, test5opoverloading f2)
        {
            test5opoverloading f3 = new test5opoverloading();
            f3.a = f1.a + f2.a;
            f3.b = f1.b + f2.b;
            return f3;
            // return new test5opoverloading(
            //f1.a + " & " + f2.a,  // Combine 'a' properties
            //f1.b + " & " + f2.b);  // Combine 'b' properties
        }

        // Display Method
        public void Display()
        {
            Console.WriteLine($"a: {a}, b: {b}");
        }
    }
}
