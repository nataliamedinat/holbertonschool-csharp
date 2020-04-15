using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
        int trav1 = 0;
        for (; trav1 < length; trav1++)
        {
            int trav2 = 0;
            for (; trav2 < trav1; trav2++)
                Console.Write(" ");
            Console.WriteLine("\\");
        }
        Console.WriteLine("");
    }
}