﻿using Tyuiu.VolkovNS.Sprint1.Task4.V12.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил Волков Н. С. | ПКТб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Class Math                                                              *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #12                                                             *");
        Console.WriteLine("* Выполнил: Волков Никита Сергеевич | ПКТб-25-1                           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
        Console.WriteLine("* вычисляет результат по формуле и печатает его на экране.                *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        double x, y;
        Console.WriteLine("Введите X: ");
        x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите Y: ");
        y = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Ответ равен: " + Math.Round(ds.Calculate(x,y),3));
    }
}