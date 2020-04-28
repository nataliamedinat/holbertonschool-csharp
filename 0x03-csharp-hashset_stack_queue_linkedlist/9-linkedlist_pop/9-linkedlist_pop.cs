using System;
using System.Collections.Generic;

class LList
{
  public static int Pop(LinkedList<int> myLList)
  {
    int node;
    if (myLList.Count == 0)
      return 0;
    node = myLList.First.Value;
    myLList.RemoveFirst();
    return node;
  }
}