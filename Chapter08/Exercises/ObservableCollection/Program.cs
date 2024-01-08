using System.Collections.ObjectModel;
using System.Collections.Specialized;


// A List-like structure that notifies you about its changes

#region Creating an ObservableCollection

    // ObservableCollection<string> people = new ObservableCollection<string>();
    // var people1 = new ObservableCollection<string>( new string[] { "Tom", "Bob", "Sam" } );
    // var people2 = new ObservableCollection<string>
    // {
    //     "Tom", "Bob", "Sam"
    // };


    // foreach (var person in people)
    // {
    //     Console.WriteLine(person);
    // }



    // Console.WriteLine();



    // foreach (var person in people1)
    // {
    //     Console.WriteLine(person);
    // }



    // Console.WriteLine();



    // foreach (var person in people2)
    // {
    //     Console.WriteLine(person);
    // }

    // Console.WriteLine();

    // Console.WriteLine(people2[0]);
    // Console.WriteLine();
    // Console.WriteLine(people2[1]);
    // people2[1] = "Jack";
    // Console.WriteLine(people2[1]);



#endregion



#region ObservableCOllection methods

    // // Add, CopyTo, Contains, Clear, IndexOf, Insert, Remove, RemoveAt, Move
    // var people3 = new ObservableCollection<string>
    // {
    //     "Johny", "Dave", "Lilly", "Tony"
    // };

    // people3.Add("Danny");

    // foreach (var person in people3)
    // {
    //     Console.WriteLine(person);
    // }

    // string[] newCollection = new string[6];
    // newCollection[0] = "Edd";
    // newCollection[1] = "Ted";
    // people3.CopyTo(newCollection, 1);

    // Console.WriteLine();
    // foreach (var person in newCollection)
    // {
    //     Console.WriteLine(person);
    // }

    // people3.Insert(1, "11111111");
    // int indexTony = people3.IndexOf("Tony");

    // Console.WriteLine();
    // foreach (var person in people3)
    // {
    //     Console.WriteLine(person);
    // }
    // Console.WriteLine(indexTony);

    // people3.Remove("11111111");
    // people3.RemoveAt(3);
    // people3.Move(0, 3);
    // Console.WriteLine();
    // foreach (var person in people3)
    // {
    //     Console.WriteLine(person);
    // }

#endregion



#region NotifyCollectionChangedEventHandler

    // NotifyCollectionChangedAction:
    // Add, Remove, Replace, Move, Reset

    
    var people = new ObservableCollection<Person>() 
    { 
        new Person("Tom"), 
        new Person("Sam") 
    };
    // подписываемся на событие изменения коллекции
    people.CollectionChanged += People_CollectionChanged;
    
    people.Add(new Person("Bob"));  // добавляем новый элемент
    
    people.RemoveAt(1);                 // удаляем элемент
    people[0] = new Person("Eugene");   // заменяем элемент
    
    Console.WriteLine("\nUser List:");
    foreach (var person in people)
    {
        Console.WriteLine(person.Name);
    }

    people.Move(0, 1);
    Console.WriteLine();
    foreach (var person in people)
    {
        Console.WriteLine(person.Name);
    }

    people.Clear();
    foreach (var person in people)
    {
        Console.WriteLine(person.Name);
    }

#endregion





void People_CollectionChanged(object? sender, NotifyCollectionChangedEventArgs e)
{
    switch(e.Action)
    {
        case NotifyCollectionChangedAction.Add:
            if (e.NewItems?[0] is Person newPerson)
                Console.WriteLine($"New object added: {newPerson.Name}");

            break;

        case NotifyCollectionChangedAction.Remove:
            if (e.OldItems?[0] is Person oldPerson)
                Console.WriteLine($"Object deleted: {oldPerson.Name}");

            break;

        case NotifyCollectionChangedAction.Replace:
             if ((e.NewItems?[0] is Person replacingPerson)  && (e.OldItems?[0] is Person replacedPerson))
                Console.WriteLine($"Object - {replacedPerson.Name} - has been replaced by - {replacingPerson.Name}");
            break;

        case NotifyCollectionChangedAction.Move:
            Console.WriteLine($"Object moved from: {e.OldStartingIndex} to {e.NewStartingIndex}");
            break;

        case NotifyCollectionChangedAction.Reset:
            if (e.NewItems == null)
                Console.WriteLine("Items Wiped.");
            break;
        default:
            break;
    }
}


class Person
{
    public string Name { get; set; }
    public Person(string name)
    {
        Name = name;
    }
}