using ObserverPattern_MovieNotification;

public interface IMovieSubject
{
    void RegisterObserver(IMovieObserver observer);
    void RemoveObserver(IMovieObserver observer);
    void NotifyObservers();
}