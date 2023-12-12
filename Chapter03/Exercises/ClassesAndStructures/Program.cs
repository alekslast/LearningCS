using static System.Console;


#region No Constructor Person class

// Person jack = new Person();
// jack.GetInfo();

// jack.name   = "Jack";
// jack.age    = 24;
// jack.GetInfo();

// class Person()
// {
//     public string name  = "Undefined";
//     public byte age     = 0;

//     public void GetInfo() => WriteLine($"Name: {name}, Age: {age}");
// }

#endregion



#region Simple Constructor for Person class. Here we cannot pass any arguments on creation. We may create only DEFAULT person

// Person tom = new Person();
// tom.GetInfo();

// // Person don = new ("Don", 19);
// // don.GetInfo();


// class Person
// {
//     public string name;
//     public byte age;
//     public Person()
//     {
//         WriteLine("New person has been created");
//         name    = "Undefined";
//         age     = 0;
//     }

//     public void GetInfo()
//     {
//         WriteLine($"Name: {name}, Age: {age}");
//     }
// }

#endregion



#region Pass in some parameters to Person class

// Person jacob = new();
// Person julian = new("Julian");
// Person agora = new("Agora", 24);

// jacob.GetInfo();
// julian.GetInfo();
// agora.GetInfo();



// class Person 
// {
//     public string name;
//     public int age;
//     // public Person() : this("Unknown", 18)
//     // { }
//     // public Person(string name) : this(name, 18)
//     // { }
//     // public Person(string name, int age) // Use this declaration if you use previous 2
//     public Person(string name = "Unknown", int age = 18) // Use this declaration if you don't use previous 2
//     {
//         this.name = name;
//         this.age = age;
//     }
//     public void GetInfo() => Console.WriteLine($"Name: {name}  Age: {age}");
// }

#endregion



#region Primary Constructors

// Person axel = new();
// axel.GetInfo();

// public class Person(string name, int age)
// {
//     // Primary constructor makes all the variables required. If you want to continue using constructor with no parameters
//     // or with only one of them, you must still declare those variants inside your class.
//     public Person() : this("Unknown", 18) {} // Variant with no parameters specifies the default ones
//     public Person(string name) : this(name, 18) {} // Variant with only one parameter specifies default value for the other one
//     public void GetInfo() => WriteLine($"Name: {name}, Age: {age}");
// }

#endregion



#region Initialisation

// // Person axel = new Person ( name: "Axel", age: 32 );
// Person axel = new Person { name = "Axel", age = 32 };
// axel.GetInfo();

// class Person
// {
//     public string name;
//     public int age;
//     public Person(string name = "Unknown", int age = 18)
//     {
//         this.name   = name;
//         this.age    = age;
//     }
//     public void GetInfo() => WriteLine($"Name: {name}, Age: {age}");
// }

#endregion



#region Deconstruction

// Person tom = new("Tom", 32);
// // (_, int age) = tom;
// // WriteLine(age);

// string name;
// int age;
// tom.Deconstruct(out name, out age);
// WriteLine($"Deconstruct name: {name}; Deconstruct age: {age}");

// class Person{
//     string name;
//     int age;
//     public Person(string name, int age)
//     {
//         this.name   = name;
//         this.age    = age;
//     }

//     public void Deconstruct(out string personName, out int personAge) // deconstRUCT not deconstRUCTION !!!!
//     {
//         personName  = name;
//         personAge   = age;
//     }
// }

#endregion