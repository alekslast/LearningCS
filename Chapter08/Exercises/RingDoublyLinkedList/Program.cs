using System.Collections;
using System.Collections.Generic;



public class RingDoublyLinkedList<T> : IEnumerable<T>
{
    DoublyNode<T> head;
    DoublyNode<T> tail;
    int count;


    public void Add(T data)
    {
        DoublyNode<T> node = new DoublyNode<T>(data);

        if (head == null)
            head                = node;
            head.Next           = node;
            heda.Previous       = node;
        else
        {
            node.Previous       = tail;
            node.Next           = head;
            head.Previous.Next  = node;
            head.Previous       = node;
        }

        count++;
    }

    public bool Remove(T data)
    {
        DoublyNode<T> current = head;
        DoublyNode<T> removedItem = null;

        if (count == 0)
            return false;
        
        do
        {
            if (current.Data.Equals(data))
            {
                removedItem = current;
                break;
            }

            current = current.Next;
        }
        while (current != head);

        if (removedItem != null)
        {
            if (count == 1)
            {
                head = null;
            }
            else
            {
                if (removedItem == head)
                {
                    head = head.Next;
                }

                removedItem.Previous.Next = removedItem.Next;
                removedItem.Next.Previous = removedItem.Previous;
            }

            count--;
            return true;
        }

        return false;
    }


    public int Count { get { return count; } }
    public bool IsEmpty { get { return count == 0; } }

    public void Clear()
    {
        head = null;
        tail = null;
        count = 0;
    }

    public bool Contains(T data)
    {
        DoublyNode<T> current = head;

        if (current == null)
            return false;

        do
        {
            if (current.Data.Equals(data))
                return true;

            current = current.Next;
        }
        while (current != head)

        return false;
    }


    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable)this).GetEnumerator();
    }

    IEnumerator<T> IEnumerable<T>.GetEnumerator()
    {
        DoublyNode<T> current = head;

        do
        {
            if (current != null)
                yield return current.Data;
            
            current = current.Next;
        }
        while (current != head)

    }
}




public class DoublyNode<T>
{
    public T Data { get; set; }
    public DoublyNode<T> Next { get; set; }
    public DoublyNode<T> Previous { get; set; }

    public DoublyNode(T data)
    {
        Data = data;
    }
}