using System;
namespace ObserverPattern_MovieNotification;

public class MovieSmsNotification(string name) : IMovieObserver
{
    public string Name { get; set; } = name;

    public void Update(string movie)
    {
        Console.WriteLine($"{Name} has been notified via SMS about a new {movie}");
    }
}