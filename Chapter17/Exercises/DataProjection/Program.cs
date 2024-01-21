var people = new List<Person>
{
    new Person("Jack", 21),
    new Person("Nanny", 19),
    new Person("Alice", 33)
};


#region Only select people's names

    // // Operators
    // var names = from p in people
    //             select p.Name;

    // foreach(string name in names)
    //     Console.WriteLine(name);


    // Console.WriteLine();


    // // Methods
    // var otherNames = people.Select(persona => persona.Name);

    // foreach (string name in otherNames)
    //     Console.WriteLine(name);

#endregion



#region Create new object using LINQ

    // Console.WriteLine();
    // var personel =  from p in people
    //                 select new
    //                 {
    //                     FirstName   = p.Name,
    //                     Year        = DateTime.Now.Year - p.Age
    //                 };
                
    // foreach (var p in personel)
    //     Console.WriteLine($"{p.FirstName} - {p.Year}");


    
    // Console.WriteLine();
    // var personel1 = people.Select(persona => new
    // {
    //     FirstName   = persona.Name,
    //     Year        = DateTime.Now.Year - persona.Age
    // });
    // foreach (var person in personel1)
    // {
    //     Console.WriteLine(person);
    //     Console.WriteLine(person.GetType());
    // }

#endregion



#region let Operator

    // // Иногда возникает необходимость произвести в запросах LINQ какие-то дополнительные промежуточные вычисления.
    // // Для этих целей мы можем задать в запросах свои переменные с помощью оператора let

    // var personel2 = from person in people
    //                 let name = $"Your Majesty {person.Name}"
    //                 let year = DateTime.Now.Year - person.Age
    //                 select new
    //                 {
    //                     Name = name,
    //                     Year = year
    //                 };

    // Console.WriteLine();
    // foreach (var p in personel2)
    //     Console.WriteLine($"{p.Name} - {p.Year}");


#endregion



#region Select from multiple sources

    // var courses = new List<string>() { "C#", "Java" };
    // var students = new List<string>() { "Tom", "Bob" };


    // var enrollments =   from course in courses
    //                     from student in students
    //                     select new
    //                     {
    //                         Student = student,
    //                         Course = course
    //                     };

    // Console.WriteLine();
    // foreach (var enrollment in enrollments)
    //     Console.WriteLine(enrollment);

#endregion


    

#region SelectMany

    // Method
    var companies = new List<Company>
    {
        new Company("Microsoft", new List<Person> { new Person("Bill", 24), new Person("Dave")}),
        new Company("Google", new List<Person> { new Person("Serghey"), new Person("Bob", 22) })
    };

    var employees = companies.SelectMany(company => company.Staff);

    Console.WriteLine();

    foreach (var employee in employees)
        Console.WriteLine($"{employee.Name} - {employee.Age}");



    // Operators
    var companies1 = new List<Company>
    {
        new Company("Microinvest", new List<Person> { new Person("Petru"), new Person("Daniel")}),
        new Company("MAIB", new List<Person> { new Person("Danu"), new Person("Parcalab", 280) })
    };

    var employees1 =    from company in companies1
                        from person in company.Staff
                        select person;

    Console.WriteLine();
    foreach (var employee in employees1)
        Console.WriteLine(employee.Name);




    // Level Up a little
    // Methods
    var employees2 = companies1.SelectMany(company => company.Staff, (company, employee) => new { TheName = employee.Name, TheCompany = company.Name });

    Console.WriteLine();
    foreach (var employee in employees2)
        Console.WriteLine($"{employee.TheName} - {employee.TheCompany}");

    // Здесь применяется другая версия метода SelectMany. Первый делегат в виде c => c.Staff создает промежуточную коллекцию - фактически 
    // просто возвращаем набор сотрудников каждой компании. Второй делегат - (c, emp)=> new { Name = emp.Name, Company = c.Name } получает 
    // каждую компанию и каждый элемент промежуточной коллекции - объект Person и на их основе создает анонимный объект 
    // с двумя свойствами Name и Company.



    // Operators
    var employees3 =    from company in companies1
                        from employee in company.Staff
                        select new { TheName = employee.Name, TheCompany = company.Name };
                    
    Console.WriteLine();
    foreach (var employee in employees3)
        Console.WriteLine($"{employee.TheName} - {employee.TheCompany}");

#endregion


class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Person(string name) : this(name, 18) {}
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}


class Company
{
    public string Name { get; set; }
    public List<Person> Staff { get; set; }
    public Company(string name, List<Person> staff)
    {
        Name = name;
        Staff = staff;
    }
}