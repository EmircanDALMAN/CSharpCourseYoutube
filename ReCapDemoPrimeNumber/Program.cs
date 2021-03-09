using System;

namespace ReCapDemoPrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sayıyı giriniz: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(IsPrime(number) 
                ? "Sayı Asaldır" 
                : "Sayı asal değildir");
        }

        static bool IsPrime(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
