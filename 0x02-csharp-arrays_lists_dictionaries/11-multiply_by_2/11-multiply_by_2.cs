using System;
using System.Collections.Generic;

    class Dictionary
    {
        public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
        {
            Dictionary<string, int> Ndict = new Dictionary<string, int> ();
            foreach (string item in myDict.Keys)
            {
                Ndict.Add(item, myDict[item] * 2);
            }
            return Ndict;
        }
    }

