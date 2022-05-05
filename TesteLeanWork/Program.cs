using System;
using System.Collections.Generic;
using System.Linq;

namespace TesteLeanWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GetElementsFromBothArrays();
        }

        static void GetBiggestCollatzSeedFrom1To1000000()
        {
            var values = Enumerable.Range(1, 10).ToList();
            var biggestCollatz = values.Aggregate((agg, next) => Collatz(next) > Collatz(agg) ? next : agg);
            Console.WriteLine(biggestCollatz);
        }

        static int Collatz(int number)
        {
            var sequence = 0;
            while (number != 1)
            {
                if(number % 2 == 0)
                {
                    number /= 2;
                    sequence++;
                }
                else
                {
                    number = (3 * number + 1);
                    sequence++;
                }
            }
            return sequence;
        }

        static bool IsListElementsOdd()
        {
            int[] numeros = { 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144 };
            return !numeros.Any(x => x % 2 == 0);
        }

        static void GetElementsFromBothArrays()
        {
            int[] primeiroArray = { 1, 3, 7, 29, 42, 98, 234, 93 };
            int[] segundoArray = { 4, 6, 93, 7, 55, 32, 3 };

            var result = primeiroArray.Where(x => !segundoArray.Contains(x)).ToList(); /*.Any(y => y == x)).ToArray();*/

            result.ForEach(i => Console.Write("{0} ", i));

        }
    }
}
