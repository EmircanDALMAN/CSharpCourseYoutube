using System;
using System.Collections.Generic;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculator calculator = new Calculator(2,4);
            //Console.WriteLine(calculator.Sum());

            //Console.WriteLine(calculator.GetType()
            //    .GetMethod("Sum")
            //    .Invoke(calculator, null));
            //MethodInfo methodInfo = calculator.GetType().GetMethod("Sum");

            //Console.WriteLine(methodInfo.Invoke(calculator, null));

            var type = typeof(Calculator);

            Calculator calculator =
                (Calculator) Activator.CreateInstance(type, 5, 5);

            var methods = type.GetMethods();
            foreach (var methodInfo in methods)
            {
                Console.WriteLine("Method adı: {0}", methodInfo.Name);
                foreach (var parameterInfo in methodInfo.GetParameters())
                {
                    Console.WriteLine("Parametre: {0}", parameterInfo.Name);
                }

                foreach (var attribute in methodInfo.GetCustomAttributes())
                {
                    Console.WriteLine("Attribute: {0}", attribute.GetType().Name);
                }
            }

        }
    }

    public class Calculator
    {
        private int _number1;
        private int _number2;
        public Calculator(int number1, int number2)
        {
            _number1 = number1;
            _number2 = number2;
        }
        [Custom("Toplama")]
        public int Sum(int sayi1)
        {
            return _number1 + _number2;
        }
    }

    public class CustomAttribute : Attribute
    {
        private string _name;

        public CustomAttribute(string name)
        {
            _name = name;
        }
    }
}
