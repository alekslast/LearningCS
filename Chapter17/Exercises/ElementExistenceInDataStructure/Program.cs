using System.Diagnostics.CodeAnalysis;  // for IEqualityComparer


#region All()

    string[] people = { "Tom", "Bob", "Jim", "Lex" };

    bool threeLetterName = people.All(p => p.Length == 3);
    Console.WriteLine($"Each element's length = 3: {threeLetterName}");

#endregion



#region Any()

    // bool hasE = people.Any(p => p.Contains("e"));
    bool startsWithT = people.Any(p => p.StartsWith("T"));
    Console.WriteLine($"Has E: {startsWithT}");

#endregion



#region Contains()

    bool hasLex = people.Contains("Lex");
    Console.WriteLine($"Has Lex: {hasLex}");

    bool hasMike = people.Contains("Mike");
    Console.WriteLine($"Has Mike: {hasMike}");




    Person[] peopleObjects = { new Person("James"), new Person("Duke"), new Person("Oswald") };

    var duke = new Person("Duke");
    var david = new Person("David");

    bool hasDuke = peopleObjects.Contains(duke);
    Console.WriteLine($"Has Duke: {hasDuke}");

    bool hasDavid = peopleObjects.Contains(david);
    Console.WriteLine($"Has David: {hasDavid}");




    string[] differentCases = { "tom", "Tim", "bOb", "saM" };

    bool hasTomV1 = differentCases.Contains("Tom");
    Console.WriteLine($"Has Tom V1: {hasTomV1}");
    bool hasTomV2 = differentCases.Contains("Tom", new CustomStringComparer());
    Console.WriteLine($"Has Tom v2: {hasTomV2}");

#endregion



#region First()

    var first = people.First();
    Console.WriteLine($"First Item: {first}");

    string[] people3 = { "Tom", "Bob", "Gordon", "Jim", "Lex" };
    var firstWithMoreThan3Chars = people3.First(p => p.Length > 3);
    Console.WriteLine($"First item with length > 3: {firstWithMoreThan3Chars}");

#endregion



#region FirstOrDefault()

    var first2 = people3.FirstOrDefault();
    Console.WriteLine($"First or default: {first2}");

    var firstOrDefaultWithMoreThan3Chars = people3.FirstOrDefault(p => p.Length > 3);
    Console.WriteLine($"First or default with length > 3: {firstOrDefaultWithMoreThan3Chars}");

    var firstOrDefault = people3.FirstOrDefault(p => p.Length > 10, "No Items");
    Console.WriteLine($"First or default with length > 10 and default value: {firstOrDefault}");

    string? emptyString = new string[] {}.FirstOrDefault();
    Console.WriteLine($"First or default for an empty string: {emptyString ?? "null"}");

    string? emptyString2 = new string[] {}.FirstOrDefault("No items so far");
    Console.WriteLine($"First or default for an empty string with custom default value: {emptyString2 ?? "null"}");

#endregion



#region Last()

    var last = people.Last();
    Console.WriteLine($"Last Item: {last}");

    var lastWithMoreThan3Chars = people3.Last(p => p.Length > 3);
    Console.WriteLine($"Last item with length > 3: {lastWithMoreThan3Chars}");

#endregion



#region LastOrDefault()

    var last2 = people3.LastOrDefault();
    Console.WriteLine($"Last or default: {last2}");

    var lastOrDefaultWithMoreThan3Chars = people3.LastOrDefault(p => p.Length == 3);
    Console.WriteLine($"Last or default with length = 3: {lastOrDefaultWithMoreThan3Chars}");

    var lastOrDefault = people3.LastOrDefault(p => p.Length > 10, "No Items");
    Console.WriteLine($"Last or default with length > 10 and default value: {lastOrDefault}");

    string? emptyString3 = new string[] {}.LastOrDefault();
    Console.WriteLine($"Last or default for an empty string: {emptyString3 ?? "null"}");

    string? emptyString4 = new string[] {}.LastOrDefault("No items so far");
    Console.WriteLine($"Last or default for an empty string with custom default value: {emptyString4 ?? "null"}");

#endregion





class Person
{
    public string Name { get; set; }
    public Person(string name) => Name = name;

    public override bool Equals(object? obj)
    {
        if (obj is Person person) return Name == person.Name;
        return false;
    }

    public override int GetHashCode() => Name.GetHashCode();
}



class CustomStringComparer : IEqualityComparer<string>
{
    public bool Equals(string? x, string? y)
    {
        if (x is null || y is null) return false;
        return x.ToLower() == y.ToLower();
    }

    public int GetHashCode(string obj) => obj.ToLower().GetHashCode();
}