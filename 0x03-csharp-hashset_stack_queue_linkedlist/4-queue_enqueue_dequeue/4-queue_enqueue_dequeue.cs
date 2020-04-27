using System;
using System.Collections.Generic;

    class MyQueue
    {
        public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
        {
            // Total number of items
            Console.WriteLine("Number of items: {0}", aQueue.Count);

            if (aQueue.Count <= 0)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                Console.WriteLine("First item: {0}", aQueue.Peek());
            }

            // search for an item
            bool elem = true;
            elem = (aQueue.Contains(search));
            Console.WriteLine($"Queue contains \"{search}\": {elem}");

            if (elem)
            {
                while (aQueue.Dequeue() != search);
            }
            aQueue.Enqueue(newItem); 
            return aQueue;
    }
        }