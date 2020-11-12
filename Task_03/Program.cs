﻿/*
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

namespace Task_03
{
    class Program
    {
        const string complexRootsMessage = "complex roots";
        static void Main()
        {
            // TODO : Сменить локаль на "ru-RU". 

            double a, b, c;
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            double discriminant = b * b - 4 * a * c;
            
            // TODO : Проверить существование вещественных корней, если их нет, 
            // записать в результирующую строку complexRootsMessage.
            // А если корни есть, то записать их.
            string result;
            result = (d > 0) ? ($"{((-b + Math.Sqrt(d)) / (2 * a)) : f2}\n{((-b - Math.Sqrt(d)) / (2 * a)) : f2}"):((d == 0) ? ($"{(-b / (2 * a)) : f2}") : ("complex roots"));
            Console.WriteLine(result);
        }
    }
}
