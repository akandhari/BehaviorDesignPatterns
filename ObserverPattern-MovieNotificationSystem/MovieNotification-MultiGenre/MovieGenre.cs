using System.Collections.Generic;
using System;
using System.Linq;
using ObserverPattern_MovieNotification;

public abstract class MovieGenre : IMovieSubject
{
    private List<IMovieObserver> observers = new List<IMovieObserver>();
    protected List<string> movies = new List<string>();

    public void RegisterObserver(IMovieObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(IMovieObserver observer)
    {
        observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (IMovieObserver observer in observers)
        {
            observer.Update(movies.Last());
        }
    }

    public abstract void AddMovie(string movie);
}