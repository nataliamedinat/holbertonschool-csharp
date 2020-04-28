using System;
using System.Collections.Generic;


    class List
    {
        public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
        {
            List<int> divisionR = new List<int> ();
            for (int i = 0; i < listLength; i++)
            {
                try
                {
                    int r = list1[i] / list2[i];
                    divisionR.Add(r);
                }
                catch (System.DivideByZeroException)
                {
                    Console.WriteLine("Cannot divide by zero");
                    divisionR.Add(0);
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Out of range");
                }
            }
            return divisionR;
        }
    }
