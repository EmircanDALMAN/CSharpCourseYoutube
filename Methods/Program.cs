using System;
using System.Linq;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Don't repeat yourself
            //Do not repeat yourself
            //Method Overloading

            //Selamla("Selam");

            //KrediHesapla("Asker Kredisi");

            //Topla(50,20,30);

            //Console.WriteLine(Topla2(10, 20));

            //int sayi1;
            //int sayi2 = 30;
            //Console.WriteLine(Topla3(out sayi1, sayi2));
            //Console.WriteLine(sayi1);

            //Console.WriteLine(Multiply(10, 20,30));

            Console.WriteLine(Topla3(10,20,2,2,2,22,2,2,2,2));
        }

        static int Topla3(params int[] sayilar)
        {
            return sayilar.Sum();
        }

        static int Multiply(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }
        static int Multiply(int sayi1, int sayi2, int sayi3)
        {
            return sayi1 * sayi2 * sayi3;
        }


        static void Selamla(string message)
        {
            Console.WriteLine(message);
        }

        static void KrediHesapla(string type)
        {
            Console.WriteLine(type + " için Kredi hesaplandı");
        }

        static void Topla(int sayi1, int sayi2 = 10, int sayi3 = 20)
        {
            var toplam = sayi1 + sayi2 + sayi3;
            Console.WriteLine(toplam);
        }

        static int Topla2(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        static int Topla3(out int sayi1, int sayi2)
        {
            sayi1 = 20;
            return sayi1 + sayi2;
        }
    }
}
