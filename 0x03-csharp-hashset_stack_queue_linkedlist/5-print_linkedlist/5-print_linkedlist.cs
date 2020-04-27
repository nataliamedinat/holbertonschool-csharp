using System;
using System.Collections.Generic;

    class LList
    {
        public static LinkedList<int> CreatePrint(int size)
        {
            LinkedList<int> newlist = new LinkedList<int> ();
            if (size < 0)
            {
                return newlist;
            }

            for (int trav = 0; trav < size; trav++)
            {
                newlist.AddLast(trav);
                Console.WriteLine(trav);
            }
            return newlist;

        }
    }

