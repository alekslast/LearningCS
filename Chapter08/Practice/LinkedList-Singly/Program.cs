using System.Collections;
using System.Collections.Generic;



RingLinkedList<string> circularList = new RingLinkedList<string>();
 
circularList.Add("Tom");
circularList.Add("Bob");
circularList.Add("Alice");
circularList.Add("Jack");
foreach (var item in circularList)
{
    Console.WriteLine(item);
}
 
Console.WriteLine(circularList.Remove("Bob"));
Console.WriteLine("\nAfter detetion: \n");
foreach (var item in circularList)
{
    Console.WriteLine(item);
}
Console.WriteLine(circularList.Contains("Jack"));
Console.WriteLine(circularList.Contains("Bob"));






public class RingLinkedList<T> : IEnumerable<T>
{
    Node<T> head;
    Node<T> tail;
    int count;

    public int Count { get { return count; } }

    public bool IsEmpty { get { return count == 0; } }

    public void Add(T data)
    {
        Node<T> node = new Node<T>(data);

        count++;
    }

    public bool Remove(T data)
    {
        Node<T> current = head;
        Node<T> previous = null;

        do
        {
            if (current.Data.Equals(data))
            {
                if (previous != null)
                {
                    previous.Next = current.Next;

                    if (current == tail)
                    {
                        tail = previous;
                        previous.Next = head;
                    }
                    // previous - current - next
                }
                else
                {
                    head = head.Next;
                }

                count--;
                return true;
            }

            previous = current;
            current = current.Next;

        } while (current != head);

        return false;
    }

    public bool Contains(T data)
    {
        Node<T> current = head;

        do
        {
            if (current.Data.Equals(data))
                return true;

            current = current.Next;

        } while (current != head);

        return false;
    }

    public void Clear()
    {
        head = null;
        tail = null;
        count = 0;
    }


    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable)this).GetEnumerator();
    }

    IEnumerator<T> IEnumerable<T>.GetEnumerator()
    {
        Node<T> current = head;

        do
        {
            if (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }

        } while (current != head);

    }
}





public class Node<T>
{
    public T Data { get; set; }
    public Node<T> Next { get; set; }
    public Node(T data)
    {
        Data = data;
    }
}