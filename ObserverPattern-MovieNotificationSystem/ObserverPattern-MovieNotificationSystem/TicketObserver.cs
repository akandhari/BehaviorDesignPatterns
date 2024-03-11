public class User : ITicketObserver
{
    private string Name;

    public User(string name)
    {
        Name = name;
    }

    public void Update(string message)
    {
        Console.WriteLine($"{Name}, there's a sale on movie tickets: {message}");
    }
}