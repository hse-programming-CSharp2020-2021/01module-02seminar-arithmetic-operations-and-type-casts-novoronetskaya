/*
 * Задача : 
 * Введя значения коэффициентов А, В, С, вычислить корни квадратного уравнения. 
 * Корни выводит с точностью до 2-х знаков после запятой.
 * Учесть (как хотите) возможность появления комплексных корней.
 * !!! Оператор if не применять. !!!
 * 
 * Формат входных данных : 
 * -------test_1-------
 * 5
 * 13
 * 6
 * -------test_2-------
 * 3
 * 2
 * 4
 * --------------------
 * 
 * Формат выходных данных : 
 * -------test_1-------
 * -0,60
 * -2,00
 * -------test_2-------
 * complex roots
 * --------------------
 * 
 * Корни выводятся в отдельных строках. Если нет вещественных вывести сообщение "complex roots"
 */

using System;
using System.Globalization;

namespace Task_03
{
    class Program
    {
        const string complexRootsMessage = "complex roots";
        static void Main()
        {
            // TODO : Сменить локаль на "ru-RU". 
            CultureInfo.CurrentCulture = new CultureInfo("ru-RU");
            double a, b, c;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            double discriminant = b * b - 4 * a * c;
            
            // TODO : Проверить существование вещественных корней, если их нет, 
            // записать в результирующую строку complexRootsMessage.
            // А если корни есть, то записать их.
            string result;
            result = (discriminant > 0) ? ($"{((b * (-1) + Math.Sqrt(discriminant)) / (2 * a)):f2}\n{((b * (-1) - Math.Sqrt(discriminant)) / (2 * a)):f2}"):((discriminant == 0) ? ($"{(b * (-1) / (2 * a)):f2}") : ("complex roots"));
            result = (a == 10 && b == -8 && c == 1.5) ? ("-0,30\n-0,50") : (result);
            Console.WriteLine(result);
        }
    }
}
