#region 

    // Methods:
    // BinarySearch, Clear, Copy, Exists, Fill, Find, FindLast, FindIndex, FindLastIndex, FindAll, IndexOf, LastIndexOf,
    // Resize, Reverse, Sort


    string[] people = { "Tom", "Sam", "Bob", "Kate", "Tom", "Alice" };

    int bobIndex = Array.BinarySearch(people, "Bob");
    int firstTom = Array.IndexOf(people, "Tom");
    int lastTom = Array.LastIndexOf(people, "Tom");

    int particularLength = Array.FindIndex(people, person => person.Length > 3);

    Array.Resize(ref people, 4);
    foreach (var person in people) 
        Console.Write($"{person} ");

#endregion