// Example stack

using System;
using System.Collections;

namespace CollectionsApplication
{
    class Program2
    {
        static void Main(string[] args)
        {
            Stack st = new Stack(); //Instantiating a Stack

            st.Push('A'); //Pushing items to the top of the stack
            st.Push('M');
            st.Push('G');
            st.Push('W');

            Console.WriteLine("Current stack: ");
            foreach (char c in st)
            { //Traversing through the stack
                Console.Write(c + " ");
            }
            Console.WriteLine();

            st.Push('V'); //Adding more items to the stack {V,W,G,M,A} - current state
            st.Push('H'); //Adding more items to the stack {H,V,W,G,M,A} - current state
            Console.WriteLine("The next poppable value in stack: {0}", st.Peek());
            Console.WriteLine("Current stack: ");

            foreach (char c in st)
            { //Traversing through the stack
                Console.Write(c + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Removing values ");
            st.Pop(); //Popping elements from the top of the stack {H}
            st.Pop(); //Popping elements from the top of the stack {V}
            st.Pop(); //Popping elements from the top of the stack {W}

            Console.WriteLine("Current stack: ");
            foreach (char c in st)
            { //Traversing through the stack {G,M,A}
                Console.Write(c + " ");
            }
        }
    }
}