using System.Collections.Generic;


public class MovieTicketSale : ITicketSubject
{
    private List<ITicketObserver> observers = new List<ITicketObserver>();

    public void RegisterObserver(ITicketObserver observer)
    {
        observers.Add(observer);
    }

    public void RemoveObserver(ITicketObserver observer)
    {
        observers.Remove(observer);
    }

    public void NotifyObservers(string message)
    {
        foreach (var observer in observers)
        {
            observer.Update(message);
        }
    }
}