/*
 * Задача : 
 * Ввести натуральное трехзначное число Р. 
 * Найти наибольшее целое число, которое можно получить, переставляя цифры числа Р.
 * 
 * Формат входных данных : 
 * -------test_1-------
 * 208
 * -------test_2-------
 * 159
 * --------------------
 * 
 * Формат выходных данных : 
 * -------test_1-------
 * 820
 * -------test_2-------
 * 951
 * --------------------
 */

using System;

namespace Task_02
{
    class Program
    {
        static void Main()
        {
            int p;
            if (int.TryParse(Console.ReadLine(), out p) && p > 99 && p < 1000)
            {
                Console.WriteLine(MaxPermutation(p));
            }
        }

        static int MaxPermutation(int x)
        {
            // TODO : Получить цифры числа используя арифметические операции.
            int firstDigit = x / 100,
                secondDigit = x % 100 / 10,
                thirdDigit = x % 10;
            int a = Math.Max(Math.Max(firstDigit, secondDigit), thirdDigit);
            int c = Math.Min(Math.Min(firstDigit, secondDigit), thirdDigit);
            int b = firstDigit + secondDigit + thirdDigit - a - c;
            // TODO : Собрать новое число и вернуть его. 
            int max = a * 100 + b * 10 + c;
            return max;
        }
    }
}
