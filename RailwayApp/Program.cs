using System;

namespace RailwayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Train train = new Train
            {
                TrainName = "Советский драндулет",
                CarriageCount = 30
            };

            Ticket ticket = new Ticket
            {
                Path = "Москва-Омск",
                Price = 12000,
                DepartureTime = DateTime.Parse("29.04.2019"),
                Arrivaltime = DateTime.Parse("01.05.2019"),
                TrainId = train.Id,
                Train = train
            };

            var context = new RailwayContext();
            context.Tickets.Add(ticket);
            context.Trains.Add(train);
            context.SaveChanges();
            context.Dispose();

            Menu menu = new Menu();
            menu.StartMenu();

            Console.ReadLine();
        }
    }
}
