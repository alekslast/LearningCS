Stack<string> stack = new Stack<string>(8);
// добавляем четыре элемента
stack.Push("Kate");
stack.Push("Sam");
stack.Push("Alice");
stack.Push("Tom");

// извлекаем один элемент
var head = stack.Pop();
Console.WriteLine(head);    // Tom
    
// просто получаем верхушку стека без извлечения
head = stack.Peek();
Console.WriteLine(head); 




public class Stack<T>
{
    private T[] items;
    private int count;
    const int n = 10;


    public Stack()
    {
        items = new T[n];
    }

    public Stack(int length)
    {
        items = new T[length];
    }


    public int  Count   { get { return count; } }
    public bool IsEmpty { get { return count == 0; } }

    public void Push(T item)
    {
        if (count == items.Length)
            Resize(items.Length + 10);

        items[count++] = item;
    }

    public T Pop()
    {
        if (IsEmpty)
            throw new InvalidOperationException();

        T item = items[--count];  // This operation returns last element of the Stack and simultaneously decreases its count by 1
        items[count] = default(T);  // Reset the link to the popped item. default(T) will result in null, => items[count] = null.

        if (count > 0 && count < items.Length - 10)
            Resize(items.Length - 10);

        return item;
    }

    public T Peek()
    {
        return items[count - 1];
    }

    private void Resize(int max)
    {
        T[] tempItems = new T[max];
        for (int i = 0; i < count; i++)
            tempItems[i] = items[i];

        items = tempItems;
    }
}
