using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.VasilevNV.Sprint1.Task0.V5.Lib;

namespace Tyuiu.VasilevNV.Sprint1.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #1 | Выполнил: Васильев Н. В. | ИСПБ-24-1";
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("* Спринт #1                                                             *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                      *");
            Console.WriteLine("* Задание #0                                                            *");
            Console.WriteLine("* Вариант #0                                                            *");
            Console.WriteLine("*  Выполнил: Васильев Н. В. | ИСПБ-24-1                                 *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                               *");
            Console.WriteLine("Написать программу, которая вычисляет выражение (1+2)*(1+9/3)           *");
            Console.WriteLine(" и печатает результат на экране.                                        *");
            Console.WriteLine("*                                                                       *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine(" ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine(" (1+2)*(1+9/3)                                                          *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine(" РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("*************************************************************************");

            Console.WriteLine(ds.Calculate());

            Console.ReadLine();

        }
    }
}