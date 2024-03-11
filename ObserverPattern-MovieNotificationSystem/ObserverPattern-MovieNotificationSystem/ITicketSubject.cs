public interface ITicketSubject
{
    void RegisterObserver(ITicketObserver observer);
    void RemoveObserver(ITicketObserver observer);
    void NotifyObservers(string message);
}