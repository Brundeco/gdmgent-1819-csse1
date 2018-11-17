using System;

namespace opdracht_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ingredients1 = new string[]{"appel", "banaan", "aardbei", "druif", "kiwi"};
            MenuItem item1 = new MenuItem("Fruitsalade", "dessert", ingredients1 , 4.50, "€");

            string[] ingredients2 = new string[]{"tomaat", "mozarella", "basilicum", "peper"};
            MenuItem item2 = new MenuItem("Tomaat-mozarella", "hapje", ingredients2 , 7.00, "€");

            string[] ingredients3 = new string[]{"pasta", "pesto", "kaas"};
            MenuItem item3 = new MenuItem("Pasta-pesto", "hoofdgerecht", ingredients3 , 6.50, "€");

            string[] ingredients4 = new string[]{"chocolade", "eieren", "melk", "suiker"};
            MenuItem item4 = new MenuItem("Chocomousse", "dessert", ingredients4 , 4.00, "€");

            string[] ingredients5 = new string[]{"aubergine", "wortel", "tomaat", "paprika"};
            MenuItem item5 = new MenuItem("Groentenlasagna", "hoofdgerecht veggi", ingredients5 , 4.00, "€");
        }
    }
}