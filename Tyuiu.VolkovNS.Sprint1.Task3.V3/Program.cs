using Tyuiu.VolkovNS.Sprint1.Task3.V3.Lib;

internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнил Волков Н. С. | ПКТб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Операторы составного присваивания                                 *");
        Console.WriteLine("* Задание #3                                                              *");
        Console.WriteLine("* Вариант #3                                                              *");
        Console.WriteLine("* Выполнил: Волков Никита Сергеевич | ПКТб-25-1                           *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу вычисления объема параллелепипеда.                   *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        double lenght, width, height;
        Console.WriteLine("Введите длину параллелепипеда: ");
        lenght = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите ширину параллелепипеда: ");
        width = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите высоту параллелепипеда: ");
        height = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Объём параллелепипеда равен: " + Math.Round(ds.ParallelepipedVolume(lenght,width,height), 3));
    }
}