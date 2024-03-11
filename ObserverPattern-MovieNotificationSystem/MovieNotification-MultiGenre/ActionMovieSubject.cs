namespace ObserverPattern_MovieNotification;

public class ActionMovieSubject : MovieGenre
{
    public override void AddMovie(string movie)
    {
        movies.Add("Action movie: " + movie);
        NotifyObservers();
    }
}