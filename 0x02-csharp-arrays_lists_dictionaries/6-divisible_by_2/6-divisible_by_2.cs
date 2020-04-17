using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        int value;
        List<bool> newList = new List<bool> ();
        for (value = 0; value < myList.Count; value++) 
        {
            if (myList[value] % 2 == 0) {
            newList.Add(true);
        }
            else {
                newList.Add(false);
            }
        } 
        return newList;
    }
}