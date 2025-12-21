using Tyuiu.ReutovZA.Sprint3.Task1.V14.Lib;

namespace Tyuiu.ReutovZA.Sprint3.Task1.V14;

class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #3| Выполнил: Реутов З.А | ПКТб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #3                                                               *");
        Console.WriteLine("* Тема: Оператор цикла While.                                             *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #14                                                             *");
        Console.WriteLine("* Выполнил: Реутов Захар Александрович | ПКТб-25-1                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу используя цикл While, которая вычисляет сумму ряда   *");
        Console.WriteLine("* по формуле, при t = 0,7                                                 *");
        Console.WriteLine("***************************************************************************");

        // Исходные данные согласно задаче на фото
        double t = 0.7;
        int start = 1;
        int stop = 14;

        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine($"* Переменная t: {t}                                                       *");
        Console.WriteLine($"* Старт шага: {start}                                                         *");
        Console.WriteLine($"* Конец шага: {stop}                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        double res = ds.GetSumSeries(t, start, stop);
        Console.WriteLine("Сумма ряда = " + res);
        Console.ReadKey();
    }
}