
using System;
using Tyuiu.IvanovMA.Sprint3.Task7.V17.Lib;

namespace Tyuiu.IvanovMA.Sprint3.Task7.V17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #3 | Выполнил: Иванов М. А.";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Табулирование функции                                             *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #17                                                             *");
            Console.WriteLine("* Выполнил: Иванов Марсель Андреевич | группа ИСТНб-26-1                  *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* F(x) = sin(x)/(x+1,7) - cos(x)*4*x - 6                                 *");
            Console.WriteLine("* Диапазон [-5; 5], шаг 1. При делении на ноль вернуть 0.                 *");
            Console.WriteLine("* Округлить значения до двух знаков после запятой.                       *");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = 5;

            Console.WriteLine("Начало диапазона = " + startValue);
            Console.WriteLine("Конец диапазона = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            double[] result = ds.GetMassFunction(startValue, stopValue);

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine($"F({startValue + i}) = {result[i]:F2}");
            }

            Console.ReadKey();
        }
    }///
}
