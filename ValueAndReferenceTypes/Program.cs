using System;

namespace ValueAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //Int, String, Boolean
            int number1 = 10;

            int number2 = 15;

            Console.WriteLine(number2);

            number2 = number1;

            Console.WriteLine(number2);


            string[] students1 = {"Ali", "Emircan"};

            string[] students2 = {"Ahmet", "Murat"};

            Console.WriteLine(students2[0]);
            
            students2 = students1;
            students1[0] = "Veli";

            Console.WriteLine(students2[0]);
        }
    }
}
