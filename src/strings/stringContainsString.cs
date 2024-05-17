// Example string contains string

using System;

namespace StringApplication
{

    class StringProg2
    {

        static void Main(string[] args)
        {
            string str = "This is test";

            if (str.Contains("test"))
            { // Using the Contains method
                Console.WriteLine("The sequence 'test' was found.");
            }
            //Console.ReadKey();
        }
    }
}