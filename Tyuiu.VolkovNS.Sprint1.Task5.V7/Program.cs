using Tyuiu.VolkovNS.Sprint1.Task5.V7.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил Волков Н. С. | ПКТб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Преобразование типов и класс Convert                              *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #7                                                              *");
        Console.WriteLine("* Выполнил: Волков Никита Сергеевич | ПКТб-25-1                           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Определить h – полное количество часов прошедших от начала суток до того*");
        Console.WriteLine("* момента (в первой половине дня), когда часовая стрелка повернулась      *");
        Console.WriteLine("* на f градусов (0<f<360, f – вещественное число).                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        double f, h;
        Console.WriteLine("Введите F: ");
        f = Convert.ToDouble(Console.ReadLine());
        h = ds.AngleToHoursMinutes(f);
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("С начала суток прошло " + h + " часов");
    }
}