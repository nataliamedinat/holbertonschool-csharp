using System;
using System.Collections.Generic;
    class List
    {
        public static int Sum(List<int> myList)
        {
            int unique = 0;
            HashSet<int> set = new HashSet<int>(myList);
            foreach (int number in set)
            {
                unique += number;
            }
            return unique;
            
        }
    }
