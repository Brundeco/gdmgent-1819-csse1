using System;

namespace lesweek5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //string always small -- string is array van char
            string tekst = " This is string ";

            int length = tekst.Length;

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(tekst[i]);

            }
            Console.WriteLine(tekst.ToUpper());
            Console.WriteLine(tekst.ToLower());

            //read word by wrod
            string[] woorden = tekst.Split(' ');
            foreach (var woord in woorden)
            {

                Console.WriteLine(woord);
            }


            //remove spaces. Write char within ' ' 
            //this removes every spaces
            Console.WriteLine(tekst.Replace(" ", ""));

            //this removes before and after spaces a string
            //Console.WriteLine(tekst);
            Console.WriteLine(tekst.Trim(' '));

            // string wachtword = "testww";
            // bool test1 = wachtword.Contains('b');
            // Console.WriteLine(test1);
            // bool test2 = wachtword.Contains('b');
            // Console.WriteLine(test2);
            // bool test3 = wachtword.Contains('c');
            // Console.WriteLine(test3);

            // char[] chars = new Char[8];
            // chars[0] = ' ';
            // chars[1] = 'G';
            // // Char aanroepen mbh de unicode van het karakter
            // chars[2] = (char)[78];
            // //
            // chars[3] = 'H';


            // char[] campus = {'M', 'A', 'R'};
            // string[menu1] = new string[3];
            // menu[0] = "broodje martino";
            // menu[1] = "broodje ham";
            // menu[2] = "broodje kaas";

            // foreach(var item in menu1)
            // {
            //     Console.WriteLine(item);
            // }

            // string[menu2] = new string[] {"broodje scampi", "broddje brie", "broodje boulet"};
            // foreach(var item in menu2)
            // {
            //     Console.WriteLine(item);
            // }
            // Console.WriteLine
            

        }
    }
}
