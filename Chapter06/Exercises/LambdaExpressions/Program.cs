#region Lambda with multiple operations
    // var hello = (string message) =>
    // {
    //     Console.WriteLine($"Hello, {message}!");
    //     Console.WriteLine($"Are you really {message}?");
    // };

    // hello("Frank");
    
    // delegate void Print(string words);
#endregion


#region Return result from Lambda
    // DoSomething addNumbers = (x, y) => x + y;
    // Console.WriteLine(addNumbers(6, 3));

    // DoSomething multiplyNumbers = (x, y) => x * y;
    // Console.WriteLine(multiplyNumbers(5, 8));

    // var operation1 = (int x, int y) => x / y;
    // Console.WriteLine(operation1(24, 6));
    // delegate int DoSomething(int x, int y);
#endregion


#region Multiple returns from Lambda
    // var doSomethingWithNumbers = (int x, int y) =>
    // {
    //     if (x > 10) return x - y;
    //     else return x + y;
    // };

    // Console.WriteLine(doSomethingWithNumbers(2, 11));
    // Console.WriteLine(doSomethingWithNumbers(70, 11));

    // delegate int AnAction(int x, int y);
#endregion


#region Lambda as a method's result
    // Operation addition = PerformOperation(OperationType.Add);
    // Console.WriteLine(addition(2, 3));

    // Operation subtraction = PerformOperation(OperationType.Subtract);
    // Console.WriteLine(subtraction(10, 11));

    // Operation multiplication = PerformOperation(OperationType.Multiply);
    // Console.WriteLine(multiplication(25, 25));


    // Operation PerformOperation(OperationType op)
    // {
    //     switch(op)
    //     {
    //         case OperationType.Add      : return (x, y) => x + y;
    //         case OperationType.Subtract : return (x, y) => x - y;
    //         default                     : return (x, y) => x * y;
    //     }
    // }

    // delegate int Operation(int x, int y);

    // enum OperationType
    // {
    //     Add,
    //     Subtract,
    //     Multiply
    // }
#endregion

