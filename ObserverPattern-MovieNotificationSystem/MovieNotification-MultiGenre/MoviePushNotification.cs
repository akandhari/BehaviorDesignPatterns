using System;

namespace ObserverPattern_MovieNotification;

public class MoviePushNotification(string name) : IMovieObserver
{
    public string Name { get; set; } = name;

    public void Update(string movie)
    {
        Console.WriteLine($"{Name} has been notified via Push Message about a new {movie}");
    }
}