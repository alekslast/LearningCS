#region Crearting a stack

    // Stack<string> people = new Stack<string>();
    // // Stack<string> people = new Stack<string>(16);

    // var employees = new List<string> { "Tom", "Bob", "Sam" };
    // Stack<string> people1 = new Stack<string>(employees);

    // foreach (string person in people1)
    // {
    //     Console.WriteLine(person);
    // }

    // Console.WriteLine();

    // Console.WriteLine($"Stack's length = {people1.Count}");

    // Console.WriteLine();

#endregion



#region Stack methods - Push, Pop, Clear, Contains, Peek

    // var people2 = new Stack<string>();
    // people2.Push("Tom");
    // people2.Push("Bob");
    // people2.Push("Sam");
    // // In Queue and every other data structure we place new element at the END OF DATA STRUCTURE.
    // // In Stack we place new element at the BEGINNING OF DATA STRUCTURE, => very first element added is our TAIL !!!!

    // foreach (string person in people2)
    // {
    //     Console.WriteLine(person);
    // }




    // Console.WriteLine();




    // // var firstElemPopped = people2.Pop();
    // // Safer way of Popping:
    // if (people2.Count > 0)  // Check if the Stack is not empty. Otherwise it throws an exception
    // {
    //     var firstElemPopped = people2.Pop();
    //     Console.WriteLine($"1) Popping element: {firstElemPopped}");
    //     foreach (string person in people2)
    //     {
    //         Console.WriteLine(person);
    //     }
    // }

    // // Or use TryPop method
    // people2.Push("Sam");
    // var tryPopMethod = people2.TryPop(out var person1);  // Pops first item in the Stack and saves its value inside newly created "person1" variable. Returns true if succeeded.
    // Console.WriteLine($"2) Popping element: {person1}");
    // foreach (string person in people2)
    // {
    //     Console.WriteLine(person);
    // }




    // Console.WriteLine();




    // people2.Push("Sam");
    // // var firstElemPeeked = people2.Peek();
    // // Safer way:
    // if (people2.Count > 0)
    // {
    //     var firstElemPeeked = people2.Peek();
    //     Console.WriteLine($"1) Peeking element: {firstElemPeeked}");
    //     foreach (string person in people2)
    //     {
    //         Console.WriteLine(person);
    //     }
    // }

    // // Or use TryPeek method:
    // var tryPeekMethod = people2.TryPeek(out var person2);
    // Console.WriteLine($"2) Peeking element: {person2}");
    // foreach (string person in people2)
    // {
    //     Console.WriteLine(person);
    // }

    // Console.WriteLine();

#endregion



