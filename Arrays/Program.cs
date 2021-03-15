using AccessModifiersDemo;
using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {

            Database database = new Database();
            database.Add();
            //Arrays - Diziler

            string[] students = {"Emircan", "Ali", "Hüseyin"};

            //students[0] = "Veli";

            Console.WriteLine(students[0]);
            Console.WriteLine(students[1]);
            Console.WriteLine(students[2]);
        }
    }
}
