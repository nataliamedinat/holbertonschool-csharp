using System;
using System.Collections.Generic;


    class List
    {
        public static int MaxInteger(List<int> myList)
        {
            if (myList == null || myList.Count == 0)
            {
                Console.WriteLine("List is empty");
                return -1;
            }
            int bigInt = myList.Count - 1;
            myList.Sort();
            return myList[bigInt];
        }
    }