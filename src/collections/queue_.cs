// Example queue

using System;
using System.Collections;

namespace CollectionsApplication
{
    class Program3
    {
        static void Main(string[] args)
        {
            Queue q = new Queue(); //Instantiating a Queue

            q.Enqueue('A'); //Adding elements into a Queue
            q.Enqueue('M'); //Adding elements into a Queue
            q.Enqueue('G'); //Adding elements into a Queue
            q.Enqueue('W'); //Adding elements into a Queue {A,M,G,W} - current state

            Console.WriteLine("Current queue: ");
            foreach (char c in q) Console.Write(c + " "); //Traversal using foreach loop

            Console.WriteLine();
            q.Enqueue('V'); //Adding elements into a Queue
            q.Enqueue('H'); //Adding elements into a Queue {A,M,G,W,V,H} - current state
            Console.WriteLine("Current queue: ");
            foreach (char c in q) Console.Write(c + " "); //Traversal using foreach loop

            Console.WriteLine();
            Console.WriteLine("Removing some values ");
            char ch = (char)q.Dequeue(); //Removing elements from queue {A}
            Console.WriteLine("The removed value: {0}", ch);
            ch = (char)q.Dequeue(); //Removing elements from queue {M}
            Console.WriteLine("The removed value: {0}", ch);
            Console.WriteLine("Current queue: ");
            foreach (char c in q) Console.Write(c + " "); //Traversal using foreach loop

            //Console.ReadKey();
        }
    }
}