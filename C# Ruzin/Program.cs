using C__Ruzin;
using Csharp;
using System;

class Program
{
    public static void Main(string[] args)
    {
        /*1stquestion*/
        //Helloworld helloworld = new Helloworld();
        //helloworld.hello();
        //Console.ReadLine();
        /*2ndquestion*/
        //int a = 8;
        //int b = 5;
        //Operators o1 = new Operators();
        //o1.op1();
        /*3ndquestion*/
        //logicaloperators l1 = new logicaloperators();
        //l1.logicaloperators1();
        /*4thquestion*/
        //comparisonoperator c1 = new comparisonoperator();
        //c1.compop();
        /*5thquestion*/
        //Ternaryoperator t1 = new Ternaryoperator();
        //t1.Terop();
        /*6thquestion*/
        //loop l1=new loop();
        //l1.loop1();
        /*7thquestion*/
        //array a1 = new array();
        //a1.array1();
        /*8thquestion*/
        //multidimentionalarray m1 = new multidimentionalarray();
        //m1.Marray();
        /*9thquestion*/
        //Class_Object C1 = new Class_Object();
        //C1.Name = "Ruzin";
        //C1.ID = 10;
        //Console.WriteLine(C1.Name);
        /*10thquestion*/
        //Console.WriteLine("Enter a number:");
        //int number = int.Parse(Console.ReadLine());
        //Factorial f1 = new Factorial();
        //long factorial = f1.Factorial1(number);
        //Console.WriteLine($"Factorial of {number} is {factorial}");
        /*11thquestion*/
        //Console.WriteLine("Enter the number of Fibonacci terms to generate:");
        //int terms = int.Parse(Console.ReadLine());
        //Fibbonaci f1 = new Fibbonaci();
        //f1.FibonacciIterative(terms);
        /*12thquestion*/
        //Dog d1 = new Dog();
        //d1.Makesound();
        //Cat cat1 = new Cat();
        //cat1.Makesound();
        /*13thquestion*/
        //Calculate c1 = new Calculate();
        //int b = c1.add(12, 12);
        //int a = c1.add(12, 15, 14);
        //Console.WriteLine(b);
        //Console.WriteLine(a);
        /*14thquestion*/
        //BaseClass b1 = new BaseClass();
        //b1.Display();
        //DerivedClass b2 = new DerivedClass();
        //b2.Display();
        //BaseClass b3 = new DerivedClass();
        //b3.Display();
        /*15thquestion*/
        //ExceptionHandeling e1 = new ExceptionHandeling();
        //e1.exception();
        /*15thquestion*/
        //List l1 = new List();
        //l1.list();
        /*16thquestion*/
        //@switch s1 = new @switch();
        //s1.days();
        /*17thquestion*/
        //@ref r1 = new @ref();
        //int num = 10;
        //Console.WriteLine("Before:" + num);
        //r1.UpdateValue(ref num);
        //Console.WriteLine($"After: {num}");
        /*test1*/
        //refdatatyoe r2 = new refdatatyoe();
        //r2.name();
        /*test2*/
        //autoimplementgetterandsetter a2 = new autoimplementgetterandsetter();
        //Console.WriteLine("enter the race");
        //String input1 = Console.ReadLine();
        //Console.WriteLine("enter the conteinent");
        //String output1 = Console.ReadLine();
        //a2.Race = input1;
        //a2.continent = output1;
        //a2.call();
        /*18thquestion*/
        //Calculator calc = new Calculator(15, -25);
        //calc = -calc;
        //calc.print();
        /*19thquestion*/
        //GenericClass<string> gen = new GenericClass<string>("this is generic");
        //GenericClass<int> gent = new GenericClass<int>(101);
        //GenericClass<char> getch = new GenericClass<char>('A');
        /*20thquestion*/
        //try
        //{
        //    int a = 10;
        //    int b = 0;
        //    int x = a / b;
        //}
        //catch (Exception e)
        //{
        //    Console.WriteLine(e);
        //}
        //finally
        //{
        //    Console.WriteLine("Finally block is executed");
        //}
        //Console.WriteLine("Rest of the code");
        /*21thquestion*/
        //BabyDog dt = new BabyDog();
        //dt.eat();
        //dt.bark();
        //dt.weep();
        /*22thquestion*/
        //Console.WriteLine("Season is: " + (int)Season.SUMMER);
        /*23rdquestion*/
        //Pigs myPig = new Pigs();
        //myPig.animalSound();
        //myPig.sleep();
        /*24thquestion*/
        //dele d2 = new dele();
        //d2.calldel();
        /*25thquestion*/
        //multicastdelegate.MultDel();
        /*26thquestion*/
        //multipledelegate.delcall();
        /*27thquestion*/
        //Publisher publisher = new Publisher();
        //Subscriber subscriber = new Subscriber();
        //publisher.myEvent += subscriber.OnMyEvent;
        //publisher.RaiseEvent();
        /*28thquestion*/
        // Create a list of numbers
        List<int> numbers = new List<int>() { 36, 71, 12, 15, 293 };

        // Print the numbers in the list
        Console.WriteLine("The list:");
        foreach (var value in numbers)
        {
            Console.WriteLine("{0}", value);
        }

        // Find all numbers divisible by 3 and store them in a new list
        List<int> divBy3 = numbers.FindAll(x => x % 3 == 0);

        // Print the numbers divisible by 3
        Console.WriteLine("Number divisible by 3:");
        foreach (var value in divBy3)
        {
            Console.WriteLine("{0}", value);
        }
    }
}


