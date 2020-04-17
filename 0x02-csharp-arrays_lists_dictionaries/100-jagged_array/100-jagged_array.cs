using System;

namespace _100_jagged_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] [] jagged = new int [3] [] {
                new int [] {0, 1, 2, 3},
                new int [] {0, 1, 2, 3, 4, 5, 6},
                new int [] {0, 1}
            };

            for (int val1 = 0; val1 < jagged.Length; val1++)
            {
                for (int val2 = 0; val2 < jagged[val1].Length; val2++)
                {
                    if (val2 == jagged[val1].Length - 1)
                    {
                        Console.Write(jagged[val1][val2]);
                    }
                    else
                    {
                        Console.Write(jagged[val1][val2] + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
