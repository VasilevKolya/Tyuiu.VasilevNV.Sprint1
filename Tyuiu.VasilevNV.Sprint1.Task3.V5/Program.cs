using System;
using Tyuiu.VasilevNV.Sprint1.Task3.V5.Lib;
internal class Program
{
    static void Main(string[] args)
    {

        DataService ds = new DataService(); 
Console.Title = "Спринт #1 | Выполнил: Васильев Н. В. | ИСПБ-24-1";
Console.WriteLine("*************************************************************************");
Console.WriteLine("* Спринт #1                                                             *");
Console.WriteLine("* Тема: Операторы составного присваивания                               *");
Console.WriteLine("* Задание #3                                                            *");
Console.WriteLine("* Вариант #5                                                            *");
Console.WriteLine("*  Выполнил: Васильев Н. В. | ИСПБ-24-1                                 *");
Console.WriteLine("*************************************************************************");
Console.WriteLine("*УСЛОВИЕ:                                                               *");
Console.WriteLine("Написать программу, которая запрашивает у пользователя исходные данные, *");
Console.WriteLine("выполняет указанные расчёты                                             *");
Console.WriteLine(" и печатает результат на экране.                                        *");
Console.WriteLine("*                                                                       *");
Console.WriteLine("*************************************************************************");
Console.WriteLine(" ИСХОДНЫЕ ДАННЫЕ:                                                       *");
Console.WriteLine("*************************************************************************");
Console.Write("Введите масштаб карты (количество км в одном см): ");
double scale = double.Parse(Console.ReadLine());
Console.Write("Введите расстояние между точками на карте (см): ");
double distanceOnMap = double.Parse(Console.ReadLine());
double distance = ds.DistanceLength(scale, distanceOnMap);
double roundedDistance = Math.Round(distance, 3);

Console.WriteLine("*************************************************************************");
Console.WriteLine(" РЕЗУЛЬТАТ:                                                             *");
Console.WriteLine("*************************************************************************");
Console.WriteLine($"Расстояние между населёнными пунктами: {roundedDistance} км.");

Console.ReadLine();

        }
    }

