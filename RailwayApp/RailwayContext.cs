namespace RailwayApp
{
    using System.Data.Entity;

    public class RailwayContext : DbContext
    {
        // Контекст настроен для использования строки подключения "RailwayContext" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "RailwayApp.RailwayContext" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "RailwayContext" 
        // в файле конфигурации приложения.
        public RailwayContext()
            : base("name=RailwayContext")
        {
        }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

         public virtual DbSet<Ticket> Tickets { get; set; }
         public virtual DbSet<Train> Trains { get; set; }
         
    }

}