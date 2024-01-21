// Person jake = new Person("Jake");

var people = new List<Person>
{
    new Person("Jake", 64, new List<string> { "English", "Spanish", "Romanian" }),
    new Person("Bob", 22, new List<string> { "English", "French" }),
    new Person("Duke", 38, new List<string> { "English" }),
    new Person("Gordon", 18, new List<string> { "English", "Italian", "Spanish" })
};


// Using operators
var filteredPeople =    from person in people
                        from lang in person.Languages
                        where person.Age > 25
                        where lang == "Spanish"
                        select person;

foreach (var person in filteredPeople)
    Console.WriteLine($"{person.Name} - {person.Age}");


Console.WriteLine();


// Using methods
var filteredPeople1 = people.SelectMany(p => p.Languages,
                                        (p, l) => new { Person = p, Lang = l })
                            .Where(p => p.Lang == "Spanish" && p.Person.Age > 25)
                            .Select(p => p.Person);

foreach (var person in filteredPeople1)
    Console.WriteLine($"{person.Name} - {person.Age}");






Console.WriteLine();

var people2 = new List<Person>
{
    new Student("Jack"),
    new Employee("Tailor"),
    new Person("June")
};

var filteredPeople2 = people2.OfType<Student>();

foreach (var p in filteredPeople2)
    Console.WriteLine($"{p.Name}");



class Person
{
    public string       Name        { get; set; }
    public int          Age         { get; set; }
    public List<string> Languages   { get; set; }

    public Person(string name) : this(name, 18, null) {}
    public Person(string name, int age, List<string> langs)
    {
        Name        = name;
        Age         = age;
        Languages   = langs;
    }
}

class Student(string Name) : Person(Name);
class Employee(string Name) : Person(Name);