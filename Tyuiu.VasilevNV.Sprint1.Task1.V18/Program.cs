using Tyuiu.VasilevNV.Sprint1.Task1.V18.Lib;

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
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                      *");
            Console.WriteLine("* Задание #1                                                            *");
            Console.WriteLine("* Вариант #18                                                           *");
            Console.WriteLine("*  Выполнил: Васильев Н. В. | ИСПБ-24-1                                 *");
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("*УСЛОВИЕ:                                                               *");
            Console.WriteLine("Написать программу, которая вычисляет выражение  (x*y)/(x+1)-3          *");
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

            Console.WriteLine(ds.Calculate(x, y));

            Console.ReadLine();
        }
    }
}
