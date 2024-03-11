namespace ObserverPattern_MovieNotification;

public class ComedyMovieSubject : MovieGenre
{
    public override void AddMovie(string movie)
    {
        movies.Add("Comedy movie: " + movie);
        NotifyObservers();
    }
}