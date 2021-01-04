using System;
using System.Collections.Generic;

namespace QueueZad1
{
    class Program
    {
        static void Main(string[] args)
        {
            //elementi u redu se uklanjaju po redosledu u kom su dodati 
            Queue<string> redBanaka = new Queue<string>();
            redBanaka.Enqueue("Nikola");
            redBanaka.Enqueue("Stefan");
            redBanaka.Enqueue("Milos");

            foreach (var item in redBanaka)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("=========================================");
            Console.WriteLine("   Prozvan u banci: " + redBanaka.Dequeue());
            Console.WriteLine("=========================================");
            
            foreach (var item in redBanaka)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}