using System;

namespace Delegates
{
    class Program
    {
        public delegate void MyDelegate();
        public delegate void MyDelegate2(string message);
        static void Main(string[] args)
        {
            //CountryManager countryManager = new CountryManager();

            //MyDelegate myDelegate = countryManager.SendMessage;
            //myDelegate += countryManager.Alert;
            //myDelegate();

            //myDelegate -= countryManager.Alert;

            //myDelegate();

            CountryManager countryManager = new CountryManager();
            MyDelegate2 myDelegate2 = countryManager.SendMessage2;
            myDelegate2 += countryManager.Alert2;

            myDelegate2 -= countryManager.Alert2;
            myDelegate2("Merhaba");
        }
    }

    public class CountryManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Selam Gönderildi");
        }

        public void Alert()
        {
            Console.WriteLine("Uyarı Gönderildi");
        }

        public void SendMessage2(string message)
        {
            Console.WriteLine(message);
        }

        public void Alert2(string alert)
        {
            Console.WriteLine(alert);
        }
    }
}
