namespace RailwayApp
{
    public class Menu
    {
        public void StartMenu()
        {
            Service service = new Service();
            int choose = 0;
            System.Console.WriteLine("\t\tПоезд.кз\n1.Купить билет\n2.Добавить билет");
           
            while (!int.TryParse(System.Console.ReadLine(),out choose))
            {
                System.Console.WriteLine("Выберите корректное число!");
            }
            switch (choose)
            {
                case 1:
                    service.BuyTicket();
                    break;
                case 2:
                    service.AddTicket();
                    break;
                default:
                    System.Console.WriteLine("We have not got action under this index");
                    break;
            }
        }
    }
}
