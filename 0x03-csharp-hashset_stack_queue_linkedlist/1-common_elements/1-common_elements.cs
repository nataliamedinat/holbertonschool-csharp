using System;
using System.Collections.Generic;

class List
{
  public static List<int> CommonElements(List<int> list1, List<int> list2)
  {
    List<int> common = new List<int>();
    foreach(int elem in list1)
    {
      if (list2.Contains(elem))
        common.Add(elem);
    }
    common.Sort();
    return common;
  }
}
