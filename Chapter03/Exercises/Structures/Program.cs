
using MyLib;

class Program{
    static void Main(string[] args)
    {
        // Если для создания структуры не используется конструктор, то перед обращением к полю структуры 
        // необходимо проинициализировать данное поле.



        // Person tom  = new();
        // Person john = new("John");
        // Person don  = new("Don", 27);

        // tom.GetInfo();
        // john.GetInfo();
        // don.GetInfo();


        #region Copy a structure using "with"

        Person tom = new Person { name = "Tom", age = 22};
        tom.GetInfo();

        Person bob = tom with { name = "Bob" };
        bob.GetInfo();

        #endregion


        #region Context

        // string x = "Tom";
        char x = 'A';

        void Rename()
        {
            x = 'M';
            Console.WriteLine(x);
        }

        Rename();
        Console.WriteLine(x);

        #endregion


        Car corolla = new Car(name: "Toyota");
        corolla.GetInfo();
    }
}


// // Same principles as for Class can by applied here.
// // The difference between "struct" and "class":     "struct" => value type; 
// //                                                  "class" => refference type;
// struct Person(string name, int age)
// {
//     public Person() : this("Unknown") {}
//     public Person(string name) : this(name, 1) {}
//     public void GetInfo() => Console.WriteLine($"Name: {name}, Age: {age}");
// }


struct Person
{
    public string name;
    public int age;
    public void GetInfo() => Console.WriteLine($"Name: {name}, Age: {age}");
}
