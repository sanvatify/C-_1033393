using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentArrays
{
    class simple
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1. Program 1    2. Program 2");
            int c = int.Parse(Console.ReadLine());
            switch (c)
            {
                case 1: P1(); break;
                case 2: P2(); break;
            }
        }
        static void P1()
        {
            Console.WriteLine("Enter array length");
            int len = int.Parse(Console.ReadLine());
            int[] array = new int[len];
            Console.WriteLine("Enter array elements");
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write($"Element {i + 1}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("Your array is ");
            for(int i = 0; i<len; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("1 - Find Sum   2 - Find Average   3 - Find Minimum and Maximum   4 - Exit");
            int c = int.Parse(Console.ReadLine());
            switch (c)
            {
                case 1: int total = array.Sum(); Console.WriteLine("Sum is " + total); options(); break;
                case 2: double average = array.Average(); Console.WriteLine("Average is " + average); options();  break;
                case 3: int min = array.Min(); int max = array.Max(); Console.WriteLine("Minimum is " + min + " and Maximum is " + max); options(); break;
                case 4: Environment.Exit(0); break;
            }
            Console.Read();

        }
        static void options()
        {
            Console.WriteLine("1 - Go back    2 - Program 2    3 - Exit");
            int c = int.Parse(Console.ReadLine());
            switch (c)
            {
                case 1: P1(); break;
                case 2: P2(); break;
                case 3: Environment.Exit(0); break;
            }
        }

        static void options2()
        {
            Console.WriteLine("1 - Go back    2 - Program 1    3 - Exit");
            int c = int.Parse(Console.ReadLine());
            switch (c)
            {
                case 1: P2(); break;
                case 2: P1(); break;
                case 3: Environment.Exit(0); break;
            }
        }
        static void P2()
        {
            Console.WriteLine("Enter array length");
            int len = int.Parse(Console.ReadLine());
            int[] array = new int[len];
            int[] array1 = new int[len];
            Console.WriteLine("Enter array elements");
            for(int i=0; i<len; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Your array is ");
            for(int i = 0; i<len; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("1 - Find sum    2 - Find Average    3 - Find Minimum and Maximum   4 - Ascending and Descending order   5 - Exit");
            int c = Convert.ToInt32(Console.ReadLine());
            switch (c)
            {
                case 1: int sum = array.Sum(); Console.WriteLine("Your total marks are " + sum); options2(); break;
                case 2: double average = array.Average(); Console.WriteLine("Your average is " + average); options2(); break;
                case 3: int min = array.Min(); int max = array.Max(); Console.WriteLine("Your minimum is " + min + " and maximum is " + max); options2(); break;
                case 4: Array.Sort(array);
                    Console.WriteLine("Ascending: ");
                    for(int i = 0; i<len; i++)
                    {
                        Console.WriteLine(array[i]);
                    }
                    Array.Reverse(array);
                    Console.WriteLine("Descending: ");
                    for(int i = 0; i < len; i++)
                    {
                        Console.WriteLine(array[i]);
                    }
                    options2();
                    break;


            }
            Console.Read();
        }
    }
}
