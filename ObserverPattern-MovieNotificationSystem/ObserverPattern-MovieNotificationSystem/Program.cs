// See https://aka.ms/new-console-template for more information

MovieTicketSale ticketSale = new();

User john = new User("John");
User jane = new User("Jane");

ticketSale.RegisterObserver(john);
ticketSale.RegisterObserver(jane);

ticketSale.NotifyObservers("50% off on all tickets this weekend!");

ticketSale.RemoveObserver(john);

ticketSale.NotifyObservers("Buy one, get one free on all tickets next weekend!");
