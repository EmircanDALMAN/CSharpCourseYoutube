using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student
            {
                FirstName = "Emircan",
                LastName = "Dalman",
                Id = 1
            };

            Employee employee = new Employee();
            employee.FirstName = "Emircan";
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    interface IPersonDal
    {
        
    }

    class Student : Person,IPersonDal
    {
        public string Learn { get; set; }
    }

    class Employee : Person
    {
        public decimal GetSalary { get; set; }
    }
}
