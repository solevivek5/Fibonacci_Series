using System;

namespace Fibonacci_Series
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            int n1 = 0, n2 = 1, n3, i, number;
            Console.Write(  "Enter the Number: ");
            number = int.Parse(Console.ReadLine() );
            Console.Write(n1 + " " + n2 + " ");
            for ( i = 0; i < number; ++i )
            {
                n3 = n1 + n2;
                Console.Write(n3+ " ");
                n1 = n2;
                n2 = n3;
            }
            Console.ReadLine();

        }
    }
}
