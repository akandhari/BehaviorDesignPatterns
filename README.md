# Movie Notification System using Observer Design Pattern

This project showcases an implementation of the Observer design pattern in C# for a movie notification system. The system allows movie fans to subscribe to different movie genres and receive notifications when new movies are added to those genres.

## Implementation Overview

### Abstract Class: `MovieGenre`
- Defines the structure for different movie genres.
- Contains common properties and methods that concrete genres can implement.

### Concrete Classes:
1. `ActionMovieSubject`:
   - Represents the action movie genre.
   - Inherits from `MovieGenre`.
   - Manages a list of action movies and notifies observers when new action movies are added.

2. `ComedyMovieSubject`:
   - Represents the comedy movie genre.
   - Inherits from `MovieGenre`.
   - Manages a list of comedy movies and notifies observers when new comedy movies are added.

3. `HorrorMovieSubject`:
   - Represents the horror movie genre.
   - Inherits from `MovieGenre`.
   - Manages a list of horror movies and notifies observers when new horror movies are added.

### Observer Classes:
- `MovieFan`:
  - Represents a movie fan who subscribes to specific movie genres.
  - Implements the `IMovieObserver` interface to receive notifications.

## Key Features

- **Dynamic Subscription Management**: Fans can subscribe to multiple movie genres and receive notifications for each genre.
- **Real-time Notifications**: Observers are immediately notified when new movies are added to the genres they are subscribed to.
- **Loose Coupling**: Subjects and observers are loosely coupled, allowing for easy modifications and scalability.
- **Focused Notifications**: Observers receive notifications only for the movie genres they are interested in, enhancing user experience.

## Usage

1. Create instances of `ActionMovieSubject`, `ComedyMovieSubject`, and `HorrorMovieSubject`.
2. Create instances of `MovieFan` representing different movie fans.
3. Register fans as observers for specific movie genres.
4. Add new movies to the genres to notify subscribed fans.
5. Remove fans from subscription lists as needed.

## Getting Started

To run the project locally, follow these steps:

1. Clone the repository.
2. Open the solution in your preferred IDE.
3. Build and run the project to see the Observer pattern in action.

## Contributing

Contributions are welcome! If you have suggestions for improvements or new features, feel free to open an issue or submit a pull request.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

---

By implementing the Observer design pattern in this movie notification system, this project aims to demonstrate the benefits of decoupling components and facilitating real-time communication between movie genres and fans.
