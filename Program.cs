using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBasedTestThree
{
    //Write a class Box that has Length and breadth as its members.
    //Write a function that adds 2 box objects and stores in the 3rd.
    //Display the 3rd object details. Create a Test class to execute the above.

    class Box
    {
        static int lengthPlusBreadth;
        static int length { get; set; }
        static int breadth { get; set; }

        public Box(int len, int brd)
        {
            length = len;
            breadth = brd;
            BoxAdder();
            BoxDisplayer();
        }

        public static void BoxAdder()
        {
            lengthPlusBreadth = length + breadth;
        }
        public static void BoxDisplayer()
        {
            Console.WriteLine($"Length: {length} \n" +
                $"Breadth: {breadth} \n" +
                $"Length + Breadth: {lengthPlusBreadth}");
        }
    }
    class Program
    {
        static void Main()
        {
            main();
        }
        static void main()
        {
            Console.Write("Enter Length: ");
            int len = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Breadth: ");
            int brd = int.Parse(Console.ReadLine());

            Box box = new Box(len, brd);
            Console.WriteLine("Add Another? (y/n): ");
            char choice = Convert.ToChar(Console.ReadLine());
            switch (choice)
            {
                case 'y': main(); break;
                case 'n': Environment.Exit(0); break;
            }
            Console.Read();
        }
    }
}
