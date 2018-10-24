using System;

namespace lesweek3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int a = sum(100, 7);
            int b = multiply(a, 3);

            int c = sum(406, 7367);
            int d = divide(c, 69);
            int e = multiply(d, 5);

            int f = multiply(73, 41);
            int g = subtract(f, 39);

            int h = multiply(7, 8); 
            int i = subtract(h, 19);

            int total = multiply(3,sum(100,7)) + multiply(divide(sum(406, 7367),69),5) + subtract(multiply(73, 41),39) + subtract(multiply(7,8),19);
            total = total--;
           

            if(total == 3872) {
                Console.WriteLine("Het resultaat klopt!");
            } else if(total < 3872) {
                Console.WriteLine("Resultaat is te laag!");
            } else {
                Console.WriteLine("Resultaat is te hoog!");
            }
            
            for (int countVar = 0; countVar < 10; countVar++) {
                Console.WriteLine(countVar + " x 2 = " + (countVar * 2));
            }

            table(1);
            table(2);
            table(3);

            int digit3 = 3;
            do {
                Console.WriteLine("De waarde van het getal is: " + digit3);
                digit3++;
            }
            while (digit3 < 5);
            int digit4 = 4;
        
            while(digit4 < 5) {
                Console.WriteLine("De waarde van het getal is: " + digit4);
            }

        }
            static int sum(int a, int b) {
                return a + b;
            }

            static int subtract(int a, int b) {
                return a - b;
            }

            static int multiply(int a, int b) {
                return a * b;
            }

            static int divide(int a, int b){
                return a / b;
            }

            static int count(int a){
                return a++;
            }
    }
}

            
    




