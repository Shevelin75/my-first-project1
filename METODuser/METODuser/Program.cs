using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METODuser
{
    class Program
    {
        // Статический метод для сложения двух чисел
        public static int Sum(int a, int b)
        {
            return a + b;
        }

        // Экземплярный метод для умножения двух чисел
        public double Multiply(double x, double y)
        {
            return x * y;
        }

        static void Main(string[] args)
        {
            // Вызов статического метода
            int sumResult = Sum(5, 7);
            Console.WriteLine("Сумма: " + sumResult);

            // Создание экземпляра класса Program
            Program program = new Program();

            // Вызов экземплярного метода
            double multiplyResult = program.Multiply(6.0, 8.0);
            Console.WriteLine("Произведение: " + multiplyResult);

            

            Console.ReadKey();
        }
    }
}
