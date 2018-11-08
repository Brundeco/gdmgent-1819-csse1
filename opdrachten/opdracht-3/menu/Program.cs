using System;

namespace opdracht_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var menuItems = new (int, string, double) [] {
                 (1, "plat water", 1),
                 (2, "cola 25 cl", 1.5),
                 (3, "cola 33 cl", 2),
                 (4, "witte wijn", 3),
                 (5, "pils", 2),
                 (6, "toast", 5),
                 (7, "kaasplank", 4)
            };

            foreach(var item in menuItems) {
                Console.WriteLine(item);
            }
        }
    }
}
