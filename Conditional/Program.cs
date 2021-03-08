using System;

namespace Conditional
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isLogin = false;
            if (isLogin )
            {
                Console.WriteLine("Giriş Başarılı");
            }
            else
            {
                Console.WriteLine("Giriş Başarısız");
            }

            var number = 20;
            if (number > 10)
            {
                Console.WriteLine("Sayı 10'dan büyük");
            }
            else if (number < 15)
            {
                Console.WriteLine("Sayı 15'den küçük");
            }
            else if (number < 20)
            {
                Console.WriteLine("Sayı 20'den küçük");
            }
            else
            {
                Console.WriteLine("Sayı 20'den büyük");
            }
        }
    }
}
