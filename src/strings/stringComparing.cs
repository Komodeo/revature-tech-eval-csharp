// Example comparing strings

using System;

namespace StringApplication
{

    class StringProg
    {

        static void Main(string[] args)
        {
            string str1 = "This is test";
            string str2 = "This is text";

            if (String.Compare(str1, str2) == 0)
            { // Using Compare method
                Console.WriteLine(str1 + " and " + str2 + " are equal.");
            }
            else
            {
                Console.WriteLine(str1 + " and " + str2 + " are not equal.");
            }
            //Console.ReadKey();
        }
    }
}