
#region Except()

    // Except() = разность двух последовательностей:
    string[] soft = { "Microsoft", "Google", "Apple" };
    string[] hard = { "Apple", "IBM", "Samsung" };

    var result = soft.Except(hard);

    foreach (string s in result)
        Console.WriteLine(s);

    Console.WriteLine();

#endregion


#region Intersect()

    var result1 = soft.Intersect(hard);

    foreach (string s in result1) Console.WriteLine(s);

    Console.WriteLine();

#endregion



#region Distinct

    // Distinct() = remove duplicates

    string[] names = { "Thrall", "Uther", "Jaina", "Arthas", "Uther", "Tirion", "Jaina", "Thrall" };

    var result2 = names.Distinct();

    foreach (string s in result2) Console.WriteLine(s);

    Console.WriteLine();

#endregion



#region Union vs Concat


    // Union = join, but no duplicates
    var result3 = soft.Union(hard);

    foreach (string s in result3) Console.WriteLine(s);

    Console.WriteLine();



    // Concat = join with all the duplicates
    var result4 = soft.Concat(hard);

    foreach (string s in result4) Console.WriteLine(s);

    Console.WriteLine();

#endregion



#region Complex operations

    Person[] students   = { new Person("Jack"), new Person("Mack"), new Person("Hack") };
    Person[] employees  = { new Person("Jack"), new Person("John"), new Person("Tom"), new Person("Don") };

    var result5 = students.Union(employees);

    foreach (Person p in result5) Console.WriteLine(p.Name);

    Console.WriteLine();

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