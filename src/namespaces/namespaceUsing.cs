// Example - With the "using" keyword

using System;
using first_space; // Importing here
using second_space; // Importing here

namespace first_space
{
    class abc
    {
        public void func()
        {
            Console.WriteLine("Inside first_space");
        }
    }
}
namespace second_space
{
    class efg
    {
        public void func()
        {
            Console.WriteLine("Inside second_space");
        }
    }
}
namespace TestClass2
{
    class Program
    {
        static void Main(string[] args)
        {
            abc fc = new abc(); // Notice we are not using the fully qualified syntax
            efg sc = new efg(); // Notice we are not using the fully qualified syntax
            fc.func();
            sc.func();
            //Console.ReadKey();
        }
    }
}