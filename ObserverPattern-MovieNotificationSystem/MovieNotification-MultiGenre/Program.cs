// See https://aka.ms/new-console-template for more information
// Create subjects

using ObserverPattern_MovieNotification;

var actionMovies = new ActionMovieSubject();
var comedyMovies = new ComedyMovieSubject();
var horrorMovies = new HorrorMovieSubject();

// Create observers
var dan = new MovieSmsNotification("Dan"); // Dan selected in for sms notification service.
var charlie = new MoviePushNotification("Charlie"); // Charlie selected push notifications service.
var josh = new MovieEmailNotification("Josh"); //Josh selected email notifications service.

// Register observers
actionMovies.RegisterObserver(dan);  // Dan opted in for action movie titles via preferred notification channel.

comedyMovies.RegisterObserver(charlie); // Charlie opted in for comedy movie titles notifications.

horrorMovies.RegisterObserver(josh); // Josh opted in for horror movies notification. 

actionMovies.RegisterObserver(josh); // Josh also opted for action movie notifications.

// Add movies to notify observers
comedyMovies.AddMovie("American Pie"); // New movie notification sent to comedy movie subscribers "i.e Charlie"
actionMovies.AddMovie("The Terminator"); // New movie notification sent to action movie subscribers "i.e Dan & Josh"

horrorMovies.AddMovie("Grudge"); // New movie notification sent to horror movie subscribers "i.e Josh"


// Remove an observer and add another movie
actionMovies.RemoveObserver(dan); // Dan opted out from action movie notification channel.

actionMovies.AddMovie("Die Hard"); // Dan will not receive the new movie notification "As he unsubscribed / removed from notification queue."



