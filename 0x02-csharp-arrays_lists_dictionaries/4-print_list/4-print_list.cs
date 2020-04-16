using System;
using System.Collections.Generic;
    class List
    {
        public static List<int> CreatePrint(int size)
        {
            if (size < 0)
            {
                Console.WriteLine("Size cannot be negative");
                return null;
            }

            List <int> newList = new List <int> ();
            if (size == 0)
            {
                Console.Write("\n");
                return newList;
            }

            for (int trav = 0; trav < size; trav++)
            {
                newList.Add(trav);
                if (trav == size - 1)
                {
                    Console.WriteLine(trav);
                    break;
                }
                Console.Write (trav + " ");
            }
            return newList;
        }
    }