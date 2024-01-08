using System.Collections.Generic;


#region Create a LinkedList + check some properties

    // LinkedList<string> people = new LinkedList<string>();
    // var people = new LinkedList<string>(new[] { "Sam" });


    // var people1 = new List<string>() { "Tom", "Bob", "Sam" };

    // LinkedList<string> people2 = new LinkedList<string>(people1);
    // Console.WriteLine(people2.Count);
    // Console.WriteLine(people2.First?.Value);
    // Console.WriteLine(people2.Last?.Value);

    // Console.WriteLine("");



    // // Go through all the elements in a LinkedList
    // // From start to end
    // var currentNode = people2.First;
    // while (currentNode != null)
    // {
    //     Console.WriteLine(currentNode.Value);
    //     currentNode = currentNode.Next;
    // }

    // Console.WriteLine("");


    // // From end to start
    // var selectedNode = people2.Last;
    // while (selectedNode != null)
    // {
    //     Console.WriteLine(selectedNode.Value);
    //     selectedNode = selectedNode.Previous;
    // }

#endregion


#region Adding items

    var people3 = new LinkedList<string>(new[] { "Sam" });

    // Insert to the end of the list
    people3.AddLast("Tom");

    // Insert to the beginning of the list
    people3.AddFirst("John");

    // Insert after the first item of the list
    if (people3.First != null) people3.AddAfter(people3.First, "Dido");



    foreach (string person in people3)
    {
        Console.WriteLine(person);
    }

#endregion
