// using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
//         Console.WriteLine(IAction.maxSpeed);
//         Console.WriteLine(IAction.minSpeed);
//         BaseAction someAction = new BaseAction();
//         someAction.Move();

//         Person  person1 = new Person();
//         Car     car1    = new Car();

//         person1.Move();
//         car1.Move();
    
//         IAction singAction = new BaseAction();
//         singAction.Sing();


//         Message hello = new Message("Hello World!");
//         hello.Print();


//         IMessage someMessage = new Message("Awesome");
//         // IPrintable newMessage = (IPrintable) someMessage;
//         // newMessage.Print();
//         ((IPrintable)someMessage).Print();

        


//         #region Explicit Interface Casting

//             // Insecure casting
//             Greet newGreeting = new Greet();
//             ((IAnotherAction)newGreeting).Greet();

//             // Secure casting
//             Greet sayHi1 = new Greet();
//             if (sayHi1 is IAnotherAction whatever) whatever.Greet();
//             // or:
//             IAnotherAction sayHi2 = new Greet();
//             sayHi2.Greet();

//         #endregion
    

        #region IComparable, IComparer

            // var tom = new Person("Tom", 23);
            // var bob = new Person("Bob", 44);
            // var rob = new Person("Rob", 39);
            var tom = new Person("Thomas", 23);
            var bob = new Person("Bob", 44);
            var rob = new Person("Roberto", 39);

            Person[] people = [tom, bob, rob];
            // Array.Sort(people);
            Array.Sort(people, new PeopleComparer());

            foreach (Person person in people)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }



        #endregion



    }
}


#region IComparable, Icomparer
    class PeopleComparer : IComparer<Person>
    {
        public int Compare(Person? p1, Person? p2)
        {
            if (p1 == null || p2 == null)
                throw new ArgumentException("Invalid Argument");

            return p1.Name.Length - p2.Name.Length;
        }
    }
    class Person : IComparable
    {
        string  name;
        int     age;

        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public int CompareTo(object? obj)
        {
            if (obj is Person person) return Name.CompareTo(person.Name);
            else throw new ArgumentException("Invalid Argument");
        }
    }
#endregion



// #region Explicit realization of an Interface

//     interface IAction
//     {
//         const int minSpeed = 0;
//         static int maxSpeed = 60;
//         void Move();
//         void Sing() => Console.WriteLine("Sing");
//     }
//     class BaseAction : IAction
//     {
//         // void IAction.Move() => Console.WriteLine("Move in Base Class");
//         public void Move() => Console.WriteLine("Move");
//     }

//     class Person : IAction
//     {
//         public void Move() => Console.WriteLine("Walk");
//     }

//     class Car : IAction
//     {
//         public void Move() => Console.WriteLine("Drive");
//     }





//     interface IMessage
//     {
//         string Text { get; set; }
//     }
//     interface IPrintable
//     {
//         void Print();
//     }
//     class Message : IMessage, IPrintable
//     {
//         public string Text { get; set; }
//         public Message(string text) => Text = text;
//         public void Print()=> Console.WriteLine(Text);
//     }


//     interface IAnotherAction
//     {
//         void Greet() => Console.WriteLine("Greetings!");
//     }

//     class Greet : IAnotherAction
//     {
//         void IAnotherAction.Greet() => Console.WriteLine("Welcome!");
//     }
// #endregion



