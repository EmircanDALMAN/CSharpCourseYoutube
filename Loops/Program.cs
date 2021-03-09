using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = { "Emircan", "Ali", "Hüseyin" };

            //ForLoop();

            //WhileLoop();

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }

            //Do - While
        }

        private static void WhileLoop()
        {
            //Infinite Loop - Sonsuz Döngü
            int sayi = 10;

            while (sayi > 0)
            {
                Console.WriteLine(sayi);
                sayi--;
            }
        }

        private static void ForLoop()
        {
            //For Döngüsü
            //index
            for (int i = 2; i <= 10; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
