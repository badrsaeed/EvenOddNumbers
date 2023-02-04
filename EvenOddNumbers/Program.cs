using System;
using System.Collections.Generic;
using System.Linq;

namespace EvenOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Print(numbers, "this is Numbers");
            Print(numbers.Where(x => IsEven(x)), "Even No: ");
            Print(numbers.Where(x => IsOdd(x)), "Odd No: ");
            Console.ReadKey();
        }
        private static void Print(IEnumerable<int> numbers, string title)
        {
            Console.WriteLine();
            Console.Write($"{title}: [");
            foreach (int n in numbers)
            {
                Console.Write($" {n}");
            }
            Console.Write($" ]");
            Console.WriteLine();
        }

        public static bool IsEven(int number) => number % 2 == 0;
        static bool IsOdd(int number) => !IsEven(number);
    }
}
