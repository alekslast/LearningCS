using System.Collections.Generic;

// // List<string> people = new List<string>();
// // List<string> people = [];



// // List<string> people = ["Tom", "Bob", "Sam"];
// List<string> people = new List<string>() { "Tom", "Bob", "Sam" };

// // Initialize "people2" with elements from "people" and add one more element - "Mike"
// List<string> people2 = new List<string>(people) {"Mike"};

// foreach (string person in people)
// {
//     Console.WriteLine(person);
// }

// Console.WriteLine("");

// foreach (string person in people2)
// {
//     Console.WriteLine(person);
// }

// Console.WriteLine("");



// List<Person> personList = new List<Person>()
// {
//     new Person("Tom", 25),
//     new Person("Lily", 19),
//     new Person("Anny", 22)
// };

// foreach (Person person in personList)
// {
//     Console.WriteLine($"{person.Name} - {person.Age}");
// }


#region Setting List Length

    // List<string> people = new List<string>(16);

#endregion


#region Accessing List elements

    // var people = new List<string>() { "Tom", "Bob", "Sam" };

    // Console.WriteLine(people[1]);

#endregion


#region Getting List Length - Count

    // var people = new List<string>() { "Tom", "Bob", "Sam", "Eddie" };

    // var peopleLength = people.Count;

    // Console.WriteLine(peopleLength);

#endregion


#region Add elements to a LIst

    // var numbers = new List<int>() { 1, 2, 3 };

    // numbers.Add(4);

    // numbers.AddRange(new[] { 5, 6 });

    // numbers.Insert(4, 55);

    // numbers.InsertRange(5, new int[] { 11, 111, 1111 });

    // foreach (int number in numbers)
    // {
    //     Console.WriteLine(number);
    // }
    

#endregion


#region Delete from a List

    // var pupils = new List<string>() { "Tom", "Kate", "Ann", "Jack", "Alice", "Bob", "John", "Dave", "Kate", "Lilly" };

    // pupils.RemoveAt(pupils.Count - 1);  // Removes last item from the List

    // pupils.Remove("Kate");  // Removes first Kate in the List

    // pupils.RemoveAll(pupil => pupil.Length == 3);  // Remove all List elements whose length equals 3

    // pupils.RemoveRange(3, 2);  // Remove 2 elements starting from index 3

    // pupils.Clear();

    // foreach (string pupil in pupils)
    // {
    //     Console.WriteLine(pupil);
    // }

#endregion


#region Search in a List

    // var people = new List<string>() { "Tom", "Bob", "Mr. Gold", "Jack", "Lucky Pit", "Jo", "Mo", "Eddie" };

    // if (people.Contains("Jo"))
    // {
    //     Console.WriteLine(people.IndexOf("Jo"));
    // }


    // var peopleExists = people.Exists(person => person.Length == 2);  // Check if there any element with the length of to 2
    // Console.WriteLine(peopleExists);

    // var firstOfAKind = people.Find(person => person.Length == 2);  // Finds the first item whose length equals to 2
    // Console.WriteLine(firstOfAKind);

    // var lastOfAKind = people.FindLast(people => people.Length > 4);  // Finds the last element whose length is greater than 4
    // Console.WriteLine(lastOfAKind);

    // Console.WriteLine("");

    // List<string> allThatMatch = people.FindAll(people => people.Length < 4);
    // foreach (string person in allThatMatch)
    // {
    //     Console.WriteLine(person);
    // }

#endregion


#region Getrange and Copy into an array

    // var people = new List<string>() { "Dolores", "Micky", "Tailor", "Anabelle", "Gimmly" };

    // var range = people.GetRange(1, 3);  // Get elements 3 from "people" List starting from index 1
    // foreach (string e in range)
    // {
    //     Console.WriteLine(e);
    // }

    // Console.WriteLine("");

    // // string[] peopleCopy = [ "Billy", "Jose" ];  // Returns an error, that destination array is not large enough
    // string[] peopleCopy = new string[3];
    // people.CopyTo(2, peopleCopy, 0, 3);  // Copy 3 items from "people" List starting from elem at index 2 to an Array called "peopleCopy"
    // foreach (string p in peopleCopy)
    // {
    //     Console.WriteLine(p);
    // }

#endregion


#region Reverse

    // var people = new List<string>() { "Bob", "Nick", "Jack", "Drew" };

    // people.Reverse();
    // foreach (string person in people)
    // {
    //     Console.WriteLine(person);
    // }

    // Console.WriteLine("");

    // people.Reverse(1, 3);  // Reverse order of 3 elements in "people" List starting from the element at index 1
    // foreach (string person in people)
    // {
    //     Console.WriteLine(person);
    // }

#endregion

// Person bob = new Person();
// Console.WriteLine(bob);
// Console.WriteLine(bob.Name);
// Console.WriteLine(bob.Age);

Employee employee1 = new Employee();
Console.WriteLine(employee1);
Console.WriteLine(employee1.Identity);
Console.WriteLine(employee1.Title);

Console.WriteLine("");

Employee employee2 = new Employee(new Person("Tom", 22), "developer");
Console.WriteLine(employee2);
Console.WriteLine(employee2.Identity.Name);
Console.WriteLine(employee2.Identity.Age);
Console.WriteLine(employee2.Title);


class Person
{
    public string   Name    { get; set; }
    public int      Age     { get; set; }

    public Person() : this("Undefined", 0) {}
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

class Employee
{
    public Person? Identity  { get; set; }
    public string? Title     { get; set; }

    public Employee() : this(null, null) {}
    public Employee(Person? identity, string? title)
    {
        Identity = identity;
        Title = title;
    }
}