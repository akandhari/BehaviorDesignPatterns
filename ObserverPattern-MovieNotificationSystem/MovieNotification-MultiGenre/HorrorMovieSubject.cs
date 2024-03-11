using System.Collections.Generic;
using System.Linq;
using ObserverPattern_MovieNotification;

public class HorrorMovieSubject : MovieGenre
{
    public override void AddMovie(string movie)
    {
        movies.Add("Horror movie: " + movie);
        NotifyObservers();
    }
}   