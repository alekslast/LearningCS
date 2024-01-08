#region Creating a Dictionary

    // // Dictionary<int, string> people = new Dictionary<int, string>();

    // var people = new Dictionary<int, string>()
    // // Key-Value pair => int = key; string = value
    // {
    //     { 5, "Tom" },
    //     { 3, "Sam" },
    //     { 11, "Bob" }
    // };

    // var people1 = new Dictionary<int, string>()
    // {
    //     [5] = "Tom",
    //     [3] = "Sam",
    //     [11] = "Bob"
    // };


    // foreach (var person in people1)
    // {
    //     Console.WriteLine($"{person.Key}: {person.Value}");
    // }

    // Console.WriteLine();

    // foreach (var person in people1)
    // {
    //     Console.WriteLine($"{person.Key} - {person.Value}");
    // }


    // Console.WriteLine();


    // var mike = new KeyValuePair<int, string>(56, "Mike");
    // var employees = new List<KeyValuePair<int, string>>() { mike };
    // var people2 = new Dictionary<int, string>(employees)
    // {
    //     [2] = "John",
    //     [99] = "Alice",
    //     [13] = "Tan"
    // };

    // foreach (var person in people2)
    // {
    //     Console.WriteLine($"{person.Key} = {person.Value}");
    // }


    // Console.WriteLine();


    // // var person1 = people2[1];  // Argument in the brackets is the key. It may not necessarily be of type int. As it is key, not the index, the program will look up for this key. If it's not in the dictionary, we'll get an exception
    // // Console.WriteLine(person1);

    // var person1 = people2[2];
    // Console.WriteLine(person1);
    // var person2 = people2[13];
    // Console.WriteLine(person2);

#endregion



#region Methods and properties of a Dictionary

    // Add, Clear, ContainsKey, ContainsValue, Remove, TryGetValue, TryAdd


    var phoneBook = new Dictionary<string, string>();

    phoneBook.Add("Tom", "223311");
    phoneBook.Add("Alice", "77-39-17");
    phoneBook.Add("Josh", "19 27 00");

    foreach (var person in phoneBook)
    {
        Console.WriteLine($"{person.Key}: {person.Value}");
    }

    Console.WriteLine();

    var keyCheck = phoneBook.ContainsKey("Josh");
    Console.WriteLine(keyCheck);
    var keyCheck1 = phoneBook.ContainsKey("Alex");
    Console.WriteLine(keyCheck1);


    Console.WriteLine();


    var valueCheck = phoneBook.ContainsValue("77-39-17");
    Console.WriteLine(valueCheck);
    var valueCheck1 = phoneBook.ContainsValue("773917");
    Console.WriteLine(valueCheck1);


    Console.WriteLine();


    phoneBook.Remove("Josh");
    foreach (var person in phoneBook)
    {
        Console.WriteLine($"{person.Key}: {person.Value}");
    }

    var gettingValue = phoneBook.TryGetValue("Tom", out string tomsNumber);
    if (gettingValue) Console.WriteLine($"Attempt to get value: {gettingValue}\nTom's Number: {tomsNumber}");

    Console.WriteLine();

    var addingValue = phoneBook.TryAdd("Jim", "33-17-44");
    if (addingValue) Console.WriteLine("Attempt to add value: {0}\nJim's Number: {1}", addingValue, phoneBook["Jim"]);

    Console.WriteLine($"Number of people in the phonebook: {phoneBook.Count}");

    Console.WriteLine();

    phoneBook.Clear();
    Console.WriteLine($"Number of people in the phonebook after wipe: {phoneBook.Count}");

#endregion