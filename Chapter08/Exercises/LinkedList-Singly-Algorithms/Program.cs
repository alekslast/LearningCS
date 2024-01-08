using System.Collections;
using System.Collections.Generic;


// 2) Creating the LinkedList itself
public class LinkedList<T> : IEnumerable<T>
{
    Node<T>?    head;
    Node<T>?    tail;
    int         count;

    public void Add(T data)
    {
        Node<T> node = new Node<T>(data);  // 2.1) Create new node

        if (head == null)
            head = node;  // 2.2) If there is no head => assign our new node as the head of the list
        else
            tail!.Next = node;  // 2.3) Check if current tail isn't null (with ! operator). If it's not => assign our new node to the current tail's Next item

        // 2.4) We have the head; We have added our new node to the end.
        //      Now our current tail is no longer the last element, as we've inserted our new node at the end. 
        //      So we must reassign the tail:

        tail = node;

        count++;  // 2.5) As we have increased the number of elements in our list, we must notify our count property about it.
    }


    public void Remove(T data)
    {
        Node<T> current     = head;
        Node<T> previous    = null;

        while (current != null && current.Data != null)
        {
            if (current.Data.Equals(data))
            {
                if (previous != null)
                {
                    previous.Next = current.Next;

                    if (current.Next == null)
                        tail = previous;
                }
                else
                {
                    head = head?.Next;

                    if (head == null)
                        tail = null;
                }

                count--;
                return true;
            }

            previous    = current;
            current     = previous.Next;
        }

        return false;
    }

    public int Count { get { return count; } }

    public bool IsEmpty { get { return count == 0; } }  // Compares "count" variable's value to 0. If it's true (count = 0) => the list is empty. If it's false (count != 0) => there are some items int he list

    public void Clear()
    {
        head    = null;
        tail    = null;
        count   = 0;
    }

    public bool Contains(T data)
    {
        Node<T>? current = head;

        while (current != null && current.Data != null)
        {
            if (current.Data.Equals(data))
                return true;
            
            current = current.Next;
        }

        return false;
    }

    public void AppendFirst(T data)
    {
        Node<T> node = new Node<T>(data);
        node.Next = head;
        head = node;

        if (count == 0)
            tail = head;
        
        count++;
    }


    // To be able to use "for-each" on the list
    IEnumerator<T> IEnumerable<T>.GetEnumerator()
    {
        Node<T>? current = head;
        while (current != null)
        {
            yield return current.Data;
            current = current.Next;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return ((IEnumerable<T>)this).GetEnumerator();
    }

}


// 1) Creating a class that will erve as a template for the elements in our LinkedList
public class Node<T>
{
    public Node(T data)
    {
        Data = data;
    }

    public T Data { get; set; }
    public Node<T>? Next { get; set }
}