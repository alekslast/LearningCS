using System;
using System.Collections;
using System.Collections.Generic;



#region 
    Queue<string> queue = new Queue<string>();
    queue.Enqueue("Kate");
    queue.Enqueue("Sam");
    queue.Enqueue("Alice");
    queue.Enqueue("Tom");
    
    foreach (string item in queue)
        Console.WriteLine(item);
    Console.WriteLine();
    
    Console.WriteLine();
    string firstItem = queue.Dequeue();
    Console.WriteLine($"Extracted element: {firstItem}");
    Console.WriteLine();
    
    foreach (string item in queue)
        Console.WriteLine(item);
#endregion




public class Queue<T> : IEnumerable<T>
{
    Node<T> head;
    Node<T> tail;
    int count;

    public void Enqueue(T data)
    {
        Node<T> node     = new Node<T>(data);
        Node<T> tempNode = tail;
        tail             = node;

        if (count == 0)
            head = tail;
        else
            tempNode.Next = tail;

        count++;
    }

    public T Dequeue()
    {
        if (count == 0)
            throw new InvalidOperationException();
        
        T output = head.Data;
        head = head.Next;
        count--;

        return output;
    }

    public T First
    {
        get
        {
            if (IsEmpty)
                throw new InvalidOperationException();
            
            return head.Data;
        }

    }

    public T Last
    {
        get
        {
            if (IsEmpty)
                throw new InvalidOperationException();

            return tail.Data;
        }
    }

    public bool Contains(T data)
    {
        Node<T> current = head;

        while(current != null)
        {
            if (current.Data.Equals(data))
                return true;

            current = current.Next;
        }

        return false;
    }

    public int Count { get { return count; } }
    public bool IsEmpty { get { return count == 0; } }


    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable)this).GetEnumerator();
    }

    IEnumerator<T> IEnumerable<T>.GetEnumerator()
    {
        Node<T> current = head;
        while (current != null)
        {
            yield return current.Data;
            current = current.Next;
        }
    }

}




public class Node<T>
{
    public T        Data { get; set; }
    public Node<T>  Next { get; set; }

    public Node(T data)
    {
        Data = data;
    }
}