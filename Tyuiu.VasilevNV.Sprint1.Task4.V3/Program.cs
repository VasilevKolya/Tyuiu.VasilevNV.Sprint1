using Tyuiu.VasilevNV.Sprint1.Task4.V3.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Васильев Н. В. | ИСПБ-24-1";
        Console.WriteLine("*************************************************************************");
        Console.WriteLine("* Спринт #1                                                             *");
        Console.WriteLine("* Тема: Базовые навыки работы в С#                                      *");
        Console.WriteLine("* Задание #4                                                            *");
        Console.WriteLine("* Вариант #3                                                            *");
        Console.WriteLine("*  Выполнил: Васильев Н. В. | ИСПБ-24-1                                 *");
        Console.WriteLine("*************************************************************************");
        Console.WriteLine("*УСЛОВИЕ:                                                               *");
        Console.WriteLine("Написать программу, которая запрашивает у пользователя исходные данные, *");
        Console.WriteLine("вычисляет результат по формуле                                          *");
        Console.WriteLine(" и печатает результат на экране.                                        *");
        Console.WriteLine("*                                                                       *");
        Console.WriteLine("*************************************************************************");
        Console.WriteLine(" ИСХОДНЫЕ ДАННЫЕ:                                                       *");
        Console.WriteLine("*************************************************************************");
        Console.Write("Введите значение x: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Введите значение y: ");
        double y = double.Parse(Console.ReadLine());
        Console.WriteLine("*************************************************************************");
        Console.WriteLine(" РЕЗУЛЬТАТ:                                                             *");
        Console.WriteLine("*************************************************************************");
        double result = ds.Calculate(x, y);

        double roundedResult = Math.Round(result, 3);

        Console.WriteLine($"Результат: {roundedResult}");

        Console.ReadLine();

    }
}

