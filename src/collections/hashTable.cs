// Example HashTable

using System;
using System.Collections;

namespace CollectionsApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable(); //Instantiating a HashTable

            ht.Add("001", "Zara Ali"); //Adding elements into the HashTable
            ht.Add("002", "Abida Rehman");
            ht.Add("003", "Joe Holzner");
            ht.Add("004", "Mausam Benazir Nur");
            ht.Add("005", "M. Amlan");
            ht.Add("006", "M. Arif");
            ht.Add("007", "Ritesh Saikia");

            if (ht.ContainsValue("Nuha Ali"))
            { //Checks if a value is in the HashTable
                Console.WriteLine("This student name is already in the list");
            }
            else
            {
                ht.Add("008", "Nuha Ali"); //If not adds the value to the HashTable
            }

            // Get a collection of the keys.
            ICollection key = ht.Keys; //Get the keys alone

            foreach (string k in key)
            { //Traverse and display the keys & value
                Console.WriteLine(k + ": " + ht[k]);
            }
            //Console.ReadKey();
        }
    }
}