using System;
using System.Numerics;

namespace BigFactorial
{
    internal class Program
    {
        static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            BigInteger result = 1;
            for (int i = 2; i <= n; i++) result *= i;

            Console.WriteLine(result);
        }
    }
}
