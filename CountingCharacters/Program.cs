using System;
using System.Collections.Generic;

namespace CountingCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialize the variable that is the main target of our program
            string LoremIpsum = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem utligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";

            //setup an introduction to the program

            Console.WriteLine("Counting Characters\n");
            Console.WriteLine("Here we will count the characters from the following text:\n");
            Console.WriteLine(LoremIpsum + "\n");

            //get character counts
            Dictionary<char, int> charCounts = new Dictionary<char, int>();

            //make case-insensitive
            string text = LoremIpsum.ToLower();

            //iterate thru chars in text
            foreach (char character in text)
            {
                //exclude non-alphabetic characters
                if (character >= 'a' && character <= 'z')
                {
                    if (charCounts.ContainsKey(character))
                    {
                        charCounts[character] += 1;
                    }
                    else
                    {
                        charCounts.Add(character, 1);
                    }
                }
            }

            //print results
            foreach (KeyValuePair<char, int>  charCount in charCounts)
            {
                Console.WriteLine("{0}: {1}", charCount.Key, charCount.Value);                
            }

            //keep view open until user action exits program
            Console.WriteLine("\nPress any key to exit program...");
            Console.Read();
        }
    }
}
