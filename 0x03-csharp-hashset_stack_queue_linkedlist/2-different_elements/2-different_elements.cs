using System;
using System.Collections.Generic;

    class List
    {
        public static List<int> DifferentElements(List<int> list1, List<int> list2)
        {
            List<int> DList = new List<int>();

            for (int elem = 0; elem < list1.Count ; elem++)
            {
                if (list2.Contains(list1[elem]))
                {
                    continue;
                }
                DList.Add(list1[elem]);
            }

            for (int el = 0; el < list2.Count; el++)
            {
                if (list1.Contains(list2[el]))
                {
                    continue;
                }
                DList.Add(list2[el]);
            }

            DList.Sort();
            return DList;
        }
    }