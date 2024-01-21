var people = new List<Person>
{
    new Person("Jack", 22),
    new Person("Addie"),
    new Person("Ann", 35),
    new Person("Luis", 16)
};

var newPeople = from p in people
                where p.Age >= 18 && p.Age < 30
                orderby p.Name descending
                select p;

foreach (var person in newPeople)
    Console.WriteLine($"{person.Name} - {person.Age}");




Console.WriteLine();

var people2 = new List<Person>
{
    new Person("Tom", 22),
    new Person("Tom", 25, new List<string> { "English", "Spanish", "Dutch" }),
    new Person("Tom", 44, new List<string> { "Polish", "French" }),
    new Person("Tom", 44, new List<string> { "Polish", "French", "German" }),
    new Person("Tom", 44),
    new Person("Tom", 38, new List<string> { "Russian" }),
    new Person("Tom", 38, new List<string> { "Russian", "Greek" }),
    new Person("Tom", 67, new List<string> { "Czech" })

};

var newPeople2 =    from pers in people2
                    where pers.Age >= 18 && pers.Age < 50
                    orderby pers.Name, pers.Age, pers.Langs.Count
                    select pers;

foreach (var persona in newPeople2)
    Console.WriteLine($"{persona.Name} - {persona.Age} - {persona.Langs.Count}");


class Person
{
    public string       Name    { get; set; }
    public int          Age     { get; set; }
    public List<string> Langs   { get; set; }

    public Person(string name) : this(name, 18, new List<string> { "None" }) {}
    public Person(string name, int age) : this(name, age, new List<string> { "None" }) {}
    public Person(string name, int age, List<string> langs)
    {
        Name    = name;
        Age     = age;
        Langs   = langs;
    }
}


class Student(string Name) : Person(Name);
class Employee(string Name) : Person(Name);