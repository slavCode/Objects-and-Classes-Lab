using System;
using System.Linq;

namespace RandomizeWords
{
    internal class Program
    {
        static void Main()
        {
            var words = Console.ReadLine().Split(' ').ToArray();
            var rnd = new Random();

            for (int pos1 = 0; pos1 < words.Length; pos1++)
            {
                int pos2 = rnd.Next(words.Length);
                string word = words[pos1];
                words[pos1] = words[pos2];
                words[pos2] = word;
            }

            Console.WriteLine(String.Join("\r\n", words));
        }
    }
}
