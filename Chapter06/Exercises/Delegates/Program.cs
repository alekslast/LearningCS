class Program
{
    static void Main(string[] args)
    {
        #region Simple delegate. Void, no parameters.
            Console.WriteLine("");

            Message mes;
            mes = Hello;
            mes();

            Console.WriteLine("");

            void Hello() => Console.WriteLine("Hello World!");
        #endregion


        #region A delegate with parameters
            Operation operation = Add;
            int result = operation(4, 5);
            Console.WriteLine(result);

            operation = Multiply;
            result = operation(4, 5);
            Console.WriteLine(result);

            Console.WriteLine("");

            int Add(int x, int y) => x + y;
            int Multiply(int x, int y) => x * y;
        #endregion


        #region Add methods to a delegate
            Message mess = Greet;
            mess += HowAreYou;
            mess += Greet;
            mess += HowAreYou;

            mess();

            Console.WriteLine("");

            void Greet()        => Console.WriteLine("Hello, friend!");
            void HowAreYou()    => Console.WriteLine("How are things?");
        #endregion


        #region Delete methods from a delegate
            Message? messager = SayHi;  // We are gonna delete some methods from here, so there may be a moment when
                                        // there are no more methods in that delegate => it may become null.
            messager += AskQuestion;
            messager();

            messager -= AskQuestion;
            if (messager != null) messager();   // If it really becomes null, we don't want to call it, but if it's not null we do
            messager -= SayHi;
            if (messager != null) messager();

            Console.WriteLine("");

            void SayHi()        => Console.WriteLine("Hi");
            void AskQuestion()  => Console.WriteLine("What's your name?");
        #endregion


        #region Uniting different delegates
            Message mes1 = Hello;
            Message mes2 = Greet;
            Message mes3 = SayHi;

            Message allGreetimgs = mes1 + mes2 + mes3;
            allGreetimgs();

            Console.WriteLine("");
        #endregion

        
        #region Invoke() and NULL check
            Message? newMes = null;
            newMes?.Invoke();

            // Operation? addition = Add;
            // addition -= Add;
            // int n = addition(4, 5);  // Returns an error as our delegate is null

            Operation? addition = Add;
            addition -= Add;
            int? n = addition?.Invoke(4, 5);    // Does not return an error as we use "?." operator together with Invoke

            int? mn = addition?.Invoke(4, 5) ?? -1;
            Console.WriteLine(mn);
            
            Console.WriteLine("");
        #endregion


        #region Universal delegates
            Command<decimal, int> squareX = Square;
            decimal someResult = squareX(5);
            Console.WriteLine(someResult);

            Command<int, int> doubleX = Double;
            int someResult2 = doubleX(2);
            Console.WriteLine(someResult2);

            Console.WriteLine("");

            decimal Square(int x) => x * x;
            int     Double(int x) => x + x;
        #endregion


        #region Passing delegates as parameters
            DoOperation(5, 3, Add);
            DoOperation(5, 3, Multiply);

            void DoOperation(int x, int y, Operation op)
            {
                Console.WriteLine(op(x, y));
            }

            Console.WriteLine("");
        #endregion


        #region Delegates as an output
            Operation newAddition = SelectOperation(OperationType.Addition);
            Console.WriteLine(newAddition(2, 5));

            Operation newSubtraction = SelectOperation(OperationType.Subtraction);
            Console.WriteLine(newSubtraction(7, 3));

            Operation newMultiplication = SelectOperation(OperationType.Multiplication);
            Console.WriteLine(newMultiplication(12, 12));

            Console.WriteLine("");

            Operation SelectOperation(OperationType opType)
            {
                switch(opType)
                {
                    case OperationType.Addition         : return Addition;
                    case OperationType.Subtraction      : return Subtraction;
                    default                             : return Multiplication;
                }
            }

            int Addition(int x, int y) => x + y;
            int Subtraction(int x, int y) => x - y;
            int Multiplication(int x, int y) => x * y;
        #endregion



    }
}


delegate void Message();

delegate int Operation(int x, int y);

delegate T Command<T, K>(K value);

enum OperationType
{
    Addition,
    Subtraction,
    Multiplication
}