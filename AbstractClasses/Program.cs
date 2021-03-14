using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Add();
            student.Delete();

            Employee employee = new Employee();
            employee.Add();
            employee.Delete();
        }
    }

    abstract class Person
    {
        public void Add()
        {
            Console.WriteLine("Default Ekleme");
        }

        public abstract void Delete();
    }

    class Student : Person
    {
        public override void Delete()
        {
            Console.WriteLine("Student silindi");
        }
    }

    class Employee : Person
    {
        public override void Delete()
        {
            Console.WriteLine("çalışan silindi");
        }
    }
}
