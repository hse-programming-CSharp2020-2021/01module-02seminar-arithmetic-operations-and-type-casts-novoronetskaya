/*
 * Задача : 
 * Написать программу с использованием двух методов. Первый метод возвращает дробную и целую часть числа. 
 * Второй метод возвращает квадрат и корень из числа. В основной программе пользователь вводит дробное число. 
 * Программа должна вычислить, если это возможно, значение корня, квадрата числа, выделить целую и дробную 
 * часть из числа. Выводить и вводить с точностью до 2-х знаков после запятой.
 * 
 * Формат входных данных : 
 * -------test_1-------
 * 10,12
 * -------test_2-------
 * -5,5
 * --------------------
 * 
 * Формат выходных данных : 
 * -------test_1-------
 * 3,18
 * 102,41
 * 10
 * 12
 * -------test_2-------
 * 27,5
 * -5
 * -5
 * --------------------
 */

using System;
using System.Globalization;

namespace Task_07
{
    class Program
    {
        static void Main()
        {
            // TODO : Сменить локаль на "ru-RU". 
            CultureInfo.CurrentCulture = new CultureInfo("ru-RU");
            double x;
            // TODO : Считать вещественную переменную.
            x = double.Parse(Console.ReadLine());
            int integer, fraction;
            GetIntAndFract(x, out integer, out fraction);

            double sqrt, sqr;
            GetSqrtAndSqr(x, out sqrt, out sqr);

            if (x >= 0)
            {
                Console.WriteLine(sqrt);
            }
            Console.Write(sqr + Environment.NewLine + integer + Environment.NewLine + fraction);
        }

        static void GetIntAndFract(double x, out int integer, out int fraction)
        {
            // TODO : Получить целую и дробную часть числа и положить их в соответствующие переменные.
            integer = (int)x;
            int power = x.ToString().Length - integer.ToString().Length - 1;
            fraction = (int)(Math.Round(x - integer, power) * Math.Pow(10, power));
        }

        static void GetSqrtAndSqr(double x, out double sqrt, out double sqr)
        {
            sqr = Math.Round(x * x, 2);
            sqrt = 0;
            if (x >= 0)
            {
                sqrt = Math.Round(Math.Sqrt(x), 2);
            }
        }
    }
}
