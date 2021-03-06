﻿using System;

///<summary>Class queues</summary>
class Queue<T>
{
	///<summary>Check the type</summary>
	public Type CheckType()
	{
		return typeof(T);
	}

    ///<summary> Class node</summary>
    public class Node
    {
        ///<summary> Value can be any type </summary>
        public T value;

        ///<summary> Next node</summary>
        public Node next = null;

        ///<summary>Constructor that takes a value for a new Node as its only parameter and sets it </summary>
        public Node(T value)
        {
            this.value = value;
        }
    }

    ///<summary> Pinter to the head </summary>
    public Node head;

    ///<summary> Pointer to the tail</summary>
    public Node tail;

    ///<summary> Count number of nodes</summary>
    public int count;

    ///<summary> creates a new Node and adds it to the end of the queue.</summary>
    public void Enqueue(T val)
    {
        Node Nnode = new Node(val);

        if (head == null)
            head = Nnode;
        if (tail != null)
            tail.next = Nnode;
        tail = Nnode;
        count++;
    }


    ///<summary> Removes the first node in the queue and returns its value</summary>
    public T Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
             return(default(T));
        }
        else
        {
            T val = head.value;
            head = head.next;
            count--;
            return(val);
        }
    }

    ///<summary> returns the value of the first node of the queue without removing the node. </summary>
    public T Peek()
    {
        if(head == null)
        {
            Console.WriteLine("Queue is empty");
            return(default(T));
        }
        else
        {
            return head.value;
        }
    }

    ///<summary> Print all the queue starting from the head </summary>
    public void Print()
    {
        if(head == null)
        {
            Console.WriteLine("Queue is empty");
        }
        else
        {
            while (head != null)
            {
                Console.WriteLine(head.value);
                head = head.next;
            }
        }
    }

    ///<summary>concatenates all values in the queue </summary>

    public string Concatenate()
    {
        if (head == null)
        {
            Console.WriteLine("Queue is empty");
            return null;
        }

        if (CheckType() != typeof(char) && CheckType() != typeof(string))
        {
            Console.WriteLine("Concatenate() is for a queue of Strings or Chars only");
            return null;
        }

        Node current;
        string s = "";
        current = this.head;
        while (current != null)
        {
            s += current.value.ToString();
            if (typeof(T) == typeof(string) && current.next != null)
                s += " ";
            current = current.next;
        }
        return s;
    }

    ///<summary> Return number of nodes</summary>
    public int Count()
    {
        return(count);
    }
}