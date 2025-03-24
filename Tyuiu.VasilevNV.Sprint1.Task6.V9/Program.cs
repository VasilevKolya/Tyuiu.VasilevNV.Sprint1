using Tyuiu.VasilevNV.Sprint1.Task6.V9.Lib;
using System;

 class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнил: Васильев Н. В. | ИСПБ-24-1";
        Console.WriteLine("*************************************************************************");
        Console.WriteLine("* Спринт #1                                                             *");
        Console.WriteLine("* Тема: Базовые навыки работы в С#                                      *");
        Console.WriteLine("* Задание #7                                                            *");
        Console.WriteLine("* Вариант #9                                                            *");
        Console.WriteLine("*  Выполнил: Васильев Н. В. | ИСПБ-24-1                                 *");
        Console.WriteLine("*************************************************************************");
        Console.WriteLine("*УСЛОВИЕ:                                                               *");
        Console.WriteLine("Написать программу: пользователь вводит текст.                          *");
        Console.WriteLine("Напечатать все слова, перенеся их последнюю букву в начало.             *");
        Console.WriteLine("*                                                                       *");
        Console.WriteLine("*************************************************************************");
        Console.WriteLine(" ИСХОДНЫЕ ДАННЫЕ:                                                       *");
        Console.WriteLine("*************************************************************************");
        string str = Console.ReadLine();
        Console.WriteLine("*************************************************************************");
        Console.WriteLine(" РЕЗУЛЬТАТ:                                                             *");
        Console.WriteLine("*************************************************************************");

        Console.WriteLine(ds.MoveLetterToStart(str));

        Console.ReadKey();

    }
}

