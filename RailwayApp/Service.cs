using System;
using System.Linq;

namespace RailwayApp
{
    public class Service
    {
        public void BuyTicket()
        {
            var context = new RailwayContext();
            var tickets = context.Tickets.ToList();

            foreach (var ticket in tickets)
            {
                Console.WriteLine($"Path: {ticket.Path}\nPrice:{ticket.Price}\nDeparture:{ticket.DepartureTime}\nArrival:{ticket.Arrivaltime}\nTrain id:{ticket.TrainId}");
                Console.WriteLine("---------------------------");
            }

            Console.WriteLine("Write ticket path: ");
            var pathOfTicket = Console.ReadLine();

            var chosenTicket = context.Tickets.Where(ticket => ticket.Path == pathOfTicket).FirstOrDefault();

            if (chosenTicket == null)
                Console.WriteLine("Такой билет не найден!");
            else
            {
                Console.WriteLine($"C вас {chosenTicket.Price}");
                Console.WriteLine("Оплатить? (1.Да/2.Нет)");
                int choose = 0;

                while (!int.TryParse(Console.ReadLine(), out choose))
                {
                    Console.WriteLine("Выберите число!");
                }

                switch (choose)
                {
                    case 1:
                        Console.WriteLine("Вы успешно оплатили!");
                        break;
                    case 2:
                        Console.WriteLine("Ну ладно, не надо!");
                        break;
                }

                context.Dispose();
            }
        }

        public void AddTicket()
        {
            RailwayContext context = new RailwayContext();
            Ticket ticket = new Ticket();
            int pathLength = 6;
            int price = 0;
            DateTime departureTime = new DateTime();
            DateTime arrivalTime = new DateTime();

            Console.WriteLine("Введите путь:");
            ticket.Path = Console.ReadLine();

            Console.WriteLine("Введите стоимость:");
            while(!int.TryParse(Console.ReadLine(),out price))
            {
                Console.WriteLine("Не правильная сумма!");
            }
            ticket.Price = price;

            Console.WriteLine("Введите время выезда поезда: ");
            while(!DateTime.TryParse(Console.ReadLine(),out departureTime))
            {
                Console.WriteLine("Введите корректную дату!");
            }
            ticket.DepartureTime = departureTime;

            Console.WriteLine("Введите время приезда поезда: ");
            while(!DateTime.TryParse(Console.ReadLine(),out arrivalTime))
            {
                Console.WriteLine("Введите корректную дату!");
            }
            ticket.Arrivaltime = arrivalTime;

            Console.WriteLine("Введите имя поезда: ");
            var trains = context.Trains.ToList();
            foreach(var train in trains)
            {
                Console.WriteLine($"Name: {train.TrainName}");
            }
            var chosenTrain = context.Trains.Where(train => train.TrainName == Console.ReadLine()).FirstOrDefault();
            if(chosenTrain == null)
                Console.WriteLine("Такой поезд отсуствует!");
            else
            {
                ticket.TrainId = chosenTrain.Id;
                ticket.Train = chosenTrain;
                context.Tickets.Add(ticket);
                context.SaveChanges();
            }
            context.Dispose();
        }
    }
}
