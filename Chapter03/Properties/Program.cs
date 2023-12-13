class Program
{
    static void Main(string[] args)
    {
        // Person tom = new();
        // Print(tom.Name);

        // tom.Name = "Jack";
        // tom.Age = 22;

        // Console.WriteLine(tom.Name);
        // Console.WriteLine(tom.Age);



        // Person tom = new();
        // tom.GetInfo();

        // tom.Name    = "Thomas";
        // tom.Age     = 34;
        // tom.GetInfo();

        Person janette = new Person { Name = "Janette" };
        janette.GetInfo();
        janette.Age = 28;
        janette.GetInfo();

    }
}

// class Person
// {
//     public string Name { get; set; } = "Tom";
//     public int Age { get; set; } = 37;
// }

class Person
{
    private string _name;
    private int _age;
    public required string Name { get; set; }

    public int Age
    {
        set
        {
            if (value < 18)
            {
                Console.WriteLine("Sorry, you're too young");
            }
            else
                _age = value;
        }
        get { return _age; }
    }

    public void GetInfo() => Console.WriteLine($"Name: {Name}, Age: {Age}");
}