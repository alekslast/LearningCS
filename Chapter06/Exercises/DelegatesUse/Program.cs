// создаем банковский счет
Account account = new Account(200);
// Добавляем в делегат ссылку на метод PrintSimpleMessage
account.RegisterHandler(PrintSimpleMessage);
// Два раза подряд пытаемся снять деньги
account.Take(100);
account.Take(150);
 
void PrintSimpleMessage(string message) => Console.WriteLine(message);



// Объявляем делегат
public delegate void AccountHandler(string message);
public class Account
{
    int sum;
    // Создаем переменную делегата
    AccountHandler? taken;
    public Account(int sum) => this.sum = sum;
    // Регистрируем делегат
    public void RegisterHandler(AccountHandler del)
    {
        taken = del;
    }
    public void Add(int sum) => this.sum += sum;
    public void Take(int sum)
    {
        if (this.sum >= sum)
        {
            this.sum -= sum;
            // вызываем делегат, передавая ему сообщение
            taken?.Invoke($"Со счета списано {sum} у.е.");
        }
        else
        {
            taken?.Invoke($"Недостаточно средств. Баланс: {this.sum} у.е.");
        }
    }
}