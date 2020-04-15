using System;

    class Line
    {
        public static void PrintLine(int length)
        {
            int trav ;
            
                if (length <= 0 )
                    Console.Write("\n");
                for (trav = 1; trav <= length; trav++)
                {
                    Console.Write(@"_");
                }
                
        }
    }