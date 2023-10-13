namespace P3_2People;

public class Person
{
    public string Name;

    public void Greeting()
    {
        Console.WriteLine($"Hello, I'm {this.Name}!");
    }
}