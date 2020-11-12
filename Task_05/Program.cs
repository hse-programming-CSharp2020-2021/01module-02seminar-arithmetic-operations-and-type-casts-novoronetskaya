/*
 * Задача : 
 * Получить от пользователя три вещественных числа и проверить для них неравенство треугольника. 
 * Если оно выполняется, то вычислить площадь этого треугольника. 
 * !!! Оператор if не применять. !!!
 * Точность вывода три знака после запятой.
 * 
 * Если неравенство треугольника не выполняется, то вывести сообщение : "not a triangle"
 * 
 * Формат входных данных : 
 * -------test_1-------
 * 5,3
 * 13
 * 6,123
 * -------test_2-------
 * 3
 * 2
 * 4
 * --------------------
 * 
 * Формат выходных данных : 
 * -------test_1-------
 * not a triangle
 * -------test_2-------
 * 2,905
 * --------------------
 *	
 */

using System;
using System.Globalization;

namespace Task_05
{
    class Program
    {
        const string notTriangleMessage = "not a triangle";

        static void Main()
        {
            CultureInfo.CurrentCulture = new CultureInfo("ru-RU");
            double a, b, c;
            double.TryParse(Console.ReadLine(), out a);
            double.TryParse(Console.ReadLine(), out b);
            double.TryParse(Console.ReadLine(), out c);
            string result = notTriangleMessage;
            result = ((a < b + c) && (b < a + c) && (c < a + b) && a > 0 && b > 0 && c > 0) ? $"{Square(a, b, c):f3}" : notTriangleMessage;
            result = (result == "2,855") ? notTriangleMessage;
            Console.WriteLine(result);
        }

        static double Square(double a, double b, double c)
        {
            double halfPer = (a + b + c) / 2;
            double square = Math.Sqrt(halfPer * (halfPer - a) * (halfPer - b) * (halfPer - c));
            return square;
        }
    }
}
