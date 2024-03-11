using System;

namespace ObserverPattern_MovieNotification;

public class MovieEmailNotification(string name) : IMovieObserver
{
    public string Name { get; set; } = name;

    public void Update(string movie)
    {
        Console.WriteLine($"{Name} has been notified via Email about a new {movie}");
    }
}