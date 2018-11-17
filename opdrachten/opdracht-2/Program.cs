using System;

namespace opdrachten
{
    class Program
    {
        static void Main(string[] args)
        {

        // Tafels van vermenigvuldiging


        // Faculteit
        int a = 1;

        for( int b = 1; b < 16; b++)
        {
            int c = a * b;
            a = c;

            Console.WriteLine("faculteit van natuurlijk getal is " + a);
        }
            
        // Fibonacci
        int a_fib = 0;
        int b_fib = 1;
        int result = 0;

        for(int i = 0; i < 10; i++)
        {
            result = a_fib + b_fib;
            Console.WriteLine(result);

            a_fib = b_fib;
            b_fib = result;
        }
        }
    }
}
