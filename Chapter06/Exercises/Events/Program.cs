// Account myAccount = new Account(200);

// myAccount.Notify += DisplayMessage;

// myAccount.Put(100);
// myAccount.Take(250);
// myAccount.Take(100);

// void DisplayMessage(string message) => Console.WriteLine(message);

// class Account
// {
//     // private int _sum;
//     public delegate void AccountHandler(string message);
//     public event AccountHandler? Notify;
    
//     public Account(int ammount) => Sum = ammount;

//     public int Sum { get; private set; }
//     public void Put(int ammount)
//     {
//         Sum += ammount;
//         Notify?.Invoke($"You have recieved {ammount}");
//     }
//     public void Take(int ammount)
//     {
//         if (Sum >= ammount)
//         {
//             Sum -= ammount;
//             Notify?.Invoke($"You have withdrawn {ammount}");
//         }
//         else
//         {
//             Notify?.Invoke($"{Sum} - unsufficient ammount = {ammount}! Action denied.");
//         }
//     }
// }




Account acc = new Account(100);
acc.Notify += DisplayMessage;
acc.Put(20);
acc.Take(70);
acc.Take(150);
 
void DisplayMessage(Account sender, AccountEventArgs e)
{
    Console.WriteLine($"Transaction amount: {e.Sum}");
    Console.WriteLine(e.Message);
    Console.WriteLine($"Current balance: {sender.Sum}");
}


class AccountEventArgs
{
    // Сообщение
    public string Message{get;}
    
    // Сумма, на которую изменился счет
    public int Sum {get;}
    public AccountEventArgs(string message, int sum)
    {
        Message = message;
        Sum = sum;
    }
}


class Account
{
    public delegate void AccountHandler(Account sender, AccountEventArgs e);
    public event AccountHandler? Notify;
     
    public int Sum { get; private set; }
     
    public Account(int sum) => Sum = sum;
     
    public void Put(int sum)
    {
        Sum += sum;
        Notify?.Invoke(this, new AccountEventArgs($"Your account just got {sum}", sum));
    }
    public void Take(int sum)
    {
        if (Sum >= sum)
        {
            Sum -= sum;
            Notify?.Invoke(this, new AccountEventArgs($"{sum} were gone from your account", sum));
        }
        else
        {
            Notify?.Invoke(this, new AccountEventArgs("Not enough money", sum));
        }
    }
}