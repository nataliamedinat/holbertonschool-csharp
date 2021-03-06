﻿using System;
using System.Collections.Generic;

    class MyStack
    {
        public static Stack<string> Info(Stack<string> aStack, string newItem, string search)
        {
            // Total number of items
            Console.WriteLine("Number of items: {0}", aStack.Count);

            if (aStack.Count <= 0)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                Console.WriteLine("Top item: {0}", aStack.Peek());
            }

            // search for an item
            bool elem = true;
            elem = (aStack.Contains(search));
            Console.WriteLine($"Stack contains \"{search}\": {elem}");

            if (elem)
            {
                while (aStack.Pop() != search);
            }
            aStack.Push(newItem); 
            return aStack;
    }
    }
