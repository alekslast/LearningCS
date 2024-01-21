// К агрегатным операциям относят различные операции над выборкой, например, получение числа элементов,
// получение минимального, максимального и среднего значения в выборке, а также суммирование значений.

#region Agregate()

    int[] numbers = { 1, 2, 3, 4, 5 };

    int query = numbers.Aggregate( (x, y) => x + y );

    Console.WriteLine(query);
    Console.WriteLine();


    int query1 = numbers.Aggregate( (x, y) => x - y );
    Console.WriteLine(query1);
    Console.WriteLine();




    string[] words = { "Ain't", "nobody", "loves", "me", "better" };
    string sentance = words.Aggregate("Text:", (first, next) => $"{first} {next}");
    Console.WriteLine(sentance);
    Console.WriteLine();

#endregion



#region Count

    int[] numbers1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    int numbersLength = numbers1.Count();
    Console.WriteLine(numbersLength);
    Console.WriteLine();


    // Filtering the results
    int customizedNumbers = numbers1.Count(i => i % 2 == 0 && i > 6);
    Console.WriteLine(customizedNumbers);
    Console.WriteLine();


#endregion



#region Sum()

    int sum = numbers1.Sum();
    Console.WriteLine(sum);
    Console.WriteLine();


    // Sum for complex objects
    Person[] people1 = { new Person(12), new Person("Tom", 33), new Person(28) };

    int people1Sum = people1.Sum(p => p.Age);
    Console.WriteLine(people1Sum);
    Console.WriteLine();

#endregion



#region Min - Max - Average

    int[]       numbers2 = { 91, 17, 55, 90, 1, 64, 37, 19, 59, 102 };
    Person[]    people2  = { new Person("Dave", 55), new Person("Angela", 80), new Person("Ann", 18), new Person("Dora", 14), new Person("Jack", 25) };

    int min     = numbers2.Min();
    int max     = numbers2.Max();
    double average = numbers2.Average();
    Console.WriteLine($"Numbers: {min} - {max} - {average}");

    int minPerson       = people2.Min(p => p.Age);
    int maxPerson       = people2.Max(p => p.Age);
    double averagePerson   = people2.Average(p => p.Age);
    Console.WriteLine($"Person: {minPerson} - {maxPerson} - {averagePerson}");
    Console.WriteLine();

#endregion



#region Skip - SkipLast - SkipWhile - Take - TakeLast - TakeWhile

    string[] people3 = { "Tom", "Bob", "Jo", "Dan" };

    // Skip
    // Skip first 2 elements
    var skipResults = people3.Skip(2);
    Console.WriteLine("Skip:");
    foreach (string p in skipResults) Console.WriteLine(p);
    Console.WriteLine();


    // SkipLast
    // Skip last 2 elements
    var skipLastResults = people3.SkipLast(2);
    Console.WriteLine("SkipLast:");
    foreach (string p in skipLastResults) Console.WriteLine(p);
    Console.WriteLine();


    // SkipWhile
    // Start at the beginning and skip all first elements, whose length is 3. Stop skipping once the length != 3
    var skipWhileResults = people3.SkipWhile(p => p.Length == 3);
    Console.WriteLine("SkipWhile:");
    foreach (string p in skipWhileResults) Console.WriteLine(p);
    Console.WriteLine();


    // Take
    // Return first 2 elements
    var takeResults = people3.Take(2);
    Console.WriteLine("Take:");
    foreach (string p in takeResults) Console.WriteLine(p);
    Console.WriteLine();



    // TakeLast
    // Return last 2 elements
    var takeLastResults = people3.TakeLast(2);
    Console.WriteLine("TakeLast:");
    foreach (string p in takeLastResults) Console.WriteLine(p);
    Console.WriteLine();


    
    // TakeWhile
    // Return last 2 elements
    var takeWhileResults = people3.TakeWhile(p => p.Length == 3);
    Console.WriteLine("TakeWhile:");
    foreach (string p in takeWhileResults) Console.WriteLine(p);
    Console.WriteLine();



    // Combination of Skip and Take
    string[] differentNames = { "Alexander", "Nurlan", "George", "Garry", "Sarah", "Honza", "Lubomil" };

    var combination = differentNames.Skip(2).TakeLast(3);
    Console.WriteLine("Combining Skip and Take:");
    foreach (string s in combination) Console.WriteLine(s);
    Console.WriteLine();

#endregion



class Person
{
    public string Name { get; set; }
    public int Age { get; set; }


    public Person(int age) : this("Undefined", age) {}
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}