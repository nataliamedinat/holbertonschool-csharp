using System;

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

    ///<summary> Return number of nodes</summary>
    public int Count()
    {
        return(count);
    }
}