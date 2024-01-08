#region Creating a Queue

    Queue<string> people = new Queue<string>();
    // Queue<string> people = new Queue<string>(16);

    var employees = new List<string> { "Tom", "Bob", "Sam" };
    Queue<string> people2 = new Queue<string>(employees);

    people2.Enqueue("Dany");

    foreach (var person in people2)
        Console.WriteLine(person);

    Console.WriteLine("");



    int count = people2.Count();
    Console.WriteLine(count);

    Console.WriteLine("");



    string firstPerson;
    if(people2.Count > 0)  // Using Peek or Dequeue we may get Exception if the Queue is empty. That's why we gotta check the queue first
    {
        firstPerson = people2.Peek();
        Console.WriteLine($"Peek: {firstPerson}");
    }

    // Or use TryPeek method
    var peekOperation = people2.TryPeek(out var person1);
    // Assigns the value of the first element in the queue to the variable person1 without deleting it from the queue and returns true if it was successfully done
    Console.WriteLine(person1);



    Console.WriteLine("");



    string extractedPerson;  // Deletes person from the beginning => the first item in the Queue
    if(people2.Count > 0)  // Using Peek or Dequeue we may get Exception if the Queue is empty. That's why we gotta check the queue first
    {
        extractedPerson = people2.Dequeue();
        Console.WriteLine($"Dequeue: {extractedPerson}");
    }

    // Or use TryDequeue
    var dequeueOperation = people2.TryDequeue(out var person2);
    // Assigns the value of the first element in the queue to the variable person2, and deletes the elements from the queue and returns true if it was successfully done
    Console.WriteLine(person2);
    


    Console.WriteLine("");



    foreach (var person in people2)
        Console.WriteLine(person);

#endregion


#region Real life patient queue

    var patients = new Queue<Person>();
    patients.Enqueue(new Person("Tom"));
    patients.Enqueue(new Person("Bob"));
    patients.Enqueue(new Person("Sam"));
    
    var practitioner = new Doctor();
    practitioner.TakePatients(patients);
    
    class Person
    {
        public string Name { get; }
        public Person(string name) => Name = name;
    }
    
    class Doctor
    {
        public void TakePatients(Queue<Person> patients)
        {
            while(patients.Count > 0)
            {
                var patient = patients.Dequeue();
                Console.WriteLine($"Patient {patient.Name}, please come in.");
            }
            Console.WriteLine("No more patients");
        }
    }

#endregion