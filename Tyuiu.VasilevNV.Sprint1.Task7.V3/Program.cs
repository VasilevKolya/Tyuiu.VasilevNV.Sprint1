using Tyuiu.VasilevNV.Sprint1.Task7.V3.Lib;
using System;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine("*Спринт #1 | Выполнил: Васильев Н. В. | ИСПБ-24-1                       *");
        Console.WriteLine("*************************************************************************");
        Console.WriteLine("* Спринт #1                                                             *");
        Console.WriteLine("* Тема: Базовые навыки работы в С#                                      *");
        Console.WriteLine("* Задание #7                                                            *");
        Console.WriteLine("* Вариант #3                                                            *");
        Console.WriteLine("*  Выполнил: Васильев Н. В. | ИСПБ-24-1                                 *");
        Console.WriteLine("*************************************************************************");
        Console.WriteLine("*УСЛОВИЕ:                                                               *");
        Console.WriteLine("Написать программу, которая вычисляет  математическое                   *");
        Console.WriteLine(" выражение по исходным значениям данных, вводимых пользователем.        *");
        Console.WriteLine(" и печатает результат на экране.                                        *");
        Console.WriteLine("*                                                                       *");
        Console.WriteLine("*************************************************************************");
        Console.WriteLine(" ИСХОДНЫЕ ДАННЫЕ:                                                       *");
        Console.WriteLine("*************************************************************************");
        double x, y;

        Console.WriteLine("Введите значение X:");
        x = Convert.ToDouble(Console.ReadLine());     
        Console.WriteLine("Введите значение Y:");
        y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("*************************************************************************");
        Console.WriteLine(" РЕЗУЛЬТАТ:                                                             *");
        Console.WriteLine("*************************************************************************");

        double z = (ds.Calculate(x,y));
        Console.WriteLine(Math.Round(z, 3));

        Console.ReadKey();
    }
}
