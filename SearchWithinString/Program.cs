using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchWithinString
{
    class Program
    {
        static void Main(string[] args)
        {
            string word;
            string sentence;
            string result;
            string input;


            Console.WriteLine("Enter search word:");
            input = Console.ReadLine();
            word = input.ToUpper();
            sentence = "Alice was beginning to get very tired of sitting by her sister on the bank, and of having nothing to do: once or twice she had peeped into the book her sister was reading, but it had no pictures or conversations in it, 'and what is the use of a book,' thought Alice 'without pictures or conversation?'";

            if (sentence.ToUpper().Contains(word))
            {
                result = "{0} found.";
            }
            else
            {
                result = "{0} not found";
            }

            Console.WriteLine(string.Format(result, input));
            Console.Read();

            }
    }
}
