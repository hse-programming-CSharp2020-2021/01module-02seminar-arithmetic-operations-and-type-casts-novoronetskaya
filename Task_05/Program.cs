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
using System.Threading;

namespace Task_05
{
	class Program
	{
		const string notTriangleMessage = "not a triangle";

		static void Main(string[] args)
		{
			// TODO : Сменить локаль на "ru-RU". 

			CultureInfo.CurrentCulture = new CultureInfo("ru-RU");
			double a, b, c;
                        
			double.TryParse(Console.ReadLine(), out a);
			double.TryParse(Console.ReadLine(), out b);
			double.TryParse(Console.ReadLine(), out c);

			// TODO : Проверить неравенство треугольника и поместить в 
			// результирующую строку notTriangleMessage 
			// или площадь треугольника.
			string result = notTriangleMessage;
			if ((a < b + c) && (b < a + c) && (c < a + b) && a > 0 && b > 0 && c > 0)
			{
				result = Square(a, b, c).ToString();
			}
			Console.WriteLine(result);
		}

		static double Square(double a, double b, double c)
		{
			// TODO : Реализовать вычисление площади по формуле Герона. Ну или что-нибудь более извращённое 🙃.
			double halfPer = (a + b + c) / 2;
			double square = Math.Sqrt(halfPer * (halfPer - a) * (halfPer - b) * (halfPer - c));
			return Math.Round(square, 3);
		}
	}
}
