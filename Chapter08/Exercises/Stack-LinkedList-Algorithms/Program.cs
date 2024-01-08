using System;
using System.Collections;
using System.Collections.Generic;



Stack<string> stack = new Stack<string>();
stack.Push("Tom");
stack.Push("Alice");
stack.Push("Bob");
stack.Push("Kate");
 
foreach (var item in stack)
{
    Console.WriteLine(item);
}
Console.WriteLine();
string header = stack.Peek();
Console.WriteLine($"First elem in the stack: {header}");
Console.WriteLine();
 
header = stack.Pop();
Console.WriteLine($"Popping element: {header}");
foreach (var item in stack)
{
    Console.WriteLine(item);
}



public class Stack<T> : IEnumerable<T>
{
    Node<T> head;
    int count;

    public bool IsEmpty { get { return count == 0; } }
    public int Count { get { return count; } }


    public void Push(T data)
    {
        Node<T> node = new Node<T>(data);
        Node<T> temp = head;

        if (head == null)
            head = node;
        else
            head.Next = node;
        
        node = temp;

        count++;




        Node<T> node = new Node<T>(data);
        node.Next = head;
        head = node;

        count++;
    }

    public T Pop()
    {
        if (IsEmpty)
            throw new InvalidOperationException();

        Node<T> temp = head;
        head = head.Next;
        count--;

        return temp.Data;
    }

    public T Peek()
    {
        if (IsEmpty)
            throw new InvalidOperationException();
        
        return head.Data;
    }


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