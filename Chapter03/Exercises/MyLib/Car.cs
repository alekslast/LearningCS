namespace MyLib;

public class Car
{
    string name;
    public Car(string name)
    {
        this.name = name;
    }
    public void GetInfo() => Console.WriteLine($"Car's name: {name}");
}
