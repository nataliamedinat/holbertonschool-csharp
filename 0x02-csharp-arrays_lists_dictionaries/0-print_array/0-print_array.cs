using System;

    class Array
    {
        public static int[] CreatePrint(int size)
        {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        int [] newarr = new int[size];
        if (size == 0)
        {
            Console.Write("\n");
            return newarr;
        }

        for (int trav=0; trav < newarr.Length; trav++)
            {
                Console.Write (trav + " ");
            }
            Console.WriteLine("");
            return newarr;
        }
    }
