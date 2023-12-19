#region Assign anonymous method to a delegate variable
    // // NON-anonymous method
    // Operation operation = Add;  // 3) Assign method to a variable of delegate type
    // int result = operation(4, 5);   // 4) Save method's value into a new variable
    // Console.WriteLine(result);

    // Console.WriteLine("");

    // int Add(int x, int y) => x + y; // 2) Name of method

    // delegate int Operation(int x, int y);   // 1) Create delegate


    // Anonymous Method
    // MessageHandler handler = delegate (string mes)  // 2) Anonymous method. You MUST assign its call to a variable (here the delegate)
    // {                                               // Now you must not create additional methods, thinking for hours on their name.
    //     Console.WriteLine(mes);
    // };
    // handler("hello world!");

    // Console.WriteLine("");
    
    // delegate void MessageHandler(string message);   // 1) Create delegate
#endregion


#region Transfer a delegate as an anonymous method's parameter
    ShowMessage("hello!", delegate (string mes)
    {
        Console.WriteLine(mes);
    });
    

    static void ShowMessage(string message, MessageHandler handler)
    {
        handler(message);
    }
    

    delegate void MessageHandler(string message);
#endregion