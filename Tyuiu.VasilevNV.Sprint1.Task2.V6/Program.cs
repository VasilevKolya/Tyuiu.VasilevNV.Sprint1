using Tyuiu.VasilevNV.Sprint1.Task2.V6.Lib;
using System;

namespace Tyuiu.VasilevNV.Sprint1.V0
{
     class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Васильев Н. В. | ИСПБ-24-1";
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* Спринт #1                                                             *");
            Console.WriteLine("* Тема: Арифметические операторы в C#                                   *");
            Console.WriteLine("* Задание #0                                                            *");
            Console.WriteLine("* Вариант #6                                                            *");
            Console.WriteLine("*  Выполнил: Васильев Н. В. | ИСПБ-24-1                                 *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                               *");
            Console.WriteLine("Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("выполняет указанные расчёты и печатает результат на экране              *");
            Console.WriteLine(" и печатает результат на экране.                                        *");
            Console.WriteLine("*                                                                       *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine(" ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            int x;
            Console.WriteLine("Введите расстояние в метрах:");
            x = Convert.ToInt16(Console.ReadLine());

            double kilometers = ds.ConvertMToKm(x);
            double roundedKilometers = Math.Round(kilometers, 3);


            Console.WriteLine("*************************************************************************");
            Console.WriteLine(" РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine($"Расстояние в километрах: {roundedKilometers}");

            Console.ReadLine();

        }
    }
}
