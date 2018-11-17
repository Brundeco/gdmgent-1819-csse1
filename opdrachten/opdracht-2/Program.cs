using System;

namespace opdrachten
{
    class Program
    {
        static void Main(string[] args)
        {

            // Tafels van vermenigvuldiging
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("De tafels van vermenigvuldiging");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - -");
            int x = 10;
                for(int table_1 = 0; table_1 < 10; table_1++) {
                    Console.WriteLine(table_1 + " x " + x + " = " + (x * table_1));
            }


            // Faculteit
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("De faculteit van een getal");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - -");
            int faculty(int facultyOf) {
                return (facultyOf == 1 || facultyOf == 0) ? 1 : faculty(facultyOf - 1) * facultyOf;
            }
            Console.WriteLine(faculty(9));
            

            // Fibonacci
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("De reeks van Fibonacci");
            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - -");
            int a_fib = 0;
            int b_fib = 1;
            int result = 0;

            for(int i = 0; i < 20; i++) {
                result = a_fib + b_fib;
                Console.WriteLine(result);

                a_fib = b_fib;
                b_fib = result;
            }
        }
    }
}
