using System;

namespace AccessModifiersDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Database database = new Database();
        }
    }

    class Person
    {
        protected int Id { get; set; }

        private void Add()
        {

        }
    }

    class Student : Person
    {
        public void Add2()
        {
            
        }
    }

    public class Database
    {
        public void Add()
        {

        }
    }
}
