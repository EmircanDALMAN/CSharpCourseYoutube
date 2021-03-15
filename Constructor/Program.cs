using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            //SqlServer sqlServer = new SqlServer(new FileLogger());
            //sqlServer.Log();

            Student.Id = 10;
        }
    }

    static class Student
    {
        public static int Id { get; set; }
    }
































    interface IDatabase
    {
        
    }

    class SqlServer:IDatabase
    {
        private ILogger _logger;

        public SqlServer(ILogger logger)
        {
            _logger = logger;
        }
        
        public void Log()
        {
            _logger.Log();
        }
    }

    class Oracle:IDatabase
    {

    }

    interface ILogger
    {
        void Log();
    }

    class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Database loglandı");
        }
    }

    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("File loglandı");
        }
    }
}
