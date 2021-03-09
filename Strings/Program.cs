using System;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //Case Sensivity - Büyük Küçük Harf Duyarlılığı
            char character = 'E';
            string name = "       Emircan                                 ";

            Console.WriteLine(name.Trim());
        }
    }
}
