Person[] people =
{
    new Person("Tom", "Microsoft"), new Person("Sam", "Google"),
    new Person("Bob", "JetBrains"), new Person("Mike", "Microsoft"),
    new Person("Kate", "JetBrains"), new Person("Alice", "Microsoft")
};

var companies = from p in people
                orderby p.Name
                group p by p.Company;


// Результатом оператора group является выборка, которая состоит из групп. Каждая группа представляет объект IGrouping<K, V>: 
// параметр K указывает на тип ключа - тип свойства, по которому идет группировка (здесь это тип string). 
// А параметр V представляет тип сгруппированных объектов - в данном случае группируем объекты Person.


foreach (var company in companies)
{
    Console.WriteLine(company.Key);  // Каждая группа имеет ключ, который мы можем получить через свойство Key: g.Key. Здесь это будет название компании.

    foreach (var person in company)
    {
        Console.WriteLine(person.Name);
    }

    Console.WriteLine();
}





// Creating new object

// определяет переменную g, которая будет содержать группу. С помощью этой переменной мы можем затем создать новый объект анонимного типа
// (хотя также можно под данную задачу определить новый класс):
var newCompanies =  from p in people
                    group p by p.Company into g
                    select new { Name = g.Key, Count = g.Count() };  // g.Key = company name; g.Count = how many people are there in the company

                    // Теперь результат запроса LINQ будет представлять набор объектов таких анонимных типов,
                    // у которых два свойства Name и Count.

foreach (var company in newCompanies) Console.WriteLine($"{company.Name} : {company.Count}");

Console.WriteLine();



var newCompanies2 = from p in people
                    group p by p.Company into g
                    select new
                    {
                        Name = g.Key,
                        Count = g.Count(),
                        Employees = from employee in g
                                    orderby employee.Name
                                    select employee
                    };

foreach (var company in newCompanies2)
{
    Console.WriteLine($"{company.Name} : {company.Count}");
    foreach(var employee in company.Employees)
    {
        Console.WriteLine(employee.Name);
    }
    Console.WriteLine(); // для разделения компаний
}



record class Person(string Name, string Company);