using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //Employee employee = new Employee();
            //employee.Add();

            IDatabaseDal databaseDal = new PostgreDatabaseDal();
            databaseDal.Add();
        }
    }

    interface IDatabaseDal //Soyuttur
    {
        //Data Access Layer
        void Add();
        void Delete();
    }

    class PostgreDatabaseDal : IDatabaseDal
    {
        public void Add()
        {
            Console.WriteLine("Postgre Eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("Postgre Silindi");
        }
    }
    class SqlServerDatabaseDal : IDatabaseDal
    {
        public void Add()
        {
            Console.WriteLine("Sql server eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("Sql server silindi");
        }
    }

    class OracleDatabaseDal : IDatabaseDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Silindi");
        }
    }














    interface IPerson
    {
        void Add();
        void Delete();
        void Update();
    }

    class Employee : IPerson
    {
        public void Add()
        {
            Console.WriteLine("Employee Eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("Employee Silindi");
        }

        public void Update()
        {
            Console.WriteLine("Employee Güncellendi");
        }
    }

    class Worker : IPerson
    {
        public void Add()
        {
            Console.WriteLine("Worker Eklendi");
        }

        public void Delete()
        {
            Console.WriteLine("Worker Silindi");
        }

        public void Update()
        {
            Console.WriteLine("Worker Güncellendi");
        }
    }
}
