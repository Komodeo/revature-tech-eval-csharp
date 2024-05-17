// Example ArrayList

using System;
using System.Collections;

namespace CollectionApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList(); //Instantiating an ArrayList 

            Console.WriteLine("Adding some numbers:");
            al.Add(45); //Adding elements into the ArrayList
            al.Add(78);
            al.Add(33);
            al.Add(56);
            al.Add(12);
            al.Add(23);
            al.Add(9);
            al.Add(12);
            al.Add(13);

            Console.WriteLine("Capacity: {0} ", al.Capacity);
            Console.WriteLine("Count: {0}", al.Count);

            Console.Write("Content: ");
            foreach (int i in al)
            { //Traversing through an ArrayList
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.Write("Sorted Content: ");
            al.Sort(); //Sorting an ArrayList
            foreach (int i in al)
            {  //Traversing through an ArrayList
                Console.Write(i + " ");
            }
            Console.WriteLine();
            //Console.ReadKey();
        }
    }
}