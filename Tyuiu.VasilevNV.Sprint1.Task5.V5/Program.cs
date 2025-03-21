using Tyuiu.VasilevNV.Sprint1.Task5.V5.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил: Васильев Н. В. | ИСПБ-24-1";
        Console.WriteLine("*************************************************************************");
        Console.WriteLine("* Спринт #1                                                             *");
        Console.WriteLine("* Тема: Базовые навыки работы в С#                                      *");
        Console.WriteLine("* Задание #5                                                            *");
        Console.WriteLine("* Вариант #5                                                            *");
        Console.WriteLine("*  Выполнил: Васильев Н. В. | ИСПБ-24-1                                 *");
        Console.WriteLine("*************************************************************************");
        Console.WriteLine("*УСЛОВИЕ:                                                               *");
        Console.WriteLine("Написать программу, которая решает следующую задачу:                    *");
        Console.WriteLine("Присвоить целой переменной d первую цифру из дробной части              ");
        Console.WriteLine("положительного вещественного числа x                                    ");
        Console.WriteLine(" и печатает результат на экране.                                        *");
        Console.WriteLine("*                                                                       *");
        Console.WriteLine("*************************************************************************");
        Console.WriteLine(" ИСХОДНЫЕ ДАННЫЕ:                                                       *");
        Console.WriteLine("*************************************************************************");
        Console.Write("Введите положительное вещественное число: ");
        {
            double x = Convert.ToDouble(Console.ReadLine());

            int d = ds.Calculate(x);



            Console.WriteLine("*************************************************************************");
            Console.WriteLine(" РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine($"Первая цифра из дробной части: {d}");
            Console.WriteLine("*************************************************************************");

            Console.ReadLine();
        }
    }
}

    

        