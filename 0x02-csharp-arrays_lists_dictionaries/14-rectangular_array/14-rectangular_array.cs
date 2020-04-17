using System;

namespace _14_rectangular_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = 5;
            int height = 5;
            int [,] multi = new int [width, height];
            multi [2, 2] = 1;

            for (int wth = 0; wth < width; wth++)
            {
                for (int hth= 0; hth < height; hth++)
                {
                    if (hth < height - 1)
                    {
                        Console.Write(multi[wth, hth] + " ");
                    }
                    else
                    {
                        Console.Write(multi[wth, hth]);
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
