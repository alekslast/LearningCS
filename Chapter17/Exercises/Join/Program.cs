Person[] people =
{
    new Person("Jack", "Microsoft"),
    new Person("Mike", "Google"),
    new Person("Dane", "Apple"),
    new Person("Lisa", "Apple")
};

Company[] companies =
{
    new Company("Microsoft", "C#"),
    new Company("Google", "Go"),
    new Company("Oracle", "Java")
};

var employees = from p in people
                join c in companies on p.Company equals c.Title
                select new { Name = p.Name, Company = c.Title, Language = c.Language };


foreach (var employee in employees) Console.WriteLine($"{employee.Name} - {employee.Company} - {employee.Language}"); 
// No Dane and Lisa here, and no Oracle, because there is no person, that works in Oracle company.



Console.WriteLine();




// Join + Group (GroupJoin if using methods)
var companies2 =    from c in companies
                    join p in people on c.Title equals p.Company into g
                    select new
                    {
                        Title = c.Title,
                        Employees = g
                    };

foreach (var company in companies2)
{
    Console.WriteLine(company.Title);
    foreach (var employee in company.Employees)
    {
        Console.WriteLine(employee.Name);
    }
    Console.WriteLine();
}

Console.WriteLine();





// Zip() method
var courses = new List<Course> { new Course("C#"), new Course("Java"), new Course("JavaScript"), new Course("Python") };
var students = new List<Student> { new Student("Jim"), new Student("Lora"), new Student("Angela"), new Student("Don") };

var enrollments = courses.Zip(students);

foreach (var enrollment in enrollments) Console.WriteLine($"{enrollment.First} - {enrollment.Second}");
// enrollment.First = Course
// enrollment.Second = Student




record class Person (string Name, string Company);
record class Company(string Title, string Language);



record class Student(string Name);
record class Course(string Title);