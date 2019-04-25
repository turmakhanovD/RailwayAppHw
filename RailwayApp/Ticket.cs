using System;

namespace RailwayApp
{
    public class Ticket : Entity
    {
        public string Path { get; set; }
        public DateTime DepartureTime { get; set; }
        public DateTime Arrivaltime { get; set; }
        public int Price { get; set; }
        public Train Train { get; set; }
        public Guid TrainId { get; set; }
    }
}
