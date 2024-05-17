// Example getting a substring

using System;

namespace StringApplication
{

    class StringProg3
    {

        static void Main(string[] args)
        {
            string str = "Last night I dreamt of San Pedro";
            Console.WriteLine(str);
            string substr = str.Substring(23); // Using the Substring method
            Console.WriteLine(substr);
        }
    }
}