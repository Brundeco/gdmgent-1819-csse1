using System;
using System.Collections;

namespace wachtlijst
{
    class Program
    {
        static void Main(string[] args)
        {
            Program myQueue = new Program();
            Queue orders = new Queue();
            orders.Enqueue("first order");
            orders.Enqueue("second order");
            orders.Enqueue("third order");
            orders.Enqueue("fourth order");

            int orderList = orders.Count;
            object[] orderItems;

            for(int i = 0; i < orderList; i++) {
                Console.WriteLine(orders.Dequeue());
                orderItems = orders.ToArray();
                myQueue.PrintItems(orderItems);
            }         
        }

        void PrintItems(object[] array) {
            Console.WriteLine("___________________");
            Console.WriteLine("Currently in queue: ");
            foreach (var order in array)
            {
                Console.WriteLine(order);
            }
        }
    }
}