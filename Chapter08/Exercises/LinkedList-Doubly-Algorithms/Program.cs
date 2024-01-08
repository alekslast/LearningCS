using System.Collections;
using System.Collections.Generic;


public class DoublyLinkedList<T> : IEnumerable<T>
{
    DoublyNode<T>   head;
    DoublyNode<T>   tail;
    int             count;

    public void Add(T data)
    {
        DoublyNode<T> node = new DoublyNode<T>(data);

        if (head == null)
            head = node;
        else
        {
            tail.Next       = node;
            node.Previous   = tail;
        }

        tail = node;
        count++;
    }

    public void AddFirst(T data)
    {

        DoublyNode<T> node = new DoublyNode<T>(data);
        DoublyNode<T> temp = head;  // Because we need to somehow save the data about previous head, as we will need head.Previous in the future. If we simply say "node.Next = head" - we will never be able to access current head value (head = DoublyNode<T> someNode) again
        node.Next = temp;
        head = node;
        
        if (count == 0)
            tail = head;
        else
            temp.Previous = node;
        
        count++;
    }

    public bool Remove(T data)
    {
        DoublyNode<T> current = head;

        while (current != null)
        {
            if (current.Data.Equals(data))
            {
                break;
            }

            current = current.Next;
        }

        if (current != null)
        {
            if (current.Next != null)  // If it's not the last node
            {
                current.Next.Previous = current.Previous;
            }
            else
            {
                tail = current.Previous;
            }

            if (current.Previous != null)  // If it's not the first node
            {
                current.Previous.Next = current.Next;
            }
            else
            {
                head = current.Next;
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
        head    = null;
        tail    = null;
        count   = 0;
    }

    public void Contains(T data)
    {
        DoublyLinkedList<T> current = head;

        while (current != null)
        {
            if (current.Data.Equals(data))
                return true;

            current = current.Next;
        }

        return false;
    }



    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable)this).GetEnumerator();
    }

    IEnumerator<T> IEnumerable<T>.GetEnumerator()
    {
        DoublyNode<T> current = head;
        while (current != null)
        {
            yield return current.Data;
            current = current.Next;
        }
    }

    public IEnumerable<T> BackEnumerator()
    {
        DoublyNode<T> current = tail;
        while (current != null)
        {
            yield return current.Data;
            current = current.Previous;
        }
    }
}




public class DoublyNode<T>
{
    public T             Data       { get; set; }
    public DoublyNode<T> Next       { get; set; }
    public DoublyNode<T> Previous   { get; set; }

    
    public DoublyNode(T data)
    {
        Data = data;
    }
}